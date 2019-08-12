using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLibrary
{
    [Serializable]
    public class MementoPersona
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

        public MementoPersona()
        {
            this.Rut = string.Empty;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.FechaNac = DateTime.Today;
            this.Email = string.Empty;
            this.Telefono = 0;
            this.Sexo = new Sexo();
        }

    }
}
