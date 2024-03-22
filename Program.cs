//Tarea de clase 6 - 16/03/2024 ==========================================================


using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

//================================================================================
//AREA DE FUNCIONES ==============================================================
//================================================================================

//Ejer 1 ==========================================================================
static void ffsumanumerospares(int[] numerosvector)
{
    int eresultado = 0; 
    int numvlongitud = numerosvector.Length;
    for (int ii = 0; ii < numvlongitud; ii++)
    {
        if (numerosvector[ii] % 2 == 0)
        {
           eresultado = numerosvector[ii] + eresultado;
        }
    } 
    Console.WriteLine($"El total de la suma de los numeros pares es: {eresultado}");
}

//Ejer 2 ==========================================================================
static void ffinvertirvector(int[] numerosvector)
{
    int numvlongitud = numerosvector.Length;
    int[] evector2 = new int [numvlongitud];
    Console.WriteLine($"\nEl vector original es:");
    ffimprimirvector(numerosvector);

    for (int ii = 0; ii < numvlongitud; ii++)
    {
        evector2[ii] = numerosvector[numvlongitud-ii-1];
    }

    Console.WriteLine($"\nEl vector resultante es:");
    ffimprimirvector(evector2);
}

//Ejer 2.5 ==========================================================================
static void ffimprimirvector(int[] vector)
{
    for (int ii = 0; ii < vector.Length; ii++)
    {
        Console.WriteLine($"{vector[ii]}");
    }
}


//Ejer 3 ==========================================================================
static void ffmayor(int[] numerosvector)
{
    int emaximo = numerosvector[0];
    for (int ii = 0; ii < numerosvector.Length; ii++)
    {
        if (emaximo < numerosvector[ii])
        {
            emaximo = numerosvector[ii];
        }
    }
    Console.WriteLine($"El número más grande que se encuentra en el vector es: {emaximo}");
}

//Ejer 4  ==========================================================================
static int ffbuscar(int[] numerosvector,int eenumero)
{
    int ii = 0;
    int eepocisión = 0;
    for (ii = 0; ii < numerosvector.Length; ii++)
    {
        if (eenumero == numerosvector[ii])
        {
            eepocisión = ii;
            ii = ii + numerosvector.Length;
        } else
        {
            eepocisión = -1;
        }
    }
    return eepocisión;
}

//Ejer 5  ==========================================================================
static void ffordenar(int[] vector)
{
    Console.WriteLine($"El arreglo original es: ");
    ffimprimirvector(vector);
    Array.Sort(vector);
    Console.WriteLine($"\nEl arreglo modificado es: ");
    ffimprimirvector(vector);
}

//Ejer 1.2 =========================================================================
static void ffimprimirvectorstring(string[] vector)
{
    foreach (string vari in vector)
    {
        Console.WriteLine(vari);
    }
}

//================================================================================
//AREA DE DEFINICIONES ===========================================================
//================================================================================


int eecanvec = 0;

string eestring1 = "";

int[] numerosvector = { 1, 2, 3, 4, 5 };
int[] eenuemros2 = { 50, 54, 69, 35, 44 };

string[] eevectorst = new string[eecanvec];


//================================================================================
//INICIO DEL PROGRAMA ============================================================
//================================================================================

for (int ii = 0; ii != -1;)
{
    try
    {
        Console.Clear();
        Console.WriteLine($"Tarea de Clase 16/03/2024\nElija una de las opciones:\n1. Ejercicios sin métodos.\n2. Ejercicios con métodos.\n-1. Salir del programa.");
        ii=int.Parse(Console.ReadLine());
        switch (ii)
        {
            case 1:
                for (int jj=0; jj!= -1;)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine($"Elija la opción que desee:\n1. Ejercicio 1.\n2. Ejercicio 2.\n3. Ejercicio 3.\n4. Ejercicio 4.\n5. Ejercicio 5.\n-1. Atrás.");
                        jj = int.Parse(Console.ReadLine());
                        switch (jj)
                        {
                            case 1:
                                Console.Clear();
                                ffsumanumerospares(numerosvector);
                                Console.ReadKey();

                                break;
                            case 2:
                                Console.Clear();
                                ffinvertirvector(numerosvector);
                                Console.ReadKey();

                                break;

                            case 3:
                                Console.Clear();
                                ffmayor(numerosvector);
                                Console.ReadKey();

                                break;

                            case 4:
                                for (int kk=0; kk!= -1;)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        int eenumero = int.Parse(Console.ReadLine());
                                        int eebuscado = ffbuscar(numerosvector, eenumero);
                                        Console.WriteLine($"El valor devuelto es: {eebuscado}");
                                        Console.ReadKey();
                                        kk = -1;
                                    }
                                    catch (Exception eerror)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            case 5:
                                Console.Clear();
                                ffordenar(eenuemros2);
                                Console.ReadKey();

                                break;
                            case -1:
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine($"Carácter ingresado no valido, vuelve a intentarlo.");
                                Console.ReadKey();
                                break;
                        }
                    }
                    catch (Exception eerror)
                    {
                        Console.Clear();
                        Console.WriteLine($"El caracter ingresado no es valido. Error: {eerror}");
                        Console.ReadKey();
                    }
                }
                break;
            case 2:
                for (int jj =0; jj!= -1;)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine($"Elija la opción que desee:\n1. Ejercicio 1.\n2. Ejercicio 2.\n3. Ejercicio 3.\n4. Ejercicio 4.\n5. Ejercicio 5.\n-1. Atrás.");
                        jj = int.Parse(Console.ReadLine());
                        switch (jj)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine($"Ingrese un nombre:");
                                eestring1 = Console.ReadLine();
                                eestring1 += ",";
                                for (int kk = 0; kk != -1;)
                                {
                                    Console.WriteLine($"Desea ingresar otro nombre?:\n1. Sí.\n-1. No.");
                                    int eevariable1 = int.Parse(Console.ReadLine());
                                    if (eevariable1 == 1)
                                    {
                                        Console.WriteLine($"Ingrese un nombre:");
                                        eestring1 += Console.ReadLine() + ",";

                                    }
                                    else if (eevariable1 == -1)
                                    {
                                        kk = -1;
                                    } else
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"El carácter ingresado no es valido. Intente de nuevo");
                                        Console.ReadKey();
                                    }
                                }
                                string[] eenombres = eestring1.Split(',');
                                Array.Sort(eenombres);
                                ffimprimirvectorstring(eenombres);
                                Console.ReadKey();

                                break;
                            case 2:

                                for (int kk = 0; kk != -1;)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Ingrese un número entero:");
                                        int[] eenumeros = new int[1];
                                        eenumeros[0] = int.Parse(Console.ReadLine()) ;
                                        int lll = 1;
                                        for (int ll = 1; ll != -1;)
                                        {
                                            Console.WriteLine($"Desea ingresar otro número?:\n1. Sí.\n-1. No.");
                                            int eevariable1 = int.Parse(Console.ReadLine());
                                            if (eevariable1 == 1)
                                            {
                                                try
                                                {
                                                    Console.WriteLine($"Ingrese un número:");
                                                    int eenumerotem = int.Parse(Console.ReadLine());
                                                    int[] eetemporal = new int[lll + 1];
                                                    Array.Copy(eenumeros, eetemporal, lll);
                                                    eetemporal[lll] = eenumerotem;
                                                    eenumeros = eetemporal;
                                                    lll++;
                                                }
                                                catch (Exception eerror)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (eevariable1 == -1)
                                            {
                                                ll = -1;
                                                kk = -1;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"El carácter ingresado no es valido. Intente de nuevo");
                                                Console.ReadKey();
                                            }
                                        }
                                        int eemax = eenumeros.Max();
                                        int eemin = eenumeros.Min();
                                        Console.WriteLine($"El número máximo es de: {eemax} y el número minimo es: {eemin}");
                                        Console.ReadKey();

                                    }
                                    catch (Exception eerror)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
                                        Console.ReadKey();
                                    }
                                }

                                break;
                            case 3:
                                Console.Clear ();
                                string[] eepaises = { "Guatemala", "El Salvador", "Honduras", "Nicaragua", "México"};
                                string eebusqueda = Console.ReadLine();
                                int eevari1 = Array.IndexOf(eepaises.Select(p=> p.ToLower()).ToArray(), eebusqueda.ToLower());
                                if (eevari1 >= 0)
                                {
                                    Console.WriteLine($"El país \"{eepaises[eevari1]}\" SÍ fue encontrado en la posición: {eevari1}.");
                                    Console.ReadKey();
                                }else
                                {
                                    Console.WriteLine($"El país \"{eebusqueda}\" NO fue encontrado."); 
                                    Console.ReadKey();
                                }
                                break;
                            case 4:
                                Console.Clear();
                                int[] eeenterosvector = { 23, 56, 98, 35, 40 };
                                Console.WriteLine($"Vector Original: \n");
                                ffimprimirvector(eeenterosvector);
                                Array.Reverse(eeenterosvector);
                                Console.WriteLine($"\nVector Resultante: \n");
                                ffimprimirvector(eeenterosvector);
                                Console.ReadKey();

                                break;
                            case 5:
                                for ( int kk = 0; kk != -1;)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Ingrese una calificación:");
                                        int[] eecalificacion = new int[1];
                                        eecalificacion[0] = int.Parse(Console.ReadLine());
                                        int eecalificacion1;
                                        int lll=1;
                                        for (int ll = 0;  ll != -1;)
                                        {
                                            Console.WriteLine($"Desea ingresar otra calificación?:\n1. Sí.\n-1. No.");
                                            int eevariable2 = int.Parse(Console.ReadLine());
                                            if (eevariable2 == 1)
                                            {
                                                try
                                                {
                                                    Console.WriteLine($"Ingrese una nueva calificación:");
                                                    eecalificacion1 = int.Parse(Console.ReadLine());
                                                    int[] eetemporal = new int[lll + 1];
                                                    Array.Copy(eecalificacion, eetemporal, lll);
                                                    eetemporal[lll] = eecalificacion1;
                                                    eecalificacion = eetemporal;
                                                    lll++;
                                                }
                                                catch (Exception eerror)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
                                                    Console.ReadKey();
                                                }
                                            }
                                            else if (eevariable2 == -1)
                                            {
                                                ll = -1;
                                                kk = -1;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"El carácter ingresado no es valido. Intente de nuevo");
                                                Console.ReadKey();
                                            }
                                        }

                                        bool eesihay90 = Array.Exists(eecalificacion, p=>p>90);
                                        if (eesihay90)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"SÍ hay calificacion/es sobresaliente/s");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"NO hay calificacion/es sobresaliente/s");
                                            Console.ReadKey();
                                        }
                                    }
                                    catch (Exception eerror)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            case -1:
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine($"Carácter ingresado no valido, vuelve a intentarlo.");
                                Console.ReadKey();

                                break;
                        }
                    }
                    catch (Exception eerror)
                    {
                        Console.Clear();
                        Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
                        Console.ReadKey();
                    }
                }
                break;
            case -1:
                break;
            default:
                Console.Clear();
                Console.WriteLine($"Carácter ingresado no valido, vuelve a intentarlo.");
                Console.ReadKey();
                break;
        }
    }
    catch ( Exception eerror )
    {
        Console.Clear();
        Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
        Console.ReadKey();
    }
}
/*
try
{

}
catch (Exception eerror)
{
   Console.Clear();
   Console.WriteLine($"El carácter ingresado no es valido. Error: {eerror}");
   Console.ReadKey();
}
*/


