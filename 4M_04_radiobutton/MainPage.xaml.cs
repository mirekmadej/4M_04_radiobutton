namespace _4M_04_radiobutton
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            lblWybor.Text = $"Twoj wybór {button.Content}";
        }






    }
}