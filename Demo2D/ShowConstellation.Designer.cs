namespace Demo2D {
    partial class ShowConstellation {
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
            this.spPanels = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbRotation = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.spPanels)).BeginInit();
            this.spPanels.Panel2.SuspendLayout();
            this.spPanels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // spPanels
            // 
            this.spPanels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spPanels.Location = new System.Drawing.Point(0, 0);
            this.spPanels.Name = "spPanels";
            // 
            // spPanels.Panel2
            // 
            this.spPanels.Panel2.Controls.Add(this.btnSave);
            this.spPanels.Panel2.Controls.Add(this.tbRotation);
            this.spPanels.Size = new System.Drawing.Size(800, 450);
            this.spPanels.SplitterDistance = 627;
            this.spPanels.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(82, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbRotation
            // 
            this.tbRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotation.Location = new System.Drawing.Point(101, 12);
            this.tbRotation.Maximum = 180;
            this.tbRotation.Minimum = -180;
            this.tbRotation.Name = "tbRotation";
            this.tbRotation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbRotation.Size = new System.Drawing.Size(56, 104);
            this.tbRotation.TabIndex = 0;
            this.tbRotation.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // ShowConstellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spPanels);
            this.DoubleBuffered = true;
            this.Name = "ShowConstellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowConstellation";
            this.spPanels.Panel2.ResumeLayout(false);
            this.spPanels.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPanels)).EndInit();
            this.spPanels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbRotation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spPanels;
        private System.Windows.Forms.TrackBar tbRotation;
        private System.Windows.Forms.Button btnSave;
    }
}