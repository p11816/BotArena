using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model m = new Model();

        bool isEvolving = true;

        public MainWindow()
        {
            InitializeComponent();

            MovingCircle c = new MovingCircle(100, 22);
            m.circles.Add(c);
            c1.DataContext = c;

            c = new MovingCircle(100, 44);
            m.circles.Add(c);
            c2.DataContext = c;

            new Thread(() => {
                while (isEvolving)
                {
                    m.Evolve(0.1);
                    Thread.Sleep(100);
                }

            }).Start();
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            isEvolving = false;
        }


    }
}
