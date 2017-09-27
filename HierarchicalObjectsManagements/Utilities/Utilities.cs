using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevelopmentSimplyPut.HierarchicalObjectsManagements.Entities;

namespace DevelopmentSimplyPut.HierarchicalObjectsManagements.Utilities
{
    public static class Utilities
    {
        public static EmployeeTreeNode GetEmployeeTreeNode(List<Employee> employees)
        {
            EmployeeTreeNode result = new EmployeeTreeNode();
            result.IsProcessed = false;

            List<EmployeeTreeNode> nodes = new List<EmployeeTreeNode>();
            foreach (Employee emp in employees)
            {
                nodes.Add(new EmployeeTreeNode(emp, false));
            }

            foreach (EmployeeTreeNode empNode in nodes)
            {
                if (empNode.IsProcessed)
                {
                    continue;
                }
                else
                {
                    if (null == empNode.Employee.ManagerID)
                    {
                        result = empNode;
                        empNode.IsProcessed = true;
                        empNode.Level = 0;
                    }
                    else
                    {
                        ProcessNode(empNode, nodes);
                    }
                }
            }

            if (result.ChildNodes.Count == 0)
            {
                result.ChildNodes.AddRange(nodes);
            }

            return result;
        }

        private static void ProcessNode(EmployeeTreeNode node, List<EmployeeTreeNode> nodes)
        {
            EmployeeTreeNode parentNode = nodes.DefaultIfEmpty(null).FirstOrDefault(n => n.Employee.ID == node.Employee.ManagerID);
            if (null != parentNode)
            {
                if (!parentNode.IsProcessed)
                {
                    ProcessNode(parentNode, nodes);
                }

                node.IsProcessed = true;
                node.Level = parentNode.Level + 1;
                parentNode.ChildNodes.Add(node);
            }
        }

        public static string Repeat(this string source, int numOfTimes)
        {
            string result = source;

            if (numOfTimes > 0)
            {
                for (int i = 0; i < numOfTimes - 1; i++)
                {
                    result += source;
                }
            }
            else
            {
                result = string.Empty;
            }

            return result;
        }
    }
}
