using System.ComponentModel;

namespace Dolores.Client.ViewModels
{
    class BaseViewModelcs: INotifyPropertyChanging
    {
	    public event PropertyChangingEventHandler PropertyChanging;
    }
}
