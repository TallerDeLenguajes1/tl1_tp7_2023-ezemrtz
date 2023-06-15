namespace EspacioEmpleado;

public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldo;
    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public int Antiguedad(){
        int antiguedad = DateTime.Today.AddTicks(-FechaIngreso.Ticks).Year - 1;
        return antiguedad;
    }
    public int Edad(){
        int edad = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1;
        return edad;
    }
    public int Jubilacion(){
        int jubil = 0;
        if(Genero == 'F'){
            if(Edad() < 60){
                jubil = 60 - Edad();
            }
        }else{
            if(Edad() < 65){
                jubil = 65 - Edad();
            }
        }
        return jubil;
    }

    public double Salario(){
        double salario, adicional;
        if(Antiguedad() <= 20){
            adicional = Sueldo * Antiguedad() / 100;
        }else{
            adicional = Sueldo * 0.25;
        }
        if(Cargo == Cargos.Ingeniero | Cargo == Cargos.Especialista){
            adicional += adicional * 0.5;
        }
        if(EstadoCivil == 'C'){
            adicional += 15000;
        }
        salario = Sueldo + adicional;
        return salario;
    }
    
    public void Mostrar(){
        Console.WriteLine("======== DATOS ========");
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Apellido: {0}", apellido);
        Console.WriteLine("Fecha de nacimiento: {0}", fechaNac.ToShortDateString());
        Console.WriteLine("Estado Civil: {0}", estadoCivil);
        Console.WriteLine("Genero: {0}", genero);
        Console.WriteLine("Fecha de ingreso: {0}", fechaIngreso.ToShortDateString());
        Console.WriteLine("Sueldo Basico: ${0}", sueldo);
        Console.WriteLine("Cargo: {0}", cargo);
        Console.WriteLine("Antiguedad: {0}", this.Antiguedad());
        Console.WriteLine("Edad: {0}", this.Edad());
        Console.WriteLine("Años para jubilarse: {0}", this.Jubilacion());
        Console.WriteLine("Salario: ${0}", this.Salario());
    }
} 