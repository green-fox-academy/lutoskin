using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace Drawing1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            LineInTheMiddle(foxDraw);
        }
        public static void LineInTheMiddle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(100, 300, 500, 300);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(300, 100, 300, 500);
       
        }
    }
}
