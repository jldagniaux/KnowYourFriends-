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
    /// Logique d'interaction pour DevinerReponses.xaml
    /// </summary>
    public partial class DevinerReponses : Window
    {
        public DevinerReponses()
        {
            InitializeComponent();
        }
        public static void UpdatePlayerScore() //change le score des joueurs
        {
            bool YesGuessCorrect = false;
            foreach (var Player in SalleAttente.playerlist)
            {
                if (Player.YesGuess == QuestionFR.NbYesAnswers)
                {
                    YesGuessCorrect = true;
                    Player.Score += 2;
                }
            }

            while (YesGuessCorrect == false && QuestionFR.NbYesAnswers >= 0)
            {
                QuestionFR.NbYesAnswers = QuestionFR.NbYesAnswers - 1;
                foreach (var Player in SalleAttente.playerlist)
                {
                    if (Player.YesGuess == QuestionFR.NbYesAnswers)
                    {
                        YesGuessCorrect = true;
                        Player.Score++;
                    }
                }
            }
        }
        private void ButtonConfirm_Click(object sender, RoutedEventArgs e) //valide la reponse du joueur
        {
            if (int.TryParse(TextBoxTryGuess.Text, out int NbYesAnswersHost) && NbYesAnswersHost <= SalleAttente.NbPlayers)
            {
                Random randomnumber = new Random();
                foreach (var Player in SalleAttente.playerlist)
                {
                    if (Player.Name != SalleAttente.HostName)
                    {
                        if (randomnumber.Next(2) == 0)
                        {
                            QuestionFR.NbYesAnswers++;
                            Player.YesGuess = randomnumber.Next(1, SalleAttente.NbPlayers + 1);
                        }
                        else
                        {
                            Player.YesGuess = randomnumber.Next(SalleAttente.NbPlayers);
                        }
                    }
                }
                var host = SalleAttente.playerlist.Find(x => x.Name == SalleAttente.HostName);
                host.YesGuess = NbYesAnswersHost;
                UpdatePlayerScore();

                if (QuestionFR.QuestionIndex == SalleAttente.NbRounds)
                {
                    SalleAttente.InfoSaved = false;
                    SalleAttente towaitingroom = new SalleAttente();
                    towaitingroom.Top = this.Top;
                    towaitingroom.Left = this.Left;
                    this.Close();
                    towaitingroom.Show();
                }
                else
                {
                    QuestionFR.QuestionIndex++;
                    QuestionFR toquestion = new QuestionFR();
                    toquestion.Top = this.Top;
                    toquestion.Left = this.Left;
                    this.Close();
                    toquestion.Show();
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Vous avez entré une réponse invalide, veuillez réessayer.", "Warning");
            }
        }
    }
}
