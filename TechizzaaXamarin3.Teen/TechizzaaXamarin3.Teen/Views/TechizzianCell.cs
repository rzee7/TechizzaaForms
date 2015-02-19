using Xamarin.Forms;

namespace TechizzaaXamarin3.Views
{
    /// <summary>
    ///   This class is a ViewCell that will be displayed for each Techizzian.
    /// </summary>
    class TechizzianCell : ViewCell
    {
        #region Constructor

        public TechizzianCell()
        {
            StackLayout nameLayout = CreateNameLayout();
            Image image = CreateTechizzianImageLayout;

            StackLayout viewLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { image, nameLayout }
            };
            View = viewLayout;
        }

        #endregion

        #region Create Techizzian Layout

        /// <summary>
        ///   Create a Xamarin.Forms image and bind it to the ImageUri property.
        /// </summary>
        /// <value>The create Techizzian image layout.</value>
        static Image CreateTechizzianImageLayout
        {
            get
            {
                Image image = new Image
                {
                    HorizontalOptions = LayoutOptions.Start
                };
                image.SetBinding(Image.SourceProperty, new Binding("ImageUri"));
                image.WidthRequest = image.HeightRequest = 40;
                return image;
            }
        }

        #endregion

        #region Create Name Layout
;
        /// <summary>
        ///   Create a layout to hold the Name & Title handle of the user.
        /// </summary>
        /// <returns>The name layout.</returns>
        static StackLayout CreateNameLayout()
        {
            #region Create a Label for name

            Button nameLabel = new Button
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text="Test"
            };

            //nameLabel.SetBinding(Image.SourceProperty, new Binding("ImageUri"));

            #endregion

            #region Create a label for the Twitter handler.

            Label twitterLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Font = Fonts.Twitter
            };
            twitterLabel.SetBinding(Label.TextProperty, "Title");

            #endregion

            #region Adding Controls to Stack Layout

            StackLayout nameLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { nameLabel, twitterLabel }
            };

            #endregion

            return nameLayout;
        }

        #endregion
    }
}
