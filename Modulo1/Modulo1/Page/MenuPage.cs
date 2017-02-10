using Modulo1.Pages.Garcons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace Modulo1.Pages
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Title = "Menu de opções";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
new Button() {
Text = "Garçons",
Image = "icone_garcons.png",
Command = new Command(() => Navigation.PushAsync(new GarconsPage()))
}
}
            };
        }
    }
}