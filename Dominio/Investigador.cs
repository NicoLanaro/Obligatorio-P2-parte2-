using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Investigador
    {
        public int Id { get; set; }

        public static int UltimoId { get; set; } = 1;
        public string Email { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public Rol Rol {  get; set; }



        public Investigador()
        {
            Id = UltimoId;
            UltimoId++;
        }

        public Investigador(string email, string contrasenia, string nombre, Rol rol)
        {
            Email = email;
            Contrasenia = contrasenia;
            Nombre = nombre;
            Rol = rol;

            Validar();
        }


        public void Validar()
        {
            ValidarEmail();
            ValidarContrasenia();
            ValidarNombre();
        }

        private void ValidarEmail()
        {
            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("El email es obligatorio");
            }
        }

        private void ValidarContrasenia()
        {
            if (string.IsNullOrEmpty(Contrasenia))
            {
                throw new Exception("La contraseña es obligatoria");
            }
        }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }
        }

        
        public override string ToString()
        {
            return $"{Id} - {Nombre}";
        }
    }
}
