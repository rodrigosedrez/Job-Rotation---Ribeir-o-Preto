//Utilizei dotnetFramework 6.0

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine($"Incira abaixo o texto/sequência numérica que você deseja inverter:");
        string text = Console.ReadLine();

        Invertida(text);
    }
    static void Invertida(string text)
    {
        string[] ext = new string[text.Length];
        for(var i = 1;i < text.Length+1;i++)
        {
            string nova = text.Substring(text.Length-i,1);
            ext[i-1] = nova;
           
        }
         foreach(string ii in ext)
            {
                Console.Write("{0}",ii);
            }
        
        
        
    }
}