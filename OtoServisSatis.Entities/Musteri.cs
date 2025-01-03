﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Musteri
namespace OtoServisSatis.Entities
{
    public class Musteri : IEntity
    {
        public int ID { get; set; }
        public int AracID { get; set; }
        [StringLength(50)]
        public string Adi {  get; set; }
        [StringLength(50)]
        public string Soyadi { get; set; }
        [StringLength(11)]
        public string? TcNo { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(250)]
        public string Adres { get; set; }
        [StringLength(15)]
        public string? Telefon { get; set; }
        public string? Notlar { get; set; }
        public virtual Arac? Arac { get; set; }

    }
}
