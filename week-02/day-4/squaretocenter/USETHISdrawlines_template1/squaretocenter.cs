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
            DrawSquare(foxDraw);
        }

        public static void DrawSquare(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.ForestGreen);
            foxDraw.DrawRectangle(295, 295, 10, 10);

        }
    }
}
