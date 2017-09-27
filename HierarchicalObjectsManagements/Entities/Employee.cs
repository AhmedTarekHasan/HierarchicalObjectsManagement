using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentSimplyPut.HierarchicalObjectsManagements.Entities
{
    public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int? ManagerID { set; get; }

        public Employee() { }

        public Employee(int id, string name, int? managerID)
        {
            ID = id;
            Name = name;
            ManagerID = managerID;
        }
    }
}
