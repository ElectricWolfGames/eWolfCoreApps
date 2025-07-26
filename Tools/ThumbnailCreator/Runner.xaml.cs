using System.Windows;

namespace ThumbnailCreator
{
    public partial class Runner : Window
    {
        public Runner()
        {
            InitializeComponent();

            CreateMissingShowData createMissingShowData = new CreateMissingShowData();
            createMissingShowData.Do();

            Close();
        }
    }
}