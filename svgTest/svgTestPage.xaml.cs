using Xamarin.Forms;

namespace svgTest
{
    public partial class svgTestPage : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {

            App.Current.MainPage = new ttfTestPage();
        }

        public svgTestPage()
        {
            InitializeComponent();
        }




    }
}
