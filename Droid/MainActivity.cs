using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Droid;
using FFImageLoading.Svg.Forms;
using FormsPlugin.Iconize.Droid;

namespace svgTest.Droid
{
    [Activity(Label = "svgTest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            Plugin.Iconize.Iconize.With(new IntegraFont());
            Plugin.Iconize.Iconize.With(new MaterialDesignIconsWebFont());



            CachedImageRenderer.Init();
            var ignore = typeof(SvgCachedImage);
       
           

            LoadApplication(new App());
        }
    }
}
