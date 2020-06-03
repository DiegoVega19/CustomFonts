using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;

namespace CustomFonts
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView text1, text2,text3;
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            text1 = FindViewById<TextView>(Resource.Id.textView1);
            text2 = FindViewById<TextView>(Resource.Id.textView2);
            text3 = FindViewById<TextView>(Resource.Id.textView3);
            Typeface tf = Typeface.CreateFromAsset(Assets, "modak.ttf"); //codigo para dar el formato a la letra
            Typeface tf2 = Typeface.CreateFromAsset(Assets, "bwgradual.otf"); //codigo para dar el formato a otra fuenta de letra
            text1.SetTypeface(tf, TypefaceStyle.Italic); //formatear el tipo de letra
            text2.SetTypeface(tf, TypefaceStyle.Normal); //el mismo codigo se usa para darle el formaot a otra letras
            text3.SetTypeface(tf2, TypefaceStyle.Normal);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}