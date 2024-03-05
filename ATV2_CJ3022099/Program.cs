namespace ATV2_CJ3022099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // projeto 1 
            /*
            float novo_salario, salario;

            Console.WriteLine("Qual é o salário do funcionário?");
                salario = float.Parse(Console.ReadLine());
                novo_salario = (salario / 100) * 25;
                salario += novo_salario;
 
            Console.WriteLine("O novo salário é de:R${0}", salario);

            // Projeto 2 
            Console.WriteLine(  );
            int n, n1, n2, soma;

            Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());

            n1 = n * 3 +1;
            n2 = n * 2 - 1;
            soma = n1 + n2;

            Console.WriteLine("A soma dos valores são:{0}", soma);

            // Projeto 3 
            Console.WriteLine();
            float valor, valor2;
          
            Console.WriteLine("O valor inicial do seu investimento é de R$1000,00.");

            valor = 1000;
            valor2 = (valor / 100) * 3.4f;
            valor -= valor2;
            valor2 = (valor/100) *2.8f;
            valor += valor2;
            valor2 = (valor / 100) * 14;
            valor += valor2;
            valor2 = (valor / 100) * 8.5f;
            valor -= valor2;

            Console.WriteLine("0 valor atual dos seus investimentos é de:{0}", valor);


            //lista (exercicio 1)
            Console.WriteLine();
            float metros, centi, mili;

            Console.WriteLine("Digite um valor em metros:");
                metros = float.Parse(Console.ReadLine());

            centi = metros * 100;
            mili = metros * 1000;

            Console.WriteLine("O valor em centimetros será de {0} e em milimetros será de {1}", centi, mili);
            
            //Lista(exercicio 2)
            Console.WriteLine();
            float Fahrenheit, Celcius;

            Console.WriteLine("Nos informe a temperatura em graus  Fahrenheit: ");
                Fahrenheit = float.Parse(Console.ReadLine());

            Celcius = (Fahrenheit - 32.0f) * (5.0f / 9.0f);
            Console.WriteLine("O  valor correspondente em graus Celsius é de {0:F2}",Celcius);

            Console.WriteLine();
            int fahr, Cel;

            Console.WriteLine("Nos informe novamente a temperatura em graus  Fahrenheit: ");
            fahr = int.Parse (Console.ReadLine());

            Cel = (fahr - 32) * (5 / 9);
            Console.WriteLine("O  valor correspondente em graus Celsius é de {0:F2}", Cel);

            
            //lista (Exercicio 3)
            Console.WriteLine();
            float peso, altura, imc;

            Console.WriteLine("Primeiramente informe a sua altura:");
                altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora insira o seu peso:");
                peso = float.Parse(Console.ReadLine());

            imc= peso / (float)Math.Pow(altura,2);
            Console.WriteLine("O imc (Índice de Massa Corporal) é:{0:F2}", imc);

            //lista (Exercicio 4)
            Console.WriteLine();
            
            float nu1, nu2, nu3, pe1, pe2, pe3, media1, media2, media3;

            Console.WriteLine("Digite três números separados por enter:");
                nu1 = float.Parse(Console.ReadLine());
                nu2 = float.Parse(Console.ReadLine());
                nu3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite três pesos refentes a mesma ordem dos números digitados,também separados por enter:");
                pe1 = float.Parse(Console.ReadLine());
                pe2 = float.Parse(Console.ReadLine());
                pe3 = float.Parse(Console.ReadLine());

            media1 = (nu1 * pe1) + (nu2 * pe2) + (nu3 * pe3);
            media2 = pe1 + pe2 + pe3;
            media3 = media1 / media2;

            Console.WriteLine("O resultado da media ponderada é:{0:F2}",media3);

            //lista (Exercicio 5)
            Console.WriteLine();
            float massa, volume, densidade;

            Console.WriteLine("Para realizarmos a formula da densidade, precisamos que insira o valor da massa,aperte enter e insira o valor do volume:");
                massa = float.Parse(Console.ReadLine());
                volume = float.Parse(Console.ReadLine());

            densidade = (massa / volume);
            Console.WriteLine("A medida da densidade sobre as informações fornecidas por você é de: {0:F1}",densidade);

            //lista (Exercicio 7)
            Console.WriteLine();
            float real, dolar, cotacao;

            Console.WriteLine("Digite um valor em real (R$):");
                real = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da contação do dólar:");
                dolar = float.Parse(Console.ReadLine());

            cotacao = real / dolar;
            Console.WriteLine("O valor correspondente em dólares é de:{0:F2}", cotacao);
            */
            //lista (Exercicio 9)
            Console.WriteLine();
            int numer;

            Console.WriteLine("Digite um número inteiro de 4 dígitos:");
            numer = int.Parse(Console.ReadLine());

            Console.WriteLine("Os dígitos do número são:");

            int digitoMilhar = numer / 1000;
            int digitoCentena = (numer % 1000) / 100;
            int digitoDezena = (numer % 100) / 10;
            int digitoUnidade = numer % 10;

            Console.WriteLine(digitoMilhar);
            Console.WriteLine(digitoCentena);
            Console.WriteLine(digitoDezena);
            Console.WriteLine(digitoUnidade);
            /*
            //lista (Exercicio 11)
            Console.WriteLine();
            float nume,quadra, cubo;

            Console.WriteLine("Digite um número:");
                nume = float.Parse(Console.ReadLine());

            quadra = (float)Math.Pow(nume, 2);
            cubo = (float)Math.Pow(nume, 3);

            Console.WriteLine("O quadrado do número que você digitou é:{0}",quadra);
            Console.WriteLine("O cubo do número que você digitou é:{0}", cubo);
            */
            //lista (Exercicio 12)
            Console.WriteLine();
            float altura, pesoIdeal;
            char sexo;

            Console.WriteLine("Digite a altura em metros:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo (M para masculino, F para feminino):");
            sexo = char.Parse(Console.ReadLine());


            if (sexo == 'M' || sexo == 'm')
            {
                pesoIdeal = (72.7f * altura) - 58;
                Console.WriteLine($"O peso ideal para um homem com altura {altura}m é {pesoIdeal}kg.");
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                pesoIdeal = (62.1f * altura) - 44.7f;
                Console.WriteLine($"O peso ideal para uma mulher com altura {altura}m é {pesoIdeal:F2}kg.");
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, digite M para masculino ou F para feminino.");
            }
        }
    }
}
