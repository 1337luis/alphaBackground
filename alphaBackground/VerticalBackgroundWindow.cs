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
        private BufferedGraphics buffer;
        private BufferedGraphicsContext context;
        private BackgroundParams bParams;
        public VerticalBackgroundWindow(Form sender)
        {
            InitializeComponent();
            parent = sender;
            setLang();
            context = BufferedGraphicsManager.Current;
            buffer = context.Allocate( resultPictureBox.CreateGraphics(), resultPictureBox.DisplayRectangle );
            bParams = new BackgroundParams( 1080, 1920, pattern, Color.DarkCyan, 10, 55, 10, 95, -3, 10 );
        }

        private void VerticalBackgroundWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }
        private void setLang()
        {
            string[] lang = (
                Properties.Settings.Default.LANG == "ES" ?
                Properties.Resources.SpanishCreate.Split( ',' ) :
                Properties.Resources.EnglishCreate.Split( ',' )
                );
            optionsGroupBox.Text = lang[ 0 ];
            resolutionGroupBox.Text = lang[ 1 ];
            pictureGroupBox.Text = lang[ 2 ];
            loadPictureButton.Text = lang[ 3 ];
            deleteBackgroundButton.Text = lang[ 4 ];
            colorGroupBox.Text = lang[ 5 ];
            verticalGroupBox.Text = lang[ 6 ];
            vqLabel.Text = lang[ 7 ];
            hqLabel.Text = lang[ 7 ];
            vGapLabel.Text = lang[ 8 ];
            hGapLabel.Text = lang[ 8 ];
            horizontalGroupBox.Text = lang[ 9 ];
            relativeGapGroupBox.Text = lang[ 10 ];
            patternSizeGroupBox.Text = lang[ 11 ];
            pSizeLabel.Text = lang[ 12 ];
            resultGroupBox.Text = lang[ 13 ];
            saveButton.Text = lang[ 14 ];
        }

        private void VerticalBackgroundWindow_Load(object sender, EventArgs e)
        {
            resolutionComboBox.SelectedIndex = 3;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void resolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] resolution = resolutionComboBox.Text.Split( 'x' );
            bParams.w = int.Parse( resolution[ 0 ] );
            bParams.h = int.Parse( resolution[ 1 ].Split( ' ' )[ 1 ] );
            showPreview();
        }

        private void patternSizeSelector_ValueChanged(object sender, EventArgs e)
        {
            bParams.patternSize = ( int )patternSizeSelector.Value;
            showPreview();
        }

        private void colorPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void verticalCountSelector_ValueChanged(object sender, EventArgs e)
        {
            bParams.vQ = ( int )verticalCountSelector.Value;
            showPreview();
        }

        private void verticalGapSelector_ValueChanged(object sender, EventArgs e)
        {
            bParams.vGap = ( int )verticalGapSelector.Value;
            showPreview();
        }

        private void horizontalCountSelector_ValueChanged(object sender, EventArgs e)
        {
            bParams.hQ = ( int )horizontalCountSelector.Value;
            showPreview();
        }

        private void horizontalGapSelector_ValueChanged(object sender, EventArgs e)
        {
            bParams.hGap = ( int )horizontalGapSelector.Value;
            showPreview();
        }

        private void relativeGapSelector_ValueChanged(object sender, EventArgs e)
        {
            bParams.rGap = ( int )relativeGapSelector.Value;
            showPreview();
        }

        private void deleteBackgroundButton_Click(object sender, EventArgs e)
        {
            if ( bParams.pattern != null ) bParams.pattern = Actions.deleteBackground( bParams.pattern );
            showPreview();
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            colorPanel.BackColor = UserInput.colorInput( colorPanel.BackColor );
            bParams.backColor = colorPanel.BackColor;
            showPreview();
        }

        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            String strUrl = "";
            pattern = UserInput.imageInput( out strUrl );
            pictureLocationTextBox.Text = strUrl;
            bParams.pattern = new Bitmap(Image.FromFile( strUrl ));
            showPreview();
        }

        private void showPreview()
        {
            if( pictureLocationTextBox.Text != "" && bParams.pattern != null )
                Actions.render( bParams, buffer );
        }
    }
}
