internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escribir dos valores numericos" ):
            double num1=Convert.ToDouble(Console.ReadLine());
            double num2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n *-*-*-*-* Menu Principal *-*-*-*-*");
        Console.WriteLine("1- Suma");
        Console.WriteLine("2- Resta")
        Console.WriteLine("3- Multiplicación");
        Console.WriteLine("4- Divison")
        Console.WriteLine("5- Salir");
        Console.WriteLine("Digite el valor segun sea la operacion []");
        int opc=Convert.ToInt32(Console.ReadLine());
        string msj = "";
        double result = 0;
        switch (opc)
        {
            case 1:
                msj = "\n SUMA \n la suma es: ";
                result = num1 + num2;
                break;
            case 2:
                msj = "\n RESTA \n la resta es: ";
                result = num1 - num2;
                break;
            case 3:
                msj = "\n MULTIPLICACION \n la multiplicacion es: ";
                result = num1 * num2;
                break;
            case 4:
                msj = "\n DIVISION \n la division es: ";
                result = num1 / num2;
                break;
            case 5:
                msj = "Saliendo del sistema ";
                break;
            default:
                msj = "dijite una opcion valida";
                break ;

        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(msj);
        Console.WriteLine(result);
        
    }
}