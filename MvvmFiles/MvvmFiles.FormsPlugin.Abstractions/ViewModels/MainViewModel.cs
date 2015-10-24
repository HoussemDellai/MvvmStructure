using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmFiles.Models;
using MvvmFiles.Services;

namespace MvvmFiles.ViewModels
{
    /// <summary>
    /// The main ViewModel that will be bound to MainView page.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Employee> _employees;

        public List<Employee> Employees
        {
            get { return _employees; }
            set {
                _employees = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            DownloadData();
        }

        private void DownloadData()
        {
            var employeesServices = new EmployeesServices();

            Employees = employeesServices.GetEmployees();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
