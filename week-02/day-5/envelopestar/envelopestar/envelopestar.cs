using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace envelopestar
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
            int x = 30;

            for (int i = 0; i <= 10; i++)
            {
                foxDraw.StrokeColor(Colors.ForestGreen);
                foxDraw.DrawLine(i*x, 300, 300, 300-(i*x));
            }

            for (int i = 0; i <= 10; i++)
            {
                foxDraw.StrokeColor(Colors.ForestGreen);
                foxDraw.DrawLine(300, i*x, 300 + (i * x), 300);
            }

            for (int i = 0; i <= 10; i++)
            {
                foxDraw.StrokeColor(Colors.ForestGreen);
                foxDraw.DrawLine(i * x, 300, 300, 300 + (i * x));
            }

            for (int i = 0; i <= 10; i++)
            {
                foxDraw.StrokeColor(Colors.ForestGreen);
                foxDraw.DrawLine(300, 300 + (i * x), 600 - (i*x), 300);
            }

        }
    }
}
