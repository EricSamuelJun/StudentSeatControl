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
        Student student;

        public Chair() : this(string.Empty) {
            
        }
        public Chair(string name) {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.Text = string.IsNullOrEmpty(name) ? string.Empty : name;
            this.BackColor = Color.Transparent;
        }
        public Chair(Student student) : this(student.name) {
            this.student = student;
        }

        public void LinkStudent(Student student) {
            this.student = student;
            this.Text = student?.name;
            this.Invalidate();
        }

        private Point dragStartPoint;
        private Bitmap dragBitmap;

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

            // Define colors
            Color backColor = ColorTranslator.FromHtml("#FFFFFF");
            Color borderColor = ColorTranslator.FromHtml("#DDDDDD");
            Color textColor = ColorTranslator.FromHtml("#333333");
            
            // Adjust colors based on state or student presence
            if (this.student != null) {
                backColor = ColorTranslator.FromHtml("#E3F2FD"); // Light Blue for occupied
                borderColor = ColorTranslator.FromHtml("#2196F3");
            }

            // Draw shadow
            Rectangle shadowRect = new Rectangle(2, 2, this.Width - 4, this.Height - 4);
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0))) {
                e.Graphics.FillPath(shadowBrush, GetRoundedPath(shadowRect, 10));
            }

            // Draw background
            Rectangle mainRect = new Rectangle(0, 0, this.Width - 5, this.Height - 5);
            using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedPath(mainRect, 10)) {
                using (SolidBrush brush = new SolidBrush(backColor)) {
                    e.Graphics.FillPath(brush, path);
                }
                using (Pen pen = new Pen(borderColor, 1.5f)) {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Draw text
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
            if (e.Button == MouseButtons.Left) {
                dragStartPoint = e.Location;

                // Create drag image
                dragBitmap = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(dragBitmap, new Rectangle(Point.Empty, this.Size));
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

        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            base.OnMouseUp(e);
            if (Parent != null) {
                foreach (Control control in Parent.Controls) {
                    if (control is Chair && control != this) {
                        var targetLabel = control as Chair;
                        var targetRect = new Rectangle(targetLabel.Location, targetLabel.Size);

                        if (targetRect.Contains(PointToParent(new Point(e.X, e.Y)))) {
                            // Swap Student
                            Student temp = this.student;
                            this.LinkStudent(targetLabel.student);
                            targetLabel.LinkStudent(temp);
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
