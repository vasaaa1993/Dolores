using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Dolores.Client.ViewModels;

namespace Dolores.Client.Views.Common
{
    /// <summary>
    /// Interaction logic for SelectFolder.xaml
    /// </summary>
    public partial class SelectFolder : Window
    {
		#region Constructo


		public SelectFolder()
		{
			InitializeComponent();
			DataContext = new SelectFolderViewModel();
		}

		#endregion


		private void SelectFolder_OnLoaded(object sender, RoutedEventArgs e)
	    {
		    foreach (var driver in Directory.GetLogicalDrives())
		    {
			    var item = new TreeViewItem()
			    {
				    Header = driver,
				    Tag = driver
			    };
			    item.Items.Add(null);

			    item.Expanded += Folder_Expanded;
				FolderView.Items.Add(item);
		    }
		   
	    }

	    private void Folder_Expanded(object sender, RoutedEventArgs e)
	    {
		    var item = (TreeViewItem) sender;

		    if (item.Items.Count != 1 || item.Items[0] != null) 
		    {
			    return;
		    }

			item.Items.Clear();

			//Get full path
		    var folderPath = (string)item.Tag;

		    var dirs = new List<string>();
		    try
		    {
			    var directories = Directory.GetDirectories(folderPath);
			    if (directories.Length > 0)
				    dirs.AddRange(directories);
			}
		    catch { }

			dirs.ForEach(dirPath =>
			{
				var subItem = new TreeViewItem()
				{
					Header = GetFileFolderName(dirPath),
					Tag = dirPath
				};

				subItem.Items.Add(null);

				subItem.Expanded += Folder_Expanded;

				// add this item to the parent
				item.Items.Add(subItem);
			});

		    var files = new List<string>();
		    try
		    {
			    var fls = Directory.GetFiles(folderPath);
			    if (fls.Length > 0)
				    files.AddRange(fls);
		    }
		    catch { }

		    files.ForEach(filePath =>
		    {
			    if (!IsFileFolderHidden(filePath))
			    {
				    var subItem = new TreeViewItem()
				    {
					    Header = GetFileFolderName(filePath),
					    Tag = filePath
				    };

				    // add this item to the parent
				    item.Items.Add(subItem);
			    }
		    });
		}

	    public static bool IsFileFolderHidden(string path)
	    {
		    return new FileInfo(path).Attributes.HasFlag(FileAttributes.Hidden);
	    }

	    public static string GetFileFolderName(string path)
	    {
		    if (string.IsNullOrEmpty(path))
			    return string.Empty;

		    var normalizePath = path.Replace('/', '\\');

		    var lastIndex = normalizePath.LastIndexOf('\\');

		    if (lastIndex <=0)
		    {
			    return path;
		    }
		    return path.Substring(lastIndex + 1);
	    }
    }
}
