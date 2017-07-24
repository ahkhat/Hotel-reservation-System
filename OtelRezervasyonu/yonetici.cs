
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OtelRezervasyonu
{
    abstract class yonetici : Kulanici
    {
        public abstract int maas { get; set; }
    }
}