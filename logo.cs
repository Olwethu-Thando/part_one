using System;
using System.Drawing;
using System.Reflection;

namespace part_one
{
    public class logo
    {
        public logo()
        {
           
            Asci();
        }
        //ascii drawing method
        private void Asci()
        {
            //path of the logo [ where the logo is ]
            string path = string.Empty;

            //auto get full path

            string fullpath = AppDomain.CurrentDomain.BaseDirectory;
            //now combine the paths
            path = fullpath.Replace(@"bin\Debug\", "logoo.png");

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 150;
            int height = 70; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            Console.ForegroundColor = ConsoleColor.Red;
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();

            }// END OF CONSTUCTOR 
        }
    }
}
           
       
    
