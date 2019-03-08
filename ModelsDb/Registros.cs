using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsDb
{
    public class Registros
    {
        public int RegistroId { get; set; }
        public DateTime DataRegistro { get; set; }
        public string SerialHDD { get; set; }
        public string ModelMachine { get; set; }
        public string SerialMachine { get; set; }
        public string Usuario { get; set; }
        public string FabricanteId { get; set; }
        public string TipoId { get; set; }
        public string Status { get; set; }
    }
}
