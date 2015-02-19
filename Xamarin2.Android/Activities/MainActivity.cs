using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin2.Android;

namespace TechizzianXamarin2
{
    [Activity(Label = "Xamarin Two", MainLauncher = true, Icon = "@drawable/Techizzaa")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnSimple = FindViewById<Button> (Resource.Id.SimpleButton);
            Button btnList = FindViewById<Button>(Resource.Id.ListButton);
            Button btnGrid = FindViewById<Button>(Resource.Id.GridButton);

            btnSimple.Click += btnSimple_Click;
            btnList.Click += btnList_Click;
		}


        void btnList_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(TechizzianListPage));
        }

        void btnSimple_Click(object sender, EventArgs e)
        {

        }
	}
}


