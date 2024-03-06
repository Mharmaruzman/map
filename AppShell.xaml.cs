

using StudentGuide.Pages;



namespace StudentGuide;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(Home), typeof(Home));
        Routing.RegisterRoute(nameof(Dashboard), typeof(Dashboard));
        Routing.RegisterRoute(nameof(Popup), typeof(Popup));


    }
}
