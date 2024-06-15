using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherSeatSetter.Forms {
    public partial class Chair : UserControl {
        /*
        public Chair() {
            InitializeComponent();
            label.MouseDown += Label_MouseDown;
            label.MouseMove += Label_MouseMove;
            label.MouseUp += Label_MouseUp;
            this.label.Text = string.Empty;
        }*/
        public Chair() : this(string.Empty) {
            
        }
        public Chair(string name) {
            InitializeComponent();
            if (String.IsNullOrEmpty(name))
                this.label.Text = string.Empty;
            else
                this.label.Text = name;
            label.MouseDown += Label_MouseDown;
            label.MouseMove += Label_MouseMove;
            label.MouseUp += Label_MouseUp;
            this.label.Text = name;
        }
        private Point dragStartPoint;
        private Bitmap dragBitmap;

        public string LabelText {
            get => label.Text;
            set => label.Text = value;
        }
        /*
        public DraggableLabel() {
            label = new Label {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray
            };
            label.MouseDown += Label_MouseDown;
            label.MouseMove += Label_MouseMove;
            label.MouseUp += Label_MouseUp;
            this.Controls.Add(label);
        }*/
        private void Label_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                dragStartPoint = e.Location;

                // Create drag image
                dragBitmap = new Bitmap(label.Width, label.Height);
                label.DrawToBitmap(dragBitmap, new Rectangle(Point.Empty, label.Size));
                Cursor.Current = CreateDragCursor(dragBitmap, dragStartPoint);
            }
        }

        private Cursor CreateDragCursor(Bitmap bitmap, Point hotspot) {
            Bitmap cursorBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            using (Graphics g = Graphics.FromImage(cursorBitmap)) {
                g.Clear(Color.Transparent);
                g.DrawImage(bitmap, Point.Empty);
            }
            IntPtr cursorPtr = cursorBitmap.GetHicon();
            return new Cursor(cursorPtr);
        }

        private void Label_MouseMove(object sender, MouseEventArgs e) {
            /*if (e.Button == MouseButtons.Left) {
                this.Left += e.X - dragStartPoint.X;
                this.Top += e.Y - dragStartPoint.Y;
            }*/
        }

        private void Label_MouseUp(object sender, MouseEventArgs e) {
            if (Parent != null) {
                foreach (Control control in Parent.Controls) {
                    if (control is Chair && control != this) {
                        var targetLabel = control as Chair;
                        var targetRect = new Rectangle(targetLabel.Location, targetLabel.Size);

                        if (targetRect.Contains(PointToParent(new Point(e.X, e.Y)))) {
                            // Swap text
                            string temp = this.LabelText;
                            this.LabelText = targetLabel.LabelText;
                            targetLabel.LabelText = temp;
                            break;
                        }
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private Point PointToParent(Point point) {
            return new Point(this.Left + point.X, this.Top + point.Y);
        }
    }

}
