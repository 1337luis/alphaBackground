using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alphaBackground
{
    static class UserInput
    {
        public static Color colorInput( Color defaultColor )
        {
            ColorDialog c = new ColorDialog();
            if( c.ShowDialog() == DialogResult.OK )
                return c.Color;
            else
                return defaultColor;
        }

        public static Bitmap imageInput( out string url )
        {
            OpenFileDialog o = new OpenFileDialog();
            Bitmap result;

            o.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp; *.gif";

            if (o.ShowDialog() == DialogResult.OK)
            {
                result = new Bitmap( Image.FromFile( o.FileName ) );
                url = o.FileName;
            } else
            {
                result = null;
                url = "";
            }

            return result;
        }
    }
}
