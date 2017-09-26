using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteRoleApp
{
    public class GameRole : BasePower
    {
        public void InitBasePower()
        {
            this.Vitality = 100;
            this.Defense = 100;
            this.Attack = 100;
        }

        public void Figth()
        {
            this.Vitality = 0;
            this.Defense = 0;
            this.Attack = 0;
        }

        public Memento BackUp()
        {
            return new Memento(Vitality, Attack, Defense);
        }

        public void Restore(Memento memento)
        { 
            this.Vitality = memento.Vitality;
            this.Defense = memento.Defense;
            this.Attack = memento.Attack;
        }


        public void Show()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：{0}", this.Vitality);

            Console.WriteLine("攻击力：{0}", this.Attack);
            Console.WriteLine("防御力：{0}", this.Defense);

            Console.WriteLine("");
        }
    }
}
