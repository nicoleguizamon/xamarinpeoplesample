using MvvmHelpers;
using PeopleApp.Models;

namespace PeopleApp.ViewModels
{
	public class DetailViewModel: BaseViewModel
	{
		private Contact _contact;
		public Contact Contact { get {
				return _contact;
			} set {
				SetProperty(ref _contact, value);
			} }
		public DetailViewModel()
		{
		}
		public void SetData(Contact contact)
		{
			Contact = contact;
			Title = contact.FullName;
		}
	}
}
