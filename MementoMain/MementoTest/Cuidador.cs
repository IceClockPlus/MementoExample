using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;


namespace MementoTest
{
    public class Cuidador
    {
        private MementoPersona _memento;

        public MementoPersona MementoPersona
        {
            set { _memento = value; }
            get { return _memento; }
        }

        public Cuidador()
        {
            this.MementoPersona = null;
        }

        public void CrearArchivoGuardado()
        {
            var filename = Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                , @"Historial\registro.txt");
            SerializerHelper.SerializeObject(filename, MementoPersona);
        }

        public void RecuperarMemento()
        {
            var filename = Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
                , @"Historial\registro.txt");
            this.MementoPersona = SerializerHelper.DeSerializeObject<MementoPersona>(filename);
        }

    }
}
