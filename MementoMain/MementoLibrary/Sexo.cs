using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLibrary
{
    public class Sexo
    {
        private int _idSexo;
        private String _nombreSexo;

        public int IdSexo
        {
            get { return _idSexo; }
            set { _idSexo = value; }
        }

        public String NombreSexo
        {
            get { return _nombreSexo; }
            set { _nombreSexo = value; }
        }

        public Sexo(){
            this.IdSexo = 0;
            this.NombreSexo = string.Empty;
        }
        
            

    }
}
