using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Grabacion : Evidencia
    {
        public int Calidad {  get; set; }
        public bool CapturarAlSospechosoInfraganti { get; set; }



        public Grabacion()
        {
           
        }

        public Grabacion(DateTime fechaRecoleccion, string descripcion, int calidad, bool capturaAlSospechosoInfraganti)
        {
            FechaRecoleccion = fechaRecoleccion;
            Descripcion = descripcion;
            Calidad = calidad;
            CapturarAlSospechosoInfraganti = capturaAlSospechosoInfraganti;

            Validar();
        }

        public override int CalcularPeso()
        {
            return -1;
        }

        public override void Validar()
        {
            base.Validar();
            ValidarCalidad();
        }

        private void ValidarCalidad()
        {
            if(Calidad < 1 || Calidad > 5)
            {
                throw new Exception("La calidad debe estar entre 1 y 5");
            }
        }
    }
}

