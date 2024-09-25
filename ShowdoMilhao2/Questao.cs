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
    private Button btResp1;
    private Button btResp2;
    private Button btResp3;
    private Button btResp4;
    private Button btResp5;
    private Button QualBtn(int rr)
    {
        if (rr ==1)
          return btResp1;
        else if (rr ==2)
          return btResp2;
        else if (rr ==3)
          return btResp3; 
        else if (rr ==4)
          return btResp4;
        else if (rr ==5)
          return btResp5;
        else 
        return null; 
    }

    public Questao ()
    {

    }
    public void Desenhar ()
    {
        labelPergunta.Text= Pergunta;
        btResp1.Text= Resposta01;
        btResp2.Text= Resposta02;
        btResp3.Text= Resposta03;
        btResp4.Text= Resposta04;
        btResp5.Text= Resposta05;

        btResp1!.BackgroundColor=Color.FromArgb("#710691");
        btResp1!.TextColor=Colors.Black;
        btResp2!.BackgroundColor=Color.FromArgb("#710691");
        btResp2!.TextColor=Colors.Black;
        btResp3!.BackgroundColor=Color.FromArgb("#710691");
        btResp3!.TextColor=Colors.Black;
        btResp4!.BackgroundColor=Color.FromArgb("#710691");
        btResp4!.TextColor=Colors.Black;
        btResp5!.BackgroundColor=Color.FromArgb("#710691");
        btResp5!.TextColor=Colors.Black;
    }
    public Questao (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta=LP;
        btResp1= bt01;
        btResp2= bt02;
        btResp3= bt03;
        btResp4= bt04;
        btResp5= bt05;
    }
     public void ConfiguraDesenho (Label LP, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta=LP;
        btResp1= bt01;
        btResp2= bt02;
        btResp3= bt03;
        btResp4= bt04;
        btResp5= bt05;
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