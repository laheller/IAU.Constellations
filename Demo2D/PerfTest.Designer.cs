namespace Demo2D {
    partial class PerfTest {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblNum = new System.Windows.Forms.Label();
            this.btnPerf = new System.Windows.Forms.Button();
            this.numCalls = new System.Windows.Forms.NumericUpDown();
            this.ssPerf = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbxSteps = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCalls)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(3, 13);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(208, 17);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Number of random coordinates:";
            // 
            // btnPerf
            // 
            this.btnPerf.Location = new System.Drawing.Point(343, 10);
            this.btnPerf.Name = "btnPerf";
            this.btnPerf.Size = new System.Drawing.Size(110, 23);
            this.btnPerf.TabIndex = 1;
            this.btnPerf.Text = "Start";
            this.btnPerf.UseVisualStyleBackColor = true;
            // 
            // numCalls
            // 
            this.numCalls.Location = new System.Drawing.Point(217, 11);
            this.numCalls.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCalls.Name = "numCalls";
            this.numCalls.Size = new System.Drawing.Size(120, 22);
            this.numCalls.TabIndex = 0;
            this.numCalls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCalls.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // ssPerf
            // 
            this.ssPerf.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssPerf.Location = new System.Drawing.Point(0, 531);
            this.ssPerf.Name = "ssPerf";
            this.ssPerf.Size = new System.Drawing.Size(782, 22);
            this.ssPerf.TabIndex = 2;
            this.ssPerf.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(3, 48);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(46, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.numCalls);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnPerf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 177);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbxSteps);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 354);
            this.panel2.TabIndex = 5;
            // 
            // lbxSteps
            // 
            this.lbxSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxSteps.FormattingEnabled = true;
            this.lbxSteps.ItemHeight = 16;
            this.lbxSteps.Location = new System.Drawing.Point(0, 0);
            this.lbxSteps.Name = "lbxSteps";
            this.lbxSteps.Size = new System.Drawing.Size(782, 354);
            this.lbxSteps.TabIndex = 0;
            // 
            // PerfTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssPerf);
            this.Name = "PerfTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performane Test";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numCalls)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPerf;
        private System.Windows.Forms.NumericUpDown numCalls;
        private System.Windows.Forms.StatusStrip ssPerf;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbxSteps;
    }
}