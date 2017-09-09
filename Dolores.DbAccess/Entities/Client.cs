using Dolores.DbAccess.Interfaces;
using System;

namespace Dolores.DbAccess.Entities
{
	class Client : IEntity
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

		public DateTime LastContactTime { get; set; }
		public DateTime DateOfContract { get; set; }

		public int GasSealNumber { get; set; }
		public int GasServiceContractNumber { get; set; }
		public int ContractNumber { get; set; }
		public string Description { get; set; }

		public Equipment Equipment { get; set; }

	}
}
