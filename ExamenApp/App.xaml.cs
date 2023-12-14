using TabbedPageSample;

namespace ExamenApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppTabbedPage();
        }
    }
}