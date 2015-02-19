using System.Collections.ObjectModel;

using Xamarin.Forms;

using TechizzaaXamarin3;
using System.Threading.Tasks;
using System;
using TechizzaaXamarin3.Views;
using TechizzaaXamarin3.Teen;

namespace TechizzaaXamarin3
{
    /// <summary>
    ///   This page will display a list of Techizzians.
    /// </summary>
    class TechizzianListPage : ContentPage
    {
        #region Private Declaration

        ListView techizzianList;
        ObservableCollection<Techizzian> techizzians = new ObservableCollection<Techizzian>();
        ToolbarItem _loginToolbarButton;

        #endregion

        #region Constructor

        public TechizzianListPage()
        {
            LoadTechizzianForDisplay();
            Title = "Techizzian List";

            CreateLoginToolbarButton();
            CreateTechizzianListView();

            Content = techizzianList;
        }

        #endregion

        #region Creaeting Login Bar

        void CreateLoginToolbarButton()
        {
            if (_loginToolbarButton != null)
            {
                return;
            }

            // There is a bug with Android which prevents the use of null for the iconName.
            string iconName = Device.OnPlatform(null, "ic_action_content_new.png", null);
            _loginToolbarButton = new ToolbarItem("Login", iconName, async () =>
            {
                ToolbarItems.Remove(_loginToolbarButton);
               
                await Navigation.PushAsync(new LoginPage());
            });
        }

        #endregion

        #region Load Techizzian

        void LoadTechizzianForDisplay()
        {
            if (App.IsLoggedIn)
            {
                if (techizzians.Count == 0)
                {
                    techizzians = App.Techizzians;
                }
            }
        }

        #endregion

        #region Creating Techizzian List View

        void CreateTechizzianListView()
        {
            techizzianList = new ListView
            {
                RowHeight = 50,
                ItemTemplate = new DataTemplate(typeof(TechizzianCell))
            };
            techizzianList.ItemSelected += TechizzianListOnItemSelected;
        }

        #endregion

        #region ListView Item Click

        /// <summary>
        ///   This method is invoked when the user selects Techizzians. Will open up the TechizzianDetailsPage for that Techizzian.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="eventArg">Event argument.</param>
        async void TechizzianListOnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listView = (ListView)sender;
            if (listView.SelectedItem == null)
            {
                return;
            }

            await Navigation.PushAsync(new TechizzianDetailPage((Techizzian)e.SelectedItem));
            listView.SelectedItem = null;
        }

        #endregion

        #region OnAppearing Method

        protected override void OnAppearing()
        {
            // This method is invoked by Xamarin.Forms at some point when the 
            // page is being displayed.
            base.OnAppearing();
            LoadTechizzianForDisplay();
            techizzianList.ItemsSource = techizzians;

            if (App.IsLoggedIn)
            {
                // Don't have to do anything. 
            }
            else
            {
                ToolbarItems.Add(_loginToolbarButton);
            }
        }

        #endregion
    }
}
