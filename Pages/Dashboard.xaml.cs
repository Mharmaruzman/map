namespace StudentGuide.Pages;

public partial class Dashboard : ContentPage
{
    double x, y;


    public Dashboard()
    {
        InitializeComponent();

    }
    void ZoomIn_Clicked(object sender, EventArgs e)
    {
        myImage.Scale *= 1.2; // You can adjust the zoom level as needed
    }

    void ZoomOut_Clicked(object sender, EventArgs e)
    {
        myImage.Scale /= 1.2; // You can adjust the zoom level as needed
    }

    void Reset_Clicked(object sender, EventArgs e)
    {
        myImage.Scale = 1.0; // Reset the image scale to its original size
    }

    private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)

        {
            case GestureStatus.Running:
                myImage.TranslationX = x + e.TotalX;
                myImage.TranslationY = y + e.TotalY;
                break;


            case GestureStatus.Completed:
                x = myImage.TranslationX;
                y = myImage.TranslationY;

                break;

        }
    }

}

