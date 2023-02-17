global using CommunityToolkit.Mvvm.Input;
namespace MyMauiApplication.View.Auth;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    // public RelayCommand LupaPw => return;// new RelayCommand(LupaPw1);
    
    public void LupaPw1(object sender, EventArgs e){
        LoginBtn.Text = "testtttttt";

		SemanticScreenReader.Announce(LoginBtn.Text);

        Shell.Current.GoToAsync(nameof(LupaPwPage));
    }
}