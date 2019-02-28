using StatisticLib.LogicModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticSimpleVisualizationLib
{
    public static class BitmapDrawExtension
    {
        public static object Draw(this Histogram histogram, DrawMode drawMode, int width = 400, int height = 300, string path = "histogram.png")
        {
            try
            {
                Bitmap bitmap = new Bitmap(width, height);

                // Fill background
                bitmap.Fill(0, 0, width, height, Color.Wheat);

                // Border
                int widthBorder = width / 18;
                int heightBorder = height / 18;

                // Draw axis
                for (int i = widthBorder; i < width - widthBorder; i++)
                    bitmap.SetPixel(i, height - heightBorder, Color.Black);
                for (int i = heightBorder; i < height - heightBorder; i++)
                    bitmap.SetPixel(widthBorder, i, Color.Black);

                // Borders
                int widthWithoutBorders = width - 2 * widthBorder;
                int widthInsideBorder = widthWithoutBorders / 18;
                int rangeWidth = ((widthWithoutBorders - 2 * widthInsideBorder) / histogram.Ranges.Count);
                int heightWithoutBorder = height - 2 * heightBorder;
                int heightInsideBorder = heightWithoutBorder / 18;
                int workingMaxHeight = heightWithoutBorder - heightInsideBorder;

                // Drawing ranges
                for (int i = 0; i < histogram.Ranges.Count; i++)
                {
                    int rangeHeight = (int)((double)histogram.Ranges[i].Count / histogram.MaxCount * workingMaxHeight);
                    
                    bitmap.Fill(widthBorder + widthInsideBorder + rangeWidth * i,
                        heightBorder + heightInsideBorder + (workingMaxHeight - rangeHeight),
                        rangeWidth,
                        rangeHeight,
                        Color.Red,
                        Color.Black);

                    // Draw lower labels
                    bool isLast = i == histogram.Ranges.Count - 1;
                    if (i % (histogram.Ranges.Count / 10) == 0 || isLast)
                    {
                        for (int j = 1; j <= heightBorder / 8; j++)
                            bitmap.SetPixel(widthBorder + widthInsideBorder + (rangeWidth * (i + (isLast? 1 : 0)) - (isLast? 1 : 0)), height - heightBorder + j, Color.Black);
                        Graphics g = Graphics.FromImage(bitmap);
                        g.DrawString((isLast? histogram.Ranges[i].To : histogram.Ranges[i].From).ToString("F3"),
                            new Font("Arial", width/75),
                            Brushes.Black,
                            widthBorder + widthInsideBorder + rangeWidth * (i - (isLast? 0 : 1)),
                            height - heightBorder + heightBorder / 8);

                        g.Flush();
                    }
                }

                // Draw left labels
                // TODO

                // Saving
                switch (drawMode)
                {
                    case DrawMode.ReturnBitmap:
                        return bitmap;

                    case DrawMode.JustSave:
                        bitmap.Save(path);
                        break;

                    case DrawMode.SaveAndOpen:
                        bitmap.Save(path);
                        Process.Start(path);
                        break;
                }

                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private static void Fill(this Bitmap bitmap, int x, int y, int width, int height, Color color, Color? borderColor = null)
        {
            if (borderColor == null) borderColor = color;
            for (int j = y; j < y + height; j++)
                for (int i = x; i < x + width; i++)
                    bitmap.SetPixel(i, j, (j == y || j == y + height - 1 || i == x || i == x + width - 1) ? borderColor.Value : color);
        }

    }
}
