using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TravelApp
{
	public partial class MasterPage : ContentPage
	{

        public ListView ListView { get { return listView; } }

        public MasterPage ()
		{
			InitializeComponent ();
            
            var masterPageItems = new List<NavigationItem>();

            masterPageItems.Add(new NavigationItem
            {
                Title = "Explore",
                IconSource = "explore.png",
                TargetType = typeof(Explore)
            });
            masterPageItems.Add(new NavigationItem
            {
                Title = "Wish List",
                IconSource = "wishlist.png",
                TargetType = typeof(WishList)
            });
            masterPageItems.Add(new NavigationItem
            {
                Title = "Itinerary",
                IconSource = "itinerary.png",
                TargetType = typeof(Itinerary)
            });
            masterPageItems.Add(new NavigationItem
            {
                Title = "Flights",
                IconSource = "flights.png",
                TargetType = typeof(Flights)
            });
            masterPageItems.Add(new NavigationItem
            {
                Title = "Contact",
                IconSource = "contact.png",
                TargetType = typeof(Contact)
            });
            masterPageItems.Add(new NavigationItem
            {
                Title = "Preferences",
                IconSource = "preferences.png",
                TargetType = typeof(Preferences)
            });
            listView.ItemsSource = masterPageItems;
        }
	}
}
