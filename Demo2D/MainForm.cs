using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Math;
using static hu.lheller.Constellations;

namespace Demo2D {
    public partial class frmMain : Form {
        private readonly string about = @"
Demo by
ladislav.heller@gmail.com
" + Information;

        public frmMain() {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();

            Width = 1280;
            Height = 800;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;
            //TopMost = true;
            //Cursor = Cursors.Cross;

            msMain.BackColor = Color.DarkGray;
            msMain.AutoSize = true;
            msMain.Dock = DockStyle.None;
            msMain.Location = new Point(0, 0);
            ssMainStatus.BackColor = Color.DarkGray;

            var CurrentConstellation = "UMI";

            var red = new Pen(Color.Red) { Width = 0.25f, DashStyle = DashStyle.Dash, StartCap = LineCap.RoundAnchor, EndCap = LineCap.ArrowAnchor };
            var green = new Pen(Color.Green) { Width = 0.25f, DashStyle = DashStyle.Dash, StartCap = LineCap.RoundAnchor, EndCap = LineCap.ArrowAnchor };
            var blue = new Pen(Color.Blue) { Width = 0.25f, DashStyle = DashStyle.Dash };
            var grid = new Pen(Color.LightGray) { Width = 0.25f, DashStyle = DashStyle.Dash };
            var tick = new Pen(Color.Blue) { Width = 0.5f, DashStyle = DashStyle.Solid };

            var black1 = new Pen(Color.Black) { Width = 0.25f, DashStyle = DashStyle.Dash };

            var ff = new Font(FontFamily.GenericMonospace, 6.0f, FontStyle.Bold);
            var fh = new Font(FontFamily.GenericMonospace, 3.0f, FontStyle.Italic);
            var fc = new Font(FontFamily.GenericMonospace, 2.0f, FontStyle.Regular);
            
            var sf1 = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var sf2 = new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near };
            var sf3 = new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Near };

            var lastDE = 90.0;
            var lastRA = 0.0;

            var SearchTime = 0.0;

            Dictionary<string, ConstellationDataXY> dataSrc1 = null;
            Dictionary<string, PointF[]> dataSrc2 = null;
            var cc = new ConstellationDataXY();

            var TickMarksNorth = new Dictionary<string, PointF[]>();
            var TickMarksSouth = new Dictionary<string, PointF[]>();
            var TickMarks = new Dictionary<string, PointF[]>();

            const float AR = 90.0f;     // distance of equator from pole
            const float TS = 2;
            const float TN = 5;
            for (var i = 0; i < 360; i += 15) {
                // start coordinates of tickmarks
                var HXS = AR * Cos(Deg2Rad(i));
                var HYS = -AR * Sin(Deg2Rad(i));

                // end coordinates of tickmarks
                var HXE = (AR - TS) * Cos(Deg2Rad(i));
                var HYE = -(AR - TS) * Sin(Deg2Rad(i));

                // coordinates of labels
                var HXN = (AR - TN) * Cos(Deg2Rad(i));
                var HYN = -(AR - TN) * Sin(Deg2Rad(i));

                var ls = i / 15;
                TickMarksSouth.Add(ls.ToString("D2"), new PointF[] {
                    new PointF((float)HXS, (float)HYS),
                    new PointF((float)HXE, (float)HYE),
                    new PointF((float)HXN, (float)HYN)
                });

                var ln = 24 - ls; if (ln == 24) ln = 0;
                TickMarksNorth.Add(ln.ToString("D2"), new PointF[] {
                    new PointF((float)HXS, (float)HYS),
                    new PointF((float)HXE, (float)HYE),
                    new PointF((float)HXN, (float)HYN)
                });
            }

            Paint += (s1, e1) => {
                // setup graphics
                var cr = e1.ClipRectangle;
                var ox = cr.Width / 2;
                var oy = cr.Height / 2;

                var gr = e1.Graphics;
                gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                // get client coordinates from current mouse screen coordinates and transform the coordinate system
                var pct = new Point[] { PointToClient(Cursor.Position) };
                gr.TranslateTransform(ox, oy);
                gr.ScaleTransform(4.0f, 4.0f);
                gr.TransformPoints(CoordinateSpace.World, CoordinateSpace.Page, pct);

                // calculate polar coordinates from XY coordinates
                var polar = XY2Polar(new PointF(pct[0].X, -pct[0].Y));
                var lastR = polar.Y;
                var lastPHI = polar.X;
                if (rbNorth.Checked) { lastRA = -lastPHI; lastDE = 90.0 - lastR; }
                if (rbSouth.Checked) { lastRA = lastPHI; lastDE = lastR - 90.0; }

                // normalize RA values
                lastRA = (lastRA + 360.0) % 360.0;

                // update status line
                ssMainStatus.Items.Clear();
                var LatinName = Boundaries[CurrentConstellation].LatinName;
                ssMainStatus.Items.Add(string.Format("RA: {0}", FormatHMS(lastRA / 15.0))).ForeColor = Color.Red;
                ssMainStatus.Items.Add(string.Format("DE: {0}", FormatDMS(lastDE))).ForeColor = Color.DarkGreen;
                ssMainStatus.Items.Add(string.Format("Current constellation: {0} - {1}", CurrentConstellation, LatinName)).ForeColor = Color.DarkBlue;
                ssMainStatus.Items.Add(string.Format("Area: {0} square degrees", Boundaries[CurrentConstellation].Area));
                ssMainStatus.Items.Add(string.Format("Rank: {0}.", Boundaries[CurrentConstellation].Rank));
                ssMainStatus.Items.Add(string.Format("Total search time: {0} ms", SearchTime)).ForeColor = Color.Yellow;

                if (cbClip.Checked) {
                    // set clip area for graphics
                    var p = new GraphicsPath();
                    //p.AddArc(-AR, -AR, 2 * AR, 2 * AR, 0, 360);
                    p.AddArc(-(AR + 0.1f), -(AR + 0.1f), 2 * (AR + 0.1f), 2 * (AR + 0.1f), 0, 360);
                    gr.SetClip(p);
                }

                // draw constellation names
                if (rbNorth.Checked) dataSrc1 = NorthConstellations;
                if (rbSouth.Checked) dataSrc1 = SouthConstellations;
                foreach (var key in dataSrc1.Keys) {
                    var c = dataSrc1[key];
                    gr.DrawString(key, fc, Brushes.Blue, c.Centroid.X, c.Centroid.Y, sf1);
                }

                // draw constellation boundaries
                if (rbNorth.Checked) dataSrc2 = NorthSegments;
                if (rbSouth.Checked) dataSrc2 = SouthSegments;
                foreach (var key in dataSrc2.Keys) gr.DrawLines(black1, dataSrc2[key]);

                // highlight current last constellation
                if (dataSrc1.Keys.Contains(CurrentConstellation)) {
                    cc = dataSrc1[CurrentConstellation];
                    gr.FillPolygon(Brushes.YellowGreen, cc.Boundary);
                    gr.DrawString(CurrentConstellation, fc, Brushes.Black, cc.Centroid.X, cc.Centroid.Y, sf1);
                }

                // draw equatorial grid
                if (cbGrid.Checked) {
                    for (var i = 10; i < 90; i += 10) gr.DrawArc(grid, -i, -i, 2 * i, 2 * i, 0, 360);
                    foreach (var key in TickMarks.Keys) gr.DrawLine(grid, 0, 0, TickMarks[key][0].X, TickMarks[key][0].Y);
                }

                // draw equator and arc of great circle at 0h
                gr.DrawArc(blue, -AR, -AR, 2 * AR, 2 * AR, 0, 360);
                gr.DrawLine(green, 0, 0, AR, 0);

                // draw hour circle ticks and hours
                if (rbNorth.Checked) TickMarks = TickMarksNorth;
                if (rbSouth.Checked) TickMarks = TickMarksSouth;
                foreach (var key in TickMarks.Keys) {
                    gr.DrawLine(tick, TickMarks[key][0].X, TickMarks[key][0].Y, TickMarks[key][1].X, TickMarks[key][1].Y);

                    // draw shadowed text
                    gr.DrawString(key, fh, Brushes.Black, TickMarks[key][2].X + 0.2f, TickMarks[key][2].Y + 0.2f, sf1);
                    gr.DrawString(key, fh, Brushes.Red, TickMarks[key][2].X, TickMarks[key][2].Y, sf1);
                }

                // draw guide graphics
                if (cbGuide.Checked) {
                    gr.DrawLine(red, 0.0f, 0.0f, pct[0].X, pct[0].Y);
                    var D = (float)lastR / 3.0f;
                    var R = (lastPHI + 360.0) % 360.0;
                    if (D > 3.0f) {
                        gr.DrawString("r = " + lastR.ToString("F"), ff, Brushes.Black, pct[0].X / 2, pct[0].Y / 2, sf2);
                        gr.DrawArc(red, -D, -D, 2 * D, 2 * D, 0, -(float)R);
                        var AX = D * Cos(Deg2Rad(R/2));
                        var AY = -D * Sin(Deg2Rad(R/2));
                        gr.DrawString("φ = " + R.ToString("F"), ff, Brushes.Black, (float)AX, (float)AY, sf3);
                    }
                }

                Invalidate();
            };

            MouseClick += (s2, e2) => {
                var sw = Stopwatch.StartNew();
                CurrentConstellation = GetConstellationFromJ2000Coordinates(lastRA, lastDE);
                sw.Stop();
                SearchTime = sw.Elapsed.TotalMilliseconds;
            };

            exitToolStripMenuItem.Click += (s3, e3) => {
                Application.Exit();
            };

            aboutToolStripMenuItem.Click += (s4, e4) => {
                MessageBox.Show(about, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            findShowToolStripMenuItem.Click += (s5, e5) => {
                var dlg = new FindAndShow();
                if (dlg.ShowDialog() == DialogResult.OK) {
                    lastDE = dlg.coordinates.Y;
                    lastRA = dlg.coordinates.X;
                    CurrentConstellation = GetConstellationFromJ2000Coordinates(lastRA, lastDE);
                    if (lastDE > 0.0) rbNorth.Checked = true;
                    else rbSouth.Checked = true;
                }
            };

            showConstellationToolStripMenuItem.Click += (s6, e6) => {
                var dlg = new ShowConstellation(CurrentConstellation);
                dlg.ShowDialog();
            };
        }

        private string FormatDMS(double value) {
            var ts = TimeSpan.FromHours(value);
            return string.Format("{0:D}°{1:D2}′{2:D2}″ ", ts.Days * 24 + ts.Hours, Abs(ts.Minutes), Abs(ts.Seconds));
        }

        private string FormatHMS(double value) {
            return TimeSpan.FromHours(value).ToString("hh\\:mm\\:ss");
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
