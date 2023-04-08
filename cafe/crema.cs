using System;
namespace cafe
{
    public class crema:decorador
    {
       public crema(Bebida bebida):base (bebida){}
       public override double costo => _bebida.costo + 0.40;
       public override string vista => string.Format($"{_bebida.vista},+ agregado de crema "); 
    }
}