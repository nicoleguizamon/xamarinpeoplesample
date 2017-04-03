using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using PeopleApp.Models;
using PeopleApp.Views;
using Xamarin.Forms;

namespace PeopleApp.ViewModels
{
	public class MainViewModel : BaseViewModel, INotifyPropertyChanged
	{
		public IList<Contact> Contacts { get; set; }

		private Contact _contactSelected;
		public Contact ContactSelected
		{
			get {	return _contactSelected; }
			set
			{
				if (_contactSelected != value)
				{
					_contactSelected = value;
					if (_contactSelected != null)
					{
						_navigation.PushAsync(new DetailView(_contactSelected));
					}
				}
			}
		}

		private INavigation _navigation;

		public MainViewModel(INavigation navigation)
		{
			_navigation = navigation;
			Contacts = new List<Contact>(Data.Get());
			Title = "MayApp";
		}
	}
}
