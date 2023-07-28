namespace SimplesApp;

class Program
{
    static void Main(string[] args)
    {
        /* Conversão - flost pra int */
        // declarando variáveis
        int inteiro = 10;
        float real = 10.8f;

        /* Conversão com Parse não funciona nesse caso
        obs: parse sempre espera receber uma string */
        //inteiro = int.Parse(real.ToString());

        /* Conversão com Convert 
        obs: no caso de float pra int, ele sempre irá arredondar o valor*/
        inteiro = Convert.ToInt32(real);

        Console.WriteLine("Conversão do tipo Convert de real pra inteiro: " + inteiro);
    }
}
