namespace LoginApp {
    public partial class App : Application {
        const int WindowWidth = 400;
        const int WindowHeight = 750;
        const int WindowXPos = 100;
        const int WindowYPos = 100;

        public App() {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState) =>
            new(new AppShell()) {
                Width = WindowWidth,
                Height = WindowHeight,
                X = WindowXPos,
                Y = WindowYPos
            };
    }
}