﻿using System.Windows;
using System.Windows.Input;
using Dolores.Client.ViewModels;

namespace Dolores.Client.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow(MainWindowViewModel mainViewModel)
		{
			InitializeComponent();

			DataContext = mainViewModel;
		}
	}
}
