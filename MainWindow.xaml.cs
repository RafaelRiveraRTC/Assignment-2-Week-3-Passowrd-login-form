// Rafael Rivera Harrison
// 4.19.2024
// Programming 122
//Assignment 2 Password login form
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_2_Week_3_Passowrd_login_form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------------------------>
        //These are voids i made accidentally,attempting to remove or comment them out messes with the whole code block so i have elected to keep them here
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------------------->
        private void Sign_Up_Here_Click(object sender, RoutedEventArgs e)
        {
            //String username and password are the name values that represent
            //what ever the user inputs into the respective boxes
            //total info will display both username and password info
            string userName = userNameInfo.Text;

            string password = passwordInfoHere.Password;

            string totalInfo = $"Thank You for signing in.  Username: {userName} Password: {password}";


            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {

                //if the password box or the username is empty,it will display the following message
                MessageBox.Show("I'm sorry this isn't enough info availible,please try again");
                runDisplay.Text = "I'm sorry this isn't enough info availible,please try again";
            }
            else if(userName.Length < 8 || password.Length < 8)
            {
                //if the password bpx or username is below the specified length the following message will display
                MessageBox.Show("This Password or Username is not long enough please try again");
                runDisplay.Text = "This Password or Username is not long enough please try again";
            }
            else
            {
                //if it succeds the first 2 checks the input from the user will display inside the rich text box
                MessageBox.Show($"Thank You for signing in.  Username: {userName} Password: {password}");
                runDisplay.Text = totalInfo;
            }

        }

        private void Sign_In_Here_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}