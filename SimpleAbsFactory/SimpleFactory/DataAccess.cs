using SimpleAbsFactory.Service;
using SimpleAbsFactory.ServiceImpl;

namespace SimpleAbsFactory.SimpleFactory
{
    public class DataAccess
    {
        private static readonly string db = "SqlServer";
        public static IUser CreateUser()
        {
            IUser result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlServerUser();
                    break;
                case "Access":
                    result = new AccessUser();
                    break;
            }
            return result;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlServerDepartment();
                    break;
                case "Access":
                    result = new AccessDepartment();
                    break;
            }
            return result;
        }
    }
}
