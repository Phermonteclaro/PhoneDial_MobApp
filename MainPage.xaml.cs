namespace PhoneDial
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnDial(object sender, EventArgs e)
        {
            try
            {
                
                string userInput = PhoneNum.Text;
                
                string phoneNumber = new string(userInput.Where(char.IsDigit).ToArray());

                // Check if the phone number is empty or less than 11 characters
                if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length != 11)
                {
                    await DisplayAlert("Invalid input", "Please enter a valid 11-digit phone number", "OK");
                }

                else
                {
                    
                    await Launcher.OpenAsync($"tel:{phoneNumber}");
                }
            }
            catch (Exception ex)
            {
                
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
