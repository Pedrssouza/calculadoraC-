namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Sentenças Matemáticas-----");


            double valor1 = 0, valor2 = 0, resultado, num;
            string operador, valorNum;
            bool isNumInteiro;

            Console.WriteLine("Escolha a operação matemática (' + | - | * | /'): ");
            operador = Console.ReadLine();


            Console.WriteLine("Digite um valor: ");
            valorNum = Console.ReadLine();
            isNumInteiro = double.TryParse(valorNum, out num);
            if (isNumInteiro)
            {
                valor1 = Math.Round(double.Parse(valorNum), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }
            Console.WriteLine("Digite outro valor: ");
            valorNum = Console.ReadLine();
            isNumInteiro = double.TryParse(valorNum, out num);
            if (isNumInteiro)
            {
                valor2 = Math.Round(double.Parse(valorNum));
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }


            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }


            Console.ReadKey();
        }
    }
}