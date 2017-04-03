using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp.Models
{
	public class Data
	{
		public static IEnumerable<Contact> Get()
		{
			return new List<Contact>()
			{
				new Contact(){ FirstName="Nico", LastName="Leguizamon", Company="Toptal", JobTitle="Engineer", Email="nicoleguizamon@gmail.com", Phone="351-9999999", Street="5th Avenue 1001", City="Cordoba", State="Cordoba", PostalCode="5000", PhotoUrl="http://nicoleguizamon.com.ar/images/nico.png"},
				new Contact(){ FirstName="Luciana", LastName="Falcone", Company="No Convesional", JobTitle="Designer", Email="mlucianafalcone@gmail.com", Phone="351-1111111", Street="5th Avenue 1001", City="Cordoba", State="Cordoba", PostalCode="5000", PhotoUrl="https://pbs.twimg.com/profile_images/789264880981446656/FgdG4cAF.jpg"}
			};
		}
	}
}
