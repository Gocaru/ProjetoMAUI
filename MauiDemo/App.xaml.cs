namespace MauiDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new MinhaPagina());

            navPage.BarBackground = Colors.Yellow;
            navPage.BarTextColor = Colors.Blue;

            return new Window(new AbsoluteLayoutDemo());
        }
    }
}