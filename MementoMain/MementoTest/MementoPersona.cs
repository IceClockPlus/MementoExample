using System;
using System.Collections.Generic;
using System.Text;

namespace MementoTest
{
    [Serializable]
    public class MementoPersona
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

        public MementoPersona()
        {
            this.Rut = string.Empty;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.FechaNac = DateTime.Today;
        }

    }
}
