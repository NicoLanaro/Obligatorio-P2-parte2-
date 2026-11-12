using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Sistema
    {
        private List<Investigador> _investigadores {  get; } = new List<Investigador>();
        private List<Sospechoso> _sospechosos { get; } = new List<Sospechoso>();

        private List<Caso> _casos { get; } = new List<Caso>();


        private static Sistema _instancia;

        private Sistema()
        {
            PrecargarDatos();
        }

        // Devuelve la única instancia de Sistema.
        public static Sistema GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Sistema();
            }

            return _instancia;
        }

        private void PrecargarDatos()
        {
            PrecargarInvestigadores();
            PrecargarSospechosos();
            PrecargarCasos();
            PrecargarEvidencias();

        }


        private void PrecargarInvestigadores()
        {
            Investigador i1 = new Investigador("detective1@gmail.com", "clave1", "Detective uno", Rol.Detective);
            AltaInvestigador(i1);
            Investigador i2 = new Investigador("detective2@gmail.com", "clave2", "Detective Dos", Rol.Detective);
            AltaInvestigador(i2);
            Investigador i3 = new Investigador("detective3@gmail.com", "clave3", "Detective Tres", Rol.Detective);
            AltaInvestigador (i3);
            Investigador i4 = new Investigador("detective4@gmail.com", "clave4", "Detective Cuatro", Rol.Detective);
            AltaInvestigador(i4);
            Investigador i5 = new Investigador("detective5@gmail.com", "clave5", "Detective Cinco", Rol.Detective);
            AltaInvestigador(i5);
            Investigador i6 = new Investigador("fiscal1@gmail.com", "clave6", "Fiscal Uno", Rol.Fiscal);
            AltaInvestigador(i6);
            Investigador i7 = new Investigador("fiscal2@gmail.com", "clave7", "Fiscal Dos", Rol.Fiscal);
            AltaInvestigador(i7);
            Investigador i8 = new Investigador("fiscal3@gmail.com", "clave8", "Fiscal Tres", Rol.Fiscal);
            AltaInvestigador(i8);
            Investigador i9 = new Investigador("fiscal4@gmail.com", "clave9", "Fiscal Cuatro", Rol.Fiscal);
            AltaInvestigador(i9);
            Investigador i10 = new Investigador("fiscal5@gmail.com", "clave10", "Fiscal Cinco", Rol.Fiscal);
            AltaInvestigador(i10);
        }

        private void PrecargarSospechosos()
        {
            Sospechoso s1 = new Sospechoso("Juan Perez", "11111111", new DateTime(1985, 3, 15), true);
            AltaSospechoso(s1);
            Sospechoso s2 = new Sospechoso("Maria Rodriguez", "22222222", new DateTime(1990, 7, 22), false);
            AltaSospechoso(s2);
            Sospechoso s3 = new Sospechoso("Carlos Martinez", "33333333", new DateTime(1978, 11, 5), true);
            AltaSospechoso(s3);
            Sospechoso s4 = new Sospechoso("Lucia Fernandez", "44444444", new DateTime(1995, 1, 30), false);
            AltaSospechoso(s4);
            Sospechoso s5 = new Sospechoso("Andres Gonzalez", "55555555", new DateTime(1982, 9, 18), true);
            AltaSospechoso(s5);
            Sospechoso s6 = new Sospechoso("Valentina Silva", "66666666", new DateTime(1993, 6, 12), false);
            AltaSospechoso(s6);
            Sospechoso s7 = new Sospechoso("Martin Lopez", "77777777", new DateTime(1987, 4, 25), true);
            AltaSospechoso(s7);
            Sospechoso s8 = new Sospechoso("Camila Torres", "88888888", new DateTime(1998, 12, 8), false);
            AltaSospechoso(s8);
            Sospechoso s9 = new Sospechoso("Diego Ramirez", "99999999", new DateTime(1975, 2, 14), true);
            AltaSospechoso(s9);
            Sospechoso s10 = new Sospechoso("Sofia Castro", "10101010", new DateTime(1991, 10, 3), false);
            AltaSospechoso(s10);
            Sospechoso s11 = new Sospechoso("Nicolas Pereira", "12121212", new DateTime(1984, 5, 27), true);
            AltaSospechoso(s11);
            Sospechoso s12 = new Sospechoso("Florencia Suarez", "13131313", new DateTime(1996, 8, 19), false);
            AltaSospechoso (s12);
            Sospechoso s13 = new Sospechoso("Sebastian Acosta", "14141414", new DateTime(1980, 1, 11), true);
            AltaSospechoso(s13);
            Sospechoso s14 = new Sospechoso("Agustina Mendez", "15151515", new DateTime(1994, 4, 6), false);
            AltaSospechoso(s14);
            Sospechoso s15 = new Sospechoso("Federico Cabrera", "16161616", new DateTime(1989, 9, 24), true);
            AltaSospechoso(s15);
        }

        private void PrecargarCasos()
        {
            Caso c1 = new Caso("Robo en supermercado", "Investigacion por mercaderia robada de un supermercado", false, BuscarSospechoso("11111111"), BuscarInvestigador("detective1@gmail.com"));
            AltaCaso(c1);
            Caso c2 = new Caso("Fraude bancario", "Investigacion por movimientos bancarios sospechosos", false, BuscarSospechoso("22222222"), BuscarInvestigador("detective2@gmail.com"));
            AltaCaso(c2);
            Caso c3 = new Caso("Robo de vehiculo", "Investigacion por la desaparicion de un vehiculo", false, BuscarSospechoso("33333333"), BuscarInvestigador("detective3@gmail.com"));
            AltaCaso(c3);
            Caso c4 = new Caso("Incendio en deposito", "Investigacion sobre un incendio ocurrido en un deposito", true, BuscarSospechoso("44444444"), BuscarInvestigador("detective4@gmail.com"));
            AltaCaso(c4);
            Caso c5 = new Caso("Falsificacion de documentos", "Investigacion por la presentacion de documentos falsificados", false, BuscarSospechoso("55555555"), BuscarInvestigador("detective5@gmail.com"));
            AltaCaso(c5);
            Caso c6 = new Caso("Robo en vivienda", "Investigacion por objetos robados de una vivienda", true, BuscarSospechoso("66666666"), BuscarInvestigador("detective1@gmail.com"));
            AltaCaso(c6);
            Caso c7 = new Caso("Estafa comercial", "Investigacion por una posible estafa en una compraventa", false, BuscarSospechoso("77777777"), BuscarInvestigador("detective2@gmail.com"));
            AltaCaso(c7);
            Caso c8 = new Caso("Robo de obras de arte", "Investigacion por la desaparicion de obras de una galeria", false, BuscarSospechoso("88888888"), BuscarInvestigador("detective3@gmail.com"));
            AltaCaso(c8);
            Caso c9 = new Caso("Daños a propiedad", "Investigacion por daños provocados en una propiedad privada", true, BuscarSospechoso("99999999"), BuscarInvestigador("detective4@gmail.com"));
            AltaCaso(c9);
            Caso c10 = new Caso("Desaparicion de mercaderia", "Investigacion por mercaderia desaparecida durante un traslado", false, BuscarSospechoso("10101010"), BuscarInvestigador("detective5@gmail.com"));
            AltaCaso(c10);
        }

        private void PrecargarEvidencias()
        {
            //Caso1
            Evidencia e1 = new Fisica(new DateTime(2026, 1, 10), "Huella encontrada en la puerta del supermercado", true);
            AltaEvidencia(1, e1);
            Evidencia e2 = new Grabacion(new DateTime(2026, 1, 10), "Grabacion de la camara de seguridad", 4, true);
            AltaEvidencia(1, e2);
            Evidencia e3 = new Testimonio(new DateTime(2026, 1, 11), "Declaracion de una persona presente en el lugar", "Testigo Uno", IndiceCredibilidad.Alto);
            AltaEvidencia(1, e3);
            Evidencia e4 = new Fisica(new DateTime(2026, 1, 11), "Herramienta encontrada cerca de la entrada", false);
            AltaEvidencia(1, e4);
            //Caso2
            Evidencia e5 = new Fisica(new DateTime(2026, 2, 5), "Documentos bancarios impresos", false);
            AltaEvidencia(2, e5);
            Evidencia e6 = new Grabacion(new DateTime(2026, 2, 5), "Grabacion de un cajero automatico", 3, false);
            AltaEvidencia(2, e6);
            Evidencia e7 = new Testimonio(new DateTime(2026, 2, 6), "Declaracion de una persona empleada en el banco", "Testigo Dos", IndiceCredibilidad.Medio);
            AltaEvidencia(2, e7);
            Evidencia e8 = new Testimonio(new DateTime(2026, 2, 6), "Declaracion de una persona titular de una cuenta", "Testigo Tres", IndiceCredibilidad.Alto);
            AltaEvidencia(2, e8);
            //Caso3
            Evidencia e9 = new Fisica(new DateTime(2026, 3, 3), "Llave encontrada cerca del lugar", true);
            AltaEvidencia(3, e9);
            Evidencia e10 = new Grabacion(new DateTime(2026, 3, 3), "Grabacion de una camara ubicada en la calle", 5, true);
            AltaEvidencia(3, e10);
            Evidencia e11 = new Testimonio(new DateTime(2026, 3, 4), "Declaracion de una persona que observo el vehiculo", "Testigo Cuatro", IndiceCredibilidad.Alto);
            AltaEvidencia(3, e11);
            Evidencia e12 = new Grabacion(new DateTime(2026, 3, 4), "Grabacion de una estacion de servicio", 2, false);
            AltaEvidencia(3, e12);
            //Caso4
            Evidencia e13 = new Fisica(new DateTime(2026, 4, 8), "Recipiente encontrado dentro del deposito", true);
            AltaEvidencia(4, e13);
            Evidencia e14 = new Grabacion(new DateTime(2026, 4, 8), "Grabacion del exterior del deposito", 3, false);
            AltaEvidencia(4, e14);
            Evidencia e15 = new Testimonio(new DateTime(2026, 4, 9), "Declaracion de una persona que trabajaba en el deposito", "Testigo Cinco", IndiceCredibilidad.Medio);
            AltaEvidencia(4, e15);
            Evidencia e16 = new Fisica(new DateTime(2026, 4, 9), "Prenda encontrada cerca del lugar del incendio", false);
            AltaEvidencia(4, e16);
            //Caso5
            Evidencia e17 = new Fisica(new DateTime(2026, 5, 12), "Documento con una firma presuntamente falsificada", true);
            AltaEvidencia(5, e17);
            Evidencia e18 = new Grabacion(new DateTime(2026, 5, 12), "Grabacion de la entrega de los documentos", 4, true);
            AltaEvidencia(5, e18);
            Evidencia e19 = new Testimonio(new DateTime(2026, 5, 13), "Declaracion de una persona responsable de recibir documentos", "Testigo Seis", IndiceCredibilidad.Alto);
            AltaEvidencia(5, e19);
            Evidencia e20 = new Testimonio(new DateTime(2026, 5, 13), "Declaracion de una persona especializada en documentos", "Testigo Siete", IndiceCredibilidad.Alto);
            AltaEvidencia(5, e20);
            //Caso6
            Evidencia e21 = new Fisica(new DateTime(2026, 6, 3), "Objeto encontrado dentro de la vivienda", true);
            AltaEvidencia(6, e21);
            Evidencia e22 = new Grabacion(new DateTime(2026, 6, 3), "Grabacion de una vivienda cercana", 3, true);
            AltaEvidencia(6, e22);
            Evidencia e23 = new Testimonio(new DateTime(2026, 6, 4), "Declaracion de una persona residente en la zona", "Testigo Ocho", IndiceCredibilidad.Medio);
            AltaEvidencia(6, e23);
            Evidencia e24 = new Fisica(new DateTime(2026, 6, 4), "Huella encontrada en una ventana", true);
            AltaEvidencia(6, e24);
            //Caso7
            Evidencia e25 = new Fisica(new DateTime(2026, 7, 14), "Contrato de compraventa encontrado", false);
            AltaEvidencia(7, e25);
            Evidencia e26 = new Grabacion(new DateTime(2026, 7, 14), "Grabacion del momento de la compraventa", 5, true);
            AltaEvidencia(7, e26);
            Evidencia e27 = new Testimonio(new DateTime(2026, 7, 15), "Declaracion de una persona presente durante la operacion", "Testigo Nueve", IndiceCredibilidad.Alto);
            AltaEvidencia(7, e27);
            Evidencia e28 = new Grabacion(new DateTime(2026, 7, 15), "Grabacion del ingreso al establecimiento", 2, false);
            AltaEvidencia(7, e28);
            //Caso8
            Evidencia e29 = new Fisica(new DateTime(2026, 8, 2), "Marco de una obra encontrado en el lugar", true);
            AltaEvidencia(8, e29);
            Evidencia e30 = new Grabacion(new DateTime(2026, 8, 2), "Grabacion del interior de la galeria", 4, true);
            AltaEvidencia(8, e30);
            Evidencia e31 = new Testimonio(new DateTime(2026, 8, 3), "Declaracion de una persona responsable de la seguridad", "Testigo Diez", IndiceCredibilidad.Alto);
            AltaEvidencia(8, e31);
            Evidencia e32 = new Testimonio(new DateTime(2026, 8, 3), "Declaracion de una persona visitante de la galeria", "Testigo Once", IndiceCredibilidad.Bajo);
            AltaEvidencia(8, e32);
            //Caso9
            Evidencia e33 = new Fisica(new DateTime(2026, 9, 5), "Herramienta encontrada en la propiedad", true);
            AltaEvidencia(9, e33);
            Evidencia e34 = new Grabacion(new DateTime(2026, 9, 5), "Grabacion de una camara exterior", 3, false);
            AltaEvidencia(9, e34);
            Evidencia e35 = new Testimonio(new DateTime(2026, 9, 6), "Declaracion de una persona residente en una propiedad cercana", "Testigo Doce", IndiceCredibilidad.Medio);
            AltaEvidencia(9, e35);
            Evidencia e36 = new Fisica(new DateTime(2026, 9, 6), "Prenda encontrada en el terreno", false);
            AltaEvidencia(9, e36);
            //Caso10
            Evidencia e37 = new Fisica(new DateTime(2026, 10, 1), "Caja vacia encontrada durante el traslado", true);
            AltaEvidencia(10, e37);
            Evidencia e38 = new Grabacion(new DateTime(2026, 10, 1), "Grabacion del deposito de salida", 4, true);
            AltaEvidencia(10, e38);
            Evidencia e39 = new Testimonio(new DateTime(2026, 10, 2), "Declaracion de una persona encargada del traslado", "Testigo Trece", IndiceCredibilidad.Medio);
            AltaEvidencia(10, e39);
            Evidencia e40 = new Grabacion(new DateTime(2026, 10, 2), "Grabacion del lugar de entrega", 2, false);
            AltaEvidencia(10, e40);

        }

        // Buscar un investigador por su email
        public Investigador BuscarInvestigador(string email)
        {
            Investigador investigadorEncontrado = null;

            foreach (Investigador investigador in _investigadores)
            {
                if (investigador.Email == email)
                {
                    investigadorEncontrado = investigador;
                }
            }

            return investigadorEncontrado;
        }


        //Validar investigador y controla que no exista otro registrado con el mismo mail
        public void AltaInvestigador(Investigador investigador)
        {
            if (investigador == null)
            {
                throw new Exception("El investigador no puede ser nulo");
            }

            if (BuscarInvestigador(investigador.Email) != null) // aca se puede usar el Contains y sobrescribir el Equals en clase Investigador.
            {
                throw new Exception("Ya existe un investigador con ese email");
            }

            investigador.Validar();
            _investigadores.Add(investigador);
        }


        // Buscar un sospechoso por su cédula
        public Sospechoso BuscarSospechoso(string cedula)
        {
            Sospechoso sospechosoEncontrado = null;

            foreach (Sospechoso sospechoso in _sospechosos)
            {
                if (sospechoso.Cedula == cedula)
                {
                    sospechosoEncontrado = sospechoso;
                    
                }
            }

            return sospechosoEncontrado;
        }


        // Validar sospechoso y controla que su cedula no esté registrada
        public void AltaSospechoso(Sospechoso sospechoso)
        {
            if (sospechoso == null)
            {
                throw new Exception("El sospechoso no puede ser nulo");
            }

            if (BuscarSospechoso(sospechoso.Cedula) != null)
            {
                throw new Exception("Ya existe un sospechoso con esa cédula");
            }

            sospechoso.Validar();
            _sospechosos.Add(sospechoso);
        }



        // Buscar un caso mediante su identificador
        public Caso BuscarCaso(int id)
        {
            Caso casoEncontrado = null;

            foreach (Caso caso in _casos)
            {
                if (caso.Id == id)
                {
                    casoEncontrado = caso;                   
                }
            }

            return casoEncontrado;
        }


        // Valida los datos del caso, sin repetir Id y que el investigador tenga asignado rol detective
        public void AltaCaso(Caso caso)
        {
            if (caso == null)
            {
                throw new Exception("El caso no puede ser nulo");
            }

            if (BuscarCaso(caso.Id) != null)
            {
                throw new Exception("Ya existe un caso con ese ID");
            }

            caso.Validar();
            _casos.Add(caso);
        }



        // Agrega una evidencia a un caso existente
        public void AltaEvidencia(int idCaso, Evidencia evidencia)
        {
            if (evidencia == null)
            {
                throw new Exception("La evidencia no puede ser nula");
            }

            Caso casoEncontrado = BuscarCaso(idCaso);

            if (casoEncontrado == null)
            {
                throw new Exception("No existe un caso con ese ID");
            }

            evidencia.Validar();
            casoEncontrado.AgregarEvidencia(evidencia);
        }


        public List<Caso> ListarCasos()
        {
            List<Caso> casosListado = new List<Caso>();

            foreach (Caso caso in _casos)
            {
                casosListado.Add(caso);
            }

            return casosListado;
        }


        // Obtiene todos los casos investigados por la persona del mail que recibe como parametro
        public List<Caso> BuscarCasosPorEmailInvestigador(string email)
        {
            List<Caso> casosEncontrados = new List<Caso>();

            foreach (Caso caso in _casos)
            {
                if (caso.Investigador.Email == email)
                {
                    casosEncontrados.Add(caso);
                }
            }

            return casosEncontrados;
        }


        // Devuelve todos los sospechosos que tienen antecedentes registrados
        public List<Sospechoso> ListarSospechososConAntecedentes()
        {
            List<Sospechoso> sospechososConAntecedentes = new List<Sospechoso>();

            foreach (Sospechoso sospechoso in _sospechosos)
            {
                if (sospechoso.TieneAntecedentes)
                {
                    sospechososConAntecedentes.Add(sospechoso);
                }
            }

            return sospechososConAntecedentes;
        }



    }


}
