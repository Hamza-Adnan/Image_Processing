using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Processor
{
    class Blur
    {
        public static bool ToBlur(Bitmap bmp)
        {
            

            /*int [,] test = new int[bmp.Width, bmp.Height];



            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    test[i, j] = bmp.GetPixel(i,j);
                }
            }*/

            for (int i = 1; i < bmp.Width; i++)
            {
                for (int j = 1; j < bmp.Height; j++)
                {
                    try
                    {
                        Color lastI = bmp.GetPixel(i - 1, j);
                        Color nextI = bmp.GetPixel(i + 1, j);
                        Color lastJ = bmp.GetPixel(i, j - 1);
                        Color nextJ = bmp.GetPixel(i, j + 1);

                        int avgRed = (int)((lastI.R + nextI.R + lastJ.R + nextJ.R) / 4);
                        int avgGreen = (int)((lastI.G + nextI.G + lastJ.G + nextJ.G) / 4);
                        int avgBlue = (int)((lastI.B + nextI.B + lastJ.B + nextJ.B) / 4);

                        bmp.SetPixel(i, j, Color.FromArgb(avgRed, avgGreen, avgBlue));




                    }
                    catch (Exception) { }

                }
            }

            return true;
        }

    }
}
