using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using static hu.lheller.Constellations;

namespace Demo2D {
    public partial class ShowConstellation : Form {
        public ShowConstellation(string key) {
            InitializeComponent();

            const float SF = 4.0f;      // scale factor
            const int M = 10;

            // get constellation boundary from contructor parameter "key"
            var _const = NorthConstellations.ContainsKey(key) ? NorthConstellations[key] : SouthConstellations[key];
            var _cp = Boundaries[key].Centroid;
            var boundary = _const.Boundary;
            var centroid = _const.Centroid;
            var newconst = new PointF[boundary.Length];

            // translate all boundary coordinate by the centroid coordinates to center the whole constellation
            for (var i = 0; i < boundary.Length; i++) newconst[i] = new PointF(boundary[i].X - centroid.X, boundary[i].Y - centroid.Y);

            var black1 = new Pen(Color.Black) { Width = 0.25f, DashStyle = DashStyle.Dash };
            var grid = new Pen(Color.LightGray) { Width = 0.25f, DashStyle = DashStyle.Dash };
            var f1 = new Font(FontFamily.GenericMonospace, 2.0f, FontStyle.Regular);
            var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            var StartPoint = new PointF(-centroid.X, -centroid.Y);
            var GreatCirclePoints = new List<PointF>();
            for (var i = 0; i < 360; i += 15) {
                var px = 180 * (float)Math.Cos(Deg2Rad(i)) - centroid.X;
                var py = 180 * (float)Math.Sin(Deg2Rad(i)) - centroid.Y;
                GreatCirclePoints.Add(new PointF(px, py));
            }

            spPanels.Panel1.Paint += (s0, e0) => {
                var cr = e0.ClipRectangle;
                var ox = cr.Width / 2;
                var oy = cr.Height / 2;
                var gr = e0.Graphics;
                gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                gr.TranslateTransform(ox, oy);
                gr.ScaleTransform(SF, SF);

                // draw border and constellation name
                var rect = new RectangleF((M - ox) / SF, (M - oy) / SF, 2 * (ox - M) / SF, 2 * (oy - M) / SF);
                gr.DrawRectangle(black1, rect.X, rect.Y, rect.Width, rect.Height);
                gr.DrawString(key, f1, Brushes.Black, 0, 0, sf);

                // draw the boundary and grid only after rotation
                gr.RotateTransform(tbRotation.Value);

                // rectangle below will show the bounds of visible area
                //gr.DrawRectangle(Pens.Green, -ox / SF, -oy / SF, 2 * ox / SF, 2 * oy / SF);

                // draw grid
                for (var i = 0; i < GreatCirclePoints.Count; i++) gr.DrawLine(grid, StartPoint, GreatCirclePoints[i]);
                for (var i = 10; i <= 150; i += 10) gr.DrawArc(grid, -i - centroid.X, -i - centroid.Y, 2 * i, 2 * i, 0, 360);

                // draw constellation boundary
                gr.DrawPolygon(black1, newconst);

                spPanels.Panel1.Invalidate();
            };

            btnSave.Click += (s1, e1) => {
                var parent = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                var sfd = new SaveFileDialog() {
                    DefaultExt = "png",
                    FileName = key,
                    Filter = "PNG|*.png",
                    InitialDirectory = parent,
                    Title = "Enter image file name..."
                };
                if (sfd.ShowDialog() != DialogResult.OK) return;

                var control = spPanels.Panel1;
                try {
                    using (var bmp = new Bitmap(control.Width, control.Height)) {
                        control.DrawToBitmap(bmp, new Rectangle(0, 0, control.Width, control.Height));
                        bmp.Save(Path.Combine(parent, sfd.FileName), ImageFormat.Png);
                    }
                    Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error");
                }
            };
        }

        // equation of line: y = mx + b
        float GetY(PointF A, PointF B, float X) {
            var dx = B.X - A.X;
            if (dx == 0.0f) return float.NaN;
            var dy = B.Y - A.Y;
            var m = dy / dx;
            var b = A.Y - m * A.X;
            return m * X + b;
        }

        // equation of line: x = my + b
        float GetX(PointF A, PointF B, float Y) {
            var dy = B.Y - A.Y;
            if (dy == 0.0f) return float.NaN;
            var dx = B.X - A.X;
            var m = dx / dy;
            var b = A.X - m * A.Y;
            return m * Y + b;
        }

        protected override CreateParams CreateParams {
            // problem solved by this answer
            // https://stackoverflow.com/a/2613272/6736299
            get {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
