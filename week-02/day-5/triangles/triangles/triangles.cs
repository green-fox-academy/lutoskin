using GreenFox;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace triangles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawTriangle(foxDraw);
        }

        public static void DrawTriangle(FoxDraw foxDraw)
        {
            int x = 25;
            double setStartPointX = 0;
            double setStartPointY = 600;

            for (int k = 12; k >= 0; k--)
            {
                double startPointX = setStartPointX;
                double startPointY = setStartPointY;

                for (int i = 0; i < k; i++)
                {
                    var points = new List<Point>();
                    points.Add(new Point(startPointX, startPointY));
                    points.Add(new Point(startPointX + 2 * x, startPointY));
                    points.Add(new Point(startPointX + x, startPointY - x * System.Math.Sqrt(3)));
                    foxDraw.FillColor(Colors.White);
                    foxDraw.DrawPolygon(points);

                    startPointX = startPointX + x;
                    startPointY = startPointY - x * System.Math.Sqrt(3);
                }
                setStartPointX = setStartPointX + 2 * x;
            }
        }
    }
}
