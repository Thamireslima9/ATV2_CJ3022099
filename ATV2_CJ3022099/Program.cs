namespace ATV2_CJ3022099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // projeto 1 
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



            


        }
    }
}
