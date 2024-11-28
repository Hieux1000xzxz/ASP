using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tx2tx2
{
    public class tblPhuongTien
    {
        public int mapt { get; set; }
        public string tenpt { get; set; }
        public double giatien { get; set; }

        public tblPhuongTien()
        {
               
        }
        public tblPhuongTien(int mapt, string tenpt, double giatien)
        {
            this.mapt = mapt;
            this.tenpt = tenpt;
            this.giatien = giatien;
        }
    }
}