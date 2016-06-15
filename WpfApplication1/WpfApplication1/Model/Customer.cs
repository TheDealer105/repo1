using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace WpfApplication1.Model
{
    public class Customer : BindableBase
    {
        public Customer()
        {
        }


        public string Name
        {
            get { return GetProperty(() => Name); }
            set { SetProperty(() => Name, value); }
        }


        public string Surname
        {
            get { return GetProperty(() => Surname); }
            set { SetProperty(() => Surname, value); }
        }


        public DateTime? DateOfBirth
        {
            get { return GetProperty(() => DateOfBirth); }
            set { SetProperty(() => DateOfBirth, value); }
        }


        public string Adress
        {
            get { return GetProperty(() => Adress); }
            set { SetProperty(() => Adress, value); }
        }


        public string City
        {
            get { return GetProperty(() => City); }
            set { SetProperty(() => City, value); }
        }


        public string PostalCode
        {
            get { return GetProperty(() => PostalCode); }
            set { SetProperty(() => PostalCode, value); }
        }


        public string PhoneNumber
        {
            get { return GetProperty(() => PhoneNumber); }
            set { SetProperty(() => PhoneNumber, value); }
        }


        public string Email
        {
            get { return GetProperty(() => Email); }
            set { SetProperty(() => Email, value); }
        }


        public double Value
        {
            get { return GetProperty(() => Value); }
            set { SetProperty(() => Value, value); }
        }
    }
}
