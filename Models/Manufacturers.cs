using System.Collections.Generic;

namespace Pro11WA.Models
{
    public class Manufacturers 
    {
        internal int Id;

        [System.ComponentModel.DataAnnotations.Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public int CompanyProducts { get; set; }

        public IEnumerable<Furnace> Furnaces { get; set; }
        //public object Id { get; set; }
    }
}