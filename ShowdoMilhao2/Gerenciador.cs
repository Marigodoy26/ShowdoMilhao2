using System.Security.Cryptography.X509Certificates;
using ShowdoMilhao2;
(
public class Gerenciador
{
    List<Questao>ListaQuestoes=new List<Questao>();
     List<int>ListaQuestoesRepondidas=new List<int>();
     Questao QuestaoCorrente;

     public Gerenciador(Label labelPergunta,Button BtnResp1,Button BtnResp2,Button BtnResp3,Button BtnResp4,Button BtnResp5)
     {
        CriarPergunta(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
     }


var CriarPergunta(Label labelPergunta, Button BtnResp1,Button BtnResp2,Button BtnResp3,Button BtnResp4,Button BtnResp5)
    {
        var Q1=new Questao(1);
        Q1.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q1.Pergunta="Quanto é 2+2?";
        Q1.Resposta01="2";
        Q1.Resposta02="22";
        Q1.Resposta03="4";
        Q1.Resposta04="sim";
        Q1.Resposta05="1";
        Q1.RespostaCerta=3;
        ListaQuestoes.Add(Q1);

        var Q2=new Questao(1);
        Q2.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q2.Pergunta="Quanto é 3+2?";
        Q2.Resposta01="2";
        Q2.Resposta02="32";
        Q2.Resposta03="5";
        Q2.Resposta04="sim";
        Q2.Resposta05="10";
        Q2.RespostaCerta=3;
        ListaQuestoes.Add(Q2);

        var Q3=new Questao(1);
        Q3.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q3.Pergunta="Quanto é 2+2?";
        Q3.Resposta01="2";
        Q3.Resposta02="22";
        Q3.Resposta03="4";
        Q3.Resposta04="sim";
        Q3.Resposta05="1";
        Q3.RespostaCerta=3;
        ListaQuestoes.Add(Q3);

        var Q4=new Questao(1);
        Q4.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q4.Pergunta="Quanto é 3+2?";
        Q4.Resposta01="2";
        Q4.Resposta02="32";
        Q4.Resposta03="5";
        Q4.Resposta04="sim";
        Q4.Resposta05="10";
        Q4.RespostaCerta=3;
        ListaQuestoes.Add(Q4);

        var Q5=new Questao(1);
        Q5.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q5.Pergunta="Quanto é 2+2?";
        Q5.Resposta01="2";
        Q5.Resposta02="22";
        Q5.Resposta03="4";
        Q5.Resposta04="sim";
        Q5.Resposta05="1";
        Q5.RespostaCerta=3;
        ListaQuestoes.Add(Q5);

        var Q6=new Questao(1);
        Q6.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q6.Pergunta="Quanto é 3+2?";
        Q6.Resposta01="2";
        Q6.Resposta02="32";
        Q6.Resposta03="5";
        Q6.Resposta04="sim";
        Q6.Resposta05="10";
        Q6.RespostaCerta=3;
        ListaQuestoes.Add(Q6);

        var Q7=new Questao(1);
        Q7.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q7.Pergunta="Quanto é 2+2?";
        Q7.Resposta01="2";
        Q7.Resposta02="22";
        Q7.Resposta03="4";
        Q7.Resposta04="sim";
        Q7.Resposta05="1";
        Q7.RespostaCerta=3;
        ListaQuestoes.Add(Q7);

        var Q8=new Questao(1);
        Q8.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q8.Pergunta="Quanto é 3+2?";
        Q8.Resposta01="2";
        Q8.Resposta02="32";
        Q8.Resposta03="5";
        Q8.Resposta04="sim";
        Q8.Resposta05="10";
        Q8.RespostaCerta=3;
        ListaQuestoes.Add(Q8);

        var Q9=new Questao(1);
        Q9.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q9.Pergunta="Quanto é 2+2?";
        Q9.Resposta01="2";
        Q9.Resposta02="22";
        Q9.Resposta03="4";
        Q9.Resposta04="sim";
        Q9.Resposta05="1";
        Q9.RespostaCerta=3;
        ListaQuestoes.Add(Q9);

        var Q10=new Questao(1);
        Q10.ConfigurarDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q10.Pergunta="Quanto é 3+2?";
        Q10.Resposta01="2";
        Q10.Resposta02="32";
        Q10.Resposta03="5";
        Q10.Resposta04="sim";
        Q10.Resposta05="10";
        Q10.RespostaCerta=3;
        ListaQuestoes.Add(Q10);

        PublicKey Async async void VerificarCerta(int RespostaRepondida)
        {
            if(QuestaoCorrente.VerificaResposta(RespostaRepondida))
            {
                await Task.Delay(1000);//1segunda
                ProximaQuestao();
            }
        }

        {
            void ProximaQuestao()
            {
                var rumAceat=Randon Shared.Next(0, ListaQuestoes.Count);
                while(ListaQuestoesRepondidas.Contains(numAleat))
                numAleat=Random.Shared.Next(0,ListaQuestoes.count);
                
            }
        }


    }
}
)