using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ASCIIArtToImage
{
    public partial class Main : Form
    {
        int ascii_width = 0;
        int ascii_height = 0;
        char[] ascii_array;
        int scale = 1;
        int progress = 0;
        int progressMaximus = 100;
        Dictionary<string, int> charLumas = new();
        bool done = false;
        Bitmap finalProduct;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            outputScaleMode.SelectedIndex = 0;
        }

        private void lumaIndexView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lumaIndexView.SelectedIndices.Count > 0)
            {
                charEditBox.Text = lumaIndexView.SelectedItems[0].Text;
                lumaStrength.Value = Convert.ToInt32(lumaIndexView.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void fileBrowserButton_Click(object sender, EventArgs e)
        {
            if (openASCII.ShowDialog() == DialogResult.OK)
            {
                fileNameBox.Text = openASCII.FileName;
            }
        }

        private void fileNameBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(fileNameBox.Text))
            {
                string file_contents = File.ReadAllText(fileNameBox.Text);
                string[] lines = file_contents.Replace("\r\n", "\n").Split("\n");
                ascii_width = lines[0].Length;
                ascii_height = lines.Length;
                List<char> ascii_data = new List<char>();
                charSet.Text = "";
                foreach (string line in lines)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!charSet.Text.Contains(line[i]))
                        {
                            charSet.Text += line[i];
                        }
                        ascii_data.Add(line[i]);
                    }
                }
                ascii_array = ascii_data.ToArray();
                progressMaximus = ascii_array.Length;
                openFileLabel.Text = openFileLabel.Text.Replace("Not loaded", "Loaded");
            } else
            {
                openFileLabel.Text = openFileLabel.Text.Replace("Loaded", "Not loaded");
            }
        }

        private void imgScaleBar_Scroll(object sender, EventArgs e)
        {
            scale = imgScaleBar.Value;
            scaleDisplayLabel.Text = String.Format("Scale = {0}x", scale);
        }

        private void changeChar_Click(object sender, EventArgs e)
        {
            if (lumaIndexView.SelectedIndices.Count > 0)
            {
                if ((charEditBox.Text.Length == 1) &&
                    (charEditBox.Text != lumaIndexView.SelectedItems[0].Text))
                {
                    lumaIndexView.Items[lumaIndexView.SelectedIndices[0]].Text = charEditBox.Text;
                }
                if ((lumaStrength.Value.ToString() != lumaIndexView.SelectedItems[0].SubItems[0].Text))
                {
                    lumaIndexView.Items[lumaIndexView.SelectedIndices[0]].SubItems[1].Text = lumaStrength.Value.ToString();
                }
            }
        }

        private void addChar_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.Text = charEditBox.Text;
            li.SubItems.Add(lumaStrength.Value.ToString());
            lumaIndexView.Items.Add(li);
        }

        private void delChar_Click(object sender, EventArgs e)
        {
            if (lumaIndexView.SelectedIndices.Count > 0)
            {
                lumaIndexView.Items.Remove(lumaIndexView.SelectedItems[0]);
            }
        }

        private void renderButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileNameBox.Text))
            {
                charLumas.Clear();
                foreach (ListViewItem li in lumaIndexView.Items)
                {
                    charLumas.Add(li.Text, Convert.ToInt32(li.SubItems[1].Text));
                }
                inputGroup.Enabled = false;
                optionsGroup.Enabled = false;
                renderButton.Enabled = false;
                saveAsButton.Enabled = false;
                outputScaleMode.Enabled = false;
                ThreadStart ts = new ThreadStart(RenderImage);
                Thread t = new Thread(ts);
                t.Start();
            }
        }

        void RenderImage()
        {
            int x = 0;
            int y = 0;
            int i = 0;
            Bitmap b = new Bitmap(ascii_width * scale, ascii_height * scale);
            foreach (char c in ascii_array)
            {
                for (int j = 0; j < scale; j++)
                {
                    for (int k = 0; k < scale; k++)
                    {
                        b.SetPixel(x * scale + j, y * scale + k, Color.FromArgb(charLumas[c.ToString()], charLumas[c.ToString()], charLumas[c.ToString()]));
                    }
                }
                x++;
                if (x == ascii_width) { x = 0; y++; }
                i++;
                progress = i;
            }
            finalProduct = b;
            done = true;
            return;
        }

        private void progressCatcher_Tick(object sender, EventArgs e)
        {
            renderProgressBar.Maximum = progressMaximus;
            renderProgressBar.Value = progress;
            if (done)
            {
                done = false;

                outputDisplay.Image = finalProduct;
                saveAsButton.Enabled = true;
                outputScaleMode.Enabled = true;
                renderButton.Enabled = true;
                inputGroup.Enabled = true;
                optionsGroup.Enabled = true;
            }
        }

        private void outputScaleMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (outputScaleMode.SelectedIndex)
            {
                case 0:
                    outputDisplay.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    outputDisplay.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 2:
                    outputDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    outputDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if (saveOutputAs.ShowDialog() == DialogResult.OK)
            {
                switch (saveOutputAs.FileName.Split(".")[saveOutputAs.FileName.Split(".").Length - 1].ToLower())
                {
                    case "png":
                        outputDisplay.Image.Save(saveOutputAs.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "bmp":
                        outputDisplay.Image.Save(saveOutputAs.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "gif":
                        outputDisplay.Image.Save(saveOutputAs.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
            }
        }
    }
}
