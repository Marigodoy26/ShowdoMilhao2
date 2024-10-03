namespace ShowdoMilhao2;
public class RetiraErrada : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.RespostaCerta)
        {
        case 1:
        Resposta02.IsVisible = false;
        Resposta04.IsVisible = false;
        Resposta05.IsVisible = false;
        break;

    case 2:
        Resposta01.IsVisible = false;
        Resposta03.IsVisible = false;
        Resposta04.IsVisible = false;
        break;

    case 3:
        Resposta01.IsVisible = false;
        Resposta04.IsVisible = false;
        Resposta05.IsVisible = false;
        break;

    case 4:
        Resposta02.IsVisible = false;
        Resposta05.IsVisible = false;
        Resposta05.IsVisible = false;
        break;

    case 5:
        Resposta05.IsVisible = false;
        Resposta02.IsVisible = false;
        Resposta04.IsVisible = false;
        break;

    }
}
}