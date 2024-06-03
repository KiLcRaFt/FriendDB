using FriendDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendDB.Views
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DBListPage : ContentPage
	{
		public DBListPage()
		{
            InitializeComponent();
		}

        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
		private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			Friend SelectedFriend = (Friend)e.SelectedItem;
			DBFriendPage friendPage = new DBFriendPage();
			friendPage.BindingContext = SelectedFriend;
			await Navigation.PushAsync(friendPage);
		}
		private async void CreateFriend(object sender, EventArgs e)
		{
			Friend friend = new Friend();
			DBFriendPage friendPage = new DBFriendPage();
			friendPage.BindingContext = friend;
			await Navigation.PushAsync(friendPage);
		}
    }
}