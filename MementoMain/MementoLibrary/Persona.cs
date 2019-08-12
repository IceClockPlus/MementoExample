using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLibrary
{
    public class Persona
    {
        private String _rut;
        private String _nombre;
        private String _apellido;
        private DateTime _fechaNac;
        private String _email;
        private int _telefono;
        private Sexo _sexo;

        public String Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Sexo Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }


        public Persona()
        {
            this.Rut = String.Empty;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
            this.FechaNac = DateTime.Today;
            this.Email = string.Empty;
            this.Telefono = 0;
            this.Sexo = new Sexo();
        }

       
        public String ListarDatos()
        {
            String datos = String.Format("Rut: {0} \nNombre Completo: {1} {2} \nFecha Nacimiento: {3}", this.Rut, this.Nombre, this.Apellido, this.FechaNac);
            return datos;
        }

        public MementoPersona Guardar()
        {
            MementoPersona m = new MementoPersona();
            m.Rut = this.Rut;
            m.Nombre = this.Nombre;
            m.Apellido = this.Apellido;
            m.FechaNac = this.FechaNac;
            m.Email = this.Email;
            m.Telefono = this.Telefono;
            m.Sexo = this.Sexo;
            return m;
        }

        public void Restaurar(MementoPersona m)
        {
            this.Rut = m.Rut;
            this.Nombre = m.Nombre;
            this.Apellido = m.Apellido;
            this.FechaNac = m.FechaNac;
            this.Email = m.Email;
            this.Telefono = m.Telefono;
            this.Sexo = m.Sexo;
        }

    }
}
