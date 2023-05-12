using System.Security.Cryptography.X509Certificates;

namespace MyPlanner
{
    public partial class MyPlannerForm : Form
    {
        public MyPlannerForm()
        {
            InitializeComponent();          
        }        

        private void AddButton_Click(object sender, EventArgs e)
        {
            toDoList.Items.Add(newTask.Text);
            newTask.Text = "";
        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)toDoList.SelectedItem;
            if (selectedItem != null)
            {
                doneList.Items.Add(selectedItem);
                toDoList.Items.Remove(selectedItem);
            }
        }
    }
}