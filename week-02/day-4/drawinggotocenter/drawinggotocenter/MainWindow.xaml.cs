using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace drawinggotocenter
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawToCenter(foxDraw);
        }

        // Create a line drawing function that takes 2 parameters:
        // The x and y coordinates of the line's starting point
        // and draws a line from that point to the center of the canvas.
        // Draw 3 lines with that function. Use loop for that.

        public static void DrawToCenter(FoxDraw foxDraw)
        {
            int[] x = {300, 100, 500};
            int[] y = {100, 500, 500};

            for (int i = 0; i < 3; i++)
            {
                var startPoint = new Point(x[i], y[i]);
                var endPoint = new Point(300, 300);
                foxDraw.DrawLine(startPoint, endPoint);
            }
         
        }
    }
}
