using System;
class HelloWorld 
{
  static void Main() 
  
  {
       double n1 = 10;
            double n2 = 10;
            double Mult;
            int i;
            int par = 0;

            Mult = n1 * n2;
            Console.WriteLine("El Resultado es: " + Mult);
            Console.Write(" Los 10 primeros numeros pares partiendo de la multiplicacion son: ", par);

            for (i = 100; i < 120; i++)
            {
                while (i % 2 == 0)
                {
                    Console.Write("{0}|", i);
                    
                    i++;
                }
            }    

        
  }
}