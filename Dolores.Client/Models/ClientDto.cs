using System;
using System.Collections.ObjectModel;
using System.Data.Common;
using Microsoft.VisualBasic;

namespace Dolores.Client.Models
{
	public class ClientDto : BaseModel
	{

		#region Properties
		public int Id { get; set; }

		public bool IsActive { get; set; }

		public bool IsСonflict { get; set; }

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

		public DateTime DateOfContractContinuation { get; set; }

		public string GasSealNumber { get; set; }

		public string GasServiceContractNumber { get; set; }

		public string ContractNumber { get; set; }

		public string Description { get; set; }

		public string EquipmentModel { get; set; }

		#endregion

		public virtual ObservableCollection<EquipmentParamDto> Equimpents { get; set; }
		public virtual ObservableCollection<PhoneDto> Phones { get; set; }

		public ClientDto()
		{
			Equimpents = new ObservableCollection<EquipmentParamDto>();
			Phones = new ObservableCollection<PhoneDto>();
		}


	}
}
