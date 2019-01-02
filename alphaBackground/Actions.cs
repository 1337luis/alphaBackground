using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphaBackground
{
    class BackgroundParams
    {
        public int w, h, vQ, hQ, vGap, hGap, rGap, patternSize;
        public Bitmap pattern;
        public Color backColor;
        public BackgroundParams(int width, int height, Bitmap pattern, Color backColor, int verticalQ, int verticalGap, int horizontalQ, int horizontalGap, int relativeGap, int patternSize)
        {
            w = width;
            h = height;
            vQ = verticalQ;
            hQ = horizontalQ;
            vGap = verticalGap;
            hGap = horizontalGap;
            rGap = relativeGap;
            this.pattern = pattern;
            this.backColor = backColor;
            this.patternSize = patternSize;
        }
    }

    static class Actions
    {
        public static void render(BackgroundParams p, BufferedGraphics buffer)
        {
            buffer.Graphics.Clear( p.backColor );
            Bitmap rPattern = new Bitmap( p.pattern, perSz( p.pattern.Size, p.patternSize ) );
            for (int y = 0; y < p.vQ; y++)
            {
                for (int x = 0; x < p.hQ; x++)
                {
                    if (y % 2 == 0)
                        buffer.Graphics.DrawImage( rPattern, new Point( x * p.hGap, y * p.vGap ) );
                    else
                        buffer.Graphics.DrawImage( rPattern, new Point( x * p.hGap + ( int )map( p.rGap, 100, p.w ), y * p.vGap ) );
                }
            }
            buffer.Render();
        }

        public static void deleteBackground(Bitmap bitmap, Color backColor)
        {
            for (int x = 0; x < bitmap.Width; x++)
                for (int y = 0; x < bitmap.Height; y++)
                    if (bitmap.GetPixel( x, y ) == backColor)
                        bitmap.SetPixel( x, y, Color.FromArgb( 0, backColor ) );
        }

        public static Bitmap deleteBackground(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap);
            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                        if (white( result.GetPixel( x, y ) ))
                            result.SetPixel( x, y, Color.Transparent );
            return result;
        }

        private static float per(int value, int percent)
        {
            return ( float )value * ( ( float )percent / 100.0f );
        }

        private static float map(int xValue, int xMax, int y)
        {
            return y * xValue / xMax;
        }

        private static Size perSz(Size sz, int percent)
        {
            return new Size(
                ( int )per( sz.Width, percent ),
                ( int )per( sz.Height, percent )
                );
        }

        private static bool white( Color c )
        {
            return c.R > 250 && c.G > 250 && c.B > 250;
        }
    }
}
