using System;
using System.Collections.ObjectModel;
using Dolores.Client.Models;
using System.Windows.Input;
using Dolores.Client.Commands;
using Dolores.Client.Messanges;
using GalaSoft.MvvmLight.Messaging;
using Dolores.Bll.Helpers;
using System.Collections.Generic;

namespace Dolores.Client.ViewModels
{
	public class ClientsListViewModel : BaseViewModel
	{
		public ObservableCollection<ClientDto> SearchedClients { get; set; }

		private List<ClientDto> _clients = new List<ClientDto>();

		public SearchParams _searchParams = new SearchParams();

		public ICommand SelectClientCommand => new RelayCommand(SelectClient);

		public ClientsListViewModel()
		{
			_clients = new List<ClientDto>()
			{
				new ClientDto()
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
				},
				new ClientDto()
				{
					FirstName = "Андрій",
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
				},
				new ClientDto()
				{
					FirstName = "Олег",
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
				},
				new ClientDto()
				{
					FirstName = "Марк",
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
				},
				new ClientDto()
				{
					FirstName = "Роман",
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
				},
				new ClientDto()
				{
					FirstName = "Володимир",
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
				},
				new ClientDto()
				{
					FirstName = "Ярослав",
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
				}
			};
			
			
			SearchedClients = new ObservableCollection<ClientDto>();
			foreach (var client in _clients)
			{
				SearchedClients.Add(client);
			}
				
		}

		public void SelectClient(object client)
		{
			var cl = client as ClientDto;
			if(cl != null)
			{
				Messenger.Default.Send(new SelectClientMsg()
				{
					Client = cl
				});
			}
		}
	}
}
