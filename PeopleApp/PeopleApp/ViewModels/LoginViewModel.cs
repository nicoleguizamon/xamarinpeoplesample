using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using PeopleApp.Views;
using Xamarin.Forms;

namespace PeopleApp.ViewModels
{
	public class LoginViewModel :BaseViewModel, INotifyPropertyChanged
	{
		private string _username;
		private string _password;
		public string Username {
			get { return _username; }
			set
			{
				if (_username != value)
				{
					_username = value;
					LoginCommand.ChangeCanExecute();
				}
			}
		}
		public string Password
		{
			get { return _password; }
			set
			{
				if (_password != value)
				{
					_password = value;
					LoginCommand.ChangeCanExecute();
				}
			}
		}
		public Command LoginCommand { get; }

		private readonly INavigation _navigation;
		public LoginViewModel(INavigation navigation)
		{
			LoginCommand = new Command(LoginExecute, CantLogin);
			_navigation = navigation;
		}

		private void LoginExecute()
		{
			if (_username == "nico" && _password == "mypass")
			{
				_navigation.PushAsync(new MainView());
			}
			
		}
		private bool CantLogin()
		{
			return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
		}
	}
}
