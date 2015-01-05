using System;
using Xamarin.Forms;

namespace Shapp
{
    class MainPage : ContentPage
    {
        public MainPage() {
            Button loginFB = new Button
            {
                Text = "inicia con facebook",
                BackgroundColor = Color.FromHex("3b5998"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.End,
                BorderRadius = 40,
                WidthRequest = 300
            };

            Button reg = new Button
            {
                Text = "regístrate",
                BackgroundColor = Color.FromHex("be1e59"),
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.Start,
                BorderRadius = 40,
                WidthRequest = 300
            };

            Button login = new Button 
            {
                Text = "ya tengo una cuenta",
                BackgroundColor = Color.FromHex("f2f2f2"),
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.End,
                BorderRadius = 40,
                WidthRequest = 300
            };

            loginFB.Clicked += (sender, e) => 
            {
                DisplayAlert("Holi", "Inicia con Facebook", "Ok", "Cancel");
            };

            reg.Clicked += (sender, e) =>
            {
                DisplayAlert("Holi", "Únete al lado oscuro, regístrate.", "Ok", "Cancel");
            };

            login.Clicked += (sender, e) =>
            {
                DisplayAlert("Holi", "Próximamente.", "Ok", "Cancel");
            };

            Content = new StackLayout
            {
                Spacing = 2,
                VerticalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.White,
                Padding = new Thickness(0, 30),
                Children = { 
                    new Label {
                        Text = "Bienvenido a",
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black,
                        Font = Font.SystemFontOfSize(20)
                    },
                    new Image{
                        Aspect = Aspect.AspectFit,
                        HorizontalOptions = LayoutOptions.Center,
                        Source =  Device.OnPlatform(
                            iOS: ImageSource.FromFile("Images/logo.png"),
                            Android:  ImageSource.FromFile("logo.png"),
                            WinPhone: ImageSource.FromFile("Images/logo.png")),
                        WidthRequest = Device.OnPlatform(
                            iOS: 150,
                            Android: 150,
                            WinPhone: 100
                        ),
                        HeightRequest = Device.OnPlatform(
                            iOS: 150,
                            Android: 120,
                            WinPhone: 100
                        )
                    },
                    new Image{
                        Aspect = Aspect.AspectFit,
                        HorizontalOptions = LayoutOptions.Center,
                        Source =  Device.OnPlatform(
                            iOS: ImageSource.FromFile("Images/nombre.png"),
                            Android:  ImageSource.FromFile("nombre.png"),
                            WinPhone: ImageSource.FromFile("Images/nombre.png")),
                        WidthRequest = Device.OnPlatform(
                            iOS: 150,
                            Android: 200,
                            WinPhone: 100
                        ),
                        HeightRequest = Device.OnPlatform(
                            iOS: 150,
                            Android: 100,
                            WinPhone: 100
                        )
                    },
                    new Label {
                        Text = "Deseos a tu alcance",
                        TextColor = Color.FromHex("be1e59"),
                        HorizontalOptions = LayoutOptions.Center,
                        Font = Font.SystemFontOfSize(20)
                    },
                    new StackLayout{
                        VerticalOptions = LayoutOptions.Fill,
                        HorizontalOptions = LayoutOptions.Fill,
                        Padding = new Thickness(0,30),
                        Children = {
                            loginFB, reg, login
                        }
                    }
                }
            };
        }
    }
}
