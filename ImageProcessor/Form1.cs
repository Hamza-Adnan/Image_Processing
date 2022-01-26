using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            picOG.SizeMode = PictureBoxSizeMode.Zoom;
            mnuBrighten.Enabled = false; //Greying out the buttons as there is no image loaded
            mnuDarken.Enabled = false;
            mnuGreyscale.Enabled = false;
            mnuInvert.Enabled = false;
            mnuReset.Enabled = false;
            mnuBlur.Enabled = false;
            mnuSaveAs.Enabled = false;
            mnuFlipVert.Enabled = false;
            mnuRotateHoriz.Enabled = false;
            mnuPencil.Enabled = false;
            mnuRot90.Enabled = false;
            mnuScale200.Enabled = false;
            mnuScale50.Enabled = false;
            Pic_OG.Hide(); //Used for resetting. Hiding it so that there is no overlapping

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpener = new OpenFileDialog();
            
            fileOpener.Filter = "Image File (*.bmp, *.jpg, *.png) | *bmp; *.jpg; *.png";
            if (DialogResult.OK == fileOpener.ShowDialog())
            {
                Bitmap temp = new Bitmap(fileOpener.FileName);
                if (temp.Width == 800 && temp.Height == 600)
                {
                    this.picOG.Image = temp;
                    
                    this.Pic_OG.Image = temp;
                    mnuBrighten.Enabled = true;
                    mnuDarken.Enabled = true;
                    mnuGreyscale.Enabled = true;
                    mnuInvert.Enabled = true;
                    mnuReset.Enabled = true;
                    mnuBlur.Enabled = true;
                    mnuSaveAs.Enabled = true;
                    mnuFlipVert.Enabled = true;
                    mnuRotateHoriz.Enabled = true;
                    mnuPencil.Enabled = true;
                    mnuRot90.Enabled = true;
                    mnuScale200.Enabled = true;
                    mnuScale50.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please enter a image that is 800x600 resolution!");
                }
                

            }
        }

        

        public static bool ToInvert(Bitmap bmp) //Just subtracting the color value from 255, getting esentially the "Opposite" of the intial color
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
                    
                    red = 255 - red;
                    green = 255 - green;
                    blue = 255 - blue;

                    bmp.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));

                }
            }

            return true;
        }

        

        

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileSaver = new SaveFileDialog();
            fileSaver.Filter = "Image File (*.bmp, *.jpg, *.png) | *bmp; *.jpg; *.png";
            if (DialogResult.OK == fileSaver.ShowDialog())
            {
                this.picOG.Image.Save(fileSaver.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void mnuBrighten_Click(object sender, EventArgs e)
        {

            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Brightness.Darken(cpy);
            this.picOG.Image = cpy;


        }

        private void mnuBrighten_Click_1(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Brightness.Brighten(cpy);
            this.picOG.Image = cpy;
        }

        private void mnuInvert_Click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            ToInvert(cpy);
            this.picOG.Image = cpy;
        }

        private void mnuGreyscale_Click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Greyscale.ToGreyscale(cpy);
            this.picOG.Image = cpy;
        }

        private void mnuReset_Click(object sender, EventArgs e)
        {
            this.picOG.Image = this.Pic_OG.Image;
        }

        private void mnuBlur_Click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Blur.ToBlur(cpy);
            this.picOG.Image = cpy;
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuPencil_Click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Bitmap Result = ToPencil(cpy);
            
            this.picOG.Image = Result;
        }

        public static Bitmap ToPencil(Bitmap bmp)   //My attempt at Edge detection that ended up more like the Sketch Filter on Photoshop hence the name "ToPencil"
                                                    //Had to use Try{} Catch{} Because the Code liked to throw errors every now and then and this was just easier
        {
            Bitmap tmp = new Bitmap(bmp.Width, bmp.Height); //Making a temporary Bitmap to put our edge detection results on

            int PreviousCol = 0; //Making a variable to hold the value of the pixel at last index

            for (int i = 1; i <= bmp.Width - 1; i++) //Making the background grey, Helps out with defining the edges 
            {
                for (int j = 1; j <= bmp.Height - 1; j++)
                {
                    tmp.SetPixel(i, j, Color.DarkGray);
                }
            }

            for (int i = 1; i <= bmp.Width - 1; i++)
            {
                for (int j = 1; j <= bmp.Height - 1; j++)
                {
                    try
                    {
                        Color pixel = bmp.GetPixel(i, j);

                        int colorVal = (pixel.R + pixel.G + pixel.B); //Gather the color of the Color pixel @ (i,j)

                        if (PreviousCol == 0) //The initial instructions for setting PreviousCol value to the value of pixel at (0,0)
                        {
                            PreviousCol = (pixel.R + pixel.G + pixel.B);
                        }

                        int diff;

                        if (colorVal > PreviousCol) { diff = colorVal - PreviousCol; } else { diff = PreviousCol - colorVal; } //Checking if Value of the current color > the previous color 

                        if (diff > 100) //If the difference of the two values above is less 100, it is an edge, and therefore it will stay, otherwise, the color can be thrown out for a background gray
                        {
                            tmp.SetPixel(i, j, Color.Gray);
                            PreviousCol = colorVal;
                        }


                    }
                    catch (Exception) { }
                }
            }

            
            Blur.ToBlur(tmp); // Blur filter smoothes the edges, making the lines more natural as opposed to the more jagged original
                              // Basically used in place of some fancy Anti-Aliasing because what am i, a loser with too much time on his hands? ... Dont answer that.


            return tmp;
        }

        private void mnuRotateHoriz_click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Rotate1(cpy);
            this.picOG.Image = cpy;
        }
        
        public static bool Rotate1(Bitmap bmp)
        {
            
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX); //What can i say? Work smarter not harder. Found this function while i was researching the Bitmap library @ https://docs.microsoft.com/en-us/dotnet/api/system.drawing.image.rotateflip?view=dotnet-plat-ext-6.0

            return true;
            
            
        }

        public static bool Rotate2(Bitmap bmp)
        {
            bmp.RotateFlip(RotateFlipType.Rotate180FlipY); //same story.  

            return true;
        }


        private void ResultImage_Click(object sender, EventArgs e)
        {

        }

        private void Pic_OG_Click(object sender, EventArgs e)
        {

        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Muhammad Hamza Adnan \nFor Mr Moniaga's ICS4U Class \nMark == 100% pls o(TヘTo)");
        }

        private void mnuFlipVert_Click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Rotate2(cpy);
            this.picOG.Image = cpy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuRot90_Click(object sender, EventArgs e)
        {
            Bitmap cpy = new Bitmap((Bitmap)this.picOG.Image);
            Rotate90(cpy);
            this.picOG.Image = cpy;
        }

        public static void Rotate90(Bitmap bmp)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipY);
        }

        private void mnuScale50_Click(object sender, EventArgs e)
        {
            
            Bitmap temp = new Bitmap ((Bitmap)this.picOG.Image);
            Bitmap cpy = Scale50(temp);
            this.picOG.Image = cpy;
            
        }
        public static Bitmap Scale200(Bitmap bmp) //making a bitmap of half the size and writing half the values to it
        {
            Bitmap temp = new Bitmap(bmp.Width/2, bmp.Height/2);

            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    Color nClr = bmp.GetPixel(i, j);
                    int red = nClr.R;
                    int green = nClr.G;
                    int blue = nClr.B;
                    int alpha = nClr.A;

                    temp.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));



                }
            }

            return temp;
        }

        public static Bitmap Scale50(Bitmap bmp) //Basically doubling the size of the image, and then writing the old image to it
        {
            Bitmap temp = new Bitmap(bmp.Width * 2, bmp.Height * 2);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color nClr = bmp.GetPixel(i, j);
                    int red = nClr.R;
                    int green = nClr.G;
                    int blue = nClr.B;
                    int alpha = nClr.A;

                    temp.SetPixel(i, j, Color.FromArgb(alpha, red, green, blue));



                }
            }

            return temp;
        }

        private void mnuScale200_Click(object sender, EventArgs e)
        {
            picOG.SizeMode = PictureBoxSizeMode.Zoom;
            Bitmap temp = new Bitmap((Bitmap)this.picOG.Image);
            Bitmap cpy = Scale200(temp);
            this.picOG.Image = cpy;
        }
    }
}
