﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using WpfApplication1.Model;
using DevExpress.Mvvm;
using System.Windows;

namespace WpfApplication1.ViewModel
{
    [POCOViewModel]
    public class MainViewModel
    {
        public MainViewModel()
        {
            InitData();
        }

        public static MainViewModel Create()
        {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        protected virtual IDialogService DialogService { get { return null; } }

        public virtual ObservableCollection<Customer> Customers { get; set; }

        public virtual Customer CustomerSelectedItem { get; set; }

        public virtual void Add()
        {
            Customer newCustomer = new Customer();
            EditCustomerViewModel viewModel = EditCustomerViewModel.Create();
            if (viewModel.ShowDialog(DialogService, newCustomer) == viewModel.OkCommand)
            {
                Customers.Add(newCustomer);
            }
        }

        public virtual bool CanAdd()
        {
            return true;
        }

        public virtual void Delete()
        {
            Customers.Remove(CustomerSelectedItem);
        }

        public virtual bool CanDelete()
        {
            if (CustomerSelectedItem != null)
                return true;
            else
                return false;
        }

        public virtual void Modify()
        {
            EditCustomerViewModel viewModel = ViewModelSource.Create(() => new EditCustomerViewModel());
            if (viewModel.ShowDialog(DialogService, CustomerSelectedItem) == viewModel.OkCommand)
            {

            }
        }

        public virtual bool CanModify()
        {
            if (CustomerSelectedItem != null)
                return true;
            else
                return false;
        }

        private void InitData()
        {
            Customers = new ObservableCollection<Customer>()
            {
                new Customer()
                {
                    Name = "Jan",
                    Surname = "Kowalski",
                    Adress = "Wybickiego 16",
                    City = "Warszawa",
                    DateOfBirth = new DateTime(1980, 11, 06),
                    Email = "jan.kowalski@gmail.com",
                    PhoneNumber = "895647482",
                    PostalCode = "02-785",
                    Value = 100
                }
            };
        }
    }
}
