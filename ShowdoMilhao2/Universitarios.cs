namespace ShowdoMilhao2;
public class Universitarios : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var Porcentagem = 100;
        for (int i = 0; i < 5; i++)
        {
            int num_randomico = 0;
            if (Porcentagem > 0)
            {
                num_randomico = Random.Shared.Next(0, Porcentagem);
                Porcentagem -= num_randomico;
            }
            switch (i)
            {
                case 0:
                    Resposta01.Text += "=" + num_randomico.ToString() + "%";
                    break;

                case 1:
                    Resposta02.Text += "=" + num_randomico.ToString() + "%";
                    break;

                case 2:
                    Resposta03.Text += "=" + num_randomico.ToString() + "%";
                    break;

                case 3:
                    Resposta04.Text += "=" + num_randomico.ToString() + "%";
                    break;

                case 4:
                    Resposta05.Text += "=" + num_randomico.ToString() + "%";
                    break;

            }
        }
    }
}