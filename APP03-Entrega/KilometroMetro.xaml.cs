namespace APP03_Entrega;

public partial class KilometroMetro : ContentPage
{
	public KilometroMetro()
	{
		InitializeComponent();
	}
	private void ConverterKmparaMetros(object sender, EventArgs e)
	{
		if (double.TryParse(etrconverter.Text, out double valor))
		{
			double resultado = valor * 1000;
			etrconverter.Text = $"{valor} Kilometros = {resultado}Metros";
		}
		else
		{
			etrconverter.Text = "Insira um valor";
		}
	}
}