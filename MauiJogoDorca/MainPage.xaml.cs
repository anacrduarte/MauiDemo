
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MauiJogoDorca
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string _highlight;
        private List<char> _letters = new List<char>();
        private string _message;
        private string _statusGame;
        private string _currentImage = "img0.png";
        string answer = "";
        List<char> guess = new List<char>();
        int error = 0;
        int maxError = 6;



        public string Highlight
        {
            get => _highlight;

            set
            {
                _highlight = value;
                OnPropertyChanged();
            }
        }

        public List<char> Letters
        {
            get => _letters;

            set
            {
                _letters = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => _message;

            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public string StatusGame
        {
            get => _statusGame;

            set
            {
                _statusGame = value;
                OnPropertyChanged();
            }
        }

        public string CurrentImage
        {
            get => _currentImage;

            set
            {
                _currentImage = value;
                OnPropertyChanged();
            }
        }

        List<string> words = new List<string>()
        {
            "python",
            "java",
            "csharp",
            "javascript",
            "ruby",
            "tomate",
            "php",
            "swift",
            "go",
            "rust",
            "kotlin",
            "perl",
            "windows",
        };


        public MainPage()
        {
            InitializeComponent();
            Letters.AddRange("abcdefghijklmnopqrstuvwxyz");
            BindingContext = this;
            ChoseWord();
            CalculateWord(answer, guess);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        private  void CalculateWord(string answer,List<char> guess)
        {
            var temp = answer.Select(x=>(guess.IndexOf(x) >= 0 ? x : '_')).ToArray();

            Highlight = string.Join(' ', temp);
        }

        private void ChoseWord()
        {
            answer = words[new Random().Next(words.Count)];
            Debug.WriteLine(answer);
        }

        private void TreatHunch(char leter)
        {
            if(guess.IndexOf(leter) == -1)
            {
                guess.Add(leter);
            }
            if (answer.IndexOf(leter) >= 0)
            {
               CalculateWord(answer, guess);
                SeeIfWin();
            }
            else if(answer.IndexOf(leter) == -1)
            {
                error++;
                UpdateGameStatus();
                SeeIfLost();
                CurrentImage = $"img{error}.png";
            }
        }

        private void UpdateGameStatus()
        {
            StatusGame = $"Erros: {error} de {maxError}";
        }

        private void SeeIfLost()
        {
            if(error == maxError)
            {
                Message = "Perdeu!!!";
                DisableLeters();
            }
        }

        private void DisableLeters()
        {
            foreach(var children in LetterContainer.Children)
            {
                var btn = children as Button;
                if(btn != null)
                {
                    btn.IsEnabled = false;
                }

            }
        }

        private void EnableLeters()
        {
            foreach (var children in LetterContainer.Children)
            {
                var btn = children as Button;
                if (btn != null)
                {
                    btn.IsEnabled = true;
                }

            }
        }

        private void SeeIfWin()
        {
           if(Highlight.Replace(" ", " ")== answer)
            {
                Message = "Ganhou!!!Parabéns!!!";
                DisableLeters();
            }
        }

   

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if(btn != null)
            {
                var leter = btn.Text;
                btn.IsEnabled = false;
                TreatHunch(leter[0]);
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            error = 0;
            guess = new List<char>();
            CurrentImage = "img0.png";
            ChoseWord();
            CalculateWord(answer, guess);
            Message = "";
            UpdateGameStatus();
            EnableLeters();


        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            error = 0;
            guess = new List<char>();
            CurrentImage = "img0.png";
            ChoseWord();
            CalculateWord(answer, guess);
            Message = "";
            UpdateGameStatus();
            EnableLeters();

        }
    }

}
