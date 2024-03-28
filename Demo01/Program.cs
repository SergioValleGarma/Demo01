
//int edad = 0;

//Console.WriteLine("ingrese la edad");

//edad = Convert.ToInt32(Console.ReadLine());

//if (edad > 18)
//{
//    Console.WriteLine("eres mayor de edad");
//}
//else
//{
//    Console.WriteLine("eres menor de edad");
//}


//int cal = 0;

//Console.WriteLine("ingrese la calificacion");

//cal = Convert.ToInt32(Console.ReadLine());

//if (cal > 100)
//{
//    Console.WriteLine("la calificacion esta fuera del rango");
//}else
//{
//    if (cal > 89)
//    {
//        Console.WriteLine("excelente");
//    }else
//    {
//        if (cal > 79)
//        {
//            Console.WriteLine("muy bueno");
//        }
//        else
//        {
//            if (cal > 69)
//            {
//                Console.WriteLine("bueno");
//            }
//            else
//            {
//                if (cal > 59)
//                {
//                    Console.WriteLine("suficiente");
//                }
//                else
//                {
//                    Console.WriteLine("insuficiente");
//                }
//            }
//        }
//    }
//}

//int mes = 0;
//string diaSeman = "";

//Console.WriteLine("ingrese el mes del año");

//mes = Convert.ToInt32(Console.ReadLine());

//switch (mes){
//    case 0:
//        diaSeman = "numero erroneo";
//        break;
//    case < 3:
//        diaSeman = "verano";
//        break;
//    case <5:
//        diaSeman = "otoño";
//        break;
//    case <9:
//        diaSeman = "invierno";
//        break;
//    case < 12:
//        diaSeman = "primavera";
//        break;
//    default:
//        diaSeman = "numero erroneo";
//        break;
//}

//Console.WriteLine("la estacion correspondiente al mes serleccionado es "+ diaSeman);

////
int opcion = 0;
int lado = 0;
int resultado = 0;
string mensaje = null;

Console.WriteLine("Selecione una de las aciones a realizar " +
    "\n opcion 1 calcular área del cuadrado" +
    "\n opcion 2 calcular volumen del cubo" +
    "\n opcion 4 salir");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 0:
        mensaje = "opción incorrecta";
        break;
    case 1:
        lado = Convert.ToInt32(Console.ReadLine());
        resultado = lado * lado;
        break;
    case 2:
        lado = Convert.ToInt32(Console.ReadLine());
        resultado = lado * lado;
        break;
    case 3:
        break;
    default:
        mensaje = "opción incorrecta";
        break;
}


