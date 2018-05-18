using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace drawhorizontallines
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawHorizontalLines(foxDraw);
        }

        public static void DrawHorizontalLines(FoxDraw foxDraw)
        {
            for (int i = 0; i < 3; i++)
            {
                int[] x = {20, 50, 100};
                int[] y = {30, 50, 100};

                foxDraw.DrawLine(x[i], y[i], x[i] + 50, y[i]);
            }
        }
    }
}
