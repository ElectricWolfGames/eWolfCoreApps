using System.Windows;

namespace FilmTagger;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Browser.Source = new Uri("https://en.wikipedia.org/wiki/No_Time_for_Sergeants_(film)");
        // E:\_ToWatch\_ToCheck
    }

    private void AddTag(string tagName)
    {
        //
    }

    private void ButtonAction_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Action");
    }

    private void ButtonComedy_Click(object sender, RoutedEventArgs e)
    {
        AddTag("Comedy");
    }
}