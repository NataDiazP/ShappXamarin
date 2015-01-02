using System;
using Xamarin.Forms;

namespace Shapp
{
    class MainPage : ContentPage
    {
        public MainPage() {
            Button reg = new Button { 
                Text = "registrate",
                BackgroundColor = Color.FromHex("be1e59"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Start,
                BorderRadius = 20,
                WidthRequest = 75
            };

            reg.Clicked += (sender, e) => {
                DisplayAlert("Holi", "Esto es un saludito", "Ok", "Cancel");
            };
            


            Content = new StackLayout
            {
                Spacing = 2,
                VerticalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.White,
                MinimumWidthRequest = 100,
                Children = { 
                    new Label {
                        Text = "Bienvenido a",
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },
                    new Image{
                        Aspect = Aspect.AspectFit,
                        HorizontalOptions = LayoutOptions.Center,
                        Source =  Device.OnPlatform(
                            iOS: ImageSource.FromFile("Images/logo.png"),
                            Android:  ImageSource.FromFile("logo.png"),
                            WinPhone: ImageSource.FromFile("Images/logo.png"))
                    },
                    new Image{
                        Aspect = Aspect.AspectFit,
                        HorizontalOptions = LayoutOptions.Center,
                        Source =  Device.OnPlatform(
                            iOS: ImageSource.FromFile("Images/nombre.png"),
                            Android:  ImageSource.FromFile("nombre.png"),
                            WinPhone: ImageSource.FromFile("Images/nombre.png"))
                    },
                    new Label {
                        Text = "Deseos a tu alcance",
                        TextColor = Color.FromHex("be1e59"),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new StackLayout{
                        VerticalOptions = LayoutOptions.Fill,
                        Spacing = 1,
                        WidthRequest = 5,
                        HorizontalOptions = LayoutOptions.Start,
                        Children = {
                            reg
                        }
                    }
                }
            };
        }
    }
}
