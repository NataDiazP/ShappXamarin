using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;
using Android.Graphics;
using System.Threading;
using Android.Graphics.Drawables.Shapes;

namespace Shapp.Droid
{
    [Activity(Label = "Shapp", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);

            SetPage(App.GetMainPage());
        }

        /*public bool OnTouch(View v, MotionEvent e)
        {
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    Thread.Sleep(100);
                    
                    login.SetBackgroundColor(Color.ParseColor("#b6b6b6"));
                    break;
                case MotionEventActions.Up:
                    login.SetBackgroundColor(Color.ParseColor("#f2f2f2"));
                    break;
            }
            return true;
        }*/
    }
}

