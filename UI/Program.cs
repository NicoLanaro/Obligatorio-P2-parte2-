using Dominio;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = Sistema.GetInstancia();

            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

                Console.Write("Ingrese una opcion:");

   
                    try
                    {
                      int opcion = int.Parse(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                ListarCasosConEvidencias(sistema);
                                Pausar();
                                break;

                            case 2:
                                BuscarCasosPorInvestigador(sistema);
                                Pausar();
                                break;

                            case 3:
                                AltaSospechoso(sistema);
                                Pausar();
                                break;

                            case 4:
                                ListarSospechososConAntecedentes(sistema);
                                Pausar();
                                break;

                            case 0:
                                Console.WriteLine("Fin del programa");
                                continuar = false;
                                break;

                            default:
                                Console.WriteLine("La opcion ingresada no es valida");
                                Pausar();
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error! Debe elegir un numero");
                        Pausar();
                    }
                
            }
        }




        static void MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine("SISTEMA DE GESTION DE CASOS");
            Console.WriteLine("============================");
            Console.WriteLine("1 - Listar casos con sus evidencias");
            Console.WriteLine("2 - Buscar casos por email del investigador");
            Console.WriteLine("3 - Alta de sospechoso");
            Console.WriteLine("4 - Listar sospechosos con antecedentes");
            Console.WriteLine("0 - Salir");
            Console.WriteLine();
        }


        // Opción 1 
        static void ListarCasosConEvidencias(Sistema sistema)
        {
            Console.WriteLine("LISTADO DE CASOS Y EVIDENCIAS");
            Console.WriteLine("=============================");

            List<Caso> casos = sistema.ListarCasos();

            if (casos.Count == 0)
            {
                Console.WriteLine("No existen casos registrados");
            }
            else
            {
                foreach (Caso caso in casos)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Caso: {caso.Id} - {caso.Nombre}");

                    foreach (Evidencia evidencia in caso.Evidencias)
                    {
                        Console.WriteLine(
                            $"   Evidencia: {evidencia.Id} - " +
                            $"{evidencia.Descripcion}"
                        );
                    }
                }
            }
        }
        

        // Opción 2
        static void BuscarCasosPorInvestigador(Sistema sistema)
        {
            Console.WriteLine("CASOS POR INVESTIGADOR");
            Console.WriteLine("======================");

            Console.Write("Ingrese el email del investigador: ");
            string email = Console.ReadLine();

            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("El email del investigador es obligatorio");
            }

            List<Caso> casos = sistema.BuscarCasosPorEmailInvestigador(email);

            if (casos.Count == 0)
            {
                Console.WriteLine("No se encontraron casos para ese investigador");
            }
            else
            {
                foreach (Caso caso in casos)
                {
                    Console.WriteLine(
                        $"Id: {caso.Id} | " +
                        $"Caso: {caso.Nombre} | " +
                        $"Investigador: {caso.Investigador.Nombre}"
                    );
                }
            }
        }


        // Opción 3
        static void AltaSospechoso(Sistema sistema)
        {
            Console.WriteLine("ALTA DE SOSPECHOSO");
            Console.WriteLine("==================");

            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }

            Console.Write("Ingrese la cedula: ");
            string cedula = Console.ReadLine();

            if (string.IsNullOrEmpty(cedula))
            {
                throw new Exception("La cedula es obligatoria");
            }


            Console.Write("Ingrese la fecha de nacimiento (dd/MM/yyyy): ");

            string fechaIngresada = Console.ReadLine();

            if (string.IsNullOrEmpty(fechaIngresada))
            {
                throw new Exception("La fecha de nacimiento es obligatoria");
            }


            DateTime fechaNacimiento;

            try
            {
                fechaNacimiento = DateTime.Parse(fechaIngresada);
            }
            catch
            {
                throw new Exception("La fecha de nacimiento no es valida");
            }



            Console.Write("Tiene antecedentes? (S/N): ");

            string respuestaAntecedentes = Console.ReadLine();

            if (string.IsNullOrEmpty(respuestaAntecedentes))
            {
                throw new Exception("Debe indicar si tiene antecedentes");
            }

            bool tieneAntecedentes;

            if (respuestaAntecedentes.ToUpper() == "S")
            {
                tieneAntecedentes = true;
            }
            else if (respuestaAntecedentes.ToUpper() == "N")
            {
                tieneAntecedentes = false;
            }
            else
            {
                throw new Exception("Debe ingresar S para si o N para no");
            }


            Sospechoso sospechoso = new Sospechoso(nombre,cedula,fechaNacimiento,tieneAntecedentes);

            sistema.AltaSospechoso(sospechoso);

            Console.WriteLine();
            Console.WriteLine("Sospechoso registrado correctamente");
        }



        // Opcion 4
        static void ListarSospechososConAntecedentes(Sistema sistema)
        {
            Console.WriteLine("SOSPECHOSOS CON ANTECEDENTES");
            Console.WriteLine("============================");


            List<Sospechoso> sospechosos = sistema.ListarSospechososConAntecedentes();

            if (sospechosos.Count == 0)
            {
                Console.WriteLine("No existen sospechosos con antecedentes");
            }
            else
            {
                foreach (Sospechoso sospechoso in sospechosos)
                {
                    Console.WriteLine(
                        $"Nombre: {sospechoso.Nombre} | " +
                        $"Cedula: {sospechoso.Cedula} | " +
                        $"Fecha de nacimiento: " + $"{sospechoso.FechaNacimiento:dd/MM/yyyy} | " +
                        $"Tiene antecedentes: " + $"{sospechoso.TieneAntecedentes}");
                }
            }
        }


        static void Pausar()
        {
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar" );

            Console.ReadKey();
        }
    }
}











//Console.WriteLine("Sistema iniciado correctamente");

//Console.WriteLine();
//Console.WriteLine("LISTADO DE CASOS");
//Console.WriteLine("----------------");

//List<Caso> casos = sistema.ListarCasos();

//foreach (Caso caso in casos)
//{
//    Console.WriteLine(caso);
//}

//Console.WriteLine();
//Console.WriteLine("CASOS DEL INVESTIGADOR detective1@gmail.com");
//Console.WriteLine("-------------------------------------------");

//List<Caso> casosInvestigador = sistema.BuscarCasosPorEmailInvestigador("detective1@gmail.com");

//foreach (Caso caso in casosInvestigador)
//{
//    Console.WriteLine(caso);
//}


//Console.WriteLine();
//Console.WriteLine("SOSPECHOSOS CON ANTECEDENTES");
//Console.WriteLine("----------------------------");

//List<Sospechoso> sospechososConAntecedentes = sistema.ListarSospechososConAntecedentes();

//foreach (Sospechoso sospechoso in sospechososConAntecedentes)
//{
//   Console.WriteLine(sospechoso);
//}


//Console.WriteLine();
//Console.WriteLine("CASOS CON SUS EVIDENCIAS");
//Console.WriteLine("------------------------");

//foreach (Caso caso in sistema.ListarCasos())
//{
//    Console.WriteLine();
//    Console.WriteLine($"Caso: {caso}");

//    foreach (Evidencia evidencia in caso.Evidencias)
//   {
//         Console.WriteLine($"   {evidencia}");
//    }
//}

//Console.ReadKey();


        
    

