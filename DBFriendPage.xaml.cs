﻿using FriendDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendDB;

public partial class DBFriendPage : ContentPage
{
	public DBFriendPage()
	{
		InitializeComponent();
	}
	private void SaveFriend(object sender, EventArgs e)
	{
		var friend = (Friend)BindingContext;
		if (!String.IsNullOrEmpty(friend.Name))
		{
			App.Database.SaveItem(friend);
		}
		this.Navigation.PopAsync();
	}
	private void DeleteFriend(object sender , EventArgs e)
	{
		var friend = (Friend)BindingContext;
		App.Database.DeleteItem(friend.Id);
		this.Navigation.PopAsync();
	}
	private void Cancel(object sender , EventArgs e)
	{
		this.Navigation.PopAsync();
	}
}