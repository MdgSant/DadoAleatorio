namespace DadoAleatorio
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void Rolar(object sender, EventArgs e)
        {
            int selecaoLados = Convert.ToInt32(Nmpckr.SelectedItem);
            Random selecionado = new Random();
            int lados = selecionado.Next(1, selecaoLados + 1);
            
            Numerolbl.Text = lados.ToString();
            DadoImagem.Source = $"lado{Nmpckr.SelectedItem}.png";

        }
    }

}
