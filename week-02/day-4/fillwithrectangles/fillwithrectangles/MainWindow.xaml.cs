using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace fillwithrectangles
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawDiagonals(foxDraw);
        }

        public static void DrawDiagonals(FoxDraw foxDraw)
        {
            int[] x = {30, 280, 470, 550};
            int[] y = {10, 240, 430, 520};
            int[] width = {10, 15, 30, 50};
            int[] height = {40, 20, 50, 40};
            Color[] color = {Colors.Pink, Colors.AliceBlue, Colors.Aquamarine, Colors.Yellow};

            for (int i = 0; i < 4; i++) 
            {
                foxDraw.FillColor(color[i]);
                foxDraw.StrokeColor(color[i]);
                foxDraw.DrawRectangle(x[i], y[i], width[i], height[i]);
            }
        }
    }
}
