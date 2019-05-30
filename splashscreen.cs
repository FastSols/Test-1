using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using System.Threading.Tasks;

namespace App4.Activities
{
    [Activity(Label = "splashscreen", MainLauncher = true ,NoHistory =true)]
    public class splashscreen : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.splashscreen);
            // Create your application here
             System.Threading.Thread.Sleep(500);
            var intent = new Intent(this, typeof(SignInActivity));
            StartActivity(intent);
            

        }
    }
}