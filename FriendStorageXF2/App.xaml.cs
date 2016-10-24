using Prism.Unity;
using Microsoft.Practices.Unity;
using FriendStorageXF2.Views;
using System;
using FriendStorageXF2.DataAccess;

namespace FriendStorageXF2
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();
			NavigationService.NavigateAsync("MainNavigationPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainNavigationPage>();
			Container.RegisterTypeForNavigation<MainPage>();
			Container.RegisterTypeForNavigation<FriendEditPage>();

			Container.RegisterType<IDataService, FriendDataService>();
		}
	}
}

