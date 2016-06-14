using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace WpfApplication1.ViewModel
{
    [POCOViewModel]
    public class MainViewModel
    {
        public static MainViewModel Create()
        {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        public virtual int Value { get; set; }

        public virtual void Increment()
        {
            Value += 1;
        }

        public virtual bool CanIncrement()
        {
            return Value < 10 ? true : false;
        }

        public virtual void Decrement()
        {
            Value -= 1;
        }

        public virtual bool CanDecrement()
        {
            return Value > -10 ? true : false;
        }
    }
}
