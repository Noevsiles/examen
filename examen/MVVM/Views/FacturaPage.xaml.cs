using examen.MVVM.ViewModels;

namespace examen.MVVM.Views;

public partial class FacturaPage : ContentPage
{
        public FacturaPage()
        {
            InitializeComponent();
            BindingContext = new FacturaViewModel(); 
        }
    }
