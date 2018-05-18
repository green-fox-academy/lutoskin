using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace testgitignore
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
            foxDraw.StrokeColor(Colors.ForestGreen);
            foxDraw.DrawLine(0, 0, 600, 600);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(600, 0, 0, 600);
        }
    }
}
