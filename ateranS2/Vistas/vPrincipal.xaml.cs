namespace ateranS2.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private void btnCalculas_Clicked(object sender, EventArgs e)
    {
        if (pkCiudades.SelectedIndex <0)
        {

            DisplayAlert("Alerta", "Seleccione 1", "Ok");
        }
		else
		{
            var datos = pkCiudades.Items[pkCiudades.SelectedIndex];

            string datos1 = datos.ToString();
            DisplayAlert("Alerta", datos1, "ok");
        }

		


    }
}