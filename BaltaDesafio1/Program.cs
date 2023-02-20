internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um texto: ");
        string txt = Console.ReadLine();

        Console.WriteLine("Esse foi o texto informado: "+txt);
        Console.WriteLine("O texto possui " + txt.Length + " caracteres");
        Console.WriteLine("E " + txt.Split(' ').Length + " palavras...");
    }
}