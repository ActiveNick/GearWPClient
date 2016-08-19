using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace GearWPClient
{
    [Activity(Label = "WP Client", MainLauncher = true, Icon = "@drawable/Tile_Trans_Windows", Theme = "@android:style/Theme.NoTitleBar")]
    public class StartActivity : Activity
    {
        //int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // PHONE TILE
            ImageButton phoneTile = FindViewById<ImageButton>(Resource.Id.tilePhone);
            phoneTile.Click += delegate
            {
                //var uri = Android.Net.Uri.Parse("tel:");
                //var intent = new Intent(Intent.ActionCallButton);
                Intent intent = PackageManager.GetLaunchIntentForPackage("com.android.browser");
                StartActivity(intent);
            };

            // CAMERA TILE
            ImageButton cameraTile = FindViewById<ImageButton>(Resource.Id.tileCamera);
            cameraTile.Click += delegate
            {
                //var uri = Android.Net.Uri.Parse("tel:");
                //var intent = new Intent(Intent.ActionCallButton);
                Intent intent = PackageManager.GetLaunchIntentForPackage("com.sec.android.app.camera");
                StartActivity(intent);
            };

            // PHOTO GALLERY TILE
            ImageButton photosTile = FindViewById<ImageButton>(Resource.Id.tilePhotos);
            photosTile.Click += delegate
            {
                //var uri = Android.Net.Uri.Parse("tel:");
                //var intent = new Intent(Intent.ActionCallButton);
                Intent intent = PackageManager.GetLaunchIntentForPackage("com.sec.android.gallery3d");
                StartActivity(intent);
            };
        }
    }
}

