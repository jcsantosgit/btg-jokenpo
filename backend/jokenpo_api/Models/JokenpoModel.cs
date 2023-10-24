using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jokenpo_api.Models
{
    public class JokenpoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WinsFrom { get; set; }

        public JokenpoModel() {}

        public JokenpoModel(int id, string name, string winsFrom)
        {
            Id = id;
            Name = name;
            WinsFrom = winsFrom;
        }
    }
}