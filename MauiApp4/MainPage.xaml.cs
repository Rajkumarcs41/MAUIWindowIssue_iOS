namespace MauiApp4;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (Application.Current != null)
        {
            Application.Current.CloseWindow(Application.Current.Windows[0]);
            Application.Current.OpenWindow(new Window(new NavigationPage(new SecondPage())));
        }
    }
}