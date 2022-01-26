using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Processor
{
    class Brightness
    {
        public static void brightness()
        {

        }


        public static bool Darken(Bitmap bmp) 
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int alpha = bmpColor.A;
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;
                    

                    red = (int)(red * 0.8);
                    green = (int)(green * 0.8);
                    blue = (int)(blue * 0.8);
                    bmp.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));

                }
            }

            return true;
        }

        public static bool Brighten(Bitmap bmp) //Multiplying the RGB values by 1.25 to increase the "Britghtness" of the color value by a factor of 1.25
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color bmpColor = bmp.GetPixel(i, j);
                    int alpha = bmpColor.A;
                    int red = bmpColor.R;
                    int green = bmpColor.G;
                    int blue = bmpColor.B;

                    if (((int)(red * 1.25) < 255) && ((int)(green * 1.25) < 255) && ((int)(blue * 1.25) < 255))
                    {
                        red = (int)(red * 1.25);
                        green = (int)(green * 1.25);
                        blue = (int)(blue * 1.25);
                    }
                    

                }
            }

            return true;
        }


    }
}
