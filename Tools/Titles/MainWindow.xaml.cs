using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Titles
{
    public partial class MainWindow : Window
    {
        public SolidColorBrush _fillColor = new SolidColorBrush(Colors.Yellow);
        private string _title = "Title";

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public SolidColorBrush FillColor
        {
            get
            {
                return _fillColor;
            }
            set
            {
                _fillColor = value;
                OnPropertyChanged(nameof(FillColor));
            }
        }

        public string TitleLabel
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(TitleLabel));
                ShowTitle.Text = _title;
                OnPropertyChanged(nameof(ShowTitle));
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}