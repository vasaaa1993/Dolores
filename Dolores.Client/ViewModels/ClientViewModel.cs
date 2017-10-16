using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Dolores.Client.Commands;
using Dolores.Client.Models;
using Microsoft.Win32;

namespace Dolores.Client.ViewModels
{
    class ClientViewModel: BaseViewModel
	{
	    public ClientDto Client { get; set; }
		public bool IsEditMode { get; set; }
		public string NewPhoneNumber { get; set; }
		public string NewFolderName { get; set; }
		public string NewFolderPath { get; set; }
		public ICommand AddNewPhoneNumberCommand => new RelayCommand(AddNewPhoneNumber, (obj) => { return !string.IsNullOrEmpty(NewPhoneNumber); });
		public ICommand DeletePhoneCommand => new RelayCommand(DeletePhone);

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

		public void AddNewPhoneNumber(object param)
		{
			Client.Phones.Add(new PhoneDto(){ Number = NewPhoneNumber});
			NewPhoneNumber = "";
		}

		public void AddNewFolder(object param)
		{
			
		}

		public void DeletePhone(object phone)
		{
			var ph = phone as string;
			var findedPhone = Client.Phones.FirstOrDefault(p => p.Number == ph);

			if (findedPhone != null)
			{
				Client.Phones.Remove(findedPhone);
			}
		}
		
    }
}
