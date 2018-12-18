using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alphaBackground
{
    public partial class VerticalBackgroundWindow : Form
    {
        private Form parent;
        private Bitmap background, preview, pattern;
        public VerticalBackgroundWindow(Form sender)
        {
            InitializeComponent();
            parent = sender;
            setLang();
        }

        private void renderButton_Click(object sender, EventArgs e)
        {

        }

        private void VerticalBackgroundWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }
        private void setLang()
        {
            string[] lang = ( 
                Properties.Settings.Default.LANG == "ES" ? 
                Properties.Resources.SpanishCreate.Split(',') : 
                Properties.Resources.EnglishCreate.Split(',')
                );
            optionsGroupBox.Text = lang[0];
            resolutionGroupBox.Text = lang[1];
            pictureGroupBox.Text = lang[2];
            loadPictureButton.Text = lang[3];
            deleteBackgroundButton.Text = lang[4];
            colorGroupBox.Text = lang[5];
            verticalGroupBox.Text = lang[6];
            vqLabel.Text = lang[7];
            hqLabel.Text = lang[7];
            vGapLabel.Text = lang[8];
            hGapLabel.Text = lang[8];
            horizontalGroupBox.Text = lang[9];
            relativeGapGroupBox.Text = lang[10];
            renderButton.Text = lang[11];
            previewGroupBox.Text = lang[12];
            resultGroupBox.Text = lang[13];
            saveButton.Text = lang[14];
        }

        private void VerticalBackgroundWindow_Load(object sender, EventArgs e)
        {
            resolutionComboBox.SelectedIndex = 3;
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = UserInput.colorInput( colorPanel.BackColor );
            previewPanel.BackColor = colorPanel.BackColor;
            resultPictureBox.BackColor = colorPanel.BackColor;
        }

        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            String strUrl = "";
            pattern = UserInput.imageInput( out strUrl );
            pictureLocationTextBox.Text = strUrl;
        }
    }
}
