using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProgExam
{
    public class Weather
    {

        public class Hourly
        {
            public int dt { get; set; }
            public double temp { get; set; }

            public int humidity { get; set; }

        }

        public class Root
        {
            public double lat { get; set; }
            public double lon { get; set; }

            public List<Hourly> hourly { get; set; }
        }

    }
}
