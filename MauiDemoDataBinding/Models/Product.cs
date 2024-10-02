
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiDemoDataBinding.Models
{
    public class Product:INotifyPropertyChanged
    {
        private string nameP;
        private decimal price;
        private int stock;

        public string NameP
        {
            get => nameP;
            set
            {
                nameP = value;
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        public int Stock
        {
            get => stock;
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName)); 
        }
    }
}
