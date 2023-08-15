using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Repository.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public List<Hero> Heroes { get; set; }
    }
}
