namespace StudentGuide.Pages;

public partial class Popup : ContentPage
{
    public Popup()
    {
        InitializeComponent();
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Dashboard());
    }
}
