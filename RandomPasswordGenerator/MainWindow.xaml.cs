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

namespace RandomPasswordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>]

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GeneratePassWord(object sender, RoutedEventArgs e)
        {
            int numberofletters;
            if (int.TryParse(NumberOfLettersTextBox.Text, out numberofletters))
            {
                string characters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

                if (SpecialCharactersCheckBox.IsChecked == true)
                {
                    characters += "~`!@#$%^&*()-_=+{}[]|/:;<>,.?";
                }

                if (NumbersCheckBox.IsChecked == true)
                {
                    characters += "0123456789";
                }

                //Create a string where the random password will be created
                string password = "";
                //Create a Random object to select random characters from the characters string
                Random rand = new Random();

                //Add random characters to the password string
                for (int x = 0; x < numberofletters; x++)
                {
                    password += characters[rand.Next(0, characters.Length)];
                }

                //Display the password that we just generated
                PasswordTextBox.Text = password;
            }
        }
    }
}