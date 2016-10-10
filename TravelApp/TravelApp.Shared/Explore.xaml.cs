using Esri.ArcGISRuntime.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp
{
    public partial class Explore : ContentPage
    {

        // String array to hold urls to publicly available web maps
        private string[] itemURLs = new string[]
        {
            "http://www.arcgis.com/home/item.html?id=2d6fa24b357d427f9c737774e7b0f977",
            "http://www.arcgis.com/home/item.html?id=01f052c8995e4b9e889d73c3e210ebe3",
            "http://www.arcgis.com/home/item.html?id=74a8f6645ab44c4f82d537f1aa0e375d"
        };

        // String array to store titles for the webmaps specified above. These titles are in the same order as the urls above
        private string[] titles = new string[]
        {
            "Housing with Mortgages",
            "USA Tapestry Segmentation",
            "Geology of United States"
        };

        public Explore()
        {
            InitializeComponent();
                   MapView
            Title = "Display a map";

            // Create the UI, setup the control references and execute initialization 
            Initialize();
        }


        /// <summary>
        /// Gets the Map rendered in the MapView
        /// </summary>
        private void Initialize()
        {

            Map myMap = new Map(new Uri(itemURLs[0]));
            MyMapView.Map = myMap;
            // Assign the map to the MapView
            //MyMapV = myMap;
        }


        private async void OnMapsClicked(object sender, EventArgs e)
        {
            // Show sheet and get title from the selection
            var selectedMapTitle =
                await DisplayActionSheet("Select map", "Cancel", null, titles);

            // If selected cancel do nothing
            if (selectedMapTitle == "Cancel") return;

            // Get index that is used to get the selected url
            var selectedIndex = titles.ToList().IndexOf(selectedMapTitle);

            // Create a new Map instance with url of the webmap that selected
            MyMapView.Map = new Map(new Uri(itemURLs[selectedIndex]));
        }
    }

}
