namespace ShowdoMilhao2;

public partial class Tela : ContentPage
{
	Gerenciador gerenciador;
	public Tela()
	{
		InitializeComponent();
		gerenciador= new Gerenciador (LP, btResp1, btResp2, btResp3, btResp4, btResp5, labelPontuacao, labelNivel);
	}

	  void ButtonA(object sender, EventArgs args)
        {
            gerenciador.VerificarCerta(1);
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