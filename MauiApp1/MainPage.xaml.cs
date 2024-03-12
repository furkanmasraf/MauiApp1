namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Add_Button_Clicked(object sender, EventArgs e)
        {
            float X, Y, Z;

            float.TryParse(XX.Text, out X);
            float.TryParse(YY.Text, out Y);
            Z = X + Y;
            ZZ.Text = Z.ToString();



        }

    }
}
