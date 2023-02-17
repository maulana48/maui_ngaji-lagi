// global using System.Windows.Input;
namespace MyMauiApplication.View;

public partial class BookAppointmentGender : ContentPage
{
    // public ICommand pCommand { get; set; }
    // bool isActive = false;
    string active = "";
    Frame selectedFrame = null;
    Label selectedLabel = null;
    
    void selectPw(object sender, TappedEventArgs args){
        onSelected(fpria_wanita, pria_wanita, "pria_wanita");
    }
    void selectP(object sender, TappedEventArgs args){
        onSelected(fpria, pria, "pria");
    }
    void selectW(object sender, TappedEventArgs args){
        onSelected(fwanita, wanita, "wanita");
    }

    void onSelected(Frame frame, Label label, string selected){
        if(active == ""){
            selectedFrame = frame;
            selectedLabel = label;
            onActive();
            active = selected;
        }
        else if(active != selected){
            onNotActive();
            selectedFrame = frame;
            selectedLabel = label;
            onActive();
            active = selected;
        }
        else{
            onNotActive();
            active = "";
        }
    }

    void onActive()
    {
        selectedFrame.BackgroundColor = Color.FromRgba("#88984A");
        selectedLabel.TextColor = Color.FromRgba("#FFF");
        pria.TextColor = Color.FromRgba("#FFF00F");
        cariustadz.Background = Color.FromRgba("#FFD53F");
        cariustadz.TextColor = Color.FromRgba("#000");
    }
    void onNotActive(){
        selectedFrame.BackgroundColor = Color.FromRgba("#FFF");
        selectedLabel.TextColor = Color.FromRgba("#000");
        cariustadz.Background = Color.FromRgba("#C0C0C0");
        cariustadz.TextColor = Color.FromRgba("#FFF");
    }

    public BookAppointmentGender()
    {  
        InitializeComponent();

        // Create a new Command with a lambda expression
        // pCommand = new Command(() =>
        // {
        //     // Do something when the button is tapped
        //     // For example:
        //     pria.BackgroundColor = Color.FromRgba("#FF00FF");
        //     pria.TextColor = Color.FromRgba("#FF0000");
        //     // DisplayAlert("Button Tapped", "You tapped the button!", "OK");
        // });
    }
}