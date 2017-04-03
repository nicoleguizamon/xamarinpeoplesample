using PeopleApp.Models;
using PeopleApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PeopleApp.Views
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailView : ContentPage
	{
		private Contact _contactSelected;
		public DetailViewModel ViewModel { get; }
		public DetailView()
		{
			
		}

		public DetailView(Contact contactSelected)
		{
			_contactSelected = contactSelected;

			InitializeComponent();
			
			BindingContext = ViewModel = new DetailViewModel();

			ViewModel.SetData(contactSelected);

		}
	}

	
}
