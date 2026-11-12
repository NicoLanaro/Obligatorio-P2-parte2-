using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Sospechoso
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }

        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public bool TieneAntecedentes { get; set; }




        public Sospechoso()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Sospechoso(string nombre, string cedula, DateTime fechaNacimiento, bool tieneAntecedentes) : this()
        {
            Nombre = nombre;
            Cedula = cedula;
            FechaNacimiento = fechaNacimiento;
            TieneAntecedentes = tieneAntecedentes;

            Validar();
        }

        public void Validar() 
        {
            ValidarNombre();
            ValidarCedula();
            ValidarFechaNacimiento();
        }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }
        }

        
        private void ValidarCedula()
        {
            if (string.IsNullOrEmpty(Cedula))
            {
                throw new Exception("La cedula es obligatoria");
            }
        }

        private void ValidarFechaNacimiento()
        {
            if(FechaNacimiento > DateTime.Now)
            {
                throw new Exception("La fecha de nacimiento no es válida");
            }

        }
        public override string ToString()
        {
            return $"{Cedula} - {Nombre}";
        }
    }
}
