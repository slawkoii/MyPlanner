using System.Security.Cryptography.X509Certificates;

namespace MyPlanner
{
    public partial class MyPlannerForm : Form
    {
        private readonly string fileName = "todo.txt";
        private List<string> tasks;
       // private readonly FileOps fileOps;

        public MyPlannerForm()
        {
            InitializeComponent();
            tasks = new List<string>();
           // fileOps = new FileOps();
        }        

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddItemToList();
        }

        private void ToDoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = (string)toDoList.SelectedItem;
            if (selectedItem != null)
            {
                doneList.Items.Add(selectedItem);
                toDoList.Items.Remove(selectedItem);
                tasks.Remove(selectedItem);
            }
        }

        private void NewTask_PressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddItemToList();
                e.Handled = true; // Zatrzymuje dŸwiêk i powstrzymuje znak Enter od wprowadzenia do pola tekstowego
            }
        }

        private void AddItemToList()
        {
            tasks.Add(newTask.Text);
            toDoList.Items.Add(newTask.Text);
            newTask.Clear();
        }
       

        private void OpenButton_Click(object sender, EventArgs e)
        {
            tasks.Clear();
            toDoList.Items.Clear();

            tasks = FileOps.LoadTasksFromFile(fileName);
           
            foreach (string task in tasks)
            {
                toDoList.Items.Add(task);
            }

            MessageBox.Show("Zadania zosta³y wczytane z pliku.", "Wczytano", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileOps.ClearFile(fileName);
            FileOps.SaveTasksToFile(fileName, tasks);
            MessageBox.Show("Zadania zosta³y zapisane do pliku.", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }           

       
    }
}