using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace to_do
{
    public partial class Form1 : Form
    {
        private string taskFile = "tasks.txt";
        private string logFile = "logs.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
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
        private void text_input_TextChanged(object sender, EventArgs e)
        {

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

        private void to_do_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void to_do_list_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string task = to_do_list.Items[e.Index].ToString();

                this.BeginInvoke((MethodInvoker)delegate
                {
                    to_do_list.Items.RemoveAt(e.Index);
                });

                RemoveTaskFromFile(task);

                LogOperation($"completed task \"{task}\"");
            }
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
    }
}
