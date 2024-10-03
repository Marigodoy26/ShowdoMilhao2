namespace ShowdoMilhao2;
public abstract class IAjuda
{
    protected Button Resposta01;
    protected Button Resposta02;
    protected Button Resposta03;
    protected Button Resposta04;
    protected Button Resposta05;
    protected Frame FrameAjuda;

    public void ConfiguraDesenho(Button BtnResp01, Button BtnResp02, Button BtnResp03, Button BtnResp04, Button BtnResp05)
    {
        this.Resposta01=BtnResp01;
        this.Resposta02=BtnResp02;
        this.Resposta03=BtnResp03;
        this.Resposta04=BtnResp04;
        this.Resposta05=BtnResp05;
    }
    public void ConfiguraDesenho(Frame FrameAjuda)
    {
        this.FrameAjuda=FrameAjuda;
    }
    
    public abstract void RealizaAjuda(Questao questao);

}