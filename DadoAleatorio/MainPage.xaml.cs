namespace DadoAleatorio
{
    public partial class MainPage : ContentPage
    {
        int numero = 6;
        
        public MainPage()
        {
            InitializeComponent();
            
        }
        public void Rolar(object sender, EventArgs e)
        {
            int selecaoLados = (int)Nmpckr.SelectedItem;
            Random selecionado = new Random();
            int lados = 0;

            switch (selecaoLados)
            {
                case 4:
                    lados = selecionado.Next(1, 5);
                    break;
                case 6:
                    lados = selecionado.Next(1, 7);
                    break;
                case 8:
                    lados = selecionado.Next(1, 9);
                    break;
                case 10:
                    lados = selecionado.Next(1, 11);
                    break;
                case 20:
                    lados = selecionado.Next(1, 21);
                    break;
                case 100:
                    lados = selecionado.Next(1, 100 + 1);
                    break;
                    
            }
            Numero.Text = lados.ToString();
            DadoImagem.Source = $"lado{Nmpckr.SelectedItem}.png";

        }
    }
}
