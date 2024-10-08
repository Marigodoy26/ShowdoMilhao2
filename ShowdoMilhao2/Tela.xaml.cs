namespace ShowdoMilhao2;

public partial class Tela : ContentPage
{
    Gerenciador gerenciador;
    public Tela()
    {
        InitializeComponent();
        gerenciador = new Gerenciador(labelPergunta, btResp1, btResp2, btResp3, btResp4, btResp5, labelPontuacao, labelNivel);
    }

    int Pula = 0;

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

    void OnAjudaRetirarClicked(Object S, EventArgs e)
    {
        var ajuda = new RetiraErrada();
        ajuda.ConfiguraDesenho(btResp1, btResp2, btResp3, btResp4, btResp5);
        ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
        (S as Button).IsVisible = false;

    }

    void OnAjudaPulaClicked(object s, EventArgs e)
    {
        if (Pula == 1)
            (s as Button).IsVisible = false;
        else
        {
            gerenciador.ProximaQuestao();
            Pula++;
        }
    }

    void AjudaPulaClicked(object s, EventArgs e)
    {
        if (Pula == 2)
            (s as Button).IsVisible = false;
        else
        {
            gerenciador.ProximaQuestao();
            Pula++;
        }
    }
}