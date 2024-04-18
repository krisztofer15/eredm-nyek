using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datagrid2
{
    class Eredmeny
    {
        public int Id { get; set; }
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public string Targy { get; set; }
        public int Szazalek { get; set; }

        public int Erdemjegy { get
            {
                if( Szazalek < 40) { return 2; }
                else if( Szazalek < 60) { return 3; }
                else if( Szazalek < 80) { return 4; }
                else if( Szazalek >= 80) { return 5; }
                else { return 1; }
            } }

        public Eredmeny(int id, string vezeteknev, string keresztnev, string targy, int szazalek)
        {
            this.Id = id;
            this.Vezeteknev = vezeteknev;
            this.Keresztnev = keresztnev;
            this.Targy = targy;
            this.Szazalek = szazalek;
        }

        public Eredmeny(string line, char delimiter = ',')
        {
            List<string> splitLine = line.Split(delimiter).ToList();
            this.Id = Convert.ToInt32(splitLine[0]);
            this.Vezeteknev = splitLine[1];
            this.Keresztnev = splitLine[2];
            this.Targy = splitLine[3];
            this.Szazalek = Convert.ToInt32(splitLine[4]);
        }

    }
}
