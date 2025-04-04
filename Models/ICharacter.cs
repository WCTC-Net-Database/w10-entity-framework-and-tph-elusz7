using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9_assignment_template.Models
{
    public interface ICharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }

        void Attack(ICharacter target);

        void ExecuteAbility(Ability ability);
    }
}
