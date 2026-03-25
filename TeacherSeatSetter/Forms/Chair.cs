using System;
using System.Drawing;
using System.Windows.Forms;
using TeacherSeatSetter.MVP.Models;

namespace TeacherSeatSetter.Forms {
    public enum DragHighlight { None, ValidDrop, OccupiedSwap }

    public partial class Chair : UserControl {
        private Student student;
        private DragHighlight _highlight = DragHighlight.None;

        public Student LinkedStudent => student;
        public bool IsOccupied => student != null;

        public event Action<Chair, Student> StudentDroppedFromList;
        public event Action<Chair, Chair> StudentSwapped;

        public Chair() : this(string.Empty) {
        }

        public Chair(string name) {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.Text = string.IsNullOrEmpty(name) ? string.Empty : name;
            this.BackColor = Color.Transparent;
            this.AllowDrop = true;
        }

        public Chair(Student student) : this(student.name) {
            this.student = student;
        }

        public void LinkStudent(Student student) {
            this.student = student;
            this.Text = student?.name;
            this.Invalidate();
        }

        public void SetHighlight(DragHighlight h) {
            _highlight = h;
            Invalidate();
        }

        public string LabelText {
            get => this.Text;
            set {
                this.Text = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Color backColor = Color.FromArgb(245, 245, 245);       // 빈 좌석: 밝은 회색
            Color borderColor = Color.FromArgb(210, 210, 210);    // 빈 좌석 테두리
            Color textColor = Color.FromArgb(51, 51, 51);
            float borderWidth = 1.2f;

            if (this.student != null) {
                backColor = Color.FromArgb(255, 243, 224);         // 배정됨: 따뜻한 크림
                borderColor = Color.FromArgb(220, 190, 160);      // 따뜻한 베이지 테두리
            }

            if (_highlight == DragHighlight.ValidDrop) {
                borderColor = ColorTranslator.FromHtml("#4CAF50");
                borderWidth = 3f;
            } else if (_highlight == DragHighlight.OccupiedSwap) {
                borderColor = ColorTranslator.FromHtml("#FF9800");
                borderWidth = 3f;
            }

            Rectangle shadowRect = new Rectangle(2, 2, this.Width - 4, this.Height - 4);
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0))) {
                e.Graphics.FillPath(shadowBrush, GetRoundedPath(shadowRect, 10));
            }

            Rectangle mainRect = new Rectangle(0, 0, this.Width - 5, this.Height - 5);
            using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedPath(mainRect, 10)) {
                using (SolidBrush brush = new SolidBrush(backColor)) {
                    e.Graphics.FillPath(brush, path);
                }
                using (Pen pen = new Pen(borderColor, borderWidth)) {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            if (!string.IsNullOrEmpty(this.Text)) {
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }) {
                    using (SolidBrush textBrush = new SolidBrush(textColor)) {
                        e.Graphics.DrawString(this.Text, this.Font, textBrush, mainRect, sf);
                    }
                }
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius) {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && student != null) {
                DragPayload payload = new DragPayload { Student = this.student, SourceChair = this };
                DoDragDrop(payload, DragDropEffects.Move);
            }
        }

        protected override void OnDragEnter(DragEventArgs e) {
            base.OnDragEnter(e);
            if (e.Data.GetDataPresent(typeof(DragPayload))) {
                DragPayload payload = (DragPayload)e.Data.GetData(typeof(DragPayload));
                if (payload.SourceChair == this) {
                    e.Effect = DragDropEffects.None;
                    return;
                }
                e.Effect = DragDropEffects.Move;
                SetHighlight(this.IsOccupied ? DragHighlight.OccupiedSwap : DragHighlight.ValidDrop);
            }
        }

        protected override void OnDragOver(DragEventArgs e) {
            base.OnDragOver(e);
            if (e.Data.GetDataPresent(typeof(DragPayload))) {
                DragPayload payload = (DragPayload)e.Data.GetData(typeof(DragPayload));
                e.Effect = payload.SourceChair == this ? DragDropEffects.None : DragDropEffects.Move;
            }
        }

        protected override void OnDragLeave(EventArgs e) {
            base.OnDragLeave(e);
            SetHighlight(DragHighlight.None);
        }

        protected override void OnDragDrop(DragEventArgs e) {
            base.OnDragDrop(e);
            SetHighlight(DragHighlight.None);

            if (!e.Data.GetDataPresent(typeof(DragPayload))) return;

            DragPayload payload = (DragPayload)e.Data.GetData(typeof(DragPayload));
            if (payload.SourceChair == this) return;

            if (payload.SourceChair != null) {
                // Chair-to-Chair swap
                Student temp = this.student;
                this.LinkStudent(payload.Student);
                payload.SourceChair.LinkStudent(temp);
                StudentSwapped?.Invoke(this, payload.SourceChair);
            } else {
                // List-to-Chair drop
                if (this.IsOccupied) return;
                this.LinkStudent(payload.Student);
                StudentDroppedFromList?.Invoke(this, payload.Student);
            }
        }
    }
}
