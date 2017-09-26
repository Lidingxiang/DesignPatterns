using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteRoleApp
{
    public class Memento : BasePower
    { 
        public Memento(int vitality, int attack, int defense)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
        } 
    }
}
