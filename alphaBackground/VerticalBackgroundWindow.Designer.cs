﻿namespace alphaBackground
{
    partial class VerticalBackgroundWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.previewPanel = new System.Windows.Forms.Panel();
            this.renderButton = new System.Windows.Forms.Button();
            this.horizontalGroupBox = new System.Windows.Forms.GroupBox();
            this.horizontalGapSelector = new System.Windows.Forms.NumericUpDown();
            this.hGapLabel = new System.Windows.Forms.Label();
            this.percentLabel2 = new System.Windows.Forms.Label();
            this.horizontalCountSelector = new System.Windows.Forms.NumericUpDown();
            this.hqLabel = new System.Windows.Forms.Label();
            this.verticalGroupBox = new System.Windows.Forms.GroupBox();
            this.verticalGapSelector = new System.Windows.Forms.NumericUpDown();
            this.vGapLabel = new System.Windows.Forms.Label();
            this.percentLabel1 = new System.Windows.Forms.Label();
            this.verticalCountSelector = new System.Windows.Forms.NumericUpDown();
            this.vqLabel = new System.Windows.Forms.Label();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.pictureGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteBackgroundButton = new System.Windows.Forms.Button();
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.pictureLocationTextBox = new System.Windows.Forms.TextBox();
            this.resolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.relativeGapGroupBox = new System.Windows.Forms.GroupBox();
            this.plusLabel = new System.Windows.Forms.Label();
            this.relativeGapSelector = new System.Windows.Forms.NumericUpDown();
            this.percentLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.resultGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.previewGroupBox.SuspendLayout();
            this.horizontalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalGapSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalCountSelector)).BeginInit();
            this.verticalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalGapSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalCountSelector)).BeginInit();
            this.colorGroupBox.SuspendLayout();
            this.pictureGroupBox.SuspendLayout();
            this.resolutionGroupBox.SuspendLayout();
            this.relativeGapGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativeGapSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.BackColor = System.Drawing.Color.DarkCyan;
            this.resultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPictureBox.Location = new System.Drawing.Point(6, 19);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(270, 480);
            this.resultPictureBox.TabIndex = 0;
            this.resultPictureBox.TabStop = false;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.saveButton);
            this.resultGroupBox.Controls.Add(this.resultPictureBox);
            this.resultGroupBox.Location = new System.Drawing.Point(295, 12);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(290, 537);
            this.resultGroupBox.TabIndex = 1;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Resultado";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 508);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(270, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.relativeGapGroupBox);
            this.optionsGroupBox.Controls.Add(this.previewGroupBox);
            this.optionsGroupBox.Controls.Add(this.renderButton);
            this.optionsGroupBox.Controls.Add(this.horizontalGroupBox);
            this.optionsGroupBox.Controls.Add(this.verticalGroupBox);
            this.optionsGroupBox.Controls.Add(this.colorGroupBox);
            this.optionsGroupBox.Controls.Add(this.pictureGroupBox);
            this.optionsGroupBox.Controls.Add(this.resolutionGroupBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(277, 537);
            this.optionsGroupBox.TabIndex = 2;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Opciones";
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Controls.Add(this.previewPanel);
            this.previewGroupBox.Location = new System.Drawing.Point(186, 422);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Size = new System.Drawing.Size(85, 109);
            this.previewGroupBox.TabIndex = 4;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Vista Previa";
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.previewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewPanel.Location = new System.Drawing.Point(18, 18);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(48, 85);
            this.previewPanel.TabIndex = 2;
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(6, 474);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(174, 57);
            this.renderButton.TabIndex = 2;
            this.renderButton.Text = "Generar";
            this.renderButton.UseVisualStyleBackColor = true;
            // 
            // horizontalGroupBox
            // 
            this.horizontalGroupBox.Controls.Add(this.horizontalGapSelector);
            this.horizontalGroupBox.Controls.Add(this.hGapLabel);
            this.horizontalGroupBox.Controls.Add(this.percentLabel2);
            this.horizontalGroupBox.Controls.Add(this.horizontalCountSelector);
            this.horizontalGroupBox.Controls.Add(this.hqLabel);
            this.horizontalGroupBox.Location = new System.Drawing.Point(6, 335);
            this.horizontalGroupBox.Name = "horizontalGroupBox";
            this.horizontalGroupBox.Size = new System.Drawing.Size(265, 80);
            this.horizontalGroupBox.TabIndex = 3;
            this.horizontalGroupBox.TabStop = false;
            this.horizontalGroupBox.Text = "Repetición Horizontal";
            // 
            // horizontalGapSelector
            // 
            this.horizontalGapSelector.Location = new System.Drawing.Point(100, 41);
            this.horizontalGapSelector.Name = "horizontalGapSelector";
            this.horizontalGapSelector.Size = new System.Drawing.Size(135, 20);
            this.horizontalGapSelector.TabIndex = 9;
            this.horizontalGapSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hGapLabel
            // 
            this.hGapLabel.AutoSize = true;
            this.hGapLabel.Location = new System.Drawing.Point(27, 43);
            this.hGapLabel.Name = "hGapLabel";
            this.hGapLabel.Size = new System.Drawing.Size(64, 13);
            this.hGapLabel.TabIndex = 10;
            this.hGapLabel.Text = "Separación:";
            // 
            // percentLabel2
            // 
            this.percentLabel2.AutoSize = true;
            this.percentLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel2.Location = new System.Drawing.Point(241, 43);
            this.percentLabel2.Name = "percentLabel2";
            this.percentLabel2.Size = new System.Drawing.Size(18, 15);
            this.percentLabel2.TabIndex = 8;
            this.percentLabel2.Text = "%";
            // 
            // horizontalCountSelector
            // 
            this.horizontalCountSelector.Location = new System.Drawing.Point(100, 19);
            this.horizontalCountSelector.Name = "horizontalCountSelector";
            this.horizontalCountSelector.Size = new System.Drawing.Size(159, 20);
            this.horizontalCountSelector.TabIndex = 6;
            this.horizontalCountSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hqLabel
            // 
            this.hqLabel.AutoSize = true;
            this.hqLabel.Location = new System.Drawing.Point(27, 21);
            this.hqLabel.Name = "hqLabel";
            this.hqLabel.Size = new System.Drawing.Size(52, 13);
            this.hqLabel.TabIndex = 7;
            this.hqLabel.Text = "Cantidad:";
            // 
            // verticalGroupBox
            // 
            this.verticalGroupBox.Controls.Add(this.verticalGapSelector);
            this.verticalGroupBox.Controls.Add(this.vGapLabel);
            this.verticalGroupBox.Controls.Add(this.percentLabel1);
            this.verticalGroupBox.Controls.Add(this.verticalCountSelector);
            this.verticalGroupBox.Controls.Add(this.vqLabel);
            this.verticalGroupBox.Location = new System.Drawing.Point(6, 249);
            this.verticalGroupBox.Name = "verticalGroupBox";
            this.verticalGroupBox.Size = new System.Drawing.Size(265, 80);
            this.verticalGroupBox.TabIndex = 2;
            this.verticalGroupBox.TabStop = false;
            this.verticalGroupBox.Text = "Repetición Vertical";
            // 
            // verticalGapSelector
            // 
            this.verticalGapSelector.Location = new System.Drawing.Point(100, 41);
            this.verticalGapSelector.Name = "verticalGapSelector";
            this.verticalGapSelector.Size = new System.Drawing.Size(135, 20);
            this.verticalGapSelector.TabIndex = 4;
            this.verticalGapSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vGapLabel
            // 
            this.vGapLabel.AutoSize = true;
            this.vGapLabel.Location = new System.Drawing.Point(27, 43);
            this.vGapLabel.Name = "vGapLabel";
            this.vGapLabel.Size = new System.Drawing.Size(64, 13);
            this.vGapLabel.TabIndex = 5;
            this.vGapLabel.Text = "Separación:";
            // 
            // percentLabel1
            // 
            this.percentLabel1.AutoSize = true;
            this.percentLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel1.Location = new System.Drawing.Point(241, 43);
            this.percentLabel1.Name = "percentLabel1";
            this.percentLabel1.Size = new System.Drawing.Size(18, 15);
            this.percentLabel1.TabIndex = 3;
            this.percentLabel1.Text = "%";
            // 
            // verticalCountSelector
            // 
            this.verticalCountSelector.Location = new System.Drawing.Point(100, 19);
            this.verticalCountSelector.Name = "verticalCountSelector";
            this.verticalCountSelector.Size = new System.Drawing.Size(159, 20);
            this.verticalCountSelector.TabIndex = 2;
            this.verticalCountSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vqLabel
            // 
            this.vqLabel.AutoSize = true;
            this.vqLabel.Location = new System.Drawing.Point(27, 21);
            this.vqLabel.Name = "vqLabel";
            this.vqLabel.Size = new System.Drawing.Size(52, 13);
            this.vqLabel.TabIndex = 2;
            this.vqLabel.Text = "Cantidad:";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorPanel);
            this.colorGroupBox.Location = new System.Drawing.Point(6, 187);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(265, 56);
            this.colorGroupBox.TabIndex = 2;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(6, 19);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(253, 27);
            this.colorPanel.TabIndex = 3;
            // 
            // pictureGroupBox
            // 
            this.pictureGroupBox.Controls.Add(this.deleteBackgroundButton);
            this.pictureGroupBox.Controls.Add(this.loadPictureButton);
            this.pictureGroupBox.Controls.Add(this.pictureLocationTextBox);
            this.pictureGroupBox.Location = new System.Drawing.Point(6, 76);
            this.pictureGroupBox.Name = "pictureGroupBox";
            this.pictureGroupBox.Size = new System.Drawing.Size(265, 105);
            this.pictureGroupBox.TabIndex = 4;
            this.pictureGroupBox.TabStop = false;
            this.pictureGroupBox.Text = "Imagen";
            // 
            // deleteBackgroundButton
            // 
            this.deleteBackgroundButton.Location = new System.Drawing.Point(6, 74);
            this.deleteBackgroundButton.Name = "deleteBackgroundButton";
            this.deleteBackgroundButton.Size = new System.Drawing.Size(253, 23);
            this.deleteBackgroundButton.TabIndex = 4;
            this.deleteBackgroundButton.Text = "Eliminar Fondo Blanco";
            this.deleteBackgroundButton.UseVisualStyleBackColor = true;
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.Location = new System.Drawing.Point(6, 45);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(253, 23);
            this.loadPictureButton.TabIndex = 3;
            this.loadPictureButton.Text = "Cargar";
            this.loadPictureButton.UseVisualStyleBackColor = true;
            // 
            // pictureLocationTextBox
            // 
            this.pictureLocationTextBox.Enabled = false;
            this.pictureLocationTextBox.Location = new System.Drawing.Point(6, 19);
            this.pictureLocationTextBox.Name = "pictureLocationTextBox";
            this.pictureLocationTextBox.Size = new System.Drawing.Size(253, 20);
            this.pictureLocationTextBox.TabIndex = 2;
            // 
            // resolutionGroupBox
            // 
            this.resolutionGroupBox.Controls.Add(this.resolutionComboBox);
            this.resolutionGroupBox.Location = new System.Drawing.Point(6, 19);
            this.resolutionGroupBox.Name = "resolutionGroupBox";
            this.resolutionGroupBox.Size = new System.Drawing.Size(265, 51);
            this.resolutionGroupBox.TabIndex = 0;
            this.resolutionGroupBox.TabStop = false;
            this.resolutionGroupBox.Text = "Resolución";
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.resolutionComboBox.Items.AddRange(new object[] {
            "720 x 1280 ( HD Ready )",
            "768 x 1366",
            "900 x 1600 ",
            "1080 x 1920 ( FullHD )",
            "1440 x 2560 ",
            "2160 x 3840 ( 4K )",
            "2880 x 5120 ( 5K )",
            "4320 x 7680 ( 8K )"});
            this.resolutionComboBox.Location = new System.Drawing.Point(6, 19);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(253, 21);
            this.resolutionComboBox.TabIndex = 1;
            // 
            // relativeGapGroupBox
            // 
            this.relativeGapGroupBox.Controls.Add(this.percentLabel3);
            this.relativeGapGroupBox.Controls.Add(this.relativeGapSelector);
            this.relativeGapGroupBox.Controls.Add(this.plusLabel);
            this.relativeGapGroupBox.Location = new System.Drawing.Point(6, 422);
            this.relativeGapGroupBox.Name = "relativeGapGroupBox";
            this.relativeGapGroupBox.Size = new System.Drawing.Size(174, 46);
            this.relativeGapGroupBox.TabIndex = 2;
            this.relativeGapGroupBox.TabStop = false;
            this.relativeGapGroupBox.Text = "Separación Relativa";
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(34, 19);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(14, 15);
            this.plusLabel.TabIndex = 0;
            this.plusLabel.Text = "+";
            // 
            // relativeGapSelector
            // 
            this.relativeGapSelector.Location = new System.Drawing.Point(50, 16);
            this.relativeGapSelector.Name = "relativeGapSelector";
            this.relativeGapSelector.Size = new System.Drawing.Size(70, 20);
            this.relativeGapSelector.TabIndex = 2;
            this.relativeGapSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.relativeGapSelector.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // percentLabel3
            // 
            this.percentLabel3.AutoSize = true;
            this.percentLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel3.Location = new System.Drawing.Point(122, 18);
            this.percentLabel3.Name = "percentLabel3";
            this.percentLabel3.Size = new System.Drawing.Size(18, 15);
            this.percentLabel3.TabIndex = 3;
            this.percentLabel3.Text = "%";
            // 
            // VerticalBackgroundWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 561);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VerticalBackgroundWindow";
            this.Text = "alphaBackground";
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.resultGroupBox.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.previewGroupBox.ResumeLayout(false);
            this.horizontalGroupBox.ResumeLayout(false);
            this.horizontalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalGapSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalCountSelector)).EndInit();
            this.verticalGroupBox.ResumeLayout(false);
            this.verticalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalGapSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalCountSelector)).EndInit();
            this.colorGroupBox.ResumeLayout(false);
            this.pictureGroupBox.ResumeLayout(false);
            this.pictureGroupBox.PerformLayout();
            this.resolutionGroupBox.ResumeLayout(false);
            this.relativeGapGroupBox.ResumeLayout(false);
            this.relativeGapGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relativeGapSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.GroupBox resolutionGroupBox;
        private System.Windows.Forms.GroupBox pictureGroupBox;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.TextBox pictureLocationTextBox;
        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.GroupBox horizontalGroupBox;
        private System.Windows.Forms.GroupBox verticalGroupBox;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Button deleteBackgroundButton;
        private System.Windows.Forms.NumericUpDown verticalGapSelector;
        private System.Windows.Forms.Label vGapLabel;
        private System.Windows.Forms.Label percentLabel1;
        private System.Windows.Forms.NumericUpDown verticalCountSelector;
        private System.Windows.Forms.Label vqLabel;
        private System.Windows.Forms.NumericUpDown horizontalGapSelector;
        private System.Windows.Forms.Label hGapLabel;
        private System.Windows.Forms.Label percentLabel2;
        private System.Windows.Forms.NumericUpDown horizontalCountSelector;
        private System.Windows.Forms.Label hqLabel;
        private System.Windows.Forms.Panel previewPanel;
        private System.Windows.Forms.GroupBox relativeGapGroupBox;
        private System.Windows.Forms.Label percentLabel3;
        private System.Windows.Forms.NumericUpDown relativeGapSelector;
        private System.Windows.Forms.Label plusLabel;
    }
}

