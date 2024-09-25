namespace ShowdoMilhao2;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRepondidas = new List<int>();
    Questao QuestaoCorrente;
    public int Pontuacao { get; private set; }
    int NivelAtual = 0;
    Label labelPontuacao;
    Label labelNivel;

    public Gerenciador(Label labelPergunta, Button BtnResp1, Button BtnResp2, Button BtnResp3, Button BtnResp4, Button BtnResp5, Label labelPontuacao, Label labelNivel)
    {
        CriarPergunta(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }


    void CriarPergunta(Label labelPergunta, Button BtnResp1, Button BtnResp2, Button BtnResp3, Button BtnResp4, Button BtnResp5)
    {
        var Q1 = new Questao();
        Q1.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q1.Pergunta = "Quanto é 2 + 2?";
        Q1.Resposta01 = "2";
        Q1.Resposta02 = "22";
        Q1.Resposta03 = "4";
        Q1.Resposta04 = "sim";
        Q1.Resposta05 = "1";
        Q1.RespostaCerta = 3;
        Q1.Nivel = 1;
        ListaQuestoes.Add(Q1);

        // Pergunta 2
        var Q2 = new Questao();
        Q2.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q2.Pergunta = "Qual é a capital da França?";
        Q2.Resposta01 = "Berlim";
        Q2.Resposta02 = "Madrid";
        Q2.Resposta03 = "Paris";
        Q2.Resposta04 = "Lisboa";
        Q2.Resposta05 = "Roma";
        Q2.RespostaCerta = 3;
        Q2.Nivel = 1;
        ListaQuestoes.Add(Q2);

        // Pergunta 3
        var Q3 = new Questao();
        Q3.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q3.Pergunta = "Quantas cores tem o arco-íris?";
        Q3.Resposta01 = "5";
        Q3.Resposta02 = "6";
        Q3.Resposta03 = "7";
        Q3.Resposta04 = "8";
        Q3.Resposta05 = "9";
        Q3.RespostaCerta = 3;
        Q3.Nivel = 1;
        ListaQuestoes.Add(Q3);

        // Pergunta 4
        var Q4 = new Questao();
        Q4.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q4.Pergunta = "Qual é o maior planeta do sistema solar?";
        Q4.Resposta01 = "Terra";
        Q4.Resposta02 = "Marte";
        Q4.Resposta03 = "Júpiter";
        Q4.Resposta04 = "Saturno";
        Q4.Resposta05 = "Vênus";
        Q4.RespostaCerta = 3;
        Q4.Nivel = 1;
        ListaQuestoes.Add(Q4);

        // Pergunta 5
        var Q5 = new Questao();
        Q5.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q5.Pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q5.Resposta01 = "Machado de Assis";
        Q5.Resposta02 = "José de Alencar";
        Q5.Resposta03 = "Clarice Lispector";
        Q5.Resposta04 = "Jorge Amado";
        Q5.Resposta05 = "Guimarães Rosa";
        Q5.RespostaCerta = 1;
        Q5.Nivel = 1;
        ListaQuestoes.Add(Q5);

        // Pergunta 6
        var Q6 = new Questao();
        Q6.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q6.Pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Q6.Resposta01 = "Ouro";
        Q6.Resposta02 = "Oxigênio";
        Q6.Resposta03 = "Carbono";
        Q6.Resposta04 = "Água";
        Q6.Resposta05 = "Cálcio";
        Q6.RespostaCerta = 2;
        Q6.Nivel = 1;
        ListaQuestoes.Add(Q6);

        // Pergunta 7
        var Q7 = new Questao();
        Q7.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q7.Pergunta = "Quantos estados tem o Brasil?";
        Q7.Resposta01 = "26";
        Q7.Resposta02 = "25";
        Q7.Resposta03 = "27";
        Q7.Resposta04 = "24";
        Q7.Resposta05 = "28";
        Q7.RespostaCerta = 3;
        Q7.Nivel = 1;
        ListaQuestoes.Add(Q7);

        // Pergunta 8
        var Q8 = new Questao();
        Q8.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q8.Pergunta = "Qual é o animal mais rápido do mundo?";
        Q8.Resposta01 = "Leopardo";
        Q8.Resposta02 = "Guepardo";
        Q8.Resposta03 = "Falcão peregrino";
        Q8.Resposta04 = "Cavalo";
        Q8.Resposta05 = "Lobo";
        Q8.RespostaCerta = 3;
        Q8.Nivel = 1;
        ListaQuestoes.Add(Q8);

        // Pergunta 9
        var Q9 = new Questao();
        Q9.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q9.Pergunta = "Qual é a língua mais falada do mundo?";
        Q9.Resposta01 = "Inglês";
        Q9.Resposta02 = "Mandarim";
        Q9.Resposta03 = "Espanhol";
        Q9.Resposta04 = "Hindi";
        Q9.Resposta05 = "Árabe";
        Q9.RespostaCerta = 2;
        Q9.Nivel = 1;
        ListaQuestoes.Add(Q9);

        // Pergunta 10
        var Q10 = new Questao();
        Q10.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q10.Pergunta = "Qual é o continente mais populoso?";
        Q10.Resposta01 = "África";
        Q10.Resposta02 = "América";
        Q10.Resposta03 = "Ásia";
        Q10.Resposta04 = "Europa";
        Q10.Resposta05 = "Oceania";
        Q10.RespostaCerta = 3;
        Q10.Nivel = 1;
        ListaQuestoes.Add(Q10);
        ProximaQuestao();
    }

    public async void VerificarCerta(int RespostaRepondida)
    {
        labelPontuacao.Text = "Pontuação:" + Pontuacao.ToString();
        labelNivel.Text = "Nível:" + NivelAtual.ToString();
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
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if (n == 1)
            Pontuacao = 1000;
        else if (n == 2)
            Pontuacao = 2000;
        else if (n == 3)
            Pontuacao = 5000;
        else if (n == 4)
            Pontuacao = 410000;
        else if (n == 5)
            Pontuacao = 20000;
        else if (n == 6)
            Pontuacao = 50000;
        else if (n == 7)
            Pontuacao = 100000;
        else if (n == 8)
            Pontuacao = 200000;
        else if (n == 9)
            Pontuacao = 500000;
        else Pontuacao = 1000000;
    }
}


