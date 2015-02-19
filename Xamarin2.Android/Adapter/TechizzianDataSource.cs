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
using TechizzianXamarin2;
using Xamarin2.Android;

namespace TechizzianXamarin2
{
    public class TechizzianDataSource : BaseAdapter<Techizzian>
    {
        Activity context;
        List<Techizzian> techizzianList;

        #region Constructor

        public TechizzianDataSource(Activity c, List<Techizzian> techizzians)
        {
            context = c;
            this.techizzianList = techizzians;
            #region Fetch Images

            var images = new List<Techizzian>() {   new Techizzian{DroidImageUri=Resource.Drawable.RupreetGujral},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.KetanSharma},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.ShagunBawa},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.MohdRiyaz},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.ManishSingh},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.NazarNaqvi},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.AnilSethi},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.HarpreetKaur},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.PardeepTandon},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.GagandeepSingh},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.NainaSharma},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.NehaGupta},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.AmanWalia},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.MeenalSharma},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.BhavnaPruthi},
                                                    new Techizzian{DroidImageUri=Resource.Drawable.Techizzaa}
            };

            #endregion

            int i = 0;
            foreach (var item in images)
            {
                techizzianList[i++].DroidImageUri = item.DroidImageUri;
            }
        }

        #endregion

        #region Get Item ID

        public override long GetItemId(int position)
        {
            return position;
        }

        #endregion

        #region Return Item

        public override Techizzian this[int position]
        {
            get { return techizzianList[position]; }
        }

        #endregion

        #region Count

        public override int Count
        {
            get { return techizzianList.Count; }
        }

        #endregion

        #region Get Item By ID

        public Techizzian GetItemByID(int position)
        {
            return techizzianList[position];
        }

        #endregion

        #region Get View Method

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = techizzianList[position];
            View view = convertView;
            try
            {
                if (view == null)
                    view = context.LayoutInflater.Inflate(Resource.Layout.TechizzianLayout, null);
                view.FindViewById<TextView>(Resource.Id.txtViewName).Text = item.DisplayName;
                view.FindViewById<TextView>(Resource.Id.txtViewTitle).Text = item.Title;
                view.FindViewById<ImageView>(Resource.Id.imgView).SetImageResource(item.DroidImageUri);

            }
            catch (Exception)
            {
                throw;
            }
            return view;
        }

        #endregion
    }
}