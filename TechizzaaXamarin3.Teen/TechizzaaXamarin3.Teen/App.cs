using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TechizzaaXamarin3.Teen
{
    public class App
    {
        #region Declarations

        static ObservableCollection<Techizzian> techizzians;

        public static bool IsLoggedIn { get; set; }

        #endregion

        #region Teachizzians Holder

        public static ObservableCollection<Techizzian> Techizzians
        {
            get
            {
                if (techizzians != null)
                {
                    return techizzians;
                }
                var techizzianList = DataProvider.GetTechizzians(); //Fetching data

                int counter = 1;
                techizzians = new ObservableCollection<Techizzian>(techizzianList.OrderBy(e => e.OrderSeq));
                return techizzians;
            }
        }

        #endregion

        public static Page GetMainPage()
        {
            NavigationPage mainNav = new NavigationPage(new TechizzianListPage());
            return mainNav;
        }
    }
}
