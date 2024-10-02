namespace ShowdoMilhao2;
public class RetiraErrada : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.RespostaCerta)
        {
        case1:
        BtnResp02.IsVisible = false;
        BtnResp04.IsVisible = false;
        BtnResp05.IsVisible = false;

    case2:
        BtnResp01.IsVisible = false;
        BtnResp03.IsVisible = false;
        BtnResp04.IsVisible = false;

    case3:
        BtnResp01.IsVisible = false;
        BtnResp04.IsVisible = false;
        BtnResp05.IsVisible = false;

    case4:
        BtnResp02.IsVisible = false;
        BtnResp01.IsVisible = false;
        BtnResp05.IsVisible = false;

    case5:
        BtnResp01.IsVisible = false;
        BtnResp02.IsVisible = false;
        BtnResp04.IsVisible = false;
    }
}
}