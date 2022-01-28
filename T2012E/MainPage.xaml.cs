using Newtonsoft.Json;
using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FormAccount
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string gender;
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton Gender = sender as RadioButton;
            gender = Gender.Content.ToString();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Validate validate = new Validate();
            int count = 0;
            if (!validate.CheckText(FirstName.Text))
            {
                FirstNameError.Text = "First Name is required!";
                count += 1;
            }
            else FirstNameError.Text = "";
            if (!validate.CheckText(LastName.Text))
            {
                LastNameError.Text = "First Name is required!";
                count += 1;
            }
            else LastNameError.Text = "";
            if (!validate.CheckText(Phone.Text))
            {
                PhoneError.Text = "Phone Number is required!";
                count += 1;
            }
            else if (!validate.CheckNumber(Phone.Text))
            {
                PhoneError.Text = "Invalid Phone Number!";
                count += 1;
            }
            else PhoneError.Text = "";
            if (!validate.CheckText(Address.Text))
            {
                AddressError.Text = "Address is required!";
                count += 1;
            }
            else AddressError.Text = "";
            if (Birthday.Date == null)
            {
                BirthdayError.Text = "Birthday is required!";
                count += 1;
            }
            else BirthdayError.Text = "";
            if (!validate.CheckText(Email.Text))
            {
                EmailError.Text = "Email is required!";
                count += 1;
            }
            else if (!validate.CheckEmail(Email.Text))
            {
                EmailError.Text = "Invalid Email!";
                count += 1;
            }
            else EmailError.Text = "";
            if (!validate.CheckText(Avatar.Text))
            {
                AvatarError.Text = "Avatar is required!";
                count += 1;
            }
            else AvatarError.Text = "";
            if (!validate.CheckText(Password.Password.ToString()))
            {
                PasswordError.Text = "Password is required!";
                count += 1;
            }
            else
            {
                PasswordError.Text = !validate.CheckPassword(Password.Password.ToString()) ? "Password must be longer than 8 characters!" : "";
            }
            if (!validate.CheckText(Introduction.Text))
            {
                IntroductionError.Text = "Introduction is required!";
                count += 1;
            }
            else IntroductionError.Text = "";
            if (count == 0)
            {
                Account account = new Account()
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Phone = Phone.Text,
                    Address = Address.Text,
                    Birthday = Birthday.Date.Value.ToString("yyyy-MM-dd"),
                    Email = Email.Text,
                    Avatar = Avatar.Text,
                    Gender = gender,
                    Password = Password.Password.ToString(),
                    Introduction = Introduction.Text
                };
                var json = JsonConvert.SerializeObject(account);
                Debug.WriteLine(json);
            }
        }
        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            FirstName.Text = "";
            FirstNameError.Text = "";
            LastName.Text = "";
            LastNameError.Text = "";
            Phone.Text = "";
            PhoneError.Text = "";
            Address.Text = "";
            AddressError.Text = "";
            Email.Text = "";
            EmailError.Text = "";
            Avatar.Text = "";
            AvatarError.Text = "";
            Birthday.Date = null;
            BirthdayError.Text = "";
            Male.IsChecked = true;
            Password.Password = "";
            PasswordError.Text = "";
            Introduction.Text = "";
            IntroductionError.Text = "";
        }

        private void TextBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {

        }
    }
}