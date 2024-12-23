using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp4;

public partial class ThirdPage : ContentPage
{
    public ThirdPage()
    {
        InitializeComponent();
    }

    private void CounterBtn_OnClicked(object sender, EventArgs e)
    {
        if (Application.Current != null)
        {
            Application.Current.CloseWindow(Application.Current.Windows[0]);
            Application.Current.OpenWindow(new Window(new NavigationPage(new FourthPage())));
        }
    }
}