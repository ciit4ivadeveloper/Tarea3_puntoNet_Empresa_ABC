public class Persona{

    public Persona (int codigo, string identificacion, string nombres, string apellidos, string telefono, string direccion, int perfilCompra, double valorCompra){
        this.codigo = codigo;
        this.identificacion = identificacion;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.telefono = telefono;
        this.direccion = direccion;
        this.perfilCompra = perfilCompra;
        this.valorCompra = valorCompra;
    }

    public int codigo{get; set;}
    public string identificacion{get; set;}
    public string nombres{get; set;}
    public string apellidos{get; set;}
    public string telefono{get; set;}
    public string direccion{get; set;}
    public int perfilCompra{get; set;}
    public double valorCompra{get; set;}

}
