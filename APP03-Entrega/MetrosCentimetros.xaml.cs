namespace APP03_Entrega;

public partial class MetrosCentimetros : ContentPage
{
	public MetrosCentimetros()
	{
		InitializeComponent();
	}
	private void ConverterMtparaCentimetros(object sender, EventArgs e)
	{
		if (double.TryParse(etrconverter2.Text, out double valor))
		{
			double resultado = valor * 100;
			etrconverter2.Text = $"{valor} Metros = {resultado} Centimetros";
		}
		else
		{
			etrconverter2.Text = "Insira um valor"; 
		}
	}
}