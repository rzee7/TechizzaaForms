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
using Xamarin2.Android;

namespace TechizzianXamarin2
{
    [Activity(Label = "Techizzian List", Icon="@drawable/Techizzaa")]
    public class TechizzianListPage : Activity
    {
        List<Techizzian> techizzianList = DataProvider.GetTechizzians();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.TechizzianListPage);

            ListView lstView = FindViewById<ListView>(Resource.Id.techizzianListView);
            lstView.Adapter = new TechizzianDataSource(this, techizzianList);
        }
    }
}