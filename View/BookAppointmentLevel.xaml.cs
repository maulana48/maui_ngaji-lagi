namespace MyMauiApplication.View;

public partial class BookAppointmentLevel : ContentPage
{
    string active = "";
    Frame selectedFrame = null;
    Label selectedLabel = null;
    
    void selectAwal(object sender, TappedEventArgs args){
        onSelected(fawal, awal, "awal");
    }
    void selectSedikit(object sender, TappedEventArgs args){
        onSelected(fsedikit, sedikit, "sedikit");
    }
    void selectLanjutan(object sender, TappedEventArgs args){
        onSelected(flanjutan, lanjutan, "lanjutan");
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
        gantiLevel.Background = Color.FromRgba("#FFD53F");
        gantiLevel.TextColor = Color.FromRgba("#000");
    }
    void onNotActive(){
        selectedFrame.BackgroundColor = Color.FromRgba("#FFF");
        selectedLabel.TextColor = Color.FromRgba("#000");
        gantiLevel.Background = Color.FromRgba("#C0C0C0");
        gantiLevel.TextColor = Color.FromRgba("#FFF");
    }

    public BookAppointmentLevel()
    {  
        InitializeComponent();
    }
}