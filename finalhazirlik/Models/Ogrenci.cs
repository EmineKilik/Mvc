using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalhazirlik.Models
{
    [Table("tblogrenci")]
    public class Ogrenci
    {
        
        public int OgrenciId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [MaxLength(50)]
        [Required]
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public float OgrenciVize { get; set; }
        public float OgrenciFinal { get; set; }
        public float OgrenciOrtalama { get; set; }
    }
}
