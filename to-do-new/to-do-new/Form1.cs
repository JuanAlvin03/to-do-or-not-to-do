using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace to_do_new
{
    public partial class Form1 : Form
    {
        private string taskFile = "tasks.txt";
        private string logFile = "logs.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTasks()
        {
            if (File.Exists(taskFile))
            {
                string[] tasks = File.ReadAllLines(taskFile);
                foreach (string task in tasks)
                {
                    if (!string.IsNullOrWhiteSpace(task))
                        to_do_list.Items.Add(task);
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string task = text_input.Text.Trim();

            if (!string.IsNullOrWhiteSpace(task))
            {
                // Add to UI
                to_do_list.Items.Add(task);

                // Save to file
                File.AppendAllText(taskFile, task + Environment.NewLine);

                // Log
                LogOperation($"added task \"{task}\"");

                text_input.Clear();
            }
        }

        private void to_do_list_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // We only act when it is being checked
            if (e.NewValue == CheckState.Checked)
            {
                string task = to_do_list.Items[e.Index].ToString();

                // Delay removal until after event completes
                this.BeginInvoke((MethodInvoker)delegate
                {
                    to_do_list.Items.RemoveAt(e.Index);
                });

                RemoveTaskFromFile(task);

                LogOperation($"completed task \"{task}\"");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void RemoveTaskFromFile(string task)
        {
            if (File.Exists(taskFile))
            {
                var tasks = File.ReadAllLines(taskFile)
                                .Where(t => t != task)
                                .ToArray();

                File.WriteAllLines(taskFile, tasks);
            }
        }

        private void LogOperation(string message)
        {
            string logEntry = $"{DateTime.Now:dd-MM-yyyy HH:mm:ss} {message}";
            File.AppendAllText(logFile, logEntry + Environment.NewLine);
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {

        }

        private void text_input_Enter(object sender, EventArgs e)
        {

        }

        private void text_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string task = text_input.Text.Trim();

                if (!string.IsNullOrWhiteSpace(task))
                {
                    // Add to UI
                    to_do_list.Items.Add(task);

                    // Save to file
                    File.AppendAllText(taskFile, task + Environment.NewLine);

                    // Log
                    LogOperation($"added task \"{task}\"");

                    text_input.Clear();
                }

                // Prevents the default system "ding" sound
                e.Handled = true;
                e.SuppressKeyPress = true; // Use this to stop further key events
            }
        }
    }
}
