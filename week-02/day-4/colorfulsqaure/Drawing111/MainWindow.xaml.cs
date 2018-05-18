using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drawing111
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawColorfulSquare(foxDraw);
        }

        public static void DrawColorfulSquare(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.DeepPink);
            foxDraw.DrawLine(200, 200, 400, 200);

            foxDraw.StrokeColor(Colors.Turquoise);
            foxDraw.DrawLine(200, 200, 200, 400);

            foxDraw.StrokeColor(Colors.DarkOrange);
            foxDraw.DrawLine(400, 200, 400, 400);

            foxDraw.StrokeColor(Colors.CornflowerBlue);
            foxDraw.DrawLine(200, 400, 400, 400);
        }
    }
}
