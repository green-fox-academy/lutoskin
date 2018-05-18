using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace positionsquare
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawCheckerBoard(foxDraw);
        }

        public static void DrawCheckerBoard(FoxDraw foxDraw)
        {
            int x = 30;
            int i = 1;
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawRectangle(0, 0, x, x);

            while (i*x < 600)
            {
                foxDraw.FillColor(Colors.Purple);
                foxDraw.DrawRectangle(i * x, i * x, x, x);
                i++;
            }
        }
    }
}
