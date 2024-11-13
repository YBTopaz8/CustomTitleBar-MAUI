namespace Titlee
{
    public partial class App : Application
    {
        public SampleTitle OurWindow { get; }
        public App(SampleTitle ourWindow)
        {
            InitializeComponent();
            OurWindow = ourWindow;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            OurWindow.Page = new AppShell();
            return OurWindow;
        }
    }
}