namespace Demo2D {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cbClip = new System.Windows.Forms.CheckBox();
            this.rbNorth = new System.Windows.Forms.RadioButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.cbBoundaries = new System.Windows.Forms.CheckBox();
            this.cbGrid = new System.Windows.Forms.CheckBox();
            this.cbGuide = new System.Windows.Forms.CheckBox();
            this.rbSouth = new System.Windows.Forms.RadioButton();
            this.ssMainStatus = new System.Windows.Forms.StatusStrip();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.constellationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConstellationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbOptions.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbClip
            // 
            this.cbClip.AutoSize = true;
            this.cbClip.Checked = true;
            this.cbClip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClip.Location = new System.Drawing.Point(6, 21);
            this.cbClip.Name = "cbClip";
            this.cbClip.Size = new System.Drawing.Size(53, 21);
            this.cbClip.TabIndex = 0;
            this.cbClip.Text = "Clip";
            this.cbClip.UseVisualStyleBackColor = true;
            // 
            // rbNorth
            // 
            this.rbNorth.AutoSize = true;
            this.rbNorth.Checked = true;
            this.rbNorth.Location = new System.Drawing.Point(6, 129);
            this.rbNorth.Name = "rbNorth";
            this.rbNorth.Size = new System.Drawing.Size(64, 21);
            this.rbNorth.TabIndex = 1;
            this.rbNorth.TabStop = true;
            this.rbNorth.Text = "North";
            this.rbNorth.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptions.Controls.Add(this.cbBoundaries);
            this.gbOptions.Controls.Add(this.cbGrid);
            this.gbOptions.Controls.Add(this.cbGuide);
            this.gbOptions.Controls.Add(this.cbClip);
            this.gbOptions.Controls.Add(this.rbSouth);
            this.gbOptions.Controls.Add(this.rbNorth);
            this.gbOptions.Location = new System.Drawing.Point(608, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(180, 193);
            this.gbOptions.TabIndex = 2;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // cbBoundaries
            // 
            this.cbBoundaries.AutoSize = true;
            this.cbBoundaries.Checked = true;
            this.cbBoundaries.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoundaries.Location = new System.Drawing.Point(6, 102);
            this.cbBoundaries.Name = "cbBoundaries";
            this.cbBoundaries.Size = new System.Drawing.Size(102, 21);
            this.cbBoundaries.TabIndex = 2;
            this.cbBoundaries.Text = "Boundaries";
            this.cbBoundaries.UseVisualStyleBackColor = true;
            // 
            // cbGrid
            // 
            this.cbGrid.AutoSize = true;
            this.cbGrid.Checked = true;
            this.cbGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrid.Location = new System.Drawing.Point(6, 75);
            this.cbGrid.Name = "cbGrid";
            this.cbGrid.Size = new System.Drawing.Size(57, 21);
            this.cbGrid.TabIndex = 0;
            this.cbGrid.Text = "Grid";
            this.cbGrid.UseVisualStyleBackColor = true;
            // 
            // cbGuide
            // 
            this.cbGuide.AutoSize = true;
            this.cbGuide.Location = new System.Drawing.Point(6, 48);
            this.cbGuide.Name = "cbGuide";
            this.cbGuide.Size = new System.Drawing.Size(68, 21);
            this.cbGuide.TabIndex = 0;
            this.cbGuide.Text = "Guide";
            this.cbGuide.UseVisualStyleBackColor = true;
            // 
            // rbSouth
            // 
            this.rbSouth.AutoSize = true;
            this.rbSouth.Location = new System.Drawing.Point(6, 156);
            this.rbSouth.Name = "rbSouth";
            this.rbSouth.Size = new System.Drawing.Size(66, 21);
            this.rbSouth.TabIndex = 1;
            this.rbSouth.Text = "South";
            this.rbSouth.UseVisualStyleBackColor = true;
            // 
            // ssMainStatus
            // 
            this.ssMainStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMainStatus.Location = new System.Drawing.Point(0, 428);
            this.ssMainStatus.Name = "ssMainStatus";
            this.ssMainStatus.Size = new System.Drawing.Size(800, 22);
            this.ssMainStatus.TabIndex = 3;
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constellationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 28);
            this.msMain.TabIndex = 4;
            // 
            // constellationsToolStripMenuItem
            // 
            this.constellationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findShowToolStripMenuItem,
            this.showConstellationToolStripMenuItem,
            this.performanceTestToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.constellationsToolStripMenuItem.Name = "constellationsToolStripMenuItem";
            this.constellationsToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.constellationsToolStripMenuItem.Text = "Constellations";
            // 
            // findShowToolStripMenuItem
            // 
            this.findShowToolStripMenuItem.Name = "findShowToolStripMenuItem";
            this.findShowToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.findShowToolStripMenuItem.Text = "Find and show...";
            // 
            // showConstellationToolStripMenuItem
            // 
            this.showConstellationToolStripMenuItem.Name = "showConstellationToolStripMenuItem";
            this.showConstellationToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.showConstellationToolStripMenuItem.Text = "Show constellation...";
            // 
            // performanceTestToolStripMenuItem
            // 
            this.performanceTestToolStripMenuItem.Name = "performanceTestToolStripMenuItem";
            this.performanceTestToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.performanceTestToolStripMenuItem.Text = "Performance test...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssMainStatus);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.gbOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constellations 2D demo";
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbClip;
        private System.Windows.Forms.RadioButton rbNorth;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.RadioButton rbSouth;
        private System.Windows.Forms.StatusStrip ssMainStatus;
        private System.Windows.Forms.CheckBox cbGuide;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem constellationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbGrid;
        private System.Windows.Forms.ToolStripMenuItem findShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConstellationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceTestToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbBoundaries;
    }
}

