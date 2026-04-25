using FilmTagger.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace FilmTagger;

public partial class MainWindow : Window, INotifyPropertyChanged
{
    private FileDetails _fileDetails;

    private string _filmTypes;
    private string _fullfilename;
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
    }

    private void ButtonAction_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Action");
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

    private void Files_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var listBox = sender as ListBox;

        if (listBox?.SelectedItem != null)
        {
            string name = listBox.SelectedItem.ToString();

            int i = 0;
            i++;

            _fileDetails = _readFiles.FileDetails.FirstOrDefault(x => x.Name == name);

            Fullfilename = name;
            FilmTypes = string.Join(", ", _fileDetails.FilmTypes);
        }
    }
}