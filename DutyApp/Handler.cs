using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutyApp
{
    public abstract class Handler
    {
        protected Handler _successor;

        /// <summary>
        /// 设置继任者
        /// </summary>
        /// <param name="successor"></param>
        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }

        /// <summary>
        /// 处理请求的抽象方法
        /// </summary>
        /// <param name="request"></param>
        public abstract void HandleRequest(int request);
    }
}
