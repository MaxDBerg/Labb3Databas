using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3Databas.Models
{
    public class Kurs
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Activ { get; set; }
    }
}