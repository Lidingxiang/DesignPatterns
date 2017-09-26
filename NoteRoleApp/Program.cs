using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteRoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole gameRole = new GameRole();
            gameRole.InitBasePower();
            gameRole.Show();

            var backUpPower = gameRole.BackUp();

            gameRole.Figth();
            gameRole.Show();

            gameRole.Restore(backUpPower);
            gameRole.Show();

            Console.ReadLine();
        }
    }
}
