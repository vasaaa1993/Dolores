using Dolores.DbAccess.Entities;
using System;
using System.Collections.ObjectModel;

namespace Dolores.Client.Models
{
	public class ClientDto : BaseModel, ICloneable
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

		public bool IsNew { get; set; }
		#endregion

		public virtual ObservableCollection<EquipmentParamDto> Equimpents { get; set; }
		public virtual ObservableCollection<PhoneDto> Phones { get; set; }

		public ClientDto()
		{
			LastContactTime = DateOfContract = DateOfContractContinuation = DateTime.Now;
			Equimpents = new ObservableCollection<EquipmentParamDto>();
			Phones = new ObservableCollection<PhoneDto>();
		}

		public object Clone()
		{
			ClientDto client = (ClientDto)MemberwiseClone();
			client.Equimpents = new ObservableCollection<EquipmentParamDto>();
			client.Phones = new ObservableCollection<PhoneDto>();
			foreach (var eq in Equimpents)
			{
				client.Equimpents.Add(eq.Clone() as EquipmentParamDto);
			}

			foreach(var phone in Phones)
			{
				client.Phones.Add(phone.Clone() as PhoneDto);
			}

			return client;
		}
	}

	public static class ClientExtentions
	{
		public static ClientE ToDbModel(this ClientDto client)
		{
			if (client == null)
				return null;
			var cl = new ClientE()
			{
				Apartment = client.Apartment,
				Building = client.Building,
				ContractNumber = client.ContractNumber,
				DateOfContract = client.DateOfContract,
				Description = client.Description,
				Distance = client.Distance,
				District = client.District,
				Email = client.Email,
				FirstName = client.FirstName,
				GasSealNumber = client.GasSealNumber,
				GasServiceContractNumber = client.GasServiceContractNumber,
				Id = client.Id,
				IsActive = client.IsActive,
				LastContactTime = client.LastContactTime,
				MiddleName = client.MiddleName,
				Region = client.Region,
				SecondName = client.SecondName,
				Street = client.Street,
				Town = client.Town,
				DateOfContractContinuation = client.DateOfContractContinuation,
				EquipmentModel  =client.EquipmentModel,
			};
			foreach (PhoneDto p in client.Phones)
				cl.Phones.Add(p.ToDbModel());
			foreach (EquipmentParamDto e in client.Equimpents)
				cl.Equimpents.Add(e.ToDbModel());

			return cl;
			
		}
		public static ClientDto ToDto(this ClientE client)
		{
			if (client == null)
				return null;
			var cl = new ClientDto()
			{
				Apartment = client.Apartment,
				Building = client.Building,
				ContractNumber = client.ContractNumber,
				DateOfContract = client.DateOfContract,
				Description = client.Description,
				Distance = client.Distance,
				District = client.District,
				Email = client.Email,
				FirstName = client.FirstName,
				GasSealNumber = client.GasSealNumber,
				GasServiceContractNumber = client.GasServiceContractNumber,
				Id = client.Id,
				IsActive = client.IsActive,
				LastContactTime = client.LastContactTime,
				MiddleName = client.MiddleName,
				Region = client.Region,
				SecondName = client.SecondName,
				Street = client.Street,
				Town = client.Town,
				DateOfContractContinuation = client.DateOfContractContinuation,
				EquipmentModel = client.EquipmentModel
			};
			foreach (PhoneE p in client.Phones)
				cl.Phones.Add(p.ToModel());
			foreach (EquimpentParamE e in client.Equimpents)
				cl.Equimpents.Add(e.ToModel());

			return cl;
		}
	}
}
