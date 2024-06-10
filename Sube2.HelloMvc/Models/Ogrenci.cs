﻿using Sube2.HelloMvc.Models.Relationships;

namespace Sube2.HelloMvc.Models
{
    public class Ogrenci
    {
        public int Ogrenciid { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public int Numara { get; set; }

        public ICollection<OgrenciDers>? OgrenciDersler { get; set; }

        public override string ToString() => $"Ad:{this.Ad} Soyad:{this.Soyad} Numara:{this.Numara}";
    }
}