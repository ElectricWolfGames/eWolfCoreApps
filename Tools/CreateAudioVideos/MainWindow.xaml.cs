using CreateAudioVideos.DR;
using CreateAudioVideos.Folder;
using System.IO;
using System;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Documents;
using Microsoft.VisualBasic.Devices;
using CreateAudioVideos.Builders;

namespace CreateAudioVideos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer _player = new MediaPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoCreationData videoCreationData = new VideoCreationData();
            videoCreationData.MP3 = @"E:\Projects\GitHub\eWolfCoreApps\Tools\CreateAudioVideos\DemoData\DemoTack.mp3";
            videoCreationData.Image = @"E:\Projects\GitHub\eWolfCoreApps\Tools\CreateAudioVideos\DemoData\s04e01 Autumn Crocus.png";

            videoCreationData.PreSets();

            VideoCreation videoCreation = new VideoCreation(videoCreationData);
            videoCreation.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            XmemlBuilder xmemlBuilder = new XmemlBuilder();
            xmeml xmeml = xmemlBuilder.CreateDemo();

            SaveExport(xmeml);
        }
        private void SaveExport(xmeml xmeml)
        {


            XmlSerializer serializer = new XmlSerializer(typeof(xmeml));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", ""); // Add an empty namespace with an empty prefix

            using (TextWriter writer = new StreamWriter(@"E:\\Projects\\GitHub\\eWolfCoreApps\\Tools\\CreateAudioVideos\\DemoData\\export.xml"))
            {
                serializer.Serialize(writer, xmeml, ns);
            }
        }
    }
}