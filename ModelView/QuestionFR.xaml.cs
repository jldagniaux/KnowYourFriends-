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
    /// Logique d'interaction pour QuestionFR.xaml
    /// </summary>
    public partial class QuestionFR : Window
    {
        public QuestionFR()
        {
            InitializeComponent();
        }

        public static int QuestionIndex = 1;
        public static int NbYesAnswers = 0;
        public static string[] Questions = new string[11]
        {
            "", //Synchronize variable IndexQuestion and index array Questions
            "Vouslez-vous avoir des enfants un jour ?",
            "Pensez-vous que la France aurait dû gagner la coupe du monde de football 2022 ?",
            "Avez-vous déjà volé quelque chose d'un magasin ou autre ?",
            "Croyez-vous en la réincarnation ?",
            "Aimes-tu les jeux de société ?",
            "Aimeriez-vous être une célébrité ?",
            "Aimez-vous les karaokés ?",
            "Avez-vous déjà juré sur la tête de quelq'un en jurant ?",
            "Aimeriez-vous travailler à l'étranger plus tard ?",
            "Lisez-vous votre horoscopre régulièrement ?" };
        public void DisplayInfoQuestion(object sender, EventArgs e) //affiche la question et son numero
        {
            TextBlockQuestionIndex.Text = "Question n°" + QuestionIndex;
            TextBlockQuestion.Text = Questions[QuestionIndex];
        }
        private void ButtonYes_Click(object sender, RoutedEventArgs e) //repond oui a la question et augmente donc le nombre de oui total
        {
            NbYesAnswers++;
            DevinerReponses toguessanswers = new DevinerReponses();
            toguessanswers.Top = this.Top;
            toguessanswers.Left = this.Left;
            this.Close();
            toguessanswers.Show();
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e) // repond non a la question
        {
            DevinerReponses toguessanswers = new DevinerReponses();
            toguessanswers.Top = this.Top;
            toguessanswers.Left = this.Left;
            this.Close();
            toguessanswers.Show();
        }
    }
}
