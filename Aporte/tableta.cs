using System;

namespace aporte
{
    public class tableta : Dispositivo ,Chip
    {
        
    public tableta(int IMEI, string MARCA, string MODELO, string System, string Country, string Primer_funcionalidad, string Segunda_funcionalidad, string Tercer_funcionalidad) : base(IMEI, MARCA, MODELO, System, Country,Primer_funcionalidad, Segunda_funcionalidad, Tercer_funcionalidad){}
    public override void Funcionabilidad()
    {
        Console.WriteLine("Funcionalidades: ");
        Console.WriteLine("1: " + Primer_funcionalidad);
        Console.WriteLine("2: " + Segunda_funcionalidad);
        Console.WriteLine("3: " + Tercer_funcionalidad);
    }

    public override void Imprimir()
    {
        Console.WriteLine("-----------------");
        Console.WriteLine("Dispositivo a reparar:");
        Console.WriteLine("------------------");
        Console.WriteLine("Marca: " + MARCA);
        Console.WriteLine("Modelo: " + MODELO);
        Console.WriteLine("IMEI: " + IMEI);
        Console.WriteLine("Sistema Operativo: " + System);
        Console.WriteLine("------------------");
    }

    public void MostrarChip()
    {
        Console.WriteLine("Chip: Si");
    }

    }
}