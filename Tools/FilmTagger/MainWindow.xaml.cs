using FilmTagger.IO;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FilmTagger;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private FileDetails _fileDetails;

    private string _filmTypes;
    private string _fullfilename;
    private bool _modifed = false;
    private string _peopleNames;
    private ReadFiles _readFiles;
    private string _titleOnly;

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;

        Browser.Source = new Uri("https://en.wikipedia.org/wiki/No_Time_for_Sergeants_(film)");

        _readFiles = new("E:\\_ToWatch\\_ToCheck\\");

        foreach (var items in _readFiles.FileDetails)
        {
            Files.Items.Add(items.Name);
        }

        Browser.CoreWebView2InitializationCompleted += (s, e) =>
        {
            if (e.IsSuccess)
            {
                Browser.CoreWebView2.NewWindowRequested += (sender, args) =>
                {
                    Browser.CoreWebView2.Navigate(args.Uri);
                    args.Handled = true;
                };
            }
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public string FilmTypes
    {
        get { return _filmTypes; }
        set
        {
            _filmTypes = value;
            OnPropertyChanged();
        }
    }

    public string Fullfilename
    {
        get { return _fullfilename; }
        set
        {
            _fullfilename = value;
            OnPropertyChanged();
        }
    }

    public string PeopleNames
    {
        get { return _peopleNames; }
        set
        {
            _peopleNames = value;
            OnPropertyChanged();
        }
    }

    public string TitleOnly
    {
        get { return _titleOnly; }
        set
        {
            _titleOnly = value;
            OnPropertyChanged();
        }
    }

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void AddTag(string tagName)
    {
        FilmTypes += tagName + ", ";
        _modifed = true;
    }

    private void ButtonAction_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Action");
    }

    private void ButtonClear_Click(object sender, RoutedEventArgs e)
    {
        FilmTypes = string.Empty;
        _modifed = true;
    }

    private void ButtonComedy_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Comedy");
    }

    private void ButtonCrime_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Crime");
    }

    private void ButtonSciFi_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Sci-fi");
    }

    private void ButtonSearch_Click(object sender, RoutedEventArgs e)
    {
        string url = $"https://www.bing.com/search?q={Uri.EscapeDataString(Fullfilename)}";
        Browser.Source = new Uri(url);
    }

    private void ButtonWar_Click(object sender, RoutedEventArgs e)
    {
        AddTag("War");
    }

    private void Files_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var listBox = sender as ListBox;

        if (listBox?.SelectedItem != null)
        {
            if (_fileDetails != null && _modifed)
            {
                _fileDetails.Save();

                // Save name
            }

            string name = listBox.SelectedItem.ToString();
            _fileDetails = _readFiles.FileDetails.FirstOrDefault(x => x.Name == name);

            Fullfilename = name;
            FilmTypes = string.Join(", ", _fileDetails.FilmTypes);
            _modifed = false;
        }
    }
}