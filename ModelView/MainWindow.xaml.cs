using KnowYourFriends.View;
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

namespace KnowYourFriends
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFR_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFR tohomefr = new MainWindowFR();
            tohomefr.Top = this.Top;
            tohomefr.Left = this.Left;
            this.Close();
            tohomefr.Show();
        }
        private void ButtonHost_Click(object sender, RoutedEventArgs e)
        {
            Host tohost = new Host();
            tohost.Top = this.Top;
            tohost.Left = this.Left;
            this.Close();
            tohost.Show();
        }

        private void ButtonJoin_Click(object sender, RoutedEventArgs e)
        {
            Join tojoin = new Join();
            tojoin.Top = this.Top;
            tojoin.Left = this.Left;
            this.Close();
            tojoin.Show();
        }

        private void ButtonLeave_Click(object sender, RoutedEventArgs e)
        {
            Leave toleave = new Leave();
            toleave.Top = this.Top;
            toleave.Left = this.Left;
            this.Close();
            toleave.Show();
        }
    }
}
