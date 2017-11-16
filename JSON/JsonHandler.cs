using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yugioh_Card_Directory
{
    class JsonHandler
    {
        [Serializable]
        public class RootObject
        {
            public string status { get; set; }
            public List<string> cards { get; set; }
        }

        //Public setters / getters
        public string name { get; set; }
        public string image_path { get; set; }
        public string thumbnail_path { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public string price_low { get; set; }
        public string price_avg { get; set; }
        public string price_high { get; set; }
        public string tcgplayer_link { get; set; }
        public bool is_monster { get; set; }
        public bool is_spell { get; set; }
        public bool is_illegal { get; set; }
        public bool is_trap { get; set; }
        public bool has_name_condition { get; set; }
        public string property { get; set; }
    }
}
