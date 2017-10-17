using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Dolores.Client.Commands;
using Dolores.Client.Models;

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
		public ICommand StartEditingCommand => new RelayCommand(StartEditing);
		public ICommand CancelEditingCommand => new RelayCommand(CancelEditing);
		public ICommand SaveChangesCommand => new RelayCommand(SaveChanges);

		public ClientViewModel()
		{
			IsEditMode = false;
		    Client = new ClientDto()
		    {
				IsActive = false,

			    FirstName = "Василь",
			    SecondName = "Барна",
			    MiddleName = "Олегович",
			    Region = "Тернопільська",
			    District = "Чортківчький",
			    Town = "Білобожниця",
			    Street = "Шевченка",
			    Building = "5",
			    Apartment = "0",

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

		

		public void AddNewFolder()
		{
			
		}

		public void StartEditing(object param)
		{
			IsEditMode = true;
		}

		public void CancelEditing(object param)
		{
			IsEditMode = false;
		}

		public void SaveChanges(object param)
		{
			IsEditMode = false;
		}

		public void AddNewPhoneNumber(object param)
		{
			Client.Phones.Add(new PhoneDto() { Number = NewPhoneNumber });
			NewPhoneNumber = "";
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
