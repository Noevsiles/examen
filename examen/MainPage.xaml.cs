using examen.MVVM.Views;

namespace examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //navegacion a la pagina de las mascotas
       private async void NavigateToMascotas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MascotasPage());
        }

        //navegacion a la pagina de la factura
        private async void NavigateToFactura(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacturaPage());
        }
    }

}
