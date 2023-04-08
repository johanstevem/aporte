using System;
namespace cafe
{
    public class azucar:decorador
    {
        public azucar(Bebida bebida): base(bebida){}
        public override double costo => _bebida.costo+ 0.40;
        public override string vista => string.Format($"{_bebida.vista}, azucar ");
    }
}