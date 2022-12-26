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
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int k = 0;//номер эмоции
        string num = "";//имя файла 
        int n = 2;
        public Window1()
        {
            InitializeComponent();
        }
        private void Complete(object sender, RoutedEventArgs e)
        {
            num = "imag/aaa.jpg"; 
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(num, UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image); //смена анимации, img – name в Image, image – новая гифка
        }

        private void Change(object sender, RoutedEventArgs e)
        {
            k = (k + 1) % n;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            if (k % 2 == 0) image.UriSource = new Uri("imag/1.jpg", UriKind.Relative);
            else image.UriSource = new Uri("imag/2.jpg", UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(img, image);
        }
    }
}
