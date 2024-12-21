namespace LoginApp;

public partial class Login : ContentPage {
    public Login() {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e) {
        try {

            List<User> users = [
                new User("José Maria", "123456"),
                new User("Maria José", "001002"),
                new User("João Rolão", "789000"),
            ];

            User newUser = new(user_text.Text, pass_text.Text);

            if(users.Any(u => newUser.Name == u.Name &&
                newUser.Password == u.Password)) {
                
                await SecureStorage.Default.SetAsync("loggeduser", newUser.Name);
                Application.Current!.Windows[0].Page = new Protected(); 
            } else {
                throw new Exception("Usuário ou Senha incorretos!");
            }

        }
        catch (Exception ex) {
            await DisplayAlert("Login inválido!", ex.Message, "Ok");
        }
    }
}