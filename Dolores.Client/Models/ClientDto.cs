using System;
using System.Collections.ObjectModel;

namespace Dolores.Client.Models
{
	class ClientDto : BaseModel
	{
		#region Private Members

		private int _id;

		private bool _isActive;
		private int _distance;
		private string _email;

		private string _region;
		private string _district;
		private string _town;
		private string _street;
		private string _building;
		private string _apartment;

		private string _firstName;
		private string _secondName;
		private string _middleName;

		private DateTime _lastContactTime;
		private DateTime _dateOfContract;

		private int _gasSealNumber;
		private int _gasServiceContractNumber;
		private int _contractNumber;
		private string _description;
		#endregion

		#region Properties
		public int Id
		{
			get => _id;
			set
			{
				if (value == _id)
					return;
				_id = value;
				OnPropertyChanged();
			}
		}

		public bool IsActive
		{
			get => _isActive;
			set
			{
				if (value == _isActive)
					return;
				_isActive = value;
				OnPropertyChanged();
			}
		}

		public int Distance
		{
			get => _distance;
			set
			{
				if (value == _distance)
					return;
				_distance = value;
				OnPropertyChanged();
			}
		}

		public string Email
		{
			get => _email;
			set
			{
				if (value == _email)
					return;
				_email = value;
				OnPropertyChanged();
			}
		}

		public string Region
		{
			get => _region;
			set
			{
				if (value == _region)
					return;
				_region = value;
				OnPropertyChanged();
			}
		}

		public string District
		{
			get => _district;
			set
			{
				if (value == _district)
					return;
				_district = value;
				OnPropertyChanged();
			}
		}

		public string Town
		{
			get => _town;
			set
			{
				if (value == _town)
					return;
				_town = value;
				OnPropertyChanged();
			}
		}

		public string Street
		{
			get => _street;
			set
			{
				if (value == _street)
					return;
				_street = value;
				OnPropertyChanged();
			}
		}

		public string Building
		{
			get => _building;
			set
			{
				if (value == _building)
					return;
				_building = value;
				OnPropertyChanged();
			}
		}

		public string Apartment
		{
			get => _apartment;
			set
			{
				if (value == _apartment)
					return;
				_apartment = value;
				OnPropertyChanged();
			}
		}

		public string FirstName
		{
			get => _firstName;
			set
			{
				if (value == _firstName)
					return;
				_firstName = value;
				OnPropertyChanged();
			}
		}

		public string SecondName
		{
			get => _secondName;
			set
			{
				if (value == _secondName)
					return;
				_secondName = value;
				OnPropertyChanged();
			}
		}

		public string MiddleName
		{
			get => _middleName;
			set
			{
				if (value == _middleName)
					return;
				_middleName = value;
				OnPropertyChanged();
			}
		}

		public DateTime LastContactTime
		{
			get => _lastContactTime;
			set
			{
				if (value == _lastContactTime)
					return;
				_lastContactTime = value;
				OnPropertyChanged();
			}
		}

		public DateTime DateOfContract
		{
			get => _dateOfContract;
			set
			{
				if (value == _dateOfContract)
					return;
				_dateOfContract = value;
				OnPropertyChanged();
			}
		}

		public int GasSealNumber
		{
			get => _gasSealNumber;
			set
			{
				if (value == _gasSealNumber)
					return;
				_gasSealNumber = value;
				OnPropertyChanged();
			}
		}

		public int GasServiceContractNumber
		{
			get => _gasServiceContractNumber;
			set
			{
				if (value == _gasServiceContractNumber)
					return;
				_gasServiceContractNumber = value;
				OnPropertyChanged();
			}
		}

		public int ContractNumber
		{
			get => _contractNumber;
			set
			{
				if (value == _contractNumber)
					return;
				_contractNumber = value;
				OnPropertyChanged();
			}
		}

		public string Description
		{
			get => _description;
			set
			{
				if (value == _description)
					return;
				_description = value;
				OnPropertyChanged();
			}
		}
		
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
