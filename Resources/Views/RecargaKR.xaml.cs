namespace KevinRosero_Examen2P.Views;
using Syncfusion.Maui.Core.Hosting;
using Syncfusion.Maui.ListView.Hosting;

public partial class RecargaKR : ContentPage
{

	public RecargaKR()
	{
		InitializeComponent();
    }

	private  async void btn_recargarKR(object sender, EventArgs e)
	{
        string respuesta = await DisplayActionSheet("Confirmacion", "Si", "No", "¿Desea Recargar?");

        if (respuesta.Equals("Si"))
		{
            await DisplayAlert("Finalizado", "Recarga Exitosa", "Ok");
        }
    }

    private void OnRadioButtonCheckedChanged3KR(object sender, CheckedChangedEventArgs e)
    {
        string valor;
    }

    private void OnRadioButtonCheckedChanged5KR(object sender, CheckedChangedEventArgs e)
    {

    }

    private void OnRadioButtonCheckedChanged10KR(object sender, CheckedChangedEventArgs e)
    {

    }
}