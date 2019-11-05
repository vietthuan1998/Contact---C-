using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baikiemtranhom1.bean
{
    class nhom
    {
        public string tennhom { get; set; }
        public string manhom { get; set; }
        public static List<nhom> getdatafromfile(string filename)
        {
                var arraylist = File.ReadAllLines(filename);
                List<nhom> kq = new List<nhom>();
                foreach(var line in arraylist)
                {
                    var temp = line.Split(new char[] { '#' });
                    var nhomdanhba = new nhom { tennhom = temp[1],manhom=temp[0]};
                    kq.Add(nhomdanhba);
                }
                return kq;
            
        }
        public static List<nhom> xoanhom()
        {
            return null;
        }
    }
}
