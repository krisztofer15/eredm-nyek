using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace datagrid2
{
    static class EredmenyRepository
    {
        public static string Path { get; set; }
        public static char Delimiter { get; set; } = ',';
        public static bool SkipHeader { get; set; }

        public static List<Eredmeny> FindAll()
        {
            StreamReader r = new StreamReader(Path, true);
            if (SkipHeader) { r.ReadLine(); }

            List<Eredmeny> eredmenyListOutput = new List<Eredmeny> { };

            while (!r.EndOfStream)
            {
                eredmenyListOutput.Add(new Eredmeny(r.ReadLine(), Delimiter));
            }
            return eredmenyListOutput;
        }
    }
}
