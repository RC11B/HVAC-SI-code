using System.ComponentModel.DataAnnotations.Schema;

namespace Pro11WA.Models
{
    public class Furnace
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int furnaceid { get; set; }

        public string brand { get; set; }

        public string modelnumber { get; set; }

        public string serialnumber { get; set; }

        public double tonnage { get; set; }

        public int size { get; set; }

        public int year { get; set; }

        [ForeignKey("Manufacturers")]
        public int CompanyId { get; set; }

        public Manufacturers manufacturers { get; set; }
    }
}
