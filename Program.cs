using EspacioEmpleado;
const int TAMA = 3;
Empleado[] empleados = new Empleado[TAMA];
int opcion;
Console.WriteLine("======= Carga de datos =======");
for (int i = 0; i < TAMA; i++){
    empleados[i] = new Empleado();
    Console.WriteLine($"-------- Empleado {i+1} -------");
    Console.WriteLine("Ingrese el nombre: ");
    empleados[i].Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido: ");
    empleados[i].Apellido = Console.ReadLine(); 
    Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/YYYY): ");
    empleados[i].FechaNac = Convert.ToDateTime(Console.ReadLine()); 
    Console.WriteLine("Ingrese el genero (F/M): ");
    empleados[i].Genero = char.Parse(Console.ReadLine()); 
    Console.WriteLine("Ingrese el estado civil (C/S): ");
    empleados[i].EstadoCivil = char.Parse(Console.ReadLine()); 
    Console.WriteLine("Ingrese la fecha de ingreso (dd/mm/YYYY): ");
    empleados[i].FechaIngreso = Convert.ToDateTime(Console.ReadLine()); 
    Console.WriteLine("Ingrese el sueldo basico: ");
    empleados[i].Sueldo = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el cargo: ");
    Console.WriteLine("1.Auxiliar");
    Console.WriteLine("2.Administrativo");
    Console.WriteLine("3.Ingeniero");
    Console.WriteLine("4.Especialista");
    Console.WriteLine("5.Investigador");
    do{
        opcion = int.Parse(Console.ReadLine());
    }while(opcion < 1 & opcion > 5);
    empleados[i].Cargo = (Cargos)(opcion-1);
}

// d. Monto total
double montoTotal = 0;
for (int i = 0; i < TAMA; i++){
    montoTotal += empleados[i].Salario();
}

// e. Mostrar mas proximo a jubilarse
int edadJubilacion = empleados[0].Jubilacion(), indice = 0;
for (int i = 1; i < TAMA; i++){
    if(edadJubilacion > empleados[i].Jubilacion()){
        edadJubilacion = empleados[i].Jubilacion();
        indice = i;
    }
}
Console.WriteLine("========== Empleado mas cercano a jubilarse ==========");
empleados[indice].Mostrar();


