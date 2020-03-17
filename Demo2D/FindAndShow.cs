using System;
using System.Drawing;
using static System.Math;
using System.Windows.Forms;

namespace Demo2D {
    public partial class FindAndShow : Form {
        public PointF coordinates = PointF.Empty;

        public FindAndShow() {
            InitializeComponent();

            foreach (var key in KnownStars.Names.Keys) cbxStars.Items.Add(key);
            //cbxStars.SelectedIndex = 0;

            cbxStars.SelectedIndexChanged += (s0, e0) => {
                if (rbManual.Checked) return;
                coordinates = KnownStars.Names[cbxStars.SelectedItem.ToString()].Coordinate;
                tbRA.Text = FormatHMS(coordinates.X / 15.0f);
                tbDE.Text = FormatDMS(coordinates.Y);
            };

            rbManual.CheckedChanged += (s2, e2) => {
                if (rbManual.Checked) {
                    tbRA.Text = "0.0";
                    tbDE.Text = "0.0";
                }
            };

            btnOK.Click += (s1, e1) => {
                if (rbManual.Checked) {
                    try {
                        coordinates.X = Convert.ToSingle(tbRA.Text) * 15.0f;
                    }
                    catch (Exception ex) {
                        tbRA.Text = "Invalid value. Enter a number between 0.0 and 24.0";
                        return;
                    }
                    try {
                        coordinates.Y = Convert.ToSingle(tbDE.Text);
                    }
                    catch (Exception ex) {
                        tbDE.Text = "Invalid value. Enter a number between 0.0 and 360.0";
                        return;
                    }
                }
                DialogResult = DialogResult.OK;
                Close();
            };
        }

        private string FormatDMS(double value) {
            var ts = TimeSpan.FromHours(value);
            return string.Format("{0:D}°{1:D2}′{2:D2}″ ", ts.Days * 24 + ts.Hours, Abs(ts.Minutes), Abs(ts.Seconds));
        }

        private string FormatHMS(double value) {
            return TimeSpan.FromHours(value).ToString("hh\\:mm\\:ss");
        }
    }
}
