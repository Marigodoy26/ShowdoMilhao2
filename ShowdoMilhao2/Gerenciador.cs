namespace ShowdoMilhao2;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRepondidas = new List<int>();
    Questao QuestaoCorrente;
    public int Pontuação {get; private set;}
    int NivelAtual=0;
    Label labelPontuacao;
    Label labelNivel;

    public Gerenciador(Label labelPergunta, Button BtnResp1, Button BtnResp2, Button BtnResp3, Button BtnResp4, Button BtnResp5, Label labelPontuacao, Label labelNivel)
    {
        CriarPergunta(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        this.labelPontuacao=labelPontuacao;
        this.labelNivel=labelNivel;
    }


    void CriarPergunta(Label labelPergunta, Button BtnResp1, Button BtnResp2, Button BtnResp3, Button BtnResp4, Button BtnResp5)
    {
        var Q1 = new Questao();
        Q1.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q1.Pergunta = "Quanto é 2+2?";
        Q1.Resposta01 = "2";
        Q1.Resposta02 = "22";
        Q1.Resposta03 = "4";
        Q1.Resposta04 = "sim";
        Q1.Resposta05 = "1";
        Q1.RespostaCerta = 3;
        ListaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q2.Pergunta = "Quanto é 3+2?";
        Q2.Resposta01 = "2";
        Q2.Resposta02 = "32";
        Q2.Resposta03 = "5";
        Q2.Resposta04 = "sim";
        Q2.Resposta05 = "10";
        Q2.RespostaCerta = 3;
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q3.Pergunta = "Quanto é 2+2?";
        Q3.Resposta01 = "2";
        Q3.Resposta02 = "22";
        Q3.Resposta03 = "4";
        Q3.Resposta04 = "sim";
        Q3.Resposta05 = "1";
        Q3.RespostaCerta = 3;
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q4.Pergunta = "Quanto é 3+2?";
        Q4.Resposta01 = "2";
        Q4.Resposta02 = "32";
        Q4.Resposta03 = "5";
        Q4.Resposta04 = "sim";
        Q4.Resposta05 = "10";
        Q4.RespostaCerta = 3;
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q5.Pergunta = "Quanto é 2+2?";
        Q5.Resposta01 = "2";
        Q5.Resposta02 = "22";
        Q5.Resposta03 = "4";
        Q5.Resposta04 = "sim";
        Q5.Resposta05 = "1";
        Q5.RespostaCerta = 3;
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q6.Pergunta = "Quanto é 3+2?";
        Q6.Resposta01 = "2";
        Q6.Resposta02 = "32";
        Q6.Resposta03 = "5";
        Q6.Resposta04 = "sim";
        Q6.Resposta05 = "10";
        Q6.RespostaCerta = 3;
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q7.Pergunta = "Quanto é 2+2?";
        Q7.Resposta01 = "2";
        Q7.Resposta02 = "22";
        Q7.Resposta03 = "4";
        Q7.Resposta04 = "sim";
        Q7.Resposta05 = "1";
        Q7.RespostaCerta = 3;
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q8.Pergunta = "Quanto é 3+2?";
        Q8.Resposta01 = "2";
        Q8.Resposta02 = "32";
        Q8.Resposta03 = "5";
        Q8.Resposta04 = "sim";
        Q8.Resposta05 = "10";
        Q8.RespostaCerta = 3;
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q9.Pergunta = "Quanto é 2+2?";
        Q9.Resposta01 = "2";
        Q9.Resposta02 = "22";
        Q9.Resposta03 = "4";
        Q9.Resposta04 = "sim";
        Q9.Resposta05 = "1";
        Q9.RespostaCerta = 3;
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q10.Pergunta = "Quanto é 3+2?";
        Q10.Resposta01 = "2";
        Q10.Resposta02 = "32";
        Q10.Resposta03 = "5";
        Q10.Resposta04 = "sim";
        Q10.Resposta05 = "10";
        Q10.RespostaCerta = 3;
        ListaQuestoes.Add(Q10);
        ProximaQuestao();
    }
    public async void VerificarCerta(int RespostaRepondida)
    {
        labelPontuacao.Text="Pontuação: R$"+labelPontuacao.ToString();
        labelNivel.Text="Nível:"+NivelAtual.ToString();
        if (QuestaoCorrente.VerificaResposta(RespostaRepondida))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Você errou", "ok");
            Inicializar();
        }
    }

    void ProximaQuestao()
    {
        var rumAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRepondidas.Contains(rumAleat))
            rumAleat = Random.Shared.Next(0, ListaQuestoes.Count);

        ListaQuestoesRepondidas.Add(rumAleat);
        QuestaoCorrente = ListaQuestoes[rumAleat];
        QuestaoCorrente.Desenhar();
    }
        void Inicializar()
        {
            Pontuação=0;
            NivelAtual=1;
            ProximaQuestao();
        }

        void AdicionaPontuacao(int n)
        {
            if(n==1)
            Pontuação=1000;
            else if(n==2)
            Pontuação=2000;
            else if(n==3)
            Pontuação=5000;
            else if(n==4)
            Pontuação=410000;
            else if(n==5)
            Pontuação=20000;
            else if(n==6)
            Pontuação=50000;
            else if(n==7)
            Pontuação=100000;
            else if(n==8)
            Pontuação=200000;
            else if(n==9)
            Pontuação=500000;
            else Pontuação=1000000;
        }
}


