// See https://aka.ms/new-console-template for more information

using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static int[] miVector = new int[10];
    static int[] numerosPago= new int[10];
    static string[] cedula = new string [10];
    static string[] nombres = new string[10];
    static string[] apellido1 = new string[10];
    static string[] apellido2 = new string[10];
    static int[] numerosCaja = new int[10];
    static int cantidadPagos = 0;
    static int [] numerosFactura = new int[10];
    static double[] montosPagar = new double[10];
    static double[] comisiones = new double[10];
    static int[] tipoServicio = new int[10];
    static double[] deducciones = new double[10];
    static double[] montosPaga = new double[10];
    static double[] vueltos = new double[10];
    DateTime[] fechas = new DateTime[10];
    TimeSpan[] horas = new TimeSpan[10];


    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú Principal");
            Console.WriteLine("1. Inicializar Vectores");
            Console.WriteLine("2. Realizar Pagos");
            Console.WriteLine("3. Consultar Pagos");
            Console.WriteLine("4. Modificar Pagos");
            Console.WriteLine("5. Eliminar Pagos");
            Console.WriteLine("6. Submenú Reportes");
            Console.WriteLine("7. Salir");

            Console.Write("Ingrese su opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    InicializarVectores();
                    break;
                case "2":
                    RealizarPagos();
                    break;
                case "3":
                    ConsultarPagos();
                    break;
                case "4":
                    ModificarPagos();
                    break;
                case "5":
                    EliminarPagos();
                    break;
                case "6":
                    SubmenuReportes();
                    break;
                case "7":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 7.");
                    break;
            }
        }
    }

    static void InicializarVectores()
    {
        Console.WriteLine("Inicializando vectores...");
        //numerosPago = new int[10];
        //nombres = new string[10];
        //apellido1 = new string[10];
        //apellido2 = new string[10];
        //cedula = new int[10];
        //fecha = new DateTime[10];
        //hora = new TimeSpan[10];
        //numerosCaja = new int[10];
        //numerosFactura = new int[10];
        //montosPagar = new int[10];
        //comisiones = new double[10];
        //deducciones = new double[10];
        //montoPagaCliente = new double[10]
        //vuelto = new double[10]
        //cantidadPagos = 0;

    }

    static void RealizarPagos()
    {
        Console.WriteLine("----- REALIZACION DE PAGOS -----...");
        DateTime[] fechas = new DateTime[10];
        TimeSpan[] horas = new TimeSpan[10];
        

        if (cantidadPagos >= 10)
        {
            Console.WriteLine("Vectores Llenos");
            return;
        }


        Random random = new Random();
        Random aleatorio = new Random();
        int numeroPago = random.Next(1000, 10000);
        int numeroCaja = aleatorio.Next(1,4);


        Console.WriteLine($"Favor ingresa la fecha: (Recordatorio: formato dd/mm/aaaa):");
        DateTime fecha;
        bool formatoFechaCorrecto;

        do
        {
            formatoFechaCorrecto = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha);

            if (!formatoFechaCorrecto)
            {
                Console.WriteLine("El formato ingresado en la fecha es incorrecto. Por favor, ingrese la fecha en formato dd/mm/aaaa:");
            }
        } while (!formatoFechaCorrecto);

        fechas[cantidadPagos] = fecha;

        Console.WriteLine($"Favor ingrese la hora: (Recordatorio: formato hh:mm:ss):");
        TimeSpan hora;
        bool formatoHoraCorrecto;

        do
        {
            formatoHoraCorrecto = TimeSpan.TryParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture, out hora);

            if (!formatoHoraCorrecto)
            {
                Console.WriteLine("El formato ingresado en la hora es incorrecto. Por favor, ingrese la hora en formato hh:mm:ss:");
            }
        } while (!formatoHoraCorrecto);

        horas[cantidadPagos] = hora;

        Console.Write("Ingrese la cedula del cliente: ");
        string cedulas;
        
        do
        {
            
            cedulas = Console.ReadLine();

            if (!Regex.IsMatch(cedulas, @"^\d+$"))
            {
                Console.WriteLine("La cédula solo debe contener números. Por favor, inténtelo de nuevo:");
            }
        } while (!Regex.IsMatch(cedulas, @"^\d+$")); 

        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el primer apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Ingrese el segundo apellido: ");
        string apellidos = Console.ReadLine();
        int opcion = 0;


        Console.WriteLine("Tipo de servicio : [ 1. Recibo de luz 2. Recibo de electricidad 3. Recibo de agua ] ");
        int opcionTipoServicio = int.Parse(Console.ReadLine());

       
        Console.Write("Ingrese el numero de factura: ");
        int numeroFactura = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el monto a pagar: ");
        double montoPagar = double.Parse(Console.ReadLine());

        double comision = 0;

        double deduccion = 0;

        double montoPagaCliente = 0;

        double vuelto = 0;


        do
        {
            Console.Write("Indique con cuanto va a pagar: ");
            montoPagaCliente = double.Parse(Console.ReadLine());

            if (montoPagaCliente < montoPagar)
            {
                Console.WriteLine("El monto pagado no puede ser menor al monto a pagar. Intente de nuevo.");
            }
        } while (montoPagaCliente < montoPagar);

        numerosPago[cantidadPagos] = numeroPago;
        cedula[cantidadPagos] = cedulas;
        nombres[cantidadPagos] = nombre;
        apellido1[cantidadPagos] = apellido;
        apellido2[cantidadPagos] = apellidos;
        numerosCaja[cantidadPagos] = numeroCaja;
        numerosFactura[cantidadPagos] = numeroFactura;
        montosPagar[cantidadPagos] = montoPagar;
        comisiones[cantidadPagos] = comision;
        deducciones[cantidadPagos] = deduccion;
        tipoServicio[cantidadPagos] = opcionTipoServicio;
        montosPaga[cantidadPagos] = montoPagaCliente;
        vueltos[cantidadPagos] = vuelto;

        cantidadPagos++;

        Console.WriteLine($"\t \t \t \t \t Sistema de Pago de Servicios \t \t \t");
        Console.WriteLine($"\t \t \t \t Tienda de Estructura - Ingreso de Datos \t \t \t");
        Console.WriteLine($"\n \n");
        Console.WriteLine($"\t \t \tNúmero de Pago: {numeroPago}");
        Console.WriteLine($"\t \t \tFecha:  {fecha.ToShortDateString()} \t \t \t Hora:  {hora}");
        Console.WriteLine($"\t \t \tCedula:  {cedulas} \t \t \t Nombre:  {nombre} \t \t \t");
        Console.WriteLine($"\t \t \tApellido1:  {apellido} \t \t \t Apellido2:  {apellidos} \t \t \t");
        Console.WriteLine($"\t \t \tNúmero de Caja: {numeroCaja}");
        Console.WriteLine($"\t \t \tTipo: " + opcionTipoServicio + " \t \t[ 1.Electricidad " + " 2. Telefono " + " 3. Agua ] ");
        Console.WriteLine($"\t \t \tNúmero de Factura: {numeroFactura}");
        //Console.WriteLine($"\t \t \tMonto a Pagar: {montoPagar}");


        // Calcular la comisión según el tipo de servicio
        switch (opcionTipoServicio)
        {
            case 1:
                comision = numeroFactura * 0.04;
                break;
            case 2:
                comision = numeroFactura * (5.5 / 100);
                break;
            case 3:
                comision = numeroFactura * (6.5 / 100);
                break;
            default:
                Console.WriteLine("Opción de servicio no válida.");
                return;
        }

        deduccion = montoPagar - comision;
        vuelto = montoPagaCliente - montoPagar;


        Console.WriteLine($"\t \t \tNúmero de Factura: {numeroFactura} \t \t \t Monto a pagar: {montoPagar} \t \t \t");
        Console.WriteLine($"\t \t \tComisión autorizada: {comision} \t \t \t Paga con: {montoPagaCliente}\t \t \t");
        Console.WriteLine($"\t \t Monto Deducido: {deduccion} \t \t \t Vuelto: {vuelto}\t \t \t");
        
        Console.WriteLine("\t \t \t¿Desea continuar? (Y/N): ");
        string response = Console.ReadLine();
        if (response.ToLower() == "s")
        {
            
        }
        else
        {
            
        }


    }


    static void ConsultarPagos()
    {
        Console.WriteLine("----- CONSULTA DE PAGOS -----");
        Console.Write("Ingrese el número de pago que desea buscar: ");
        int numeroPagoBuscar = Convert.ToInt32(Console.ReadLine());

        int i = Array.IndexOf(numerosPago, numeroPagoBuscar);
        if (i != -1)
        {
            Console.WriteLine($"\t \t \tDato encontrado Posicion Vector {i}. Información asociada: \t \t \t");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tNúmero de pago: {numerosPago[i]}");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tCédula: {cedula[i]} \t \t \t Nombre: {nombres[i]} \t \t \t");
            Console.WriteLine($"\t \t \tPrimer Apellido: {apellido1[i]} \t \t \t Segundo Apellido: {apellido2[i]}");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tTipo:  { tipoServicio[i]}  \t \t[ 1.Electricidad  2. Telefono  3. Agua ] ");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tNúmero de Caja: {numerosCaja[i]} \t \t \t");
            Console.WriteLine($"\t \t \tNúmero de Factura: {numerosFactura[i]} \t \t \t Monto a pagar: {montosPagar[i]}\t \t \t");
            Console.WriteLine($"\t \t \tComision autorizada: {comisiones[i]} \t \t \t Paga con: {montosPaga[i]}\t \t \t");
            Console.WriteLine($"\t \t \tMonto Deducido: {deducciones[i]} \t \t \t Vuelto: {vueltos[i]}\t \t \t");

        }
        else
        {
            Console.WriteLine("--- Pago no se encuentra registrado.");
        }
    }




    static void ModificarPagos()
    {
        
        
            Console.WriteLine("----- MODIFICACIÓN DE PAGOS -----");
            Console.Write("Ingrese el número de pago que desea modificar: ");
            int numeroPagoModificar = Convert.ToInt32(Console.ReadLine());

            int i = Array.IndexOf(numerosPago, numeroPagoModificar);
            if (i != -1)
            {
                Console.WriteLine($"\t \t \tDato encontrado en la posición del vector {i}. Información asociada: \t \t \t");
                Console.WriteLine("\n");
                Console.WriteLine($"\t \t \tNúmero de pago: {numerosPago[i]}");
                Console.WriteLine("\n");
                Console.WriteLine($"\t \t \tCédula: {cedula[i]} \t \t \t Nombre: {nombres[i]} \t \t \t");
                Console.WriteLine($"\t \t \tPrimer Apellido: {apellido1[i]} \t \t \t Segundo Apellido: {apellido2[i]}");
                Console.WriteLine("\n");
                Console.WriteLine($"\t \t \tTipo:  {tipoServicio[i]}  \t \t[ 1. Recibo de luz " + " 2. Recibo de electricidad " + " 3. Recibo de agua ] ");
                Console.WriteLine("\n");
                Console.WriteLine($"\t \t \tNúmero de Caja: {numerosCaja[i]}");
                Console.WriteLine($"\t \t \tNúmero de Factura: {numerosFactura[i]} \t \t \t Monto a pagar: {montosPagar[i]}\t \t \t");
                Console.WriteLine($"\t \t \tComision autorizada: {comisiones[i]} \t \t \t Paga con: {montosPaga[i]}\t \t \t");
                Console.WriteLine($"\t \t \tMonto Deducido: {deducciones[i]} \t \t \t Vuelto: {vueltos[i]}\t \t \t");

                Console.WriteLine("¿Qué desea modificar?");
                Console.WriteLine("1. Monto a pagar");
                Console.WriteLine("2. Tipo de servicio");
                Console.WriteLine("3. Número de factura");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Ingrese su opción: ");
                string opcionModificar = Console.ReadLine();

                switch (opcionModificar)
                {
                    case "1":
                        Console.Write("Ingrese el nuevo monto a pagar: ");
                        montosPagar[i] = double.Parse(Console.ReadLine());
                        Console.WriteLine("Monto a pagar modificado correctamente.");
                        break;
                    case "2":
                        Console.Write("Ingrese el nuevo tipo de servicio: ");
                        tipoServicio[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tipo de servicio modificado correctamente.");
                        break;
                    case "3":
                        Console.Write("Ingrese el nuevo número de factura: ");
                        numerosFactura[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Número de factura modificado correctamente.");
                        break;
                    case "4":
                        Console.WriteLine("Volviendo al menú principal.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("--- Pago no se encuentra registrado.");
            }
        

    }

    static void EliminarPagos()
    {
        Console.WriteLine("Eliminando pagos...");
        Console.Write("Ingrese el número de pago que desea buscar: ");
        int numeroPagoEliminar = Convert.ToInt32(Console.ReadLine());

        int i = Array.IndexOf(numerosPago, numeroPagoEliminar);
        if (i != -1)
        {
            Console.WriteLine($"\t \t \tDato encontrado Posicion Vector {i}. Información asociada: \t \t \t");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tNúmero de pago: {numerosPago[i]}");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tCédula: {cedula[i]} \t \t \t Nombre: {nombres[i]} \t \t \t");
            Console.WriteLine($"\t \t \tPrimer Apellido: {apellido1[i]} \t \t \t Segundo Apellido: {apellido2[i]}");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tTipo:  {tipoServicio[i]}  \t \t[ 1. Recibo de luz " + " 2. Recibo de electricidad " + " 3. Recibo de agua ] ");
            Console.WriteLine("\n");
            Console.WriteLine($"\t \t \tNúmero de Caja: {numerosCaja[i]}");
            Console.WriteLine($"\t \t \tNúmero de Factura: {numerosFactura[i]} \t \t \t Monto a pagar: {montosPagar[i]}\t \t \t");
            Console.WriteLine($"\t \t \tComision autorizada: {comisiones[i]} \t \t \t Paga con: {montosPaga[i]}\t \t \t");
            Console.WriteLine($"\t \t \tMonto Deducido: {deducciones[i]} \t \t \t Vuelto: {vueltos[i]}\t \t \t");

            Console.Write("¿Está seguro de eliminar el dato? (S/N): ");
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "S")
            {
                numerosPago[i] = 0;
                cedula[i] = "";
                nombres[i] = "";
                apellido1[i] = "";
                apellido2[i] = "";
                numerosCaja[i] = 0;
                numerosFactura[i] = 0;
                montosPagar[i] = 0;
                comisiones[i] = 0;
                deducciones[i] = 0;
                tipoServicio[i] = 0;
                montosPaga[i] = 0;
                vueltos[i] = 0;

                Console.WriteLine("La información ha sido eliminada.");
            }
            else
            {
                Console.WriteLine("La información no fue eliminada.");
            }
        }
        else
        {
            Console.WriteLine("Pago no se encuentra registrado.");
        }
    }

    
    static void SubmenuReportes()
    {
        bool volver = false;

        while (!volver)
        {
            Console.WriteLine("---Submenú Reportes---");
            
            Console.WriteLine("1. Ver todos los Pagos");
            Console.WriteLine("2. Ver Pagos por tipo de Servicio");
            Console.WriteLine("3. Ver Pagos por código de caja");
            Console.WriteLine("4. Ver Dinero Comisionado por servicios");
            Console.WriteLine("5. Regresar Menú Principal");
           
            Console.Write("Ingrese su opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    TodosPagos();
                    break;
                case "2":
                    PagoTipoServicio();
                    break;
                case "3":
                    PagoCodigoCaja();
                    break;
                case "4":
                    DineroComisionado();
                    break;

                case "5":
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese 8 para volver al Menú Principal.");
                    break;
            }
        }
    }

    static void TodosPagos() 
    {
        Console.WriteLine("\t \t \t \tSistema Pago de Servicios Publicos");
        Console.WriteLine("\t \t \t \t Reporte Todos los Pagos");
        Console.WriteLine("\n");
        Console.WriteLine("\t#Pago \t#Fecha/Hora Pago \tCedula \tNombre \tApellido1 \tApellido2 \tMonto Recibo");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");


        
        int totalPagos = 0;
        double totalMonto = 0;

        
        for (int i = 0; i < cantidadPagos; i++)
        {

            //Console.WriteLine($"\t{numerosPago[i]} \t{fechas[i].ToShortDateString()} {horas[i]} \t{cedula[i]} \t{nombres[i]} \t{apellido1[i]} \t{apellido2[i]} \t{montosPagar[i]}");
            Console.WriteLine($"\t{numerosPago[i]} \t \t{cedula[i]} \t{nombres[i]} \t{apellido1[i]} \t{apellido2[i]} \t{montosPagar[i]}");

            totalPagos++;
            totalMonto += montosPagar[i];
        }

        
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine($"\t \t \tTotal de Registros: {totalPagos} \t \t \t Monto Total: {totalMonto} \t \t \t");
        
        


    }

    static void PagoTipoServicio()
    {
        Console.WriteLine("\t \t \t \tSistema Pago de Servicios Publicos");
        Console.WriteLine("\t \t \t \t Reporte Todos los Pagos por Tipo Servicio");
        Console.WriteLine("\n");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("Seleccione Codigo de Servicio: [1] Electricidad [2] Telefono [3] Agua ] ");
        int codigoServicio = Convert.ToInt32(Console.ReadLine());
        int OptipoServicio = int.Parse(Console.ReadLine());
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        

        Console.WriteLine("\t#Pago \t#Fecha/Hora Pago \tCedula \tNombre \tApellido1 \tApellido2 \tMonto Recibo");
        
        int totalTipoServicio = 0;
        double totalPagosTipoServicio = 0;

        for (int i = 0; i < cantidadPagos; i++)
        {
            if (tipoServicio[i] == OptipoServicio)
            {
                Console.WriteLine($"\t{numerosPago[i]} \t \t {cedula[i]} \t{nombres[i]} \t{apellido1[i]} \t{apellido2[i]} \t{montosPagar[i]}");

                totalTipoServicio++;
                totalPagosTipoServicio += montosPagar[i];
            }
        }

        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine($"\t \t \tTotal de Registros  {totalTipoServicio} \t \t \t Monto Total: {totalPagosTipoServicio} \t \t \t");


    }

    static void PagoCodigoCaja()
    {
        Console.WriteLine("\t \t \t \tSistema Pago de Servicios Publicos");
        Console.WriteLine("\t \t \t \t Reporte Todos los Pagos por Codigo De Cajero");
        Console.WriteLine("\n");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("Seleccione Codigo de Cajero: [1] Caja #1 [2] Caja #2 [3] Caja #3 ] ");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");

       


        Console.WriteLine("\t#Pago \t#Fecha/Hora Pago \tCedula \tNombre \tApellido1 \tApellido2 \tMonto Recibo");


        int OpcionCaja = int.Parse(Console.ReadLine());
        int totalCajas = 0;
        double totalPagosCajas = 0;

        for (int i = 0; i < cantidadPagos; i++)
        {
            if (numerosCaja[i] == OpcionCaja)
            {
                Console.WriteLine($"\t \t{numerosPago[i]} \t{cedula[i]} \t{nombres[i]} \t{apellido1[i]} \t{apellido2[i]} \t{montosPagar[i]}");

                totalCajas++;
                totalPagosCajas += montosPagar[i];
            }
        }

        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine($"\t \t \tTotal de Registros  {totalCajas} \t \t \t Monto Total: {totalPagosCajas} \t \t \t");

    }

    static void DineroComisionado()
    {
        
        Console.WriteLine("\t \t \t \t Reporte de Dinero Comisionado- Desgloce por Tipo Servicio");
        Console.WriteLine("\n");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t ITEM \t \t \t Cant.Transacciones \t \t \t Total Comisionado");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\n");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");
        Console.WriteLine("\t--------------------------------------------------------------------------------------------");

        //debe de presionar cualquier tecla para regresar al submenu de reportes


       

    }
}




