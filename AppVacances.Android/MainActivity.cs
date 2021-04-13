using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

using System.IO;
using System.Threading.Tasks;
using Android.Content;
using Xamarin.Forms;

namespace AppVacances.Droid
{
    [Activity(Label = "AppVacances", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        internal static MainActivity Instance { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Instance = this;
        }

        public static readonly int PickImageId = 1000; //propriété, méthode et champ pr le picker
        public TaskCompletionSource<Stream> PickImageTaskCompletionSource { get; set; }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent intent)
        {
            base.OnActivityResult(requestCode, resultCode, intent);

            if(requestCode == PickImageId)
            {
                if((resultCode == Result.Ok) && (intent != null))
                {
                    Android.Net.Uri uri = intent.Data;
                    Stream stream = ContentResolver.OpenInputStream(uri);

                    PickImageTaskCompletionSource.SetResult(stream);
                }
                else
                {
                    PickImageTaskCompletionSource.SetResult(null);
                }
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}