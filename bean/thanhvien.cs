using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Baikiemtranhom1.bean
{
    class thanhvien
    {
        public string tengoi { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string manhom { get; set; }
        public string diachi { get; set; }
        public static List<thanhvien> getfromfile(string filename,string manhom)
        {
            var array = File.ReadAllLines(filename);
            List<thanhvien> kq = new List<thanhvien>();
            foreach(var line in array)
            {
                var temp = line.Split(new char[] { ';' });
                var thanhvien = new thanhvien { 
                    manhom=temp[0],
                    tengoi = temp[1],
                    email=temp[2],
                    phone=temp[3],
                    diachi=temp[4]
                };
                if(manhom.Equals(temp[0])) kq.Add(thanhvien);
            }
            return kq;
        }

    }
}
