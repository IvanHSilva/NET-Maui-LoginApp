namespace LoginApp {
    public partial class App : Application {

        string? loggedUser = string.Empty; 
        
        const int WindowWidth = 400;
        const int WindowHeight = 750;
        const int WindowXPos = 100;
        const int WindowYPos = 100;

        public App() {
            InitializeComponent();

            Task.Run(async () => {
                loggedUser = await SecureStorage.Default.GetAsync("logged_user");

                if (loggedUser == null) {
                    Current!.Windows[0].Page = new Login();
                }
                else {
                    Current!.Windows[0].Page = new Protected();
                }
            });
        }

        protected override Window CreateWindow(IActivationState? activationState) =>
            new(loggedUser != null ? new Protected() : new Login())
            {
                Width = WindowWidth,
                Height = WindowHeight,
                X = WindowXPos,
                Y = WindowYPos
            };
    }
}