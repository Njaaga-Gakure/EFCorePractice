using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; } = string.Empty;
        public string ActorGender { get; set; } = string.Empty;  
    }
}
