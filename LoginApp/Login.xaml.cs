namespace LoginApp;

public partial class Login : ContentPage {
    public Login() {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e) {
        try {

            List<User> users = [
                new User("Jos� Maria", "123456"),
                new User("Maria Jos�", "001002"),
                new User("Jo�o Rol�o", "789000"),
            ];

            User newUser = new(user_text.Text, pass_text.Text);

            if(users.Any(u => newUser.Name == u.Name &&
                newUser.Password == u.Password)) {
                
                await SecureStorage.Default.SetAsync("loggeduser", newUser.Name);
                Application.Current!.Windows[0].Page = new Protected(); 
            } else {
                throw new Exception("Usu�rio ou Senha incorretos!");
            }

        }
        catch (Exception ex) {
            await DisplayAlert("Login inv�lido!", ex.Message, "Ok");
        }
    }
}