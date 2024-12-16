using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace examen.MVVM.ViewModels
{

    //pasos a seguir: el INotify, crear las cosas(el importe, el descuento y el total), el comando para el total y el metodo para el total.
    public class FacturaViewModel : INotifyPropertyChanged
    {
        private double _importe;
        private double _descuento;
        private double _total;

        //para el importe
        public double Importe
        {
            get => _importe;
            set
            {
                if (_importe != value)
                {
                    _importe = value;
                    OnPropertyChanged();
                }
            }
        }

        //para el descuento
        public double Descuento
        {
            get => _descuento;
            set
            {
                if (_descuento != value)
                {
                    _descuento = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Total
        {
            get => _total;
            set
            {
                if (_total != value)
                {
                    _total = value;
                    OnPropertyChanged();
                }
            }
        }

        //comando para calcular el total
        public ICommand CalcularTotalCommand { get; }

        public FacturaViewModel()
        {
            CalcularTotalCommand = new Command(CalcularTotal);
        }

        //metodo para calcular el total, el immporte + el importe por el iva y entre 100, menos el descuento
        public void CalcularTotal()
        {
            Total = (Importe + (Importe * 21) / 100) - Descuento;
        }

        //evento del propertychanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
