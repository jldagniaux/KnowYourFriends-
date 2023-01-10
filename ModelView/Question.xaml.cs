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
    /// Logique d'interaction pour Question.xaml
    /// </summary>
    public partial class Question : Window
    {
        public Question()
        {
            InitializeComponent();
        }
        public static int QuestionIndex = 1;
        public static int NbYesAnswers = 0;
        public static string[] Questions = new string[11]
        {
            "", //Synchronize variable IndexQuestion and index array Questions
            "Do you want to have children one day?",
            "Do you think France should have won the 2022 football World Cup?",
            "Have you ever stolen anything from a store or somewhere else ?",
            "Do you believe in reincarnation ?",
            "Do you like board games ?",
            "Would you like to be famous? ?",
            "Do you like karaoke ?",
            "Have you ever sworn on a friend's head while lying ?",
            "Would you like to work abroad later ?",
            "Do you read your horoscope regularly ?" };
        public void DisplayInfoQuestion(object sender, EventArgs e) //affiche la question et son numero
        {
            TextBlockQuestionIndex.Text = "Question n°" + QuestionIndex;
            TextBlockQuestion.Text = Questions[QuestionIndex];
        }
        private void ButtonYes_Click(object sender, RoutedEventArgs e) //repond oui a la question et augmente donc le nombre de oui total
        {
            NbYesAnswers++;
            GuessAnswers toguessanswers = new GuessAnswers();
            toguessanswers.Top = this.Top;
            toguessanswers.Left = this.Left;
            this.Close();
            toguessanswers.Show();
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e) // repond non a la question
        {
            GuessAnswers toguessanswers = new GuessAnswers();
            toguessanswers.Top = this.Top;
            toguessanswers.Left = this.Left;
            this.Close();
            toguessanswers.Show();
        }
    }
}
