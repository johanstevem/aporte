using System;
namespace cafe
{
public abstract class decorador: Bebida
{
protected Bebida _bebida;
    public  decorador(Bebida bebida)
    {
    _bebida=bebida;
    }
}
}