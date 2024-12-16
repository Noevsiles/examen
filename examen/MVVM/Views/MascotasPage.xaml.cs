using examen.MVVM.Models;
using System.Collections.ObjectModel;

namespace examen.MVVM.Views;

public partial class MascotasPage : ContentPage
{

    //hay que crear una observable collection de mascotas
    public ObservableCollection<Mascota> Mascotas { get; set; }

    public MascotasPage()
    {
        InitializeComponent();
        //se inicializa la lista
        Mascotas = new ObservableCollection <Mascota> 
        {
            //se crean las mascotas
                new Mascota { Nombre = "Trasgu", Especie = "Perro", Edad = 3, BackgroundColor = Colors.LightCyan },
                new Mascota { Nombre = "Cala", Especie = "Perro", Edad = 7, BackgroundColor = Colors.LightCyan },
                new Mascota { Nombre = "Barney", Especie = "Perro", Edad = 15, BackgroundColor = Colors.LightCyan },
                new Mascota { Nombre = "Bigotes", Especie = "Gato", Edad = 2, BackgroundColor = Colors.LightYellow },
                new Mascota { Nombre = "Mochi", Especie = "Gato", Edad = 4, BackgroundColor = Colors.LightYellow },
                new Mascota { Nombre = "Ladrillo", Especie = "Gato", Edad = 6, BackgroundColor = Colors.LightYellow }
         };
        
        BindingContext = this;
    }

}



