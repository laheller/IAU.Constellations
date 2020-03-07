namespace Demo2D {
    partial class FindAndShow {
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
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxStars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(310, 66);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cbxStars
            // 
            this.cbxStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStars.FormattingEnabled = true;
            this.cbxStars.Location = new System.Drawing.Point(12, 29);
            this.cbxStars.Name = "cbxStars";
            this.cbxStars.Size = new System.Drawing.Size(173, 24);
            this.cbxStars.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a star from the list...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(191, 10);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(31, 17);
            this.lblRA.TabIndex = 3;
            this.lblRA.Text = "RA:";
            this.lblRA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Location = new System.Drawing.Point(191, 32);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(31, 17);
            this.lblDE.TabIndex = 3;
            this.lblDE.Text = "DE:";
            this.lblDE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FindAndShow
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 102);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStars);
            this.Controls.Add(this.btnOK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindAndShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindAndShow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxStars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblDE;
    }
}