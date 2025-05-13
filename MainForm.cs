using System;
using System.Windows.Forms;

namespace Taskyfier
{
    public class MainForm : Form
    {
        private TextBox taskInput;
        private Button addButton;
        private ListBox taskList;

        public MainForm()
        {
            Text = "Taskyfier - Task Manager";
            Width = 400;
            Height = 300;

            taskInput = new TextBox { Top = 20, Left = 20, Width = 250 };
            addButton = new Button { Text = "Add Task", Top = 20, Left = 280 };
            taskList = new ListBox { Top = 60, Left = 20, Width = 340, Height = 180 };

            addButton.Click += (sender, e) =>
            {
                if (!string.IsNullOrWhiteSpace(taskInput.Text))
                {
                    taskList.Items.Add(taskInput.Text);
                    taskInput.Clear();
                }
            };

            Controls.Add(taskInput);
            Controls.Add(addButton);
            Controls.Add(taskList);
        }
    }
}
