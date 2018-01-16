﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel:IHotel,IData
    {
        SortedDictionary<Pokoj, Gosc> rezerwacje=new SortedDictionary<Pokoj,Gosc>();
        double zysk;
        DateTime data;

        public Hotel()
        {
            this.zysk = -80;
        }

        public void DodajRezerwacje(string imie, string nazwisko,int nrPokoju,double cenaZaDzien)
        {
            rezerwacje.Add(new Pokoj(nrPokoju, cenaZaDzien),new Gosc(imie, nazwisko));
            zysk += cenaZaDzien;
        }

        public void OdwolajRezerwacje()
        {
            try
            {
                rezerwacje.Remove(rezerwacje.Last().Key);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void UstawDate(DateTime data)
        {
            this.data = data;
        }

        public bool SprawdzDate()
        {
            if (data > DateTime.Now)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            string opis = "Rezerwacje:" + Environment.NewLine;
            opis += "Data:" + data+Environment.NewLine;
            foreach(var i in rezerwacje)
            {
                opis += "[" + i.Key.ToString() + i.Value.ToString() + "]" + Environment.NewLine;
            }
            opis += "Zysk" + zysk;

            return opis;
        }

    }
}
