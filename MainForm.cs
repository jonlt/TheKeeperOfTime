using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace TheKeeperOfTime
{
    public partial class MainForm : Form
    {
        private string _path;
        private bool _pasted = false;

        public MainForm()
        {
            InitializeComponent();
            
            var dir = ConfigurationSettings.AppSettings["path"] as string;
            
            if (dir == null)
                dir = Directory.GetCurrentDirectory();

            if (!dir.EndsWith("\\") && !dir.EndsWith("/"))
                dir += "\\";

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            _path = string.Format("{0}{1}.txt", dir, DateTime.Now.ToString("dd-MM-yyyy"));

            File.Open(_path, FileMode.OpenOrCreate).Close();
            this.CenterToScreen();
        }

        private void PasteFile()
        {
            using (var reader = new StreamReader(_path))
            {
                allDay.Text = reader.ReadToEnd();
            }

            allDay.SelectionStart = allDay.Text.Length;
            allDay.ScrollToCaret();
        }

        private void SaveFile()
        {
            using (var writer = new StreamWriter(_path))
            {
                writer.Write(allDay.Text);
                writer.Flush();
            }
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) // ENTER
            {
                using (var writer = new StreamWriter(File.Open(_path, FileMode.Append)))
                {
                    writer.WriteLine(string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm:ss"), input.Text));
                }
                input.Text = string.Empty;
                PasteFile();
                Close();
            }
            else if (e.KeyValue == 27) // ESC
            {
                this.Close();
            }
        }

        private void allDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27) // ESC
            {
                this.Close();
            }
        }

        private void allDay_Leave(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (!_pasted)
            {
                PasteFile();
                _pasted = true;
            }
            this.TopMost = true;
        }

      
    }
}
