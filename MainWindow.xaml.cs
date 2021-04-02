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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static SortyBoy.FileIO;

namespace SortyBoy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileIO FileObj;
        public MainWindow()
        {
            InitializeComponent();
            FileObj = new FileIO();
        }

        private void Import_Source(object sender, RoutedEventArgs e)
        {
            // Open a file window to find and select the folder to import
            // Grab a list of the files in the folder and pass them to the textblock to display the names
            // Hold onto the path of the files
            // Grab the number of files imported and pass the number to the # textblock
            // Grab the extenstion and pass it to the extension textblock
        }

        private void Export_Destination(object sender, RoutedEventArgs e)
        {
            // Open the file window to find the path where the folder and the items are going to be transfered too
        }

        private void Convert(object sender, RoutedEventArgs e)
        {
            // Create a folder based on the name provided
            // Rename the files based on the name provided
            // Copy the files over to the destination
            // Populate the exported textblock
        }

        private void Name_Entered(object sender, TextChangedEventArgs e)
        {
            FileObj.File_Name = File_Name_Input.Text.ToString();
            Import.Text = FileObj.File_Name.ToString();
        }
    }
}
