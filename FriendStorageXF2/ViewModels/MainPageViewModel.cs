using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using FriendStorageXF2.DataAccess;
using FriendStorageXF2.Model;
using System.Collections.ObjectModel;

namespace FriendStorageXF2.ViewModels
{
	public class MainPageViewModel : BindableBase, INavigationAware
	{
		public MainPageViewModel(IDataService dataService)
		{
			_dataService = dataService;
			ReloadFriends();
		}

		IDataService _dataService;

		#region Properties

		string _title = string.Empty;
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		ObservableCollection<Friend> _friends = new ObservableCollection<Friend>();
		public ObservableCollection<Friend> Friends
		{
			get { return _friends; }
			set { SetProperty(ref _friends, value); }
		}

		#endregion Properties

		#region INavigationAware

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			Debug.WriteLine($"{nameof(MainPageViewModel)}.OnNavigatedFrom");
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			Debug.WriteLine($"{nameof(MainPageViewModel)}.OnNavigatedTo");
		}

		#endregion INavigationAware

		void ReloadFriends()
		{
			Debug.WriteLine($"{nameof(MainPageViewModel)}.ReloadFriends");
			Friends = _dataService.GetAllFriends() as ObservableCollection<Friend>;
		}
	}
}

