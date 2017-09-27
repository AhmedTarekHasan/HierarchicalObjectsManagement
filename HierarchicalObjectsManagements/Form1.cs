using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevelopmentSimplyPut.HierarchicalObjectsManagements.Entities;
using DevelopmentSimplyPut.HierarchicalObjectsManagements.Utilities;

namespace HierarchicalObjectsManagements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BuildTree_Click(object sender, EventArgs e)
        {
            lst_Employees.Items.Clear();

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(4, "Saleh", 2));
            employees.Add(new Employee(1, "Ahmed", null));
            employees.Add(new Employee(5, "Selim", 4));
            employees.Add(new Employee(2, "Tarek", 1));
            employees.Add(new Employee(6, "Mohamed", 2));
            employees.Add(new Employee(3, "Hasan", 1));

            EmployeeTreeNode employeeTreeTopNode = Utilities.GetEmployeeTreeNode(employees);

            BuildTree(employeeTreeTopNode);
            MessageBox.Show("Done");
        }

        public void BuildTree(EmployeeTreeNode node)
        {
            lst_Employees.Items.Add("-".Repeat(node.Level) + node.Employee.Name);
            foreach (EmployeeTreeNode childNode in node.ChildNodes)
            {
                BuildTree(childNode);
            }
        }
    }
}
