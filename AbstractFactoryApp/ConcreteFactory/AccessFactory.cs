﻿using AbstractFactoryApp.Service;
using AbstractFactoryApp.ServiceImpl;

namespace AbstractFactoryApp.ConcreteFactory
{
    public class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }

        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }
    }
}
