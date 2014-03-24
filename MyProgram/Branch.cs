using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Linq;

namespace MyProgram
{
    class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Fio { get; set; }
        public string E_mail { get; set; }
        public string State { get; set; }
    }
}
