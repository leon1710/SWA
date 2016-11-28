using System;
using System.ComponentModel;

namespace CodingDojo3.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnChange(string propertyname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        
    }
}