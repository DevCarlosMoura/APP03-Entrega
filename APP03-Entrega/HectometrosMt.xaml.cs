using Intents;

namespace APP03_Entrega;

public partial class HectometrosMt : ContentPage
{
	public HectometrosMt()
	{
		InitializeComponent();
	}
	private void ConverterHecparaMetros(object sender, EventArgs e)
	{
		if (double.TryParse(etrconverter3.Text, out double valor))
		{
			double resultado = valor * 100;
			etrconverter3.Text = $"{valor}Hectometros = {resultado} Metros";
		}
		else
		{
			etrconverter3.Text = "Insira um valor";
		}
	}
}