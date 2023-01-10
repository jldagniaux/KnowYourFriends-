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
    /// Logique d'interaction pour GuessAnswers.xaml
    /// </summary>
    public partial class GuessAnswers : Window
    {
        public GuessAnswers()
        {
            InitializeComponent();
        }
        public static void UpdatePlayerScore() //change le score des joueurs
        {
            bool YesGuessCorrect = false;
            foreach (var Player in WaitingRoom.playerlist)
            {
                if (Player.YesGuess == Question.NbYesAnswers)
                {
                    YesGuessCorrect = true;
                    Player.Score += 2;
                }
            }

            while (YesGuessCorrect == false && Question.NbYesAnswers >= 0)
            {
                Question.NbYesAnswers = Question.NbYesAnswers - 1;
                foreach (var Player in WaitingRoom.playerlist)
                {
                    if (Player.YesGuess == Question.NbYesAnswers)
                    {
                        YesGuessCorrect = true;
                        Player.Score++;
                    }
                }
            }
        }
        private void ButtonConfirm_Click(object sender, RoutedEventArgs e) //valide la reponse du joueur
        {
            if (int.TryParse(TextBoxTryGuess.Text, out int NbYesAnswersHost) && NbYesAnswersHost <= WaitingRoom.NbPlayers)
            {
                Random randomnumber = new Random();
                foreach (var Player in WaitingRoom.playerlist)
                {
                    if (Player.Name != WaitingRoom.HostName)
                    {
                        if (randomnumber.Next(2) == 0)
                        {
                            Question.NbYesAnswers++;
                            Player.YesGuess = randomnumber.Next(1, WaitingRoom.NbPlayers + 1);
                        }
                        else
                        {
                            Player.YesGuess = randomnumber.Next(WaitingRoom.NbPlayers);
                        }
                    }
                }
                var host = WaitingRoom.playerlist.Find(x => x.Name == WaitingRoom.HostName);
                host.YesGuess = NbYesAnswersHost;
                UpdatePlayerScore();

                if (Question.QuestionIndex == WaitingRoom.NbRounds)
                {
                    WaitingRoom.InfoSaved = false;
                    WaitingRoom towaitingroom = new WaitingRoom();
                    towaitingroom.Top = this.Top;
                    towaitingroom.Left = this.Left;
                    this.Close();
                    towaitingroom.Show();
                }
                else
                {
                    Question.QuestionIndex++;
                    Question toquestion = new Question();
                    toquestion.Top = this.Top;
                    toquestion.Left = this.Left;
                    this.Close();
                    toquestion.Show();
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("You entered an invalid answer, please try again.", "Warning");
            }
        }
    }
}
