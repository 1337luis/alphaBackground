namespace alphaBackground
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newVerticalBGButton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.langSelector = new System.Windows.Forms.ToolStripSplitButton();
            this.englishSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.SpanishSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.newHorizontalBGButton = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // newVerticalBGButton
            // 
            this.newVerticalBGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newVerticalBGButton.Location = new System.Drawing.Point(12, 12);
            this.newVerticalBGButton.Name = "newVerticalBGButton";
            this.newVerticalBGButton.Size = new System.Drawing.Size(389, 78);
            this.newVerticalBGButton.TabIndex = 0;
            this.newVerticalBGButton.Text = "New Vertical Background";
            this.newVerticalBGButton.UseVisualStyleBackColor = true;
            this.newVerticalBGButton.Click += new System.EventHandler(this.newVerticalBGButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langSelector});
            this.statusBar.Location = new System.Drawing.Point(0, 190);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(413, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "langBar";
            // 
            // langSelector
            // 
            this.langSelector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.langSelector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishSelect,
            this.SpanishSelect});
            this.langSelector.Image = ((System.Drawing.Image)(resources.GetObject("langSelector.Image")));
            this.langSelector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.langSelector.Name = "langSelector";
            this.langSelector.Size = new System.Drawing.Size(61, 20);
            this.langSelector.Text = "English";
            // 
            // englishSelect
            // 
            this.englishSelect.Checked = true;
            this.englishSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishSelect.Name = "englishSelect";
            this.englishSelect.Size = new System.Drawing.Size(180, 22);
            this.englishSelect.Text = "English";
            this.englishSelect.Click += new System.EventHandler(this.englishSelect_Click);
            // 
            // SpanishSelect
            // 
            this.SpanishSelect.Name = "SpanishSelect";
            this.SpanishSelect.Size = new System.Drawing.Size(180, 22);
            this.SpanishSelect.Text = "Español";
            this.SpanishSelect.Click += new System.EventHandler(this.SpanishSelect_Click);
            // 
            // newHorizontalBGButton
            // 
            this.newHorizontalBGButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHorizontalBGButton.Location = new System.Drawing.Point(12, 96);
            this.newHorizontalBGButton.Name = "newHorizontalBGButton";
            this.newHorizontalBGButton.Size = new System.Drawing.Size(389, 78);
            this.newHorizontalBGButton.TabIndex = 2;
            this.newHorizontalBGButton.Text = "New Horizontal Background";
            this.newHorizontalBGButton.UseVisualStyleBackColor = true;
            this.newHorizontalBGButton.Click += new System.EventHandler(this.newHorizontalBGButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(413, 212);
            this.Controls.Add(this.newHorizontalBGButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.newVerticalBGButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - alphaBackground";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newVerticalBGButton;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripSplitButton langSelector;
        private System.Windows.Forms.ToolStripMenuItem englishSelect;
        private System.Windows.Forms.ToolStripMenuItem SpanishSelect;
        private System.Windows.Forms.Button newHorizontalBGButton;
    }
}