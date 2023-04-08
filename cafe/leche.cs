using System;
namespace cafe
{
    public class leche:decorador
    {
      public leche(Bebida bebida):base(bebida){}  

      public override double costo => _bebida.costo + 0.30;
      public override string vista => string.Format($"{_bebida.vista}, +leche");
    }
}