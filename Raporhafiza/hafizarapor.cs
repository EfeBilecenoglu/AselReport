using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raporhafiza
{
    public static class hafizarapor
    {
        static public DataClasses1DataContext raporveritabani { get; set; }
        static public Rapor rapor { get; set; }
        static public Islem islem { get; set; }
        static hafizarapor()
        {
            raporveritabani = new DataClasses1DataContext();
            if (!raporveritabani.DatabaseExists())
            {
                raporveritabani.CreateDatabase();
            }
        }
    }
}
