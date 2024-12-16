using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace examen.MVVM.Models
{

    //pasos para la clase model: el propertychanged, poner los atributos (nombre, especie, edad y color de fondo)
    //hacer getters y setters y meter el propertyChanged
    public class Mascota : INotifyPropertyChanged
    {
        private string? _nombre;
        private string? _especie;
        private int _edad;
        private Color? _backgroundColor;

        //nombre
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged();
                }
            }
        }
        //especie
        public string Especie
        {
            get => _especie;
            set
            {
                if (_especie != value)
                {
                    _especie = value;
                    OnPropertyChanged();
                }
            }
        }

        //edad
        public int Edad
        {
            get => _edad;
            set
            {
                if (_edad != value)
                {
                    _edad = value;
                    OnPropertyChanged();
                }
            }
        }

        //color del fondo
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                if (_backgroundColor != value)
                {
                    _backgroundColor = value;
                    OnPropertyChanged();
                }
            }
        }

        //evento generado
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
