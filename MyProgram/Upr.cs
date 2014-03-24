using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProgram
{
    class Upr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Fio { get; set; }
        public string E_mail { get; set; }

        public Branch ToGrid()
        {
            return new Branch()
            {
                Name = Name,
                Address = Address,
                Fio = Fio,
                E_mail = E_mail
            };  
        }
    }
}
