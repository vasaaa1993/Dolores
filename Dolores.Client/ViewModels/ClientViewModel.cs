using System;
using System.Collections.ObjectModel;
using Dolores.Client.Models;
using Microsoft.Win32;

namespace Dolores.Client.ViewModels
{
    class ClientViewModel: BaseViewModelcs
	{
	    public ClientDto Client { get; set; }

		public bool IsEditMode { get; set; }

		public ClientViewModel()
		{
			IsEditMode = true;
		    Client = new ClientDto()
		    {
			    FirstName = "Василь",
			    SecondName = "Барна",
			    MiddleName = "Олегович",
			    Region = "Тернопільська",
			    District = "Чортківчький",
			    Town = "Білобожниця",
			    Street = "Шевченка",
			    Building = "5",
			    Apartment = "",

			    Email = "vasaaa1993@gmail.com",
			    LastContactTime = DateTime.Now,
			    DateOfContract = DateTime.Now,
			    GasSealNumber = "134454354",
			    GasServiceContractNumber = "321321321",
			    ContractNumber = "65465465",

			    Description = "Дуже крутий чувак",
				Phones = new ObservableCollection<PhoneDto>()
				{
					new PhoneDto()
					{
						Number = "0932266519"
					},
					new PhoneDto()
					{
						Number = "093226520"
					}
				},
				Equimpents = new ObservableCollection<EquipmentParamDto>()
				{
					new EquipmentParamDto()
					{
						Name = "Інструкція",
					},
					new EquipmentParamDto()
					{
						Name = "Специфікація"
					}
				}
		    };
	    }

		public void AddNewFolderPath()
		{
		}
    }
}
