using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Evidencia
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public DateTime FechaRecoleccion { get; set; }
        public string Descripcion { get; set; }



        public Evidencia()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Evidencia(DateTime fechaRecoleccion, string descripcion) : this()
        {
            FechaRecoleccion = fechaRecoleccion;
            Descripcion = descripcion;

          
        }

        public abstract int CalcularPeso();


        public virtual void Validar()
        {
            ValidarFechaRecoleccion();
            ValidarDescripcion();
        }

        private void ValidarFechaRecoleccion()
        {
            if(FechaRecoleccion > DateTime.Now)
            {
                throw new Exception("La fecha de recoleccion no es válida");
            }
        }

        private void ValidarDescripcion()
        {
            if (string.IsNullOrEmpty(Descripcion))
            {
                throw new Exception("La descripción es obligatoria");
            }
        }


        public override string ToString()
        {
            return $"{Id} - {Descripcion}";
        }

}
}
