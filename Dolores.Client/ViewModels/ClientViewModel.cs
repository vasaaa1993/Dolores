using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Dolores.Client.Commands;
using Dolores.Client.Models;
using GalaSoft.MvvmLight.Messaging;
using Dolores.Client.Messanges;
using Dolores.DbAccess.Entities;
using Dolores.DbAccess.Interfaces;
using System.Collections.Generic;

namespace Dolores.Client.ViewModels
{
    public class ClientViewModel: BaseViewModel
	{
	    public ClientDto Client { get; set; }

		private ClientDto _tmpClient;

		private List<PhoneDto> _phonesForDelete = new List<PhoneDto>();

		public bool IsEditMode { get; set; }

		public string NewPhoneNumber { get; set; }
		public string NewEquimpentName { get; set; }
		public string NewEquimpentPath { get; set; }

		public ICommand AddNewPhoneNumberCommand => new RelayCommandWithoutParam(AddNewPhoneNumber, (obj) => { return !string.IsNullOrEmpty(NewPhoneNumber); });
		public ICommand DeletePhoneCommand => new RelayCommand(DeletePhone);
		
		public ICommand StartEditingCommand => new RelayCommandWithoutParam(StartEditing);
		public ICommand CancelEditingCommand => new RelayCommandWithoutParam(CancelEditing);
		public ICommand SaveChangesCommand => new RelayCommandWithoutParam(SaveChanges);
		public ICommand OpenClientFolderCommand => new RelayCommandWithoutParam(OpenClientFolder);

		public ICommand SelectFileCommand => new RelayCommandWithoutParam(SelectFile);
		public ICommand AddNewFolderCommand => new RelayCommandWithoutParam(AddNewEquimpent, (obj) => { return !string.IsNullOrEmpty(NewEquimpentName) && !string.IsNullOrEmpty(NewEquimpentPath); });
		public ICommand DeleteEquimpentCommand => new RelayCommand(DeleteEquimpent);
		public ICommand OpenEquimpentFolderCommand => new RelayCommand(OpenEquimpentFolder);

		private readonly IRepository<ClientE> _repository;
		public ClientViewModel()
		{
			IsEditMode = false;

			_repository = _unitOfWork.Repository<ClientE>();

			RegisterMessages();
		}

		private void RegisterMessages()
		{
			Messenger.Default.Register<SelectClientMsg>(this, (msg) =>
			{
				Client = msg.Client;
				if (Client.IsNew == true)
					IsEditMode = true;
			});
		}

		public void AddNewEquimpent()
		{
			Client.Equimpents.Add(new EquipmentParamDto
			{
				Name = NewEquimpentName,
				Path = NewEquimpentPath
			});

			NewEquimpentPath = "";
			NewEquimpentName = "";
		}

		public void DeleteEquimpent(object equimpent)
		{
			var eq = equimpent as EquipmentParamDto;

			var findedEquimpent = Client.Equimpents.FirstOrDefault(e => e.Path == eq.Path || e.Name == eq.Name);

			if (findedEquimpent != null)
			{
				Client.Equimpents.Remove(findedEquimpent);
			}
		}

		public void OpenEquimpentFolder(object equimpent)
		{
			var eq = equimpent as EquipmentParamDto;

			if(!string.IsNullOrEmpty(eq.Path))
			{
				Process.Start(eq.Path);
			}

		}

		public void SelectFile()
		{
			System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
			if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				NewEquimpentPath = dialog.FileName;
			}
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
			_tmpClient = Client.Clone() as ClientDto;
		}

		public void CancelEditing()
		{
			IsEditMode = false;
			Client = _tmpClient; // restore client
		}

		public void SaveChanges()
		{
			IsEditMode = false;
			if(Client.IsNew == true)
			{
				_repository.Add(Client.ToDbModel());
				Messenger.Default.Send(new UpdateClientMsg()
				{
					Client = Client
				});
			}
			else
			{
				var client = Client.ToDbModel();
				_repository.Attach(client);

				//var phoneRepo = _unitOfWork.Repository<PhoneE>();
				//foreach(var p in client.Phones)
				//{
				//	phoneRepo.Attach(p);
				//}
				//foreach (var p in client.Phones)
				//{
				//	client.Phones.Remove(p);
				//}
				//_repositor
				//var phones = client.Phones;
				//var equipment = client.Equimpents;
				

				//_unitOfWork.Save();


				//foreach (var p in _phonesForDelete.Select(p => p.ToDbModel()).Where(p => p.Id != 0))
				//{
				//	phoneRepo.Attach(p);
				//}
		
				//_unitOfWork.Save();
				//_phonesForDelete.Clear();
				//_unitOfWork.Repository<EquimpentParamE>().DeleteRange(equipment.Where(e => e.Id != 0));


				//foreach (var p in phones)
				//	client.Phones.Add(p);

				//foreach (var e in equipment)
				//	client.Equimpents.Add(e);

			}
			_unitOfWork.Save();
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
			_phonesForDelete.Add(findedPhone);

			if (findedPhone != null)
			{
				Client.Phones.Remove(findedPhone);
			}
		}
		
    }
}
