using System;
namespace cafe
{
    public class Edulcorante: decorador
    {
        public Edulcorante(Bebida bebida): base(bebida){}
        public override double costo => _bebida.costo +0.25;
        public override string vista => string.Format($"{_bebida.vista}, edulcorante");
    }
}