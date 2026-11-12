using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    //Interfaz de validación: toda clase del dominio que deba validarse
    //antes de darse de alta en el sistema la implementa.
    //Si los datos no son válidos, Validar() lanza una Exception con un mensaje explicativo.
    public interface IValidable
    {
        void Validar();
    }
}
