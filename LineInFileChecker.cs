using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace assignment8_AndreiKazakov
{
    internal class LineInFileChecker
    {
        private string[] lines;

        public string SelectAndReadFile()
        {
            string filePath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        ReadLines(reader);
                    }
                }
            }

            return filePath;
        }

        public bool CheckLine(string line)
        {
            return lines.Contains(NormalizeLine(line));
        }

        private void ReadLines(StreamReader reader)
        {
            List<string> lines = new List<string>() { };
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                line = NormalizeLine(line);

                if (line.Length > 0)
                {
                    lines.Add(line);
                }
            }

            this.lines = lines.ToArray();
        }

        private string NormalizeLine(string line)
        {
            return line.Trim().ToLower();
        }
    }
}
