using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonManager jinli = new CommonManager("金利");
            Majordemo zongjian = new Majordemo("宗剑");
            GeneralManager zhongjingli = new GeneralManager("钟经理");
            jinli.SetSuperior(zongjian);
            zongjian.SetSuperior(zhongjingli);

            Request request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小明请假";
            request.Number = 1;
            jinli.RequestApplications(request);

            Request request2 = new Request();
            request2.RequestType = "请假";
            request2.RequestContent = "小明请假";
            request2.Number = 4;
            jinli.RequestApplications(request2);

            Request request3 = new Request();
            request3.RequestType = "加薪";
            request3.RequestContent = "小明请求加薪";
            request3.Number = 500;
            jinli.RequestApplications(request3);

            Request request4 = new Request();
            request4.RequestType = "加薪";
            request4.RequestContent = "小明请求加薪";
            request4.Number = 1000;
            jinli.RequestApplications(request4);

            Console.Read();
        }
    }
}
