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
        // Nível 1 (10 perguntas)
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

        var Q2 = new Questao();
        Q2.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q2.Pergunta = "Qual é a capital da França?";
        Q2.Resposta01 = "Londres";
        Q2.Resposta02 = "Paris";
        Q2.Resposta03 = "Roma";
        Q2.Resposta04 = "Berlim";
        Q2.Resposta05 = "Madri";
        Q2.RespostaCerta = 2;
        Q2.Nivel = 1;
        ListaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q3.Pergunta = "Qual o maior planeta do sistema solar?";
        Q3.Resposta01 = "Terra";
        Q3.Resposta02 = "Marte";
        Q3.Resposta03 = "Júpiter";
        Q3.Resposta04 = "Saturno";
        Q3.Resposta05 = "Vênus";
        Q3.RespostaCerta = 3;
        Q3.Nivel = 1;
        ListaQuestoes.Add(Q3);

        var Q4 = new Questao();
        Q4.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q4.Pergunta = "Quem descobriu o Brasil?";
        Q4.Resposta01 = "Pedro Álvares Cabral";
        Q4.Resposta02 = "Cristóvão Colombo";
        Q4.Resposta03 = "Vasco da Gama";
        Q4.Resposta04 = "Dom Pedro II";
        Q4.Resposta05 = "Fernando de Noronha";
        Q4.RespostaCerta = 1;
        Q4.Nivel = 1;
        ListaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q5.Pergunta = "Quantos continentes existem na Terra?";
        Q5.Resposta01 = "5";
        Q5.Resposta02 = "6";
        Q5.Resposta03 = "7";
        Q5.Resposta04 = "8";
        Q5.Resposta05 = "4";
        Q5.RespostaCerta = 3;
        Q5.Nivel = 1;
        ListaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q6.Pergunta = "Quantos dias tem um ano bissexto?";
        Q6.Resposta01 = "365";
        Q6.Resposta02 = "366";
        Q6.Resposta03 = "364";
        Q6.Resposta04 = "360";
        Q6.Resposta05 = "368";
        Q6.RespostaCerta = 2;
        Q6.Nivel = 1;
        ListaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q7.Pergunta = "Qual é o animal mais rápido do mundo?";
        Q7.Resposta01 = "Leão";
        Q7.Resposta02 = "Guepardo";
        Q7.Resposta03 = "Falcão-peregrino";
        Q7.Resposta04 = "Leopardo";
        Q7.Resposta05 = "Águia";
        Q7.RespostaCerta = 3;
        Q7.Nivel = 1;
        ListaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q8.Pergunta = "Qual é o maior oceano da Terra?";
        Q8.Resposta01 = "Atlântico";
        Q8.Resposta02 = "Índico";
        Q8.Resposta03 = "Pacífico";
        Q8.Resposta04 = "Ártico";
        Q8.Resposta05 = "Antártico";
        Q8.RespostaCerta = 3;
        Q8.Nivel = 1;
        ListaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q9.Pergunta = "Qual é o menor país do mundo?";
        Q9.Resposta01 = "Mônaco";
        Q9.Resposta02 = "Vaticano";
        Q9.Resposta03 = "San Marino";
        Q9.Resposta04 = "Luxemburgo";
        Q9.Resposta05 = "Andorra";
        Q9.RespostaCerta = 2;
        Q9.Nivel = 1;
        ListaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q10.Pergunta = "Qual é o órgão humano responsável por bombear sangue?";
        Q10.Resposta01 = "Pulmão";
        Q10.Resposta02 = "Cérebro";
        Q10.Resposta03 = "Fígado";
        Q10.Resposta04 = "Coração";
        Q10.Resposta05 = "Rim";
        Q10.RespostaCerta = 4;
        Q10.Nivel = 1;
        ListaQuestoes.Add(Q10);

        // Nível 2
        var Q11 = new Questao();
        Q11.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q11.Pergunta = "Quem pintou a Mona Lisa?";
        Q11.Resposta01 = "Michelangelo";
        Q11.Resposta02 = "Leonardo da Vinci";
        Q11.Resposta03 = "Picasso";
        Q11.Resposta04 = "Van Gogh";
        Q11.Resposta05 = "Rafael";
        Q11.RespostaCerta = 2;
        Q11.Nivel = 2;
        ListaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q12.Pergunta = "Em que continente fica o Brasil?";
        Q12.Resposta01 = "América do Sul";
        Q12.Resposta02 = "Ásia";
        Q12.Resposta03 = "Europa";
        Q12.Resposta04 = "África";
        Q12.Resposta05 = "Oceania";
        Q12.RespostaCerta = 1;
        Q12.Nivel = 2;
        ListaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q13.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
        Q13.Resposta01 = "George Washington";
        Q13.Resposta02 = "Abraham Lincoln";
        Q13.Resposta03 = "Thomas Jefferson";
        Q13.Resposta04 = "John Adams";
        Q13.Resposta05 = "Franklin Roosevelt";
        Q13.RespostaCerta = 1;
        Q13.Nivel = 2;
        ListaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q14.Pergunta = "Quantos ossos tem o corpo humano adulto?";
        Q14.Resposta01 = "206";
        Q14.Resposta02 = "305";
        Q14.Resposta03 = "198";
        Q14.Resposta04 = "187";
        Q14.Resposta05 = "246";
        Q14.RespostaCerta = 1;
        Q14.Nivel = 2;
        ListaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q15.Pergunta = "Qual é a montanha mais alta do mundo?";
        Q15.Resposta01 = "Monte Everest";
        Q15.Resposta02 = "K2";
        Q15.Resposta03 = "Monte Kilimanjaro";
        Q15.Resposta04 = "Mont Blanc";
        Q15.Resposta05 = "Pico da Neblina";
        Q15.RespostaCerta = 1;
        Q15.Nivel = 2;
        ListaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q16.Pergunta = "Qual é o maior deserto do mundo?";
        Q16.Resposta01 = "Saara";
        Q16.Resposta02 = "Atacama";
        Q16.Resposta03 = "Gobi";
        Q16.Resposta04 = "Deserto da Antártica";
        Q16.Resposta05 = "Kalahari";
        Q16.RespostaCerta = 4;
        Q16.Nivel = 2;
        ListaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q17.Pergunta = "Qual é a fórmula química da água?";
        Q17.Resposta01 = "CO2";
        Q17.Resposta02 = "H2O";
        Q17.Resposta03 = "O2";
        Q17.Resposta04 = "NaCl";
        Q17.Resposta05 = "H2SO4";
        Q17.RespostaCerta = 2;
        Q17.Nivel = 2;
        ListaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q18.Pergunta = "Qual o nome do maior animal terrestre?";
        Q18.Resposta01 = "Elefante africano";
        Q18.Resposta02 = "Rinoceronte";
        Q18.Resposta03 = "Girafa";
        Q18.Resposta04 = "Leão";
        Q18.Resposta05 = "Hipopótamo";
        Q18.RespostaCerta = 1;
        Q18.Nivel = 2;
        ListaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q19.Pergunta = "Qual foi o primeiro homem a viajar para o espaço?";
        Q19.Resposta01 = "Neil Armstrong";
        Q19.Resposta02 = "Yuri Gagarin";
        Q19.Resposta03 = "Buzz Aldrin";
        Q19.Resposta04 = "Laika";
        Q19.Resposta05 = "Michael Collins";
        Q19.RespostaCerta = 2;
        Q19.Nivel = 2;
        ListaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q20.Pergunta = "Quem escreveu 'Dom Quixote'?";
        Q20.Resposta01 = "William Shakespeare";
        Q20.Resposta02 = "Miguel de Cervantes";
        Q20.Resposta03 = "Gabriel García Márquez";
        Q20.Resposta04 = "Eça de Queirós";
        Q20.Resposta05 = "Victor Hugo";
        Q20.RespostaCerta = 2;
        Q20.Nivel = 2;
        ListaQuestoes.Add(Q20);

        // Nível 3 
        var Q21 = new Questao();
        Q21.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q21.Pergunta = "Qual é a capital da Austrália?";
        Q21.Resposta01 = "Sydney";
        Q21.Resposta02 = "Melbourne";
        Q21.Resposta03 = "Canberra";
        Q21.Resposta04 = "Perth";
        Q21.Resposta05 = "Brisbane";
        Q21.RespostaCerta = 3;
        Q21.Nivel = 3;
        ListaQuestoes.Add(Q21);

        var Q22 = new Questao();
        Q22.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q22.Pergunta = "Em que ano aconteceu a Revolução Francesa?";
        Q22.Resposta01 = "1776";
        Q22.Resposta02 = "1789";
        Q22.Resposta03 = "1799";
        Q22.Resposta04 = "1815";
        Q22.Resposta05 = "1804";
        Q22.RespostaCerta = 2;
        Q22.Nivel = 3;
        ListaQuestoes.Add(Q22);

        var Q23 = new Questao();
        Q23.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q23.Pergunta = "Qual é o elemento químico mais abundante na atmosfera terrestre?";
        Q23.Resposta01 = "Oxigênio";
        Q23.Resposta02 = "Hidrogênio";
        Q23.Resposta03 = "Nitrogênio";
        Q23.Resposta04 = "Carbono";
        Q23.Resposta05 = "Árgon";
        Q23.RespostaCerta = 3;
        Q23.Nivel = 3;
        ListaQuestoes.Add(Q23);

        var Q24 = new Questao();
        Q24.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q24.Pergunta = "Qual é a moeda usada no Japão?";
        Q24.Resposta01 = "Dólar";
        Q24.Resposta02 = "Won";
        Q24.Resposta03 = "Iene";
        Q24.Resposta04 = "Yuan";
        Q24.Resposta05 = "Rupia";
        Q24.RespostaCerta = 3;
        Q24.Nivel = 3;
        ListaQuestoes.Add(Q24);

        var Q25 = new Questao();
        Q25.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q25.Pergunta = "Em qual país se encontra a Muralha da China?";
        Q25.Resposta01 = "Coreia do Norte";
        Q25.Resposta02 = "Japão";
        Q25.Resposta03 = "China";
        Q25.Resposta04 = "Tailândia";
        Q25.Resposta05 = "Índia";
        Q25.RespostaCerta = 3;
        Q25.Nivel = 3;
        ListaQuestoes.Add(Q25);

        var Q26 = new Questao();
        Q26.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q26.Pergunta = "Qual é a fórmula química do sal de cozinha?";
        Q26.Resposta01 = "H2O";
        Q26.Resposta02 = "NaCl";
        Q26.Resposta03 = "CO2";
        Q26.Resposta04 = "KCl";
        Q26.Resposta05 = "CaCO3";
        Q26.RespostaCerta = 2;
        Q26.Nivel = 3;
        ListaQuestoes.Add(Q26);

        var Q27 = new Questao();
        Q27.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q27.Pergunta = "Quem foi o líder do movimento de independência da Índia?";
        Q27.Resposta01 = "Mahatma Gandhi";
        Q27.Resposta02 = "Nelson Mandela";
        Q27.Resposta03 = "Jawaharlal Nehru";
        Q27.Resposta04 = "Subhas Chandra Bose";
        Q27.Resposta05 = "Indira Gandhi";
        Q27.RespostaCerta = 1;
        Q27.Nivel = 3;
        ListaQuestoes.Add(Q27);

        var Q28 = new Questao();
        Q28.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q28.Pergunta = "Qual é a capital do Canadá?";
        Q28.Resposta01 = "Toronto";
        Q28.Resposta02 = "Montreal";
        Q28.Resposta03 = "Vancouver";
        Q28.Resposta04 = "Ottawa";
        Q28.Resposta05 = "Quebec";
        Q28.RespostaCerta = 4;
        Q28.Nivel = 3;
        ListaQuestoes.Add(Q28);

        var Q29 = new Questao();
        Q29.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q29.Pergunta = "Qual cientista formulou a teoria da relatividade?";
        Q29.Resposta01 = "Isaac Newton";
        Q29.Resposta02 = "Marie Curie";
        Q29.Resposta03 = "Albert Einstein";
        Q29.Resposta04 = "Galileu Galilei";
        Q29.Resposta05 = "Nikola Tesla";
        Q29.RespostaCerta = 3;
        Q29.Nivel = 3;
        ListaQuestoes.Add(Q29);

        var Q30 = new Questao();
        Q30.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q30.Pergunta = "Quem foi o autor de 'O Pequeno Príncipe'?";
        Q30.Resposta01 = "J.K. Rowling";
        Q30.Resposta02 = "Antoine de Saint-Exupéry";
        Q30.Resposta03 = "Charles Dickens";
        Q30.Resposta04 = "Mark Twain";
        Q30.Resposta05 = "Hans Christian Andersen";
        Q30.RespostaCerta = 2;
        Q30.Nivel = 3;
        ListaQuestoes.Add(Q30);

        // Nível 4 
        var Q31 = new Questao();
        Q31.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q31.Pergunta = "Qual é o nome do maior oceano da Terra?";
        Q31.Resposta01 = "Atlântico";
        Q31.Resposta02 = "Índico";
        Q31.Resposta03 = "Pacífico";
        Q31.Resposta04 = "Ártico";
        Q31.Resposta05 = "Antártico";
        Q31.RespostaCerta = 3;
        Q31.Nivel = 4;
        ListaQuestoes.Add(Q31);

        // Nível 4 (Continuação)
        var Q32 = new Questao();
        Q32.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q32.Pergunta = "Quem pintou o teto da Capela Sistina?";
        Q32.Resposta01 = "Leonardo da Vinci";
        Q32.Resposta02 = "Michelangelo";
        Q32.Resposta03 = "Raphael";
        Q32.Resposta04 = "Donatello";
        Q32.Resposta05 = "Caravaggio";
        Q32.RespostaCerta = 2;
        Q32.Nivel = 4;
        ListaQuestoes.Add(Q32);

        var Q33 = new Questao();
        Q33.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q33.Pergunta = "Qual é o maior país da América do Sul?";
        Q33.Resposta01 = "Brasil";
        Q33.Resposta02 = "Argentina";
        Q33.Resposta03 = "Chile";
        Q33.Resposta04 = "Peru";
        Q33.Resposta05 = "Colômbia";
        Q33.RespostaCerta = 1;
        Q33.Nivel = 4;
        ListaQuestoes.Add(Q33);

        var Q34 = new Questao();
        Q34.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q34.Pergunta = "Em que país se encontra a Torre Eiffel?";
        Q34.Resposta01 = "França";
        Q34.Resposta02 = "Itália";
        Q34.Resposta03 = "Alemanha";
        Q34.Resposta04 = "Espanha";
        Q34.Resposta05 = "Bélgica";
        Q34.RespostaCerta = 1;
        Q34.Nivel = 4;
        ListaQuestoes.Add(Q34);

        var Q35 = new Questao();
        Q35.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q35.Pergunta = "Qual a capital da Alemanha?";
        Q35.Resposta01 = "Munique";
        Q35.Resposta02 = "Berlim";
        Q35.Resposta03 = "Frankfurt";
        Q35.Resposta04 = "Colônia";
        Q35.Resposta05 = "Hamburgo";
        Q35.RespostaCerta = 2;
        Q35.Nivel = 4;
        ListaQuestoes.Add(Q35);

        var Q36 = new Questao();
        Q36.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q36.Pergunta = "Quem é o autor de 'A Origem das Espécies'?";
        Q36.Resposta01 = "Albert Einstein";
        Q36.Resposta02 = "Isaac Newton";
        Q36.Resposta03 = "Charles Darwin";
        Q36.Resposta04 = "Galileu Galilei";
        Q36.Resposta05 = "Gregor Mendel";
        Q36.RespostaCerta = 3;
        Q36.Nivel = 4;
        ListaQuestoes.Add(Q36);

        var Q37 = new Questao();
        Q37.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q37.Pergunta = "Qual foi a primeira mulher a ganhar o Prêmio Nobel?";
        Q37.Resposta01 = "Marie Curie";
        Q37.Resposta02 = "Rosalind Franklin";
        Q37.Resposta03 = "Ada Lovelace";
        Q37.Resposta04 = "Jane Goodall";
        Q37.Resposta05 = "Rachel Carson";
        Q37.RespostaCerta = 1;
        Q37.Nivel = 4;
        ListaQuestoes.Add(Q37);

        var Q38 = new Questao();
        Q38.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q38.Pergunta = "Qual o nome do maior continente da Terra?";
        Q38.Resposta01 = "África";
        Q38.Resposta02 = "América do Norte";
        Q38.Resposta03 = "Ásia";
        Q38.Resposta04 = "Europa";
        Q38.Resposta05 = "Oceania";
        Q38.RespostaCerta = 3;
        Q38.Nivel = 4;
        ListaQuestoes.Add(Q38);

        var Q39 = new Questao();
        Q39.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q39.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
        Q39.Resposta01 = "1965";
        Q39.Resposta02 = "1969";
        Q39.Resposta03 = "1971";
        Q39.Resposta04 = "1963";
        Q39.Resposta05 = "1959";
        Q39.RespostaCerta = 2;
        Q39.Nivel = 4;
        ListaQuestoes.Add(Q39);

        var Q40 = new Questao();
        Q40.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q40.Pergunta = "Qual é o símbolo químico do ouro?";
        Q40.Resposta01 = "Au";
        Q40.Resposta02 = "Ag";
        Q40.Resposta03 = "Fe";
        Q40.Resposta04 = "Hg";
        Q40.Resposta05 = "Pb";
        Q40.RespostaCerta = 1;
        Q40.Nivel = 4;
        ListaQuestoes.Add(Q40);

        // Nível 5 (10 perguntas)
        var Q41 = new Questao();
        Q41.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q41.Pergunta = "Quem escreveu 'A Odisséia'?";
        Q41.Resposta01 = "Sófocles";
        Q41.Resposta02 = "Homero";
        Q41.Resposta03 = "Platão";
        Q41.Resposta04 = "Aristóteles";
        Q41.Resposta05 = "Heródoto";
        Q41.RespostaCerta = 2;
        Q41.Nivel = 5;
        ListaQuestoes.Add(Q41);

        var Q42 = new Questao();
        Q42.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q42.Pergunta = "Qual é a camada mais externa da Terra?";
        Q42.Resposta01 = "Manto";
        Q42.Resposta02 = "Crosta";
        Q42.Resposta03 = "Núcleo Externo";
        Q42.Resposta04 = "Núcleo Interno";
        Q42.Resposta05 = "Litosfera";
        Q42.RespostaCerta = 2;
        Q42.Nivel = 5;
        ListaQuestoes.Add(Q42);

        var Q43 = new Questao();
        Q43.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q43.Pergunta = "Qual foi a primeira cidade a ser atingida por uma bomba atômica?";
        Q43.Resposta01 = "Tóquio";
        Q43.Resposta02 = "Nagasaki";
        Q43.Resposta03 = "Hiroshima";
        Q43.Resposta04 = "Osaka";
        Q43.Resposta05 = "Yokohama";
        Q43.RespostaCerta = 3;
        Q43.Nivel = 5;
        ListaQuestoes.Add(Q43);

        var Q44 = new Questao();
        Q44.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q44.Pergunta = "Em que ano caiu o Muro de Berlim?";
        Q44.Resposta01 = "1987";
        Q44.Resposta02 = "1989";
        Q44.Resposta03 = "1991";
        Q44.Resposta04 = "1985";
        Q44.Resposta05 = "1995";
        Q44.RespostaCerta = 2;
        Q44.Nivel = 5;
        ListaQuestoes.Add(Q44);

        var Q45 = new Questao();
        Q45.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q45.Pergunta = "Qual é a fórmula química do gás carbônico?";
        Q45.Resposta01 = "CO";
        Q45.Resposta02 = "CO2";
        Q45.Resposta03 = "O2";
        Q45.Resposta04 = "CH4";
        Q45.Resposta05 = "H2O";
        Q45.RespostaCerta = 2;
        Q45.Nivel = 5;
        ListaQuestoes.Add(Q45);

        var Q46 = new Questao();
        Q46.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q46.Pergunta = "Qual foi o maior império em extensão territorial?";
        Q46.Resposta01 = "Império Britânico";
        Q46.Resposta02 = "Império Romano";
        Q46.Resposta03 = "Império Mongol";
        Q46.Resposta04 = "Império Russo";
        Q46.Resposta05 = "Império Otomano";
        Q46.RespostaCerta = 1;
        Q46.Nivel = 5;
        ListaQuestoes.Add(Q46);

        var Q47 = new Questao();
        Q47.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q47.Pergunta = "Qual é o nome do processo em que uma lagarta se transforma em borboleta?";
        Q47.Resposta01 = "Metamorfose";
        Q47.Resposta02 = "Polinização";
        Q47.Resposta03 = "Fotossíntese";
        Q47.Resposta04 = "Germinação";
        Q47.Resposta05 = "Respiração";
        Q47.RespostaCerta = 1;
        Q47.Nivel = 5;
        ListaQuestoes.Add(Q47);

        var Q48 = new Questao();
        Q48.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q48.Pergunta = "Em qual país surgiu a Revolução Industrial?";
        Q48.Resposta01 = "França";
        Q48.Resposta02 = "EUA";
        Q48.Resposta03 = "Alemanha";
        Q48.Resposta04 = "Reino Unido";
        Q48.Resposta05 = "Itália";
        Q48.RespostaCerta = 4;
        Q48.Nivel = 5;
        ListaQuestoes.Add(Q48);

        var Q49 = new Questao();
        Q49.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q49.Pergunta = "Quem pintou 'Guernica'?";
        Q49.Resposta01 = "Salvador Dalí";
        Q49.Resposta02 = "Pablo Picasso";
        Q49.Resposta03 = "Claude Monet";
        Q49.Resposta04 = "Vincent Van Gogh";
        Q49.Resposta05 = "Paul Cézanne";
        Q49.RespostaCerta = 2;
        Q49.Nivel = 5;
        ListaQuestoes.Add(Q49);

        var Q50 = new Questao();
        Q50.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q50.Pergunta = "Qual a capital da Austrália?";
        Q50.Resposta01 = "Sydney";
        Q50.Resposta02 = "Melbourne";
        Q50.Resposta03 = "Brisbane";
        Q50.Resposta04 = "Canberra";
        Q50.Resposta05 = "Perth";
        Q50.RespostaCerta = 4;
        Q50.Nivel = 5;
        ListaQuestoes.Add(Q50);

        // Nível 6 (10 perguntas)
        var Q51 = new Questao();
        Q51.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q51.Pergunta = "Em que ano aconteceu a Revolução Russa?";
        Q51.Resposta01 = "1917";
        Q51.Resposta02 = "1914";
        Q51.Resposta03 = "1905";
        Q51.Resposta04 = "1923";
        Q51.Resposta05 = "1939";
        Q51.RespostaCerta = 1;
        Q51.Nivel = 6;
        ListaQuestoes.Add(Q51);

        var Q52 = new Questao();
        Q52.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q52.Pergunta = "Quem foi o primeiro presidente dos Estados Unidos?";
        Q52.Resposta01 = "Abraham Lincoln";
        Q52.Resposta02 = "George Washington";
        Q52.Resposta03 = "Thomas Jefferson";
        Q52.Resposta04 = "John Adams";
        Q52.Resposta05 = "James Madison";
        Q52.RespostaCerta = 2;
        Q52.Nivel = 6;
        ListaQuestoes.Add(Q52);

        var Q53 = new Questao();
        Q53.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q53.Pergunta = "Qual é o planeta mais próximo do Sol?";
        Q53.Resposta01 = "Terra";
        Q53.Resposta02 = "Marte";
        Q53.Resposta03 = "Vênus";
        Q53.Resposta04 = "Mercúrio";
        Q53.Resposta05 = "Júpiter";
        Q53.RespostaCerta = 4;
        Q53.Nivel = 6;
        ListaQuestoes.Add(Q53);

        var Q54 = new Questao();
        Q54.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q54.Pergunta = "Em que ano o homem pisou na Lua pela primeira vez?";
        Q54.Resposta01 = "1965";
        Q54.Resposta02 = "1969";
        Q54.Resposta03 = "1971";
        Q54.Resposta04 = "1975";
        Q54.Resposta05 = "1980";
        Q54.RespostaCerta = 2;
        Q54.Nivel = 6;
        ListaQuestoes.Add(Q54);

        var Q55 = new Questao();
        Q55.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q55.Pergunta = "Qual é a fórmula química da água?";
        Q55.Resposta01 = "CO2";
        Q55.Resposta02 = "H2O";
        Q55.Resposta03 = "O2";
        Q55.Resposta04 = "NaCl";
        Q55.Resposta05 = "H2SO4";
        Q55.RespostaCerta = 2;
        Q55.Nivel = 6;
        ListaQuestoes.Add(Q55);

        var Q56 = new Questao();
        Q56.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q56.Pergunta = "Quem escreveu 'Dom Quixote'?";
        Q56.Resposta01 = "William Shakespeare";
        Q56.Resposta02 = "Miguel de Cervantes";
        Q56.Resposta03 = "Jorge Luis Borges";
        Q56.Resposta04 = "Gabriel García Márquez";
        Q56.Resposta05 = "Fernando Pessoa";
        Q56.RespostaCerta = 2;
        Q56.Nivel = 6;
        ListaQuestoes.Add(Q56);

        var Q57 = new Questao();
        Q57.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q57.Pergunta = "Qual é o maior oceano da Terra?";
        Q57.Resposta01 = "Oceano Atlântico";
        Q57.Resposta02 = "Oceano Índico";
        Q57.Resposta03 = "Oceano Pacífico";
        Q57.Resposta04 = "Oceano Ártico";
        Q57.Resposta05 = "Oceano Antártico";
        Q57.RespostaCerta = 3;
        Q57.Nivel = 6;
        ListaQuestoes.Add(Q57);

        var Q58 = new Questao();
        Q58.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q58.Pergunta = "Quem pintou a Mona Lisa?";
        Q58.Resposta01 = "Vincent van Gogh";
        Q58.Resposta02 = "Claude Monet";
        Q58.Resposta03 = "Pablo Picasso";
        Q58.Resposta04 = "Leonardo da Vinci";
        Q58.Resposta05 = "Michelangelo";
        Q58.RespostaCerta = 4;
        Q58.Nivel = 6;
        ListaQuestoes.Add(Q58);

        var Q59 = new Questao();
        Q59.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q59.Pergunta = "Em que país as Pirâmides de Gizé estão localizadas?";
        Q59.Resposta01 = "México";
        Q59.Resposta02 = "Peru";
        Q59.Resposta03 = "Egito";
        Q59.Resposta04 = "Índia";
        Q59.Resposta05 = "Grécia";
        Q59.RespostaCerta = 3;
        Q59.Nivel = 6;
        ListaQuestoes.Add(Q59);

        var Q60 = new Questao();
        Q60.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q60.Pergunta = "Qual é a capital da Austrália?";
        Q60.Resposta01 = "Sydney";
        Q60.Resposta02 = "Melbourne";
        Q60.Resposta03 = "Perth";
        Q60.Resposta04 = "Brisbane";
        Q60.Resposta05 = "Canberra";
        Q60.RespostaCerta = 5;
        Q60.Nivel = 6;
        ListaQuestoes.Add(Q60);

        var Q61 = new Questao();
        Q61.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q61.Pergunta = "Quem desenvolveu a teoria da relatividade?";
        Q61.Resposta01 = "Isaac Newton";
        Q61.Resposta02 = "Albert Einstein";
        Q61.Resposta03 = "Galileu Galilei";
        Q61.Resposta04 = "Nikola Tesla";
        Q61.Resposta05 = "Stephen Hawking";
        Q61.RespostaCerta = 2;
        Q61.Nivel = 6;
        ListaQuestoes.Add(Q61);

        var Q62 = new Questao();
        Q62.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q62.Pergunta = "Qual é a moeda oficial do Japão?";
        Q62.Resposta01 = "Yuan";
        Q62.Resposta02 = "Won";
        Q62.Resposta03 = "Rupia";
        Q62.Resposta04 = "Iene";
        Q62.Resposta05 = "Peso";
        Q62.RespostaCerta = 4;
        Q62.Nivel = 6;
        ListaQuestoes.Add(Q62);

        var Q63 = new Questao();
        Q63.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q63.Pergunta = "Qual é o elemento químico de símbolo 'O'?";
        Q63.Resposta01 = "Ouro";
        Q63.Resposta02 = "Oxigênio";
        Q63.Resposta03 = "Ósmio";
        Q63.Resposta04 = "Oganessônio";
        Q63.Resposta05 = "Olíbdeno";
        Q63.RespostaCerta = 2;
        Q63.Nivel = 6;
        ListaQuestoes.Add(Q63);

        var Q64 = new Questao();
        Q64.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q64.Pergunta = "Qual foi a primeira cidade a ser atacada por uma bomba atômica?";
        Q64.Resposta01 = "Tóquio";
        Q64.Resposta02 = "Hiroshima";
        Q64.Resposta03 = "Nagasaki";
        Q64.Resposta04 = "Osaka";
        Q64.Resposta05 = "Fukuoka";
        Q64.RespostaCerta = 2;
        Q64.Nivel = 6;
        ListaQuestoes.Add(Q64);

        var Q65 = new Questao();
        Q65.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q65.Pergunta = "Quem foi o líder revolucionário da independência da Índia?";
        Q65.Resposta01 = "Nelson Mandela";
        Q65.Resposta02 = "Martin Luther King Jr.";
        Q65.Resposta03 = "Mahatma Gandhi";
        Q65.Resposta04 = "Jawaharlal Nehru";
        Q65.Resposta05 = "Subhas Chandra Bose";
        Q65.RespostaCerta = 3;
        Q65.Nivel = 6;
        ListaQuestoes.Add(Q65);

        var Q66 = new Questao();
        Q66.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q66.Pergunta = "Quantos estados há nos Estados Unidos?";
        Q66.Resposta01 = "48";
        Q66.Resposta02 = "49";
        Q66.Resposta03 = "50";
        Q66.Resposta04 = "51";
        Q66.Resposta05 = "52";
        Q66.RespostaCerta = 3;
        Q66.Nivel = 6;
        ListaQuestoes.Add(Q66);

        var Q67 = new Questao();
        Q67.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q67.Pergunta = "Qual é a capital da França?";
        Q67.Resposta01 = "Berlim";
        Q67.Resposta02 = "Madri";
        Q67.Resposta03 = "Paris";
        Q67.Resposta04 = "Londres";
        Q67.Resposta05 = "Roma";
        Q67.RespostaCerta = 3;
        Q67.Nivel = 6;
        ListaQuestoes.Add(Q67);

        var Q68 = new Questao();
        Q68.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q68.Pergunta = "Qual é a maior montanha do mundo?";
        Q68.Resposta01 = "Monte Fuji";
        Q68.Resposta02 = "Monte Kilimanjaro";
        Q68.Resposta03 = "Montanha K2";
        Q68.Resposta04 = "Monte Everest";
        Q68.Resposta05 = "Montanhas Rochosas";
        Q68.RespostaCerta = 4;
        Q68.Nivel = 6;
        ListaQuestoes.Add(Q68);

        var Q69 = new Questao();
        Q69.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q69.Pergunta = "Em que continente fica o deserto do Saara?";
        Q69.Resposta01 = "Ásia";
        Q69.Resposta02 = "América do Norte";
        Q69.Resposta03 = "África";
        Q69.Resposta04 = "Austrália";
        Q69.Resposta05 = "Europa";
        Q69.RespostaCerta = 3;
        Q69.Nivel = 6;
        ListaQuestoes.Add(Q69);

        var Q70 = new Questao();
        Q70.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q70.Pergunta = "Qual é o maior país do mundo em área territorial?";
        Q70.Resposta01 = "Estados Unidos";
        Q70.Resposta02 = "Canadá";
        Q70.Resposta03 = "China";
        Q70.Resposta04 = "Brasil";
        Q70.Resposta05 = "Rússia";
        Q70.RespostaCerta = 5;
        Q70.Nivel = 6;
        ListaQuestoes.Add(Q70);

        var Q71 = new Questao();
        Q71.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q71.Pergunta = "Qual é o menor país do mundo?";
        Q71.Resposta01 = "Liechtenstein";
        Q71.Resposta02 = "Mônaco";
        Q71.Resposta03 = "San Marino";
        Q71.Resposta04 = "Malta";
        Q71.Resposta05 = "Vaticano";
        Q71.RespostaCerta = 5;
        Q71.Nivel = 6;
        ListaQuestoes.Add(Q71);

        var Q72 = new Questao();
        Q72.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q72.Pergunta = "Qual é o segundo maior planeta do Sistema Solar?";
        Q72.Resposta01 = "Terra";
        Q72.Resposta02 = "Marte";
        Q72.Resposta03 = "Júpiter";
        Q72.Resposta04 = "Saturno";
        Q72.Resposta05 = "Urano";
        Q72.RespostaCerta = 4;
        Q72.Nivel = 6;
        ListaQuestoes.Add(Q72);

        var Q73 = new Questao();
        Q73.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q73.Pergunta = "Qual é a língua oficial do Brasil?";
        Q73.Resposta01 = "Espanhol";
        Q73.Resposta02 = "Inglês";
        Q73.Resposta03 = "Português";
        Q73.Resposta04 = "Francês";
        Q73.Resposta05 = "Italiano";
        Q73.RespostaCerta = 3;
        Q73.Nivel = 6;
        ListaQuestoes.Add(Q73);

        var Q74 = new Questao();
        Q74.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q74.Pergunta = "Quantos continentes existem no planeta Terra?";
        Q74.Resposta01 = "5";
        Q74.Resposta02 = "6";
        Q74.Resposta03 = "7";
        Q74.Resposta04 = "8";
        Q74.Resposta05 = "9";
        Q74.RespostaCerta = 3;
        Q74.Nivel = 6;
        ListaQuestoes.Add(Q74);

        var Q75 = new Questao();
        Q75.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q75.Pergunta = "Qual é o rio mais longo do mundo?";
        Q75.Resposta01 = "Rio Nilo";
        Q75.Resposta02 = "Rio Amazonas";
        Q75.Resposta03 = "Rio Yangtzé";
        Q75.Resposta04 = "Rio Mississippi";
        Q75.Resposta05 = "Rio Ganges";
        Q75.RespostaCerta = 2;
        Q75.Nivel = 6;
        ListaQuestoes.Add(Q75);

        var Q76 = new Questao();
        Q76.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q76.Pergunta = "Qual é o nome do tratado que pôs fim à Primeira Guerra Mundial?";
        Q76.Resposta01 = "Tratado de Paris";
        Q76.Resposta02 = "Tratado de Versalhes";
        Q76.Resposta03 = "Tratado de Tordesilhas";
        Q76.Resposta04 = "Tratado de Lisboa";
        Q76.Resposta05 = "Tratado de Genebra";
        Q76.RespostaCerta = 2;
        Q76.Nivel = 6;
        ListaQuestoes.Add(Q76);

        var Q77 = new Questao();
        Q77.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q77.Pergunta = "Quem foi o autor de 'O Pequeno Príncipe'?";
        Q77.Resposta01 = "Antoine de Saint-Exupéry";
        Q77.Resposta02 = "Jules Verne";
        Q77.Resposta03 = "Victor Hugo";
        Q77.Resposta04 = "Jean-Paul Sartre";
        Q77.Resposta05 = "Albert Camus";
        Q77.RespostaCerta = 1;
        Q77.Nivel = 6;
        ListaQuestoes.Add(Q77);

        var Q78 = new Questao();
        Q78.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q78.Pergunta = "Qual é a montanha mais alta da América do Sul?";
        Q78.Resposta01 = "Monte Roraima";
        Q78.Resposta02 = "Monte Aconcágua";
        Q78.Resposta03 = "Monte Chimborazo";
        Q78.Resposta04 = "Monte Cotopaxi";
        Q78.Resposta05 = "Monte Fitz Roy";
        Q78.RespostaCerta = 2;
        Q78.Nivel = 6;
        ListaQuestoes.Add(Q78);

        var Q79 = new Questao();
        Q79.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q79.Pergunta = "Qual país é conhecido como a terra do sol nascente?";
        Q79.Resposta01 = "China";
        Q79.Resposta02 = "Japão";
        Q79.Resposta03 = "Coreia do Sul";
        Q79.Resposta04 = "Tailândia";
        Q79.Resposta05 = "Filipinas";
        Q79.RespostaCerta = 2;
        Q79.Nivel = 6;
        ListaQuestoes.Add(Q79);

        var Q80 = new Questao();
        Q80.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q80.Pergunta = "Em qual país o idioma mandarim é a língua oficial?";
        Q80.Resposta01 = "Japão";
        Q80.Resposta02 = "China";
        Q80.Resposta03 = "Tailândia";
        Q80.Resposta04 = "Coreia do Norte";
        Q80.Resposta05 = "Vietnã";
        Q80.RespostaCerta = 2;
        Q80.Nivel = 6;
        ListaQuestoes.Add(Q80);

        var Q81 = new Questao();
        Q81.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q81.Pergunta = "Quem foi o autor de 'Odisseia'?";
        Q81.Resposta01 = "Sófocles";
        Q81.Resposta02 = "Eurípedes";
        Q81.Resposta03 = "Homero";
        Q81.Resposta04 = "Platão";
        Q81.Resposta05 = "Aristóteles";
        Q81.RespostaCerta = 3;
        Q81.Nivel = 6;
        ListaQuestoes.Add(Q81);

        var Q82 = new Questao();
        Q82.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q82.Pergunta = "Quem foi o 16º presidente dos Estados Unidos?";
        Q82.Resposta01 = "Theodore Roosevelt";
        Q82.Resposta02 = "George Washington";
        Q82.Resposta03 = "Abraham Lincoln";
        Q82.Resposta04 = "Thomas Jefferson";
        Q82.Resposta05 = "John F. Kennedy";
        Q82.RespostaCerta = 3;
        Q82.Nivel = 6;
        ListaQuestoes.Add(Q82);

        var Q83 = new Questao();
        Q83.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q83.Pergunta = "Quem pintou o teto da Capela Sistina?";
        Q83.Resposta01 = "Leonardo da Vinci";
        Q83.Resposta02 = "Michelangelo";
        Q83.Resposta03 = "Raphael";
        Q83.Resposta04 = "Donatello";
        Q83.Resposta05 = "Sandro Botticelli";
        Q83.RespostaCerta = 2;
        Q83.Nivel = 6;
        ListaQuestoes.Add(Q83);

        var Q84 = new Questao();
        Q84.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q84.Pergunta = "Em que país fica a Torre Eiffel?";
        Q84.Resposta01 = "Itália";
        Q84.Resposta02 = "Espanha";
        Q84.Resposta03 = "França";
        Q84.Resposta04 = "Alemanha";
        Q84.Resposta05 = "Inglaterra";
        Q84.RespostaCerta = 3;
        Q84.Nivel = 6;
        ListaQuestoes.Add(Q84);

        var Q85 = new Questao();
        Q85.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q85.Pergunta = "Quem descobriu o Brasil em 1500?";
        Q85.Resposta01 = "Cristóvão Colombo";
        Q85.Resposta02 = "Vasco da Gama";
        Q85.Resposta03 = "Pedro Álvares Cabral";
        Q85.Resposta04 = "Ferdinando Magalhães";
        Q85.Resposta05 = "Américo Vespúcio";
        Q85.RespostaCerta = 3;
        Q85.Nivel = 6;
        ListaQuestoes.Add(Q85);

        var Q86 = new Questao();
        Q86.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q86.Pergunta = "Qual animal é conhecido como o rei da selva?";
        Q86.Resposta01 = "Tigre";
        Q86.Resposta02 = "Leão";
        Q86.Resposta03 = "Elefante";
        Q86.Resposta04 = "Gorila";
        Q86.Resposta05 = "Urso";
        Q86.RespostaCerta = 2;
        Q86.Nivel = 6;
        ListaQuestoes.Add(Q86);

        var Q87 = new Questao();
        Q87.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q87.Pergunta = "Em que país fica a Muralha da China?";
        Q87.Resposta01 = "Coreia do Sul";
        Q87.Resposta02 = "Japão";
        Q87.Resposta03 = "Mongólia";
        Q87.Resposta04 = "China";
        Q87.Resposta05 = "Vietnã";
        Q87.RespostaCerta = 4;
        Q87.Nivel = 6;
        ListaQuestoes.Add(Q87);

        var Q88 = new Questao();
        Q88.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q88.Pergunta = "Quem é conhecido como o Pai da Aviação?";
        Q88.Resposta01 = "Irmãos Wright";
        Q88.Resposta02 = "Alberto Santos Dumont";
        Q88.Resposta03 = "Charles Lindbergh";
        Q88.Resposta04 = "Amelia Earhart";
        Q88.Resposta05 = "Leonardo da Vinci";
        Q88.RespostaCerta = 2;
        Q88.Nivel = 6;
        ListaQuestoes.Add(Q88);

        var Q89 = new Questao();
        Q89.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q89.Pergunta = "Qual é o maior deserto do mundo?";
        Q89.Resposta01 = "Deserto do Atacama";
        Q89.Resposta02 = "Deserto do Saara";
        Q89.Resposta03 = "Deserto da Arábia";
        Q89.Resposta04 = "Deserto de Gobi";
        Q89.Resposta05 = "Antártida";
        Q89.RespostaCerta = 5;
        Q89.Nivel = 6;
        ListaQuestoes.Add(Q89);

        var Q90 = new Questao();
        Q90.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q90.Pergunta = "Em que país fica o Coliseu?";
        Q90.Resposta01 = "França";
        Q90.Resposta02 = "Espanha";
        Q90.Resposta03 = "Itália";
        Q90.Resposta04 = "Grécia";
        Q90.Resposta05 = "Alemanha";
        Q90.RespostaCerta = 3;
        Q90.Nivel = 6;
        ListaQuestoes.Add(Q90);

        var Q91 = new Questao();
        Q91.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q91.Pergunta = "Qual metal tem como símbolo 'Fe'?";
        Q91.Resposta01 = "Ferro";
        Q91.Resposta02 = "Ouro";
        Q91.Resposta03 = "Prata";
        Q91.Resposta04 = "Cobre";
        Q91.Resposta05 = "Chumbo";
        Q91.RespostaCerta = 1;
        Q91.Nivel = 6;
        ListaQuestoes.Add(Q91);

        var Q92 = new Questao();
        Q92.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q92.Pergunta = "Quem é o criador do personagem Sherlock Holmes?";
        Q92.Resposta01 = "Agatha Christie";
        Q92.Resposta02 = "Arthur Conan Doyle";
        Q92.Resposta03 = "Edgar Allan Poe";
        Q92.Resposta04 = "J.K. Rowling";
        Q92.Resposta05 = "Mark Twain";
        Q92.RespostaCerta = 2;
        Q92.Nivel = 6;
        ListaQuestoes.Add(Q92);

        var Q93 = new Questao();
        Q93.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q93.Pergunta = "Quem foi o primeiro homem a pisar na Lua?";
        Q93.Resposta01 = "Buzz Aldrin";
        Q93.Resposta02 = "Yuri Gagarin";
        Q93.Resposta03 = "Neil Armstrong";
        Q93.Resposta04 = "John Glenn";
        Q93.Resposta05 = "Michael Collins";
        Q93.RespostaCerta = 3;
        Q93.Nivel = 6;
        ListaQuestoes.Add(Q93);

        var Q94 = new Questao();
        Q94.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q94.Pergunta = "Qual é a fórmula química da água?";
        Q94.Resposta01 = "H2O";
        Q94.Resposta02 = "CO2";
        Q94.Resposta03 = "O2";
        Q94.Resposta04 = "H2SO4";
        Q94.Resposta05 = "NaCl";
        Q94.RespostaCerta = 1;
        Q94.Nivel = 6;
        ListaQuestoes.Add(Q94);

        var Q95 = new Questao();
        Q95.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q95.Pergunta = "Qual é o maior mamífero terrestre?";
        Q95.Resposta01 = "Elefante";
        Q95.Resposta02 = "Hipopótamo";
        Q95.Resposta03 = "Girafa";
        Q95.Resposta04 = "Rinoceronte";
        Q95.Resposta05 = "Baleia Azul";
        Q95.RespostaCerta = 1;
        Q95.Nivel = 6;
        ListaQuestoes.Add(Q95);

        var Q96 = new Questao();
        Q96.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q96.Pergunta = "Qual é a moeda oficial dos Estados Unidos?";
        Q96.Resposta01 = "Libra Esterlina";
        Q96.Resposta02 = "Euro";
        Q96.Resposta03 = "Dólar";
        Q96.Resposta04 = "Iene";
        Q96.Resposta05 = "Peso";
        Q96.RespostaCerta = 3;
        Q96.Nivel = 6;
        ListaQuestoes.Add(Q96);

        var Q97 = new Questao();
        Q97.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q97.Pergunta = "Em qual país aconteceu a Revolução Francesa?";
        Q97.Resposta01 = "Espanha";
        Q97.Resposta02 = "Portugal";
        Q97.Resposta03 = "França";
        Q97.Resposta04 = "Alemanha";
        Q97.Resposta05 = "Itália";
        Q97.RespostaCerta = 3;
        Q97.Nivel = 6;
        ListaQuestoes.Add(Q97);

        var Q98 = new Questao();
        Q98.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q98.Pergunta = "Quantos planetas compõem o Sistema Solar?";
        Q98.Resposta01 = "7";
        Q98.Resposta02 = "8";
        Q98.Resposta03 = "9";
        Q98.Resposta04 = "10";
        Q98.Resposta05 = "11";
        Q98.RespostaCerta = 2;
        Q98.Nivel = 6;
        ListaQuestoes.Add(Q98);

        var Q99 = new Questao();
        Q99.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q99.Pergunta = "Qual é o nome do ponto mais alto da Terra?";
        Q99.Resposta01 = "Everest";
        Q99.Resposta02 = "K2";
        Q99.Resposta03 = "Kangchenjunga";
        Q99.Resposta04 = "Lhotse";
        Q99.Resposta05 = "Makalu";
        Q99.RespostaCerta = 1;
        Q99.Nivel = 6;
        ListaQuestoes.Add(Q99);

        var Q100 = new Questao();
        Q100.ConfiguraDesenho(labelPergunta, BtnResp1, BtnResp2, BtnResp3, BtnResp4, BtnResp5);
        Q100.Pergunta = "Em que ano terminou a Segunda Guerra Mundial?";
        Q100.Resposta01 = "1943";
        Q100.Resposta02 = "1944";
        Q100.Resposta03 = "1945";
        Q100.Resposta04 = "1946";
        Q100.Resposta05 = "1947";
        Q100.RespostaCerta = 3;
        Q100.Nivel = 6;
        ListaQuestoes.Add(Q100);

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

    public void ProximaQuestao()
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

    public Questao GetQuestaoCorrente()
    {
        return QuestaoCorrente;
    }

}


