using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace USETHISdrawlines_template1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLinePlay(foxDraw);
        }

        public static void DrawLinePlay(FoxDraw foxDraw)
        {
            int x = 20;
            int y = 20;
         

            for (int i = 1; i <= 30; i++)
            {
                foxDraw.StrokeColor(Colors.ForestGreen);
                foxDraw.DrawLine(i * x, 0, 600, i*x);
            }

            for (int j = 1; j <= 30; j++)
            {
                foxDraw.StrokeColor(Colors.DeepPink);
                foxDraw.DrawLine(0, j * y, j*y, 600);
            }
        }
    }
}
