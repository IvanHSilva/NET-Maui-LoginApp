namespace LoginApp {
    public partial class App : Application {

        bool isLogged = false; 
        
        const int WindowWidth = 400;
        const int WindowHeight = 750;
        const int WindowXPos = 100;
        const int WindowYPos = 100;

        public App() {
            InitializeComponent();

            string? loggedUser = string.Empty;

            Task.Run(async () => {
                loggedUser = await SecureStorage.Default.GetAsync("logged_user");

                if (loggedUser != null) isLogged = true;
            });
        }

        protected override Window CreateWindow(IActivationState? activationState) =>
            new(isLogged ? new Protected() : new Login())
            {
                Width = WindowWidth,
                Height = WindowHeight,
                X = WindowXPos,
                Y = WindowYPos
            };
    }
}