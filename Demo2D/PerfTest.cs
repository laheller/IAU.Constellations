using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static hu.lheller.Constellations;

namespace Demo2D {
    public partial class PerfTest : Form {
        public PerfTest() {
            InitializeComponent();

            lblInfo.Text = @"
Performance test is working following way:
The required amount (default is 10000) of random equatorial coordinate is generated.
A new stopwatch is started.
For each equatorial coordinate the constellation finder method is called in a separate thread.
Once the last thread is finished, the stopwatch is stopped.
We have the time needed to finish everything.
            ";

            btnPerf.Click += (s1, e1) => {
                btnPerf.Enabled = false;
                ssPerf.Items.Clear();
                var rnd = new Random();
                var cde = new CountdownEvent((int)numCalls.Value);
                cde.Reset();
                ssPerf.Items.Add(string.Format("Performing {0} paralell tests...", cde.InitialCount));
                var sw = Stopwatch.StartNew();

                // start performance test in a separate thread
                ThreadPool.QueueUserWorkItem(arg1 => {
                    for (var i = 0; i < cde.InitialCount; i++) {
                        ThreadPool.QueueUserWorkItem(_ => {
                            var ra = 360.0 * rnd.NextDouble();          // random RA between 0 and 360
                            var de = 180.0 * rnd.NextDouble() - 90.0;   // random DE between -90 and +90
                            var _const = GetConstellationFromJ2000Coordinates(ra, de);
                            cde.Signal();
                        });
                    }
                });

                // wait for all tests to be finished in a separate thread
                ThreadPool.QueueUserWorkItem(arg2 => {
                    cde.Wait();
                    sw.Stop();
                    Invoke((MethodInvoker)(() => {
                        ssPerf.Items.Clear();
                        ssPerf.Items.Add(string.Format("It took {0:F2} seconds to locate all {1} coordinate", sw.Elapsed.TotalSeconds, cde.InitialCount));
                        btnPerf.Enabled = true;
                    }));
                });
            };
        }
    }
}
