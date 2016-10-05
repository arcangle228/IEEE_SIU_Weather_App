using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace IEEE_Weather_App
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var content = new ContentPage
            {
                BackgroundImage = "Lighthouse-Windows---1080-x-1920.png",
                Title = "IEEE Weather App",
                BackgroundColor = Color.Navy,
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Weather App!!!!",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FontAttributes = FontAttributes.Bold
                        },
                        new Label
                        {
                            
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "(UNDER CONSTRUCTION)",
                            FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                            FontAttributes = FontAttributes.Italic
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
