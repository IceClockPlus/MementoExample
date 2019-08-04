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

        public Persona()
        {
            this.Rut = String.Empty;
            this.Nombre = String.Empty;
            this.Apellido = String.Empty;
            this.FechaNac = DateTime.Today;
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
            return m;
        }

        public void Restaurar(MementoPersona m)
        {
            this.Rut = m.Rut;
            this.Nombre = m.Nombre;
            this.Apellido = m.Apellido;
            this.FechaNac = m.FechaNac;
        }

    }
}
