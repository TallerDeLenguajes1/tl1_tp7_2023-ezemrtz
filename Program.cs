using EspacioCalculadora;

Calculadora calc = new Calculadora();
int opcion = 0;
bool anda = false;
double num = 0;

Console.WriteLine("======== Calculadora ========");
do{
    Console.WriteLine("Que operacion quiere realizar?");
    Console.WriteLine("1. SUMAR");
    Console.WriteLine("2. RESTAR");
    Console.WriteLine("3. MULTIPLICAR");
    Console.WriteLine("4. DIVIDIR");
    Console.WriteLine("5. LIMPIAR");
    Console.WriteLine("6. SALIR DE CALCULADORA");
    do{
        Console.WriteLine("Ingrese la opcion: ");
        anda = int.TryParse(Console.ReadLine(), out opcion);
    }while(!anda);
    if(opcion != 6 && opcion != 5){
        do{
            Console.WriteLine("Ingrese un numero: ");
            anda = double.TryParse(Console.ReadLine(), out num);
        }while(!anda);
    }

    switch(opcion){
        case 1:
            calc.Sumar(num);
            break;
        case 2:
            calc.Restar(num);
            break;
        case 3:
            calc.Multiplicar(num);
            break;
        case 4:
            calc.Dividir(num);
            break;
        case 5:
            calc.Limpiar();
            break;
        case 6:
            break;
        default: break;
    }
}while(opcion != 6);

Console.WriteLine("El resultado final es: {0}", calc.Resultado);

