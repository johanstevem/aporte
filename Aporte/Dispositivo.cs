using System;

namespace aporte
{
    public abstract class Dispositivo
    {
    public int IMEI {get; set;}
    public string MARCA {get; set;}
    public string MODELO {get; set;}
    public string System {get; set;}
    public string Country {get; set;}
    public string Primer_funcionalidad {get; set;}
    public string Segunda_funcionalidad {get; set;}
    public string Tercer_funcionalidad {get; set;}

    public Dispositivo(int IMEI, string MARCA, string MODELO, string System, string Country, string Primer_funcionalidad, string Segunda_funcionalidad, string Tercer_funcionalidad)
    { 
        this.IMEI = IMEI;
        this.MARCA = MARCA;
        this.MODELO = MODELO;
        this.System = System;
        this.Country = Country;
        this.Primer_funcionalidad = Primer_funcionalidad;
        this.Segunda_funcionalidad = Segunda_funcionalidad;
        this.Tercer_funcionalidad= Tercer_funcionalidad;
    }

    public abstract void Funcionabilidad();

    public abstract void Imprimir();

    }
}