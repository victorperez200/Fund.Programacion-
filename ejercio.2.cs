using System;
                    
public class Program
{
    public static void Main()
    {
        //Programa que escriba en pantalla los números del 1 al 10, usando "do..while".
        
        int i = 1;
        
        do
        {
            Console.WriteLine("Contador: {0}", i);

            i = i + 1;
            
        }
        
        while(i <= 10);

    }
}
