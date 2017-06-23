using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Test
{
    class Program
    {
        // These are used to draw 
        const int ROWS = 10;
        const int COLUMNS = 10;

        const int WIDTH_IN_PIXLES = 500;
        const int HEITH_IN_PIXLES = 500;

        const int PEN_THICKNESS_IN_PIXLES = 3;

        static void Main(string[] args)
        {
            Bitmap gridPng = new Bitmap(WIDTH_IN_PIXLES, HEITH_IN_PIXLES); // create the .png with WIDTH_IN_PIXLES width and HEITH_IN_PIXELS height
            Graphics tool = Graphics.FromImage(gridPng); // Create the grid in said png using the gridPng object. This class is used to create the actual drawings
            Pen blackPen = new Pen(Color.Black, PEN_THICKNESS_IN_PIXLES); //Initialize the pen we will be drawing with


            /*
            //Temporary representation of the rooms

            //int[,] rooms_t = new int[ROWS, COLUMNS];
            int[][] rooms_t = new int[ROWS][]; // A jagged array allows for each row and column to have different sizes (array-of-arrays)

            for (int x = 0; x < rooms_t.Length; x++)
            {
                rooms_t[x] = new int[COLUMNS];
            }

            foreach (int x in rooms_t)
            {

            }
            */

            int cellWidth = WIDTH_IN_PIXLES / COLUMNS;
            int cellHeigth = HEITH_IN_PIXLES / ROWS;

            // Fill the rectangle with a gradient
            int currentColumn = 250;
            int currentRow = 1;
            int xOfUpperLeft = currentColumn * cellWidth;
            int yOfUpperLeft = currentRow * cellHeigth;
            int xOfLowerRight = (currentColumn * cellWidth) + cellWidth; // adding cellwidth shifts the position to the right
            int yOfLowerRight = (currentRow * cellHeigth) + cellHeigth;

            Brush partColorBrush = new SolidBrush(Color.Gold);
            Brush partColorBrush2 = new SolidBrush(Color.Red);
            Pen partColorPen = new Pen(Color.Red, 7);
            //tool.FillRectangle(partColorBrush, xOfUpperLeft, yOfUpperLeft, cellWidth, cellHeigth); // create a rectangle and fill it with said brush color
            tool.FillRectangle(partColorBrush, currentColumn, currentRow, cellWidth, cellHeigth);
            //tool.DrawLine(partColorPen, currentColumn, currentRow, 0, currentRow * cellHeigth);
            //tool.DrawLine(partColorPen, 1, 0, 0, 10);
            tool.FillEllipse(partColorBrush2, currentColumn, currentRow, cellWidth/2, cellHeigth/2);

            // Dispose of the tools and release them from memory
            gridPng.Save("Hello.png");
            blackPen.Dispose();
            tool.Dispose();
            gridPng.Dispose();
        }

    }
}
