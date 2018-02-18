using System;
using Dolores.DbAccess.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dolores.DbAccess.Entities
{
	[Table("Clients")]
	public class ClientE : IEntity
	{
		public int Id { get; set; }

		public bool IsActive { get; set; }
		public int Distance { get; set; }
		public string Email { get; set; }

		public string Region { get; set; }
		public string District { get; set; }
		public string Town { get; set; }
		public string Street { get; set; }
		public string Building { get; set; }
		public string Apartment { get; set; }

		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public string MiddleName { get; set; }

		[Column(TypeName = "DateTime")]
		public DateTime LastContactTime { get; set; }
		[Column(TypeName = "DateTime")]
		public DateTime DateOfContract { get; set; }
		[Column(TypeName = "DateTime")]
		public DateTime DateOfContractContinuation { get; set; }

		public string GasSealNumber { get; set; }
		public string EquipmentModel { get; set; }
		public string GasServiceContractNumber { get; set; }
		public string ContractNumber { get; set; }
		public string Description { get; set; }

		//public virtual Equipment Equipment { get; set; }

		public virtual ICollection<EquimpentParamE> Equimpents { get; set; }
		public virtual ICollection<PhoneE> Phones { get; set; }

		public ClientE()
		{
			Equimpents = new List<EquimpentParamE>();
			Phones = new List<PhoneE>(); 
		}


	}
}
