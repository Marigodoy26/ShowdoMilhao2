namespace ShowdoMilhao2;

public partial class Tela : ContentPage
{
	Gerenciador gerenciador;
	public Tela()
	{
		InitializeComponent();
		gerenciador= new Gerenciador (labelPergunta:, A, B, C, D, E);
	}

	 void ButtonB(object sender, EventArgs args)
        {
            gerenciador.VerificarCerta(2);
        }

		void ButtonC(object sender, EventArgs args)
        {
            gerenciador.VerificarCerta(3);
        }

		void ButtonD(object sender, EventArgs args)
        {
            gerenciador.VerificarCerta(4);
        }

		void ButtonE(object sender, EventArgs args)
        {
            gerenciador.VerificarCerta(5);
        }

}