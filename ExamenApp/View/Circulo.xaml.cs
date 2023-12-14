namespace ExamenApp.View;

public partial class Circulo : ContentPage
{
	public Circulo()
	{
		InitializeComponent();
	}


    private void OncalcularClicked(object sender, EventArgs e)
    {
        if (ValidarCampos())
        {

            double v1 = Convert.ToDouble(diametro.Text);



            double resultado =  Math.PI * Math.Pow((double)Convert.ToDecimal(diametro.Text), 2);


            resultadoLabel.Text = $"Resultado del area es: {resultado}";
          
        }
    }
    private void OnLimpiarCamposClicked(object sender, EventArgs e)
    {
        diametro.Text = "";
       
        resultadoLabel.Text = "";
    }
    private bool ValidarCampos()
    {
        if (string.IsNullOrWhiteSpace(diametro.Text) )
        {
            resultadoLabel.Text = "Todos los campos son obligatorios.";

            return false;
        }

        return true;
    }


}