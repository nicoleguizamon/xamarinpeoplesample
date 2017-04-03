using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PeopleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PeopleApp.Views
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView()
		{
			InitializeComponent();
			BindingContext = new LoginViewModel(Navigation);

			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}
