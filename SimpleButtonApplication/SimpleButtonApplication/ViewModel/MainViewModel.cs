using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;

namespace SimpleButtonApplication.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private bool isClickable = false;
        private string text ="";
        private int counter = 0;

        RelayCommand  clickBtnCommand;
        RelayCommand clickbtnCommand2;

        public int Counter
        {
            get { return counter; }
            set { counter = value; RaisePropertyChanged("Counter"); }
        }


        public string Text
        {
            get { return text; }
            set { text = value; RaisePropertyChanged("Text"); }
        }


        public MainViewModel()
        {
            //ClickBtnCommand = new RelayCommand(new Action(ExecuteClickCount), new Func<bool>(CanExecuteCount));
            ClickBtnCommand = new RelayCommand(ExecuteClickCount, CanExecuteCount);
            ClickbtnCommand2 = new RelayCommand(ExecuteClickCount, CheckTextLength);
            //ClickbtnCommand2 = new RelayCommand(ExecuteClickCount, ()=> { if (Text.Length > 3) { return true; } else { return false; } });
        }

        private bool CheckTextLength()
        {
            if(Text.Length > 3)
            {
                return true;
            }else
            {
                return false;
            }
        }

        private bool CanExecuteCount()
        {
            return IsClickable;
        }

        private void ExecuteClickCount()
        {
            Counter++;
        }

        public bool IsClickable
        {
            get
            {
                return isClickable;
            }

            set
            {
                isClickable = value;
            }
        }

        public RelayCommand ClickBtnCommand
        {
            get
            {
                return clickBtnCommand;
            }

            set
            {
                clickBtnCommand = value;
            }
        }

        public RelayCommand ClickbtnCommand2
        {
            get
            {
                return clickbtnCommand2;
            }

            set
            {
                clickbtnCommand2 = value;
            }
        }
    }
}