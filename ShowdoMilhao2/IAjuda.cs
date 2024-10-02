namespace ShowdoMilhao2;
public abstract class IAjuda
{
    protected Button Resposta01;
    protected Button Resposta01;
    protected Button Resposta01;
    protected Button Resposta01;
    protected Button Resposta01;
    protected Frame FrameAjuda;

    public void ConfiguraDesenho(Button BtnResp01, Button BtnResp02, Button BtnResp03, Button BtnResp04, Button BtnResp05)
    {
        this.BtnResp01=BtnResp01;
        this.BtnResp01=BtnResp02;
        this.BtnResp01=BtnResp03;
        this.BtnResp01=BtnResp04;
        this.BtnResp01=BtnResp05;
    }
    public void ConfiguraDesenho(Frame FrameAjuda)
    {
        this.FrameAjuda=FrameAjuda;
    }
    
    public abstract void RealizaAjuda(Questao questao);

}