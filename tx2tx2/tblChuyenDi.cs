using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tx2tx2
{
    public class tblChuyenDi
    {
        public int macd { get; set; }
        public string tencd { get; set; }
        public int songaydi { get; set; }
        public int songuoidi { get; set; }
        public int mapt { get; set; }
        public tblChuyenDi()
        {

        }
        public tblChuyenDi(int macd, string tencd, int songaydi, int songuoidi, int mapt)
        {
            this.macd=macd;
            this.tencd=tencd;
            this.songaydi = songaydi;
            this.songuoidi = songuoidi;
            this.mapt = mapt;
        }


    }
}