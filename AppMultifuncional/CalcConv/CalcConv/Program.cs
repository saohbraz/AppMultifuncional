// See https://aka.ms/new-console-template for more information

namespace AppMultifuncional
{
    class Program
    {
        static void Main(string[] args)
        {
            int operador;
            int v1, v2; //O valor 1 e valor 2 simplifiquei para v1 e v2
            string resposta = "";
            double a, b, c, x1, x2, x;
            double delta, raiz;
            double valor1= 0, valor2= 0, resultado, numero;
            double iof = 6.0;
            double cc, f, k;
            double peso, altura, imc;
            double salario_minimo, salario;
            string funcao, conversao;
            string valorDigitado;
            int idadee, tempoContribuicao, anoNascimento;
            string nomeUsuario, sexo, resp = "";
            bool validacao = true;
            bool isNumeroInteiro;

            Program program = new Program();

            do
            {
                Console.Title = "APP MULTIFUNCIONAL";
                Console.WriteLine("============ O MELHOR APP MULTIFUNCIONAL DO MUNDO ==================== ");
                Console.WriteLine("============ (SE FOR NÚMERO DECIMAL (USE PONTO) ==================== ");
                Console.WriteLine("O que você deseja utilizar?");
                Console.WriteLine("(1) Usar Calculadora Simples");
                Console.WriteLine("(2) Usar Conversão de Moedas");
                Console.WriteLine("(3) Usar Conversor de temperaturas");
                Console.WriteLine("(4) Calcular o seu IMC!");
                Console.WriteLine("(5) Usar Calculadora de Bhaskara");
                Console.WriteLine("(6) Descubra quantos meses, dias, horas e minutos você já viveu!");
                Console.WriteLine("(7) INSS Simulação de Aposentadoria Por idade!!");
                Console.WriteLine("(8) Confira quantos salários mínimos você recebe!!");
                Console.WriteLine("(9) SAIR");

                Console.WriteLine("\nDigite sua opção: ");
                operador = Convert.ToInt32(Console.ReadLine());

                switch (operador)
                {
                    case 1:

                        Console.WriteLine("Escreva o primeiro valor: "); v1 = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("Insira a opção desejada: ");
                        Console.WriteLine("Para soma digite (+) no console");
                        Console.WriteLine("Para subtração digite (-) no console");
                        Console.WriteLine("Para multiplicação digite (x) no console");
                        Console.WriteLine("Para divisão digite (/) no console");
                        funcao = Console.ReadLine()!;

                        if (funcao == "+")
                        {
                            Console.WriteLine("Escreva o segundo valor: ");
                            v2 = int.Parse(Console.ReadLine()!);

                            Console.WriteLine("{0} + {1} = {2}\n", v1, v2, v1 + v2);
                        }
                        if (funcao == "/")
                        {
                            Console.WriteLine("Escreva o segundo valor: ");
                            v2 = int.Parse(Console.ReadLine()!);

                            Console.WriteLine("{0} / {1} = {2}\n", v1, v2, v1 / v2);
                        }
                        if (funcao == "x")
                        {
                            Console.WriteLine("Escreva o segundo valor: ");
                            v2 = int.Parse(Console.ReadLine()!);

                            Console.WriteLine("{0} * {1} = {2}\n", v1, v2, v1 * v2);
                        }
                        if (funcao == "-")
                        {
                            Console.WriteLine("Escreva o segundo valor: ");
                            v2 = int.Parse(Console.ReadLine()!);

                            Console.WriteLine("{0} - {1} = {2}\n", v1, v2, v1 - v2);
                        }
                        break;

                    case 2:

                        Console.WriteLine("Digite o síbolo da moeda que deseja comprar: \nDolar: USD\nEuro: EUR");
                        conversao = Console.ReadLine()!;

                        Console.WriteLine("Quantos em reais você usará para comprar a moeda desejada? ");
                        valorDigitado = Console.ReadLine()!;

                        isNumeroInteiro = double.TryParse(valorDigitado, out numero);

                        if (isNumeroInteiro)
                        {
                            valor1 = Math.Round(double.Parse(valorDigitado), 2);
                        }
                        else
                        {
                            Console.WriteLine("Quantos em reais você usará para comprar a moeda desejada? ");
                        }
                        Console.WriteLine("Qual a cotação da moeda escolhida, Hoje?: ");
                        valorDigitado = Console.ReadLine()!;
                        isNumeroInteiro = double.TryParse(valorDigitado, out numero);
                        if (isNumeroInteiro)
                        {
                            valor2 = Math.Round(double.Parse(valorDigitado), 2);
                        }
                        else
                        {
                            Console.WriteLine("Qual a cotação da moeda escolhida, Hoje?: ");
                        }
                        //Suponha que você tem R$ 1.000, precisa converter para Dólar, cotado em R$ 5, o cálculo é esse: 1.000 ÷ 5 = USD 200.

                        if (conversao == "USD")
                        {
                            resultado = Math.Round(valor1 / valor2, 2);
                            Console.WriteLine($"{ valor1 } {"/"} { valor2 } = {resultado + resultado * (iof / 100.0):0.##} dolares\n");
                        }
                        if (conversao == "EUR")
                        {
                            resultado = Math.Round(valor1 / valor2, 2);
                            Console.WriteLine($"{ valor1 } {"/"} { valor2 } = {resultado + resultado * (iof / 100.0):0.##} euros \n");
                        }
                        break;

                    case 3:

                        Console.WriteLine("\n####### Conversor de temperaturas #######\n");
                        Console.Write("Insira a temperatura em Celsius: ");
                        cc = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("\n--------------------------------------------------");

                        //Calculo de C para F  //(c * 9 / 5) + 32 = F
                        f = (cc * 9 / 5) + 32;

                        //Calculo de C para K  //c + 273,15
                        k = cc + 273.15;

                        Console.WriteLine(cc + " graus celsius = " + f + " graus fahrenheit");
                        Console.WriteLine(cc + " graus celsius = " + k + " graus kelvin");
                        Console.WriteLine("--------------------------------------------------\n");

                        break;

                    case 4:

                        Console.WriteLine("\n####### Calculadora de IMC! #######\n");
                        Console.WriteLine("Digite seu peso:");
                        peso = double.Parse(Console.ReadLine()!);
                        Console.WriteLine("Digite sua altura: (exemplo: 1.58)");
                        altura = double.Parse(Console.ReadLine()!);

                        imc = peso/(altura*altura);

                        Console.WriteLine("Seu indice de massa coporal é: " + imc.ToString("F2"));

                        if (imc < 18.5)
                        {
                            Console.WriteLine("\n===> Abaixo do peso!\n");
                        }
                        else if (imc <= 24.9)
                        {
                            Console.WriteLine("\n===> Peso normal!\n");
                        }
                        else if (imc <= 29.9)
                        {
                            Console.WriteLine("\n===> Acima do peso(Sobrepeso)!\n");
                        }
                        else if (imc <= 34.9)
                        {
                            Console.WriteLine("\n===> Obesidade I!\n");
                        }
                        else if (imc <= 39.9)
                        {
                            Console.WriteLine("\n===> Obesidade II!\n");
                        }
                        else
                        {
                            Console.WriteLine("\n===> Obesidade III!\n");
                        }
                        break;

                    case 5:

                        Console.WriteLine("========Calculadora de Bhaskara========");

                        Console.WriteLine("Algum valor esta em decimal (Sim ou Não)");
                        resposta = Convert.ToString(Console.ReadLine()!);

                        if (resposta == "Sim" || resposta == "sim")
                        {           //SE FOR EM DECINMAL (NUMERO COM VIRGULA (ponto))

                            Console.WriteLine("Digite o valor de A, B e C");
                            a = Convert.ToDouble(Console.ReadLine());
                            b = Convert.ToDouble(Console.ReadLine());
                            c = Convert.ToDouble(Console.ReadLine());

                            delta = (Math.Pow(b, 2.0) - (4 * a * c)) / (2.0 * a);
                            raiz = (Math.Sqrt(delta));

                            if (delta > 0)
                            {
                                x1 = (-b + raiz) / (2.0 * a);
                                x2 = (-b - raiz) / (2.0 * a);

                                Console.WriteLine("Valor do x1 é {0}", x1);
                                Console.WriteLine("valor do x2 é {0}", x2);
                            }
                            else if (delta == 0)
                            {
                                x = (-b + raiz) / (2.0 * a);
                                Console.WriteLine("Valor do x1 é {0}", x);
                            }
                            else
                            {
                                Console.WriteLine("O delta deu {0}, é menor que 0 então não tem raiz\n", delta);
                            }
                            //-----------------------------------------
                        }
                        else   //NUMERO INTEIRO (NUMERO SEM VIRGULA (ponto))
                        {     
                            Console.WriteLine("\nDigite o valor de A (aperte enter), digite o valor de B (aperte enter), digite o valor de C (aperte enter)");
                            a = Convert.ToInt32(Console.ReadLine());
                            b = Convert.ToInt32(Console.ReadLine());
                            c = Convert.ToInt32(Console.ReadLine());

                            delta = (b * b) - (4 * a * c) / (2 * a);
                            raiz = Math.Sqrt(delta);

                            if (delta > 0)
                            {
                                x1 = ((-(b)) + raiz) / (2 * a);
                                x2 = ((-(b)) - raiz) / (2 * a);

                                Console.WriteLine("\nValor do x1 é {0}", Convert.ToInt32(x1));
                                Console.WriteLine("valor do x2 é {0}", Convert.ToInt32(x2));
                            }
                            else if (delta == 0)
                            {
                                x1 = ((-(b)) + raiz) / (2.0 * a);

                                Console.WriteLine("Valor do x1 é {0}", Convert.ToInt32(x1));
                            }
                            else
                            {
                                Console.WriteLine("O delta deu {0}, é menor que 0 então não tem raiz\n", delta);
                            }
                        }
                        break;

                    case 6:
                        {
                            {
                                Console.WriteLine("========Contador de idade========\n");
                                Console.WriteLine("Digite sua idade ");

                                //       ENTRADA
                                int idade = int.Parse(Console.ReadLine()!);

                                //       PROCESSAMENTO
                                int meses = idade * 12;
                                int dias = idade * 365;
                                int horas = dias * 24;
                                int minutos = horas * 60;

                                Console.WriteLine("\nVoce ja viveu: ");
                                Console.WriteLine("Meses: {0}", meses);
                                Console.WriteLine("Dias: " + dias);
                                Console.WriteLine("Horas: " + horas);
                                Console.WriteLine("Minutos: " + minutos);
                            }
                        }
                        break;

                    case 7:

                        do
                        {
                            Console.WriteLine("|======== INSS Simulação de Aposentadoria Por idade ========|");
                            Console.Write("| Informe seu nome: ");
                            nomeUsuario = Console.ReadLine()!;
                            Console.Write("| Digite o ano de nacimento com quatro digitos: ");
                            anoNascimento = int.Parse(Console.ReadLine()!);
                            Console.Write("| Digite tempo de contribuição: ");
                            tempoContribuicao = int.Parse(Console.ReadLine()!);
                            Console.Write("| Qual o seu sexo [m/f]: ");
                            sexo = Console.ReadLine()!;
                            Console.WriteLine("|===========================================================|");
                            idadee = 2022 - anoNascimento;

                            if (idadee >= 62 && tempoContribuicao >= 15 && sexo == "f")
                            {
                                Console.WriteLine("|-----------------------------------------------------------------|");
                                Console.WriteLine($"| {nomeUsuario} a sra podera dar entrada na Aponsetadoria por idade |");
                                Console.WriteLine("|-----------------------------------------------------------------|");
                            }
                            else if (idadee >= 65 && tempoContribuicao >= 20 && sexo == "m")
                            {
                                Console.WriteLine("|-----------------------------------------------------------------|");
                                Console.WriteLine($"| {nomeUsuario} o sr podera dar entrada na Aponsetadoria por idade  |");
                                Console.WriteLine("|-----------------------------------------------------------------|");
                            }
                            else if (idadee <= 65 && tempoContribuicao < 15 && sexo == "f" || sexo == "m")
                            {
                                Console.WriteLine("|--------------------------------------------------------------------|");
                                Console.WriteLine("| Sem direito para aposentadoria por idade.                           |");
                                Console.WriteLine("|--------------------------------------------------------------------|");
                            }
                            else
                            {
                                Console.WriteLine("|---------------------------|");
                                Console.WriteLine("| Reveja os dados digitados");
                                Console.WriteLine("|---------------------------|");
                            }

                            Console.Write("|\t\tDeseja continuar? [s/]n:");

                            resp = Console.ReadLine()!;
                            Console.Clear();
                        }
                        while (resp != "n");

                        break;

                    case 8:

                        Console.WriteLine("|======== Saiba quantos Salários Mínimos você recebe ========|");
                        Console.WriteLine("\nDigite seu salário: ");
                        salario = Convert.ToDouble(Console.ReadLine());

                        salario_minimo = 1212;
                        resultado = program.Salario(salario, salario_minimo);
                        Console.WriteLine("\n=> O seu salário equilave a {0} salários mínimos!!\n", Math.Round(resultado, 2));

                        break;

                    case 9:

                        validacao = false;
                        Console.WriteLine("\nAperte ENTER para sair");
                        break;
                }
                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (validacao);
        }
        public double funcao(double v1, double v2)
        {
            return 2;
        }
        public double Salario(double salario, double salario_minimo)
        {
            return salario / salario_minimo;
        }
    }
}
