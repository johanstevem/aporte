using System;
namespace cafe
{
    public class program
    {
        static void Main (string []args)
        {
            Bebida bebida_1= new cafeexpreso();
            bebida_1= new crema(bebida_1);
            bebida_1= new leche(bebida_1);
Console.WriteLine($"costo:{bebida_1.costo} producto:${bebida_1.vista}");
        }
    }
}
