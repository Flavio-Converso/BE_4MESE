﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console25_06
{
    public class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public string Descrizione { get; set; }
        public List<string> Compiti { get; set; }
    }
}
