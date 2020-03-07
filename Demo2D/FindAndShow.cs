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
                coordinates = KnownStars.Names[cbxStars.SelectedItem.ToString()];
                lblRA.Text = "RA: " + FormatHMS(coordinates.X / 15.0f);
                lblDE.Text = "DE: " + FormatDMS(coordinates.Y);
            };

            btnOK.Click += (s1, e1) => {
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
