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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            setLang();
        }

        private void setLang()
        {
            String lang = Properties.Settings.Default.LANG;
            String[] strings;
            if( lang == "ES" )
            {
                strings = Properties.Resources.SpanishMain.Split( ',' );
                englishSelect.Checked = false;
                SpanishSelect.Checked = true;
            } else
            {
                strings = Properties.Resources.EnglishMain.Split( ',' );
                englishSelect.Checked = true;
                SpanishSelect.Checked = false;
            }

            Text = strings[ 0 ];
            newVerticalBGButton.Text = strings[ 1 ];
            newHorizontalBGButton.Text = strings[ 2 ];
            langSelector.Text = strings[ 5 ];
            SpanishSelect.Text = strings[ 4 ];
            englishSelect.Text = strings[ 3 ];
              
        }

        private void englishSelect_Click(object sender, EventArgs e)
        {
            englishSelect.Checked = true;
            SpanishSelect.Checked = false;
            Properties.Settings.Default.LANG = "ENG";
            Properties.Settings.Default.Save();
            setLang();
        }

        private void SpanishSelect_Click(object sender, EventArgs e)
        {
            englishSelect.Checked = false;
            SpanishSelect.Checked = true;
            Properties.Settings.Default.LANG = "ES";
            Properties.Settings.Default.Save();
            setLang();
        }

        private void newVerticalBGButton_Click(object sender, EventArgs e)
        {
            Hide();
            new VerticalBackgroundWindow(this).ShowDialog();
        }

        private void newHorizontalBGButton_Click(object sender, EventArgs e)
        {
            Hide();
            new HorizontalBackgroundWindow(this).ShowDialog();
        }
    }
}
