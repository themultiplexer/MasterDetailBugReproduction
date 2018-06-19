using System;
using Xamarin.Forms;
using MasterDetailBugReproduction.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MasterDetailBugReproduction
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
			MainPage = new MasterDetail();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
