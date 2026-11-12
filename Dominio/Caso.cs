using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Caso
    {
        public int Id {  get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstaCerrado { get; set; }

        public Sospechoso SospechosoPrincipal { get; set; }

        public Investigador Investigador { get; set; }

        public List<Evidencia> Evidencias { get; set; }


   
        public Caso()
        {
            Id = UltimoId;
            UltimoId++;

            Evidencias = new List<Evidencia>();
        }

        public Caso(string nombre, string descripcion, bool estaCerrado, Sospechoso sospechosoPrincipal, Investigador investigador) : this()
        {
            Nombre = nombre;
            Descripcion = descripcion;
            EstaCerrado = estaCerrado;
            SospechosoPrincipal = sospechosoPrincipal;
            Investigador = investigador;

            Validar();
            
        }


        public void AgregarEvidencia(Evidencia evidencia)
        {
            Evidencias.Add(evidencia);
        }

        public int CalcularPesoEvidencias()
        {
            int total = 0;

            foreach(Evidencia e in Evidencias)
            {
                total += e.CalcularPeso();

            }

            return total;
        }

        public string ElaborarRecomendacion()
        {
            return "";
        }

        public void Validar()
        {
            ValidarNombre();
            ValidarDescripcion();
            ValidarSospechoso();
            ValidarInvestigador();
        }

        // Validaciones
        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre no puede ser vacío");
            }
        }

        private void ValidarDescripcion()
        {
            if (string.IsNullOrEmpty(Descripcion))
            {
                throw new Exception("La descripción no puede estar vacía");
            }
        }

        private void ValidarSospechoso()
        {
            if(SospechosoPrincipal == null)
            {
                throw new Exception("El sospechoso no puede ser nulo");
            }
        }

        private void ValidarInvestigador()
        {
            if(Investigador == null)
            {
                throw new Exception("El investigador no puede ser nulo");
            }

            if(Investigador.Rol != Rol.Detective)
            {
                throw new Exception("El investigador debe tener rol Detective");
            }
        }


        public override string ToString()
        {
            return $"{Id} - {Nombre}";
            ;
        }

    }
}
