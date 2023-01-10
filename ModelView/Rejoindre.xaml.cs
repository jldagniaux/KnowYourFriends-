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
    /// Logique d'interaction pour Rejoindre.xaml
    /// </summary>
    public partial class Rejoindre : Window
    {
        public Rejoindre()
        {
            InitializeComponent();
        }
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindowFR tomainwindowfr = new MainWindowFR();
            this.Close();
            tomainwindowfr.Show();
        }
    }
}
