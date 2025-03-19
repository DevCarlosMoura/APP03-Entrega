namespace APP03_Entrega;

public partial class MetrosCentimetros : ContentPage
{
    public MetrosCentimetros()
    {
        InitializeComponent();
    }
    private void ConverterMtparaCentimetros(object sender, EventArgs e)
        {
            int Mt;

            Mt = int.Parse(etrMt.Text) * 100;
            etrconverter2.Text = Mt.ToString();
        }
        private void ClickOnLimpeza(object sender, EventArgs e)
        {
            etrconverter2.Text = "";
            etrMt.Text = "";
        }
    }