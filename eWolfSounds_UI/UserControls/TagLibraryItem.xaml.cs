using eWolfSounds_UI.Services;
using System.ComponentModel;
using System.Windows.Controls;

namespace eWolfSounds_UI.UserControls
{
    public partial class TagLibraryItem : UserControl
    {
        private string _tagName = "non";

        public TagLibraryItem()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string TagName
        {
            get
            {
                return _tagName;
            }
            set
            {
                _tagName = value;
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private void Label_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var mainWindow = ServiceLocator.Instance.GetService<MainWindow>();
            mainWindow.SetNewTagOnSelectedItem(TagName);
        }
    }
}