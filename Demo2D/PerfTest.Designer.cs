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
            ((System.ComponentModel.ISupportInitialize)(this.numCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(12, 9);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(208, 17);
            this.lblNum.TabIndex = 2;
            this.lblNum.Text = "Number of random coordinates:";
            // 
            // btnPerf
            // 
            this.btnPerf.Location = new System.Drawing.Point(352, 6);
            this.btnPerf.Name = "btnPerf";
            this.btnPerf.Size = new System.Drawing.Size(110, 23);
            this.btnPerf.TabIndex = 1;
            this.btnPerf.Text = "Start";
            this.btnPerf.UseVisualStyleBackColor = true;
            // 
            // numCalls
            // 
            this.numCalls.Location = new System.Drawing.Point(226, 7);
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
            this.ssPerf.Location = new System.Drawing.Point(0, 224);
            this.ssPerf.Name = "ssPerf";
            this.ssPerf.Size = new System.Drawing.Size(602, 22);
            this.ssPerf.TabIndex = 2;
            this.ssPerf.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(46, 17);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "label1";
            // 
            // PerfTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 246);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.numCalls);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ssPerf);
            this.Controls.Add(this.btnPerf);
            this.Name = "PerfTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performane Test";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numCalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPerf;
        private System.Windows.Forms.NumericUpDown numCalls;
        private System.Windows.Forms.StatusStrip ssPerf;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblInfo;
    }
}