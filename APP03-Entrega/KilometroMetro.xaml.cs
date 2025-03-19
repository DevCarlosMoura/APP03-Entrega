namespace APP03_Entrega;

public partial class KilometroMetro : ContentPage
{
    public KilometroMetro()
    {
        InitializeComponent();
    }
    private void ConverterKmparaMetros(object sender, EventArgs e)
        {
            int Km;

            Km = int.Parse(etrKm.Text) * 100;
            etrconverter.Text = Km.ToString();
        }
        private void ClickOnLimpeza(object sender, EventArgs e)
        {
            etrconverter.Text = "";
            etrKm.Text = "";
        }
    }