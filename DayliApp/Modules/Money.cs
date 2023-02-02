using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DayliApp.Modules
{
    public class Money
    {
        [JsonInclude]
        public int Code; // работает с [JsonInclude]
        [JsonInclude]
        public string Name { private get; set; } // работает с [JsonInclude]
        public string Symbol { get; set; }
        [JsonPropertyName("D")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime? LastUpdate { get; set; }
        [JsonIgnore]
        public string Text => $"{Code}+{Name}";


        public override string ToString()
        {
            return $"{Code}  {Name} {Symbol}";
        }

    }
}
