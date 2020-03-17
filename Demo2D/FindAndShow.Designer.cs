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
            this.grpCoordinate = new System.Windows.Forms.GroupBox();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.tbRA = new System.Windows.Forms.TextBox();
            this.tbDE = new System.Windows.Forms.TextBox();
            this.grpCoordinate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(531, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // cbxStars
            // 
            this.cbxStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStars.FormattingEnabled = true;
            this.cbxStars.Location = new System.Drawing.Point(15, 114);
            this.cbxStars.Name = "cbxStars";
            this.cbxStars.Size = new System.Drawing.Size(173, 24);
            this.cbxStars.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a star from the list...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(204, 37);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(31, 17);
            this.lblRA.TabIndex = 3;
            this.lblRA.Text = "RA:";
            this.lblRA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Location = new System.Drawing.Point(204, 59);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(31, 17);
            this.lblDE.TabIndex = 3;
            this.lblDE.Text = "DE:";
            this.lblDE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpCoordinate
            // 
            this.grpCoordinate.Controls.Add(this.rbManual);
            this.grpCoordinate.Controls.Add(this.rbList);
            this.grpCoordinate.Location = new System.Drawing.Point(12, 12);
            this.grpCoordinate.Name = "grpCoordinate";
            this.grpCoordinate.Size = new System.Drawing.Size(176, 79);
            this.grpCoordinate.TabIndex = 4;
            this.grpCoordinate.TabStop = false;
            this.grpCoordinate.Text = "Coordinates";
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Checked = true;
            this.rbList.Location = new System.Drawing.Point(6, 21);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(141, 21);
            this.rbList.TabIndex = 0;
            this.rbList.TabStop = true;
            this.rbList.Text = "From list by a star";
            this.rbList.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(6, 48);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(123, 21);
            this.rbManual.TabIndex = 1;
            this.rbManual.Text = "Enter manually";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // tbRA
            // 
            this.tbRA.Location = new System.Drawing.Point(241, 32);
            this.tbRA.Name = "tbRA";
            this.tbRA.Size = new System.Drawing.Size(365, 22);
            this.tbRA.TabIndex = 3;
            // 
            // tbDE
            // 
            this.tbDE.Location = new System.Drawing.Point(241, 56);
            this.tbDE.Name = "tbDE";
            this.tbDE.Size = new System.Drawing.Size(365, 22);
            this.tbDE.TabIndex = 4;
            // 
            // FindAndShow
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 153);
            this.Controls.Add(this.tbDE);
            this.Controls.Add(this.tbRA);
            this.Controls.Add(this.grpCoordinate);
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
            this.grpCoordinate.ResumeLayout(false);
            this.grpCoordinate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxStars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.GroupBox grpCoordinate;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.TextBox tbRA;
        private System.Windows.Forms.TextBox tbDE;
    }
}