using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.Данные
{
    class Date: INotifyPropertyChanged
    {

        private string _name;
        private string _surname;
        private string _age;
        private string _phone;
        private string _email;
        private bool _isVac;

        public string Name
        {
            get { return _name; }
            set {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get { return _surname; }
            set {
                if (_surname == value)
                    return;
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Age
        {
            get { return _age; }
            set
            {

                if (_age == value)
                    return;
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public string Phone
        {
            get { return _phone; }
            set {

                if (_phone == value)
                    return;
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public string Email
        {
            get { return _email; }
            set {

                if (_email == value)
                    return;
                _email = value;
                OnPropertyChanged("Email");
            }
        }


        public bool Vac
        {
            get { return _isVac; }
            set {
                if (_isVac == value)
                    return;

                _isVac = value;
                OnPropertyChanged("Vac");
            }
        }
  



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
           
        }
        
    }
}
