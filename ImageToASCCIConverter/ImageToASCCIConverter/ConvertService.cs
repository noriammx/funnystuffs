using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace ImageToASCCIConverter
{
    /// <summary>
    /// Service to convert any image to art ASCII
    /// I am based on: https://www.c-sharpcorner.com/article/generating-ascii-art-from-an-image-using-c-sharp/
    /// I only migrated this coded to net core
    /// </summary>
    public class ConvertService
    {
        private string[] _AsciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", "&nbsp;" };

        private string imgDefault = Directory.GetCurrentDirectory() + "\\Assets\\LogoNetCode27.png";

        public string ConvertImage(string imagePath=null , int widthImage=300)
        {
            if (imagePath == null)
            {
                imagePath = imgDefault;
            }

            //Load the Image from the specified path
            Bitmap image = new Bitmap(imagePath, true);
            //Resize the image...
            //I've used a trackBar to emulate Zoom In / Zoom Out feature
            //This value sets the WIDTH, number of characters, of the text image
            image = GetReSizedImage(image, widthImage);

            //Convert the resized image into ASCII
            return ConvertToAscii(image);

            //Enclose the final string between <pre> tags to preserve its formatting
            //and load it in the browser control
            //browserMain.DocumentText = "<pre>" + "<Font size=0>" + _Content + "</Font></pre>";
            
        }

        //Define de the image agree with the parameters
        private Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
        {
            int asciiHeight = 0;
            //Calculate the new Height of the image from its width
            asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);

            //Create a new Bitmap and define its resolution
            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage((Image)result);
            //The interpolation mode produces high quality images 
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();
            return result;
        }

        private string ConvertToAscii(Bitmap image)
        {
            Boolean toggle = false;
            StringBuilder sb = new StringBuilder();

            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    //Average out the RGB components to find the Gray Color
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);

                    //Use the toggle flag to minimize height-wise stretch
                    if (!toggle)
                    {
                        int index = (grayColor.R * 10) / 255;
                        sb.Append(_AsciiChars[index]);
                    }
                }
                if (!toggle)
                {
                    sb.Append("<BR>");
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }

      
    }
}
