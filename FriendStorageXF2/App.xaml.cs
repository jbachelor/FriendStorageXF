using Prism.Unity;
using FriendStorageXF2.Views;

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
		}
	}
}

