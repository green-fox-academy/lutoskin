using GreenFox;
using System.Windows;
using System.Windows.Media;

namespace USETHISdrawlines_template2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawCheckerBox(foxDraw);
        }
      
        public static void DrawCheckerBox(FoxDraw foxDraw)
        {
            int k = 0;
            while (k * 60 < 300)
            {
                foxDraw.StrokeColor(Colors.Black);
                foxDraw.FillColor(Colors.Black);
                foxDraw.DrawRectangle(0, k*60, 30, 30);
                foxDraw.FillColor(Colors.White);
                foxDraw.DrawRectangle(30, k*60, 30, 30);

                int i = 1;

                while (i * 30 < 300)
                {
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle(i * 60, k*60, 30, 30);
                    foxDraw.FillColor(Colors.White);
                    foxDraw.DrawRectangle((30 + (i * 60)), k*60, 30, 30);
                    i++;
                }

                foxDraw.FillColor(Colors.White);
                foxDraw.DrawRectangle(0, ((k*60)+30), 30, 30);
                foxDraw.FillColor(Colors.Black);
                foxDraw.DrawRectangle(30, ((k * 60) + 30), 30, 30);

                int j = 1;
                while (j * 30 < 300)
                {
                    foxDraw.FillColor(Colors.White);
                    foxDraw.DrawRectangle(j * 60, ((k * 60) + 30), 30, 30);
                    foxDraw.FillColor(Colors.Black);
                    foxDraw.DrawRectangle((30 + (j * 60)), ((k * 60) + 30), 30, 30);
                    j++;
                }
                k++;
            }
          
        }
    }
}
