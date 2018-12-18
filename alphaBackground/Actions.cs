using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphaBackground
{
    class backgroundParams
    {
        public int Width, Height, vQ, hQ, vGap, hGap, rGap;
        public Bitmap pattern;
        public Color backColor;
        public backgroundParams( int w, int h, Bitmap pattern, Color backColor, int verticalQ, int verticalGap, int horizontalQ, int horizontalGap, int relativeGap)
        {
            Width = w;
            Height = h;
            vQ = verticalQ;
            hQ = horizontalQ;
            vGap = verticalGap;
            hGap = horizontalGap;
            rGap = relativeGap;
            this.pattern = pattern;
            this.backColor = backColor;
        }
    }

    static class Actions
    {
        public static void deleteBackground( Bitmap bitmap, Color backColor )
        {
            for ( int x = 0; x < bitmap.Width; x++ )
                for (int y = 0; x < bitmap.Height; y++)
                    if (bitmap.GetPixel( x, y ) == backColor)
                        bitmap.SetPixel( x, y, Color.FromArgb( 0, backColor ) );
        }

        public static void deleteBackground( Bitmap bitmap )
        {
            for ( int x = 0; x < bitmap.Width; x++ )
                for (int y = 0; x < bitmap.Height; y++)
                    if (bitmap.GetPixel( x, y ) == Color.White)
                        bitmap.SetPixel( x, y, Color.FromArgb( 0, Color.White ) );
        }

        public static Bitmap getPreview( backgroundParams bparams )
        {
            Bitmap result = new Bitmap( bparams.Width / 10, bparams.Height / 10 );
            for( int x = 0; x < result.Width; x++ )
            {
                for( int y = 0; y < result.Height; y++ )
                {

                }
            }
            return result;
        }
        public static Bitmap renderResult( backgroundParams bparams )
        {
            Bitmap result = new Bitmap( bparams.Width, bparams.Height );
            return result;
        }
    }
}
