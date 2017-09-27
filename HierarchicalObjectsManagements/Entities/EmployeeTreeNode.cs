using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentSimplyPut.HierarchicalObjectsManagements.Entities
{
    public class EmployeeTreeNode
    {
        public Employee Employee { set; get; }
        public bool IsProcessed { set; get; }
        public int Level { set; get; }

        private List<EmployeeTreeNode> childNodes;
        public List<EmployeeTreeNode> ChildNodes
        {
            get { return childNodes; }
        }

        public EmployeeTreeNode()
        {
            Level = 0;
            childNodes = new List<EmployeeTreeNode>();
        }

        public EmployeeTreeNode(Employee employee, bool isProcessed) : this()
        {
            Level = 0;
            Employee = employee;
            IsProcessed = isProcessed;
        }
    }
}
