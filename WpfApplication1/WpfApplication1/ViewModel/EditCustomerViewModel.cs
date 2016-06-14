using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Charts;
using WpfApplication1.Model;
using WpfApplication1.View;

namespace WpfApplication1.ViewModel
{
    [POCOViewModel]
    public class EditCustomerViewModel
    {
        public virtual UICommand CancelCommand { get; set; }

        public virtual  UICommand OkCommand { get; set; }

        public virtual Customer Customer { get; set; }

        public static EditCustomerViewModel Create()
        {
            return ViewModelSource.Create(() => new EditCustomerViewModel());
        }

        public UICommand ShowDialog(IDialogService dialogService, Customer customer)
        {
            if (customer != null) InitData(customer);

            OkCommand = new UICommand()
            {
                Caption = "OK",
                IsCancel = true,
                Command = new DelegateCommand<CancelEventArgs>(
                    x => SaveData(this.Customer),
                    x => ValidData())
            };

            CancelCommand = new UICommand()
            {
                Caption = "Cancel",
                IsCancel = true,
                IsDefault = true,
            };

            return dialogService.ShowDialog(new List<UICommand> {OkCommand, CancelCommand}, "Edit Customer",
                typeof(EditCustomerView).Name, this);
        }

        private bool ValidData()
        {
            if (!string.IsNullOrEmpty(Name) &&
                !string.IsNullOrEmpty(Surname) &&
                DateOfBirth != null &&
                !string.IsNullOrEmpty(Adress) &&
                !string.IsNullOrEmpty(City) &&
                !string.IsNullOrEmpty(PostalCode) &&
                !string.IsNullOrEmpty(PhoneNumber) &&
                !string.IsNullOrEmpty(Email) &&
                Value >= 0)
                return true;
            else
                return false;
        }

        private void SaveData(Customer customer)
        {
            customer.Name = Name;

            customer.Surname = Surname;

            customer.DateOfBirth = DateOfBirth;

            customer.Adress = Adress;

            customer.City = City;

            customer.PostalCode = PostalCode;

            customer.PhoneNumber = PhoneNumber;

            customer.Email = Email;

            customer.Value = Value;
        }

        private void InitData(Customer customer)
        {
            this.Customer = customer;

            Name = customer.Name;

            Surname = customer.Surname;

            DateOfBirth = customer.DateOfBirth;

            Adress = customer.Adress;

            City = customer.City;

            PostalCode = customer.PostalCode;

            PhoneNumber = customer.PhoneNumber;

            Email = customer.Email;

            Value = customer.Value;
        }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual DateTime? DateOfBirth { get; set; }

        public virtual string Adress { get; set; }

        public virtual string City { get; set; }

        public virtual string PostalCode { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual double Value { get; set; }
    }
}
