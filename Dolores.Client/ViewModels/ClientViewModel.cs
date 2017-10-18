using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
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

		public ICommand AddNewPhoneNumberCommand => new RelayCommandWithoutParam(AddNewPhoneNumber, (obj) => { return !string.IsNullOrEmpty(NewPhoneNumber); });
		public ICommand DeletePhoneCommand => new RelayCommand(DeletePhone);
		public ICommand StartEditingCommand => new RelayCommandWithoutParam(StartEditing);
		public ICommand CancelEditingCommand => new RelayCommandWithoutParam(CancelEditing);
		public ICommand SaveChangesCommand => new RelayCommandWithoutParam(SaveChanges);
		public ICommand OpenClientFolderCommand => new RelayCommandWithoutParam(OpenClientFolder);

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

		public void SelectFolder()
		{
			
		}

		public void OpenClientFolder()
		{
			if (string.IsNullOrEmpty(Client.ContractNumber))
			{
				MessageBox.Show("Перш ніж відкрити папку користувача, вкажіть будь-ласка номер газового рахунку",
					"Ого, чогось не вистачає",
					MessageBoxButton.OK,
					MessageBoxImage.Information);
			}
			else
			{
				var curDir = Directory.GetCurrentDirectory();
				var userFolder = Path.Combine(curDir, Client.ContractNumber);
				if (!Directory.Exists(userFolder))
					Directory.CreateDirectory(userFolder);

				Process.Start(userFolder);
			}
		}
		public void StartEditing()
		{
			IsEditMode = true;
		}

		public void CancelEditing()
		{
			IsEditMode = false;
		}

		public void SaveChanges()
		{
			IsEditMode = false;
		}

		public void AddNewPhoneNumber()
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
