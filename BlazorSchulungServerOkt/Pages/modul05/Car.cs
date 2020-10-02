using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungServerOkt.Pages.modul05
{
    public class Car
    {
        public int ID { get; set; }
        [Range(40,500,ErrorMessage ="PS Range beachten")]
        public int Leistung { get; set; }
        [Required(ErrorMessage ="Brauchste Hersteller")]
        [MaxLength(5,ErrorMessage ="nur Kürzel")]
        public string Hersteller { get; set; }
        public DateTime Jahr { get; set; }
    }
}
