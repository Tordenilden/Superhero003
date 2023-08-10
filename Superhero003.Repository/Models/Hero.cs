using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero003.Repository.Models
{
    public class Hero
    {
        //[Key] // Attribute / Dataannotation => PK
        public int Id { get; set; }
        //  public int HeroId { get; set; }
        public string Name { get; set; }
        public string RealName { get; set; }
        public string Place { get; set; }
        //public DateTime DebutYear { get; set; }
        public DateTime DebutYear { get; set; }
    }
}
