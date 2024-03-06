using StudentGuide.Pages;

namespace StudentGuide
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Home());
        }
    }
}

