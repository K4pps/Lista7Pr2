using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 1, i;
            while (j != 0)
            {
                //Menu

                int exec;
                Console.WriteLine("Menu:");

                Console.WriteLine("\nExercicio 1");

                Console.WriteLine("Exercicio 2");

                Console.WriteLine("Exercicio 3");

                Console.WriteLine("Exercicio 4");

                Console.WriteLine("Exercicio 5");

                Console.WriteLine("Exercicio 6");

                Console.WriteLine("Exercicio 7");

                exec = int.Parse(Console.ReadLine());

                switch (exec)

                {


                    case 1:

                        int quantidade, para = 4;

                        double preço, tot1, tot2 = 0;

                        i = 0;
                        while (true)
                        {
                            Console.WriteLine("Digite a quantidade dos produtos: ");
                            quantidade = int.Parse(Console.ReadLine());

                            if (quantidade == 0)
                            {
                                break;
                            }
                            Console.WriteLine("Digite o preço do produto: ");
                            preço = double.Parse(Console.ReadLine());

                            tot1 = quantidade * preço;
                            tot2 = tot1 + tot2;
                            i++;

                            Console.WriteLine("Digite 0 para SAIR e 2 para continuar");
                            para = int.Parse(Console.ReadLine());

                        }

                        Console.WriteLine("Suas compra deu um total de {0} reais ", tot2);
                        break;

                    case 2:

                        int NumItens, parada = 2;
                        float valor, Valormaior, Valormenor;
                        string nome, NmMe = "", NmMa = "";

                        Valormaior = float.MinValue;
                        Valormenor = float.MaxValue;

                        while (parada != 1)
                        {
                            Console.WriteLine("Digite o nome do pruduto: ");
                            nome = Console.ReadLine();

                            Console.WriteLine("Digite a quantidade de produtos: ");
                            NumItens = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o preço do produto:");
                            valor = float.Parse(Console.ReadLine());

                            float total = NumItens * valor;
                            if (total > Valormaior)
                            {
                                Valormaior = total;
                                NmMa = nome;
                            }

                            if (total < Valormenor)
                            {
                                Valormenor = total;
                                NmMe = nome;
                            }
                            Console.WriteLine("Digite 0 para SAIR ou 2 para Prosseguir");
                            parada = int.Parse(Console.ReadLine());


                        }
                        Console.WriteLine("Quantia maior investida {0} no produto {1} ", Valormaior, NmMa);
                        Console.WriteLine("Quantia menor investida {0} no produto {1} ", Valormenor, NmMe);
                        break;

                    case 3:
                        int somapesoav = 0, pesoava, totalava;

                        Console.WriteLine("Digite o total de avaliações do bimestre:");
                        totalava = int.Parse(Console.ReadLine());

                        if (totalava <= 0)
                            Console.WriteLine("Nº de avaliações inválido!");
                        i = 0;
                        while (i < totalava)
                        {
                            Console.WriteLine("Infome o peso da avalição {0}", i + 1);
                            pesoava = int.Parse(Console.ReadLine());

                            somapesoav += pesoava;
                            i++;
                        }

                        if (somapesoav < 100)
                            Console.WriteLine("O peso final das avalições não é suficiente!");
                        else if (somapesoav > 100)
                            Console.WriteLine("O peso final das avaliações é acima!");
                        else
                            Console.WriteLine("O peso final das avaliações é adequado.");
                        break;

                    case 4:

                        string sga;
                        Console.WriteLine("\nAM");

                        Console.WriteLine("AC");

                        Console.WriteLine("AL");

                        Console.WriteLine("AP");

                        Console.WriteLine("BA");

                        Console.WriteLine("CE");

                        Console.WriteLine("ES");

                        Console.WriteLine("GO");

                        Console.WriteLine("MA");

                        Console.WriteLine("MT");

                        Console.WriteLine("MS");

                        Console.WriteLine("MG");

                        Console.WriteLine("PA");

                        Console.WriteLine("PB");

                        Console.WriteLine("PR");

                        Console.WriteLine("RR");

                        Console.WriteLine("SC");

                        Console.WriteLine("SE");

                        Console.WriteLine("TO");

                        Console.WriteLine("DF");

                        Console.WriteLine("PE");

                        Console.WriteLine("PI");

                        Console.WriteLine("RJ");

                        Console.WriteLine("RN");

                        Console.WriteLine("RS");

                        Console.WriteLine("RO");

                        Console.WriteLine("\nDigite a sigla de sua escolha: ");
                        sga = Console.ReadLine();

                        switch (sga)
                        {
                            case "AM":
                                Console.WriteLine("Amazonas");
                                break;

                            case "AL":
                                Console.WriteLine("Alagoas");
                                break;

                            case "AC":
                                Console.WriteLine("Acre");
                                break;


                            case "AP":
                                Console.WriteLine("Amapa");
                                break;

                            case "BA":
                                Console.WriteLine("Bahia");
                                break;

                            case "CE":
                                Console.WriteLine("Ceara");
                                break;

                            case "ES":
                                Console.WriteLine("Espirito Santo ");
                                break;

                            case "GO":
                                Console.WriteLine("Goias");
                                break;

                            case "MA":
                                Console.WriteLine("Maranhao");
                                break;

                            case "MT":
                                Console.WriteLine("Mato Grosso");
                                break;

                            case "MS":
                                Console.WriteLine("Mato Grosso do sul");
                                break;

                            case "MG":
                                Console.WriteLine("Minas Gerais");
                                break;

                            case "PA":
                                Console.WriteLine("Paraiba");
                                break;

                            case "PR":
                                Console.WriteLine("Parana");
                                break;

                            case "PE":
                                Console.WriteLine("Pernambuco");
                                break;

                            case "RJ":
                                Console.WriteLine("Rio de Janeiro");
                                break;

                            case "PI":
                                Console.WriteLine("Piaui");
                                break;

                            case "RN":
                                Console.WriteLine("Rio Grande do Norte");
                                break;

                            case "RO":
                                Console.WriteLine("Rondonia");
                                break;

                            case "RS":
                                Console.WriteLine("Rio Grande do Sul");
                                break;

                            case "RR":
                                Console.WriteLine("Roraima");
                                break;

                            case "SC":
                                Console.WriteLine("Santa Catrina");
                                break;

                            case "SE":
                                Console.WriteLine("Sergipe");
                                break;

                            case "DF":
                                Console.WriteLine("Distrito Federal");
                                break;


                            case "TO":
                                Console.WriteLine("Tocantins");
                                break;

                            default:
                                Console.WriteLine("Sigla não reconhecida");
                                break;
                        }
                        break;

                    case 5:

                        int mês, dia;
                        string estacAno = "";
                        Console.WriteLine("01 - Janeiro");

                        Console.WriteLine("02 - Fevereiro");

                        Console.WriteLine("03 - Marco");

                        Console.WriteLine("04 - Abril");
 
                        Console.WriteLine("05 - Maio");

                        Console.WriteLine("06 - Junho");

                        Console.WriteLine("07 - Julho");

                        Console.WriteLine("08 - Agosto");

                        Console.WriteLine("09 - Setembro");

                        Console.WriteLine("010 - Outubro");

                        Console.WriteLine("011 - Novembro");

                        Console.WriteLine("012 - Dezembro");

                        Console.WriteLine("Qual o mês de sua escolha?");
                        mês = int.Parse(Console.ReadLine());

                        switch (mês)


                        {
                            case 1:
                            case 2:
                                estacAno = "Verao";
                                break;
                            case 3:
                                Console.WriteLine("Digite o dia do mês:");
                                dia = int.Parse(Console.ReadLine());

                                if (dia < 21) estacAno = "Verao";
                                else estacAno = "Outono";
                                break;

                            case 4:
                            case 5:
                                estacAno = "Outono";
                                break;
                            case 6:
                                Console.WriteLine("Digite o dia do mês:");
                                dia = int.Parse(Console.ReadLine());

                                if (dia >= 21) estacAno = "Inverno";
                                else estacAno = "Outono";
                                break;
                            case 7:
                            case 8:
                                estacAno = "Inverno";
                                break;
                            case 9:
                                Console.WriteLine("Digite o dia do mês:");
                                dia = int.Parse(Console.ReadLine());

                                if (dia >= 23) estacAno = "Primavera";
                                else estacAno = "Inverno";
                                break;
                            case 10:
                            case 11:
                                estacAno = "Primavera";
                                break;
                            case 12:
                                Console.WriteLine("Digite o dia do mês:");
                                dia = int.Parse(Console.ReadLine());

                                if (dia >= 22) estacAno = "Verão";
                                else estacAno = "Primavera";
                                break;
                        }
                        Console.WriteLine("A estacão do ano correspondente é {0}", estacAno);
                        Console.ReadKey();
                        break;

                    case 6:

                        float peso, imc, altura;
                        Console.WriteLine("Digite o seu peso:");

                        peso = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a sua altura:");

                        altura = float.Parse(Console.ReadLine());

                        imc = peso / altura * altura;


                        if (imc <= 18.5)
                            Console.WriteLine("Abaixo do peso!");

                        else if (imc <= 24.9 && imc >= 18.5)
                            Console.WriteLine("Peso normal!");

                        else if (imc >= 25 && imc <= 29.5)
                            Console.WriteLine("Acima do peso!");

                        else if (imc >= 30 && imc <= 34.9)
                            Console.WriteLine("Obesidade nivel 1!");

                        else if (imc >= 35 && imc <= 39.9)
                            Console.WriteLine("Obsedidade nivel 2!");

                        else
                            Console.WriteLine("Obsediade nivel 3 (morbida)!");
                        break;

                    case 7:
                        int num;
                        Console.WriteLine("Digite um número:");
                        num = int.Parse(Console.ReadLine());

                        if (num <= 0)
                            Console.WriteLine("O número escolhido deve ser maior que 0!");

                        string divisores = "";

                        i = 1;
                        while (i < num + 1)
                        {
                            if (num % i == 0) divisores += i + " ";
                            i++;
                        }
                        break;

                    default:
                        Console.WriteLine("Exercicio não é valido!!");

                        Console.WriteLine("Continuar digite 1 para sim e 0 para não!! ");
                        j = int.Parse(Console.ReadLine());

                        break;
                }

            }
        }
    }
}


