using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Memento
    {
        private readonly string _state;
        /// <summary>
        /// 构造，将相关数据导入
        /// </summary>
        /// <param name="state"></param>
        public Memento(string state)
        {
            _state = state;
        }

        /// <summary>
        /// 需要保存的数据属性，可以是一个也可以是多个
        /// </summary>
        public string State
        {
            get { return _state; }
        }
    }
}
