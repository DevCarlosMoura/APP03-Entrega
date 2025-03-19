

namespace APP03_Entrega;

public partial class HectometrosMt : ContentPage
{
    public HectometrosMt()
    {
        InitializeComponent();
    }
    private void ConverterHecparaMetros(object sender, EventArgs e)
    {
        int Hec;

        Hec = int.Parse(etrHec.Text) * 100;
        etrconverter3.Text = Hec.ToString();
    }
    private void ClickOnLimpeza(object sender, EventArgs e)
    {
        etrconverter3.Text = "";
        etrHec.Text = "";
    }
}