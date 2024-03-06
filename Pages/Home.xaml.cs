

using StudentGuide.Pages;

namespace StudentGuide.Pages;

public partial class Home : ContentPage
{ 
public Home()
{

    InitializeComponent();

}
private void ButtonClicked(object sender, EventArgs e)
{
    Navigation.PushAsync(new Popup());
}
}