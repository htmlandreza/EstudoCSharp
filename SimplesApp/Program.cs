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
        // usando Convert dentro do Console
        Console.WriteLine("Conversão pra Bool, dentro do console: " + Convert.ToBoolean(real));


        /* Operadores */
        // Atrubuição
        int x = 2;
        x += 2; // 4
        Console.WriteLine("x = " + x);

        // Comparação
        Console.WriteLine("Comparação: o valor de X é igual de 25?");
        Console.WriteLine(x == 25); //Não é possivel colocar strings juntas nesse caso que contem comparação
    }
}
