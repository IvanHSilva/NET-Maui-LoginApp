namespace LoginApp;

public partial class Protected : ContentPage
{
	public Protected()
	{
		InitializeComponent();

		string? loggedUser = string.Empty;

		Task.Run(async () => {
			loggedUser = await SecureStorage.Default.GetAsync("logged_user");
			welcome_label.Text = $"Bem-vindo(a) {loggedUser}";
		});
	}

	private async void Button_Clicked(object sender, EventArgs e) {

		bool confirmation = await DisplayAlert("Deseja mesmo sair?", "Logout",
			"Sim", "Não");

		if (confirmation) {
			SecureStorage.Default.Remove("logged_user");
			Application.Current!.Windows[0].Page = new Login();
		}
	}
}