namespace ExamenApp.View;

public partial class Rectangulo : ContentPage
{
	public Rectangulo()
	{
		InitializeComponent();
	}

    private void OncalcularClicked(object sender, EventArgs e)
    {
        if (ValidarCampos())
        {

            double v1 = Convert.ToDouble(Txtbase.Text);
            double v2 = Convert.ToDouble(altura.Text);
          


            double resultado = v1 * v2 ;


            resultadoLabel.Text = $"Resultado del area es : {resultado}";
           
        }
    }
    private void OnLimpiarCamposClicked(object sender, EventArgs e)
    {
        Txtbase.Text = "";
        altura.Text = "";
     
        resultadoLabel.Text = "";
    }
    private bool ValidarCampos()
    {
        if (string.IsNullOrWhiteSpace(Txtbase.Text) || string.IsNullOrWhiteSpace(altura.Text))
        {
            resultadoLabel.Text = "Todos los campos son obligatorios.";

            return false;
        }

        return true;
    }


}