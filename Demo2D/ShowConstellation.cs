using System;
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

            // get constellation boundary from contructor parameter "key"
            var _const = NorthConstellations.ContainsKey(key) ? NorthConstellations[key] : SouthConstellations[key];
            var boundary = _const.Boundary;
            var centroid = _const.Centroid;
            var newconst = new PointF[boundary.Length];

            // translate all boundary coordinate by the centroid coordinates to center the whole constellation
            for (var i = 0; i < boundary.Length; i++) newconst[i] = new PointF(boundary[i].X - centroid.X, boundary[i].Y - centroid.Y);

            var black1 = new Pen(Color.Black) { Width = 0.25f, DashStyle = DashStyle.Dash };
            var grid = new Pen(Color.LightGray) { Width = 0.25f, DashStyle = DashStyle.Dash };
            var f1 = new Font(FontFamily.GenericMonospace, 2.0f, FontStyle.Regular);
            var sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            spPanels.Panel1.Paint += (s0, e0) => {
                var cr = e0.ClipRectangle;
                var ox = cr.Width / 2;
                var oy = cr.Height / 2;
                var gr = e0.Graphics;
                gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                gr.TranslateTransform(ox, oy);
                gr.ScaleTransform(SF, SF);

                gr.DrawString(key, f1, Brushes.Black, 0, 0, sf);

                // draw the boundary and grid only after rotation
                gr.RotateTransform(tbRotation.Value);
                for (var i = 0; i < 360; i += 15) gr.DrawLine(grid, -centroid.X, -centroid.Y, 180 * (float)Math.Cos(Deg2Rad(i)) - centroid.X, 180 * (float)Math.Sin(Deg2Rad(i)) - centroid.Y);
                for (var i = 10; i <= 150; i += 10) gr.DrawArc(grid, -i - centroid.X, -i - centroid.Y, 2 * i, 2 * i, 0, 360);
                gr.DrawPolygon(black1, newconst);

                spPanels.Panel1.Invalidate();
            };

            btnSave.Click += (s1, e1) => {
                var parent = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                var control = spPanels.Panel1;
                try {
                    using (var bmp = new Bitmap(control.Width, control.Height)) {
                        control.DrawToBitmap(bmp, new Rectangle(0, 0, control.Width, control.Height));
                        bmp.Save(Path.Combine(parent, key + ".png"), ImageFormat.Png);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error");
                }
            };
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
