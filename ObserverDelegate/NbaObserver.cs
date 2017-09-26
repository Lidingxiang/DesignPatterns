using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDelegate
{
    public class NbaObserver
    {
        private readonly string _name;
        private readonly Subject _subject;

        public NbaObserver(string name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public void CloseNbaDirectSeeding()
        {
            Console.WriteLine("{0} {1} 关闭NBA直播，继续工作", _name, _subject.SubjectState);
        }
    }
}
