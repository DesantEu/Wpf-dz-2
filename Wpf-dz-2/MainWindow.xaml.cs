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

namespace Wpf_dz_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Убегатор";
        }

        private void static_enter(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Canvas cnv = this.Content as Canvas;
            int _left = r.Next( Convert.ToInt32(cnv.ActualWidth - statik.ActualWidth));
            int _top = r.Next( Convert.ToInt32(cnv.ActualHeight - statik.ActualHeight));
            // statik.Margin = new Thickness(_left,_top,0,0);
            Canvas.SetTop(statik, _top);
            Canvas.SetLeft(statik, _left);
        }
    }
}
