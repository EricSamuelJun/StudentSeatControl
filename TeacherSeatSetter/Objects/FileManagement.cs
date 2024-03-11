using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace TeacherSeatSetter.Objects {
    internal class FileManagement {
        /*
        public static FileManagement manager {
            get { if (manager == null) manager = new FileManagement(); return manager; }
            private set { return; }
        }*/
        private static FileManagement _instance;
        public static FileManagement manager {
            get {
                if(_instance == null) {
                    _instance = new FileManagement();
                }
                return _instance;
            }
        }
        //최소 16 char 이상
        private string Password = "?,rZB(EJVH>D8t3)L$1ELNI0INsx(No12}A$s|U-VOa[%)>b12";

        private string key = "";
        private string localAppDataDirectory;


        public FileManagement() {
            localAppDataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            localAppDataDirectory += "\\sungwook";
            DirectoryInfo di = new DirectoryInfo(localAppDataDirectory);
            if (!di.Exists) {
                di.Create();
            }
            key = Password.Substring(0, 128 / 8);
        }


        private string Encrypt(string plain) {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plain);

            // AES : 고급 암호화 표준
            // 레인달(Rijndael) : 벨기에 공학자들 이름을 합쳐 만든 알고리즘 이름
            RijndaelManaged rijndael = new RijndaelManaged();

            // CipherMode : 암호화 모드 지정
            // https://learn.microsoft.com/ko-kr/dotnet/api/system.security.cryptography.ciphermode?view=net-6.0
            rijndael.Mode = CipherMode.CBC;

            // PaddingMode : 메시지 데이터 블록이 암호화 작업에 필요한 전체 길이보다 짧을 때 뭘로 채울 것인지 결정
            // https://learn.microsoft.com/ko-kr/dotnet/api/system.security.cryptography.paddingmode?view=net-6.0
            rijndael.Padding = PaddingMode.PKCS7;

            // KeySize : 패스워드 키 사이즈
            // https://learn.microsoft.com/ko-kr/dotnet/api/system.security.cryptography.rijndaelmanaged.keysize?view=net-6.0#system-security-cryptography-rijndaelmanaged-keysize
            rijndael.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream();

            ICryptoTransform encryptor = rijndael.CreateEncryptor(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptBytes = memoryStream.ToArray();
            string encryptString = Convert.ToBase64String(encryptBytes);

            cryptoStream.Close();
            memoryStream.Close();

            return encryptString;
            //출처:  https://ohsol.tistory.com/entry/C-AES128를-이용해-암호화-복호화 [오솔의 블로그:티스토리]
        }

        private string Decrypt(string encrypt) {
            byte[] encryptBytes = Convert.FromBase64String(encrypt);

            RijndaelManaged rijndael = new RijndaelManaged();
            rijndael.Mode = CipherMode.CBC;
            rijndael.Padding = PaddingMode.PKCS7;
            rijndael.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream(encryptBytes);
            ICryptoTransform decryptor = rijndael.CreateDecryptor(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(key));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainBytes = new byte[encryptBytes.Length];

            int plainCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);

            string plainString = Encoding.UTF8.GetString(plainBytes, 0, plainCount);

            cryptoStream.Close();
            memoryStream.Close();

            return plainString;
            //출처: https://ohsol.tistory.com/entry/C-AES128를-이용해-암호화-복호화 [오솔의 블로그:티스토리]

        }


        public void SaveFile(string fileName, object content, bool encryption = false) {

            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(content);


            string strEncrypted = string.Empty;
            if (encryption) {
                strEncrypted = this.Encrypt(jsonString);
            } else {
                strEncrypted = jsonString;
            }

            string directory = localAppDataDirectory + "\\" + fileName + ".sav";
            File.WriteAllText(directory, strEncrypted);

        }

        public object LoadFile(string fileName, bool encryption = false) {
            string fileStr = string.Empty;
            string directory = localAppDataDirectory + "\\" + fileName + ".sav";
            try {
                fileStr = File.ReadAllText(directory);
                if (encryption) {
                    fileStr = this.Decrypt(fileStr);
                }
                Console.WriteLine(fileStr);
                return JsonConvert.DeserializeObject(fileStr);
            }catch(Exception ex) {
                return null;
            }

        }

    }
}
