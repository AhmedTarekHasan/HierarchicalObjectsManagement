namespace HierarchicalObjectsManagements
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_BuildTree = new System.Windows.Forms.Button();
            this.lst_Employees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_BuildTree
            // 
            this.btn_BuildTree.Location = new System.Drawing.Point(181, 165);
            this.btn_BuildTree.Name = "btn_BuildTree";
            this.btn_BuildTree.Size = new System.Drawing.Size(75, 23);
            this.btn_BuildTree.TabIndex = 0;
            this.btn_BuildTree.Text = "Build Tree";
            this.btn_BuildTree.UseVisualStyleBackColor = true;
            this.btn_BuildTree.Click += new System.EventHandler(this.btn_BuildTree_Click);
            // 
            // lst_Employees
            // 
            this.lst_Employees.FormattingEnabled = true;
            this.lst_Employees.Location = new System.Drawing.Point(12, 12);
            this.lst_Employees.Name = "lst_Employees";
            this.lst_Employees.Size = new System.Drawing.Size(244, 147);
            this.lst_Employees.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 193);
            this.Controls.Add(this.lst_Employees);
            this.Controls.Add(this.btn_BuildTree);
            this.Name = "Form1";
            this.Text = "Hierarchical Objects Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BuildTree;
        private System.Windows.Forms.ListBox lst_Employees;
    }
}

