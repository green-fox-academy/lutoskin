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
            Triangle(foxDraw);
        }

        public static void DrawTriangle(FoxDraw foxDraw)
        {
            int x = 100;
            int startPoint = 100;

            var points = new List<Point>();
            points.Add(new Point(startPoint, (x/2)* System.Math.Sqrt(3)));
            points.Add(new Point(startPoint + x, (x/2) * System.Math.Sqrt(3)));
            points.Add(new Point(startPoint + x/2, 0));
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawPolygon(points);
        }

        public static void Triangle(FoxDraw foxDraw)
        {
            int x = 100;
            int startPoint = 300;

            var points = new List<Point>();
            points.Add(new Point(startPoint, 0));
            points.Add(new Point(startPoint-x / 2, (x/2) * System.Math.Sqrt(3)));
            points.Add(new Point(startPoint + x / 2, (x / 2) * System.Math.Sqrt(3)));
            foxDraw.FillColor(Colors.White);
            foxDraw.DrawPolygon(points);
        }

    }
}
