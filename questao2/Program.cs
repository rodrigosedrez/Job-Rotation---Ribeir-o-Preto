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
       Console.WriteLine($"A baixo está a soma dos dois ultimos valores da sequencia fibonacci:");
       Console.WriteLine($"0, 1, 1, 2, 3, 5, 8, 13, 21, 34,...");
       Console.WriteLine($"Text");
       Console.WriteLine($"DIGITE O NUMERO A SER COPARADO ENTRE 0 E 90:");
       Console.WriteLine($" ");
        int numero = Convert.ToInt32(Console.ReadLine());
        
        Calculo(numero);
        
    
    }
    static void Calculo(int numero)
    {   

        if (numero < 90)
        {
            int[] result = new int[10];
            int nFinal = 0;
            int ultimo = 1;
            int penultimo = 0;
            int igual = 0;

            for (var i = 0; i < 10; i++)
            {
                 nFinal = penultimo + ultimo;
           
                penultimo = ultimo;
                ultimo = nFinal;
                result[i]= nFinal;
            }
            for (var ii = 0; ii < 10; ii++)
            {

                if ( numero == result[ii])
                {
                result[ii]= numero;
                igual = numero;
                }    
        }  
            if (numero == igual) Console.WriteLine("Seu numero pertence a tabela fibonacci \n");
            if (numero != igual) Console.WriteLine($"Seu numero NÃO pertence a tabela. \n");
            Console.WriteLine($"Pressione enter para reiniciar a pesquisa. \n");
            Console.WriteLine($"Para fechar 's' ");
    
           string sair = Console.ReadLine().ToLower();  
           if (sair == "s") System.Environment.Exit(0);
     }
     
         Menu();
    }
}