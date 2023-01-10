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

namespace KnowYourFriends.View
{
    /// <summary>
    /// Logique d'interaction pour MainWindowFR.xaml
    /// </summary>
    public partial class MainWindowFR : Window
    {
        public MainWindowFR()
        {
            InitializeComponent();
        }
        private void ButtonFR_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tomainwindow = new MainWindow();
            tomainwindow.Top = this.Top;
            tomainwindow.Left = this.Left;
            this.Close();
            tomainwindow.Show();
        }
        private void ButtonHost_Click(object sender, RoutedEventArgs e)
        {
            Heberger tohost = new Heberger();
            tohost.Top = this.Top;
            tohost.Left = this.Left;
            this.Close();
            tohost.Show();
        }

        private void ButtonJoin_Click(object sender, RoutedEventArgs e)
        {
            Rejoindre tojoin = new Rejoindre();
            tojoin.Top = this.Top;
            tojoin.Left = this.Left;
            this.Close();
            tojoin.Show();
        }

        private void ButtonLeave_Click(object sender, RoutedEventArgs e)
        {
            Quitter toleave = new Quitter();
            toleave.Top = this.Top;
            toleave.Left = this.Left;
            this.Close();
            toleave.Show();
        }
    }
}
