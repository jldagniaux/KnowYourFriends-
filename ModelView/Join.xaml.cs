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

namespace KnowYourFriends
{
    /// <summary>
    /// Logique d'interaction pour Join.xaml
    /// </summary>
    public partial class Join : Window
    {
        public Join()
        {
            InitializeComponent();
        }

        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tomainwindow = new MainWindow();
            this.Close();
            tomainwindow.Show();
        }
    }
}
