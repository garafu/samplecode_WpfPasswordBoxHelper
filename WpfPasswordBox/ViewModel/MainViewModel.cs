namespace WpfPasswordBox.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using WpfPasswordBox.Model;
    using WpfPasswordBox.Command;

    public class MainViewModel : INotifyPropertyChanged
    {
        public UserModel User { get; set; }

        public DelegateCommand ExecuteCommand { get; set; }

        public MainViewModel()
        {
            this.User = new UserModel();
            this.ExecuteCommand = new DelegateCommand(this.ExecuteCommand_Executed);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string parameterName = "")
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(parameterName));
            }
        }

        private void ExecuteCommand_Executed(object parameter)
        {
            MessageBox.Show(this.User.Password);
        }
    }
}
