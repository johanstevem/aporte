using System;

namespace aporte {
public class Decorador : Orden_base
{
    protected Orden_base orden;
    public Decorador (Orden_base orden)
    {
        this.orden = orden;
    }
    public override string Add()
    {
        return orden.Add();
    }
}
}