using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonu
{
    class Muster : Kulanici {
        private string Tckn;
        public string checkin;
        public string checkout;
        public decimal kisiSayisi;
        public decimal ucret;
        public string ekstra;
        public EnumOda Oda { get; set; }
        public static int odaSayisi ;


       // public virtual string Adsoyad() { return ad + soyad; }


       //overload nesen çağrılınca ilk arkada dönen değerler 
        public Muster()
        {
            odaSayisi = 30;
            ad = "ece";
            soyad = "kaya";

        }
        public Muster(string Ad)
        {
            odaSayisi = 30;
            Ad = ad;
            soyad = "kaya";
  
        }
        public Muster(string Ad,string Soyad)
        {
            odaSayisi = 30;
            Ad = ad;
            Soyad = soyad;
    
        }

        DateTime bugun = DateTime.Now.Date;

        public string TCKN
        {
            get
            {
                return Tckn;
            }
            set
            {
                if (value.Length == 11)//property'e dışarıdan gönderdiğimiz değer value dir.
                    Tckn = value;
                else
                    throw new
                        Exception("TCKN 11 haneli olmalı ve '0' ile başlamamalı...");//dışarıdan girilen değer 11 haen değilse hata kodu
            }
        }

        //public DateTime CheckIN
        //{
        //    get
        //    { return checkin; }
        //    set
        //    {
        //        if (value >= DateTime.Now.Date)
        //        {
        //            checkin = value;

        //        }
        //        else
        //        {

        //            throw new Exception("Check-in Şuanki tarihten küçük olamaz");
        //        }
        //    }
        //}


        //public DateTime CheckOUT
        //{
        //    get { return checkout; }
        //    set
        //    {
        //        if (DateTime.Now >= checkin)
        //        {

        //            checkout = value;
        //        }
        //        else { throw new Exception("Check-out, Check-in ile aynı gün veya daha küçük olamaz."); }
        //    }
        //}

    }
    enum EnumOda
    {
        Suit, DenizManzaralı, JuniorSuit, StandartOda
    }
}

