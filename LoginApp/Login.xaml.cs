namespace LoginApp;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e) {
		try {

		} catch(Exception ex) {
			DisplayAlert("Ops", ex.Message, "Ok");
		}
    }
}