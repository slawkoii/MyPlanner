namespace MyPlanner
{
    partial class MyPlannerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainListView = new System.Windows.Forms.ListView();
            this.toDoList = new System.Windows.Forms.CheckedListBox();
            this.doneList = new System.Windows.Forms.ListBox();
            this.newTask = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainListView
            // 
            this.mainListView.Location = new System.Drawing.Point(120, 61);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(797, 361);
            this.mainListView.TabIndex = 0;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.Location = new System.Drawing.Point(129, 84);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(758, 158);
            this.toDoList.TabIndex = 1;
            this.toDoList.SelectedIndexChanged += new System.EventHandler(this.ToDoList_SelectedIndexChanged);
            // 
            // doneList
            // 
            this.doneList.FormattingEnabled = true;
            this.doneList.ItemHeight = 20;
            this.doneList.Location = new System.Drawing.Point(129, 306);
            this.doneList.Name = "doneList";
            this.doneList.Size = new System.Drawing.Size(758, 104);
            this.doneList.TabIndex = 2;
            // 
            // newTask
            // 
            this.newTask.Location = new System.Drawing.Point(120, 541);
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(797, 27);
            this.newTask.TabIndex = 3;
            this.newTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewTask_PressEnter);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(923, 541);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(170, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Dodaj Zadanie";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zadania Do Wykonania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zrobione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nowe Zadanie";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(962, 61);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 29);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Zapisz Liste";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(1136, 61);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(131, 29);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Wczytaj Liste";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // MyPlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 571);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.newTask);
            this.Controls.Add(this.doneList);
            this.Controls.Add(this.toDoList);
            this.Controls.Add(this.mainListView);
            this.Name = "MyPlannerForm";
            this.Text = "Moje Zadania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView mainListView;
        private CheckedListBox toDoList;
        private ListBox doneList;
        private TextBox newTask;
        private Button addButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
        private Button openButton;
    }
}