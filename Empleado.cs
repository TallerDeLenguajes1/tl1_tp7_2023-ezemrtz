namespace EspacioEmpleado;

public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleado{
    string Nombre;
    string Apellido;
    DateTime FechaNac;
    char EstadoCivil;
    char Genero;
    DateTime FechaIngreso;
    double Sueldo;
    Cargos Cargo;

}