using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsDb
{
    public class Updates
    {
        public int UpdatesId { get; set; }
        public int RegistrosId { get; set; }
        public string Username { get; set; }
        public DateTime Data { get; set; }
    }
}
