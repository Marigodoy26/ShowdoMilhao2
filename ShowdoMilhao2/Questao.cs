namespace ShowdoMilhao2
{
  public class Questao
  {
    public string Pergunta;
    public string Resposta01;
    public string Resposta02;
    public string Resposta03;
    public string Resposta04;
    public string Resposta05;
    public int RespostaCerta;
    public int RespostaIncorreta;
    public int Nivel;

    private Label labelPergunta;
    private Button btResposta01;
    private Button btResposta02;
    private Button btResposta03;
    private Button btResposta04;
    private Button btResposta05;
    private Button QualBtn(int rr)
    {
        if (rr ==1)
          return btResposta01;
        else if (rr ==2)
          return btResposta02;
        else if (rr ==3)
          return btResposta03; 
        else if (rr ==4)
          return btResposta04;
        else if (rr ==5)
          return btResposta05;
        else 
        return null; 
    }

    public Questao ()
    {

    }
    public void Desenhar ()
    {
        labelPergunta.Text= Pergunta;
        btResposta01.Text= Resposta01;
        btResposta02.Text= Resposta02;
        btResposta03.Text= Resposta03;
        btResposta04.Text= Resposta04;
        btResposta05.Text= Resposta05;
    }
    public Questao (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta=LP;
        btResposta01= bt01;
        btResposta02= bt02;
        btResposta03= bt03;
        btResposta04= bt04;
        btResposta05= bt05;
    }
     public void ConfiguraDesenho (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta=LP;
        btResposta01= bt01;
        btResposta02= bt02;
        btResposta03= bt03;
        btResposta04= bt04;
        btResposta05= bt05;
    }

    public bool VerificaResposta (int RespostaRespondida)
    {
        if (RespostaRespondida == RespostaCerta)
        {
            var Btn= QualBtn (RespostaRespondida);
            Btn.BackgroundColor= Colors.Green;
            return true;
        }
        else
        {
            var BtnCorreto= QualBtn (RespostaCerta);
            var BtnIncorreto= QualBtn (RespostaRespondida);
            BtnCorreto.BackgroundColor= Colors.Yellow;
            BtnIncorreto.BackgroundColor= Colors.Red;
            return false;
        }
    }
  }
}