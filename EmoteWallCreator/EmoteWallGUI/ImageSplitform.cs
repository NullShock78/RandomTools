using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoteWallGUI
{
    public partial class ImageSplitform : Form
    {
        public ImageSplitform()
        {
            InitializeComponent();
        }

        private void buttonDoit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxOutput.Text = ImageSplitter.SplitImage(openFile.FileName, string.IsNullOrEmpty(textBoxName.Text) ? "em" : textBoxName.Text);
                    openFile.OpenFile().Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        Random rand = new Random();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string res = "";

            for (int j = 0; j < textBox1.Text.Length; j++)
            {
                if (textBox1.Text[j] == '\r' || textBox1.Text[j] == '\n' || char.IsWhiteSpace(textBox1.Text[j]))
                {
                    res += textBox1.Text[j];
                }
                else
                {
                    if (radioButtonSans.Checked)
                    {
                        res += $":{textBox1.Text[j]}_:";

                    }
                    else if(radioButtonFlags.Checked)
                    {
                        if (textBox1.Text[j].ToString().ToLower() == "a")
                        {
                            if (rand.Next(0, 2) == 0)
                            {
                                res += ":a: ";
                                continue;
                            }
                        }

                        if (textBox1.Text[j].ToString().ToLower() == "b")
                        {
                            if (rand.Next(0, 2) == 0)
                            {
                                res += ":b: ";
                                continue;
                            }
                        }

                        if (textBox1.Text[j].ToString().ToLower() == "o")
                        {
                            if (rand.Next(0, 2) == 0)
                            {
                                res += ":o: ";
                                continue;
                            }
                        }

                        if (char.IsLetter(textBox1.Text[j]))
                        {
                            res += $":regional_indicator_{textBox1.Text[j].ToString().ToLower()}: ";
                        }
                        else if(char.IsNumber(textBox1.Text[j]))
                        {
                            res += $":{numbers[int.Parse(textBox1.Text[j].ToString())]}: ";
                        }
                        else
                        {
                            res += textBox1.Text[j];
                        }

                    }
                }
                
            }
            textBoxOut.Text = res;
            //Clipboard.SetText(res);
        }



        string[] numbers = new string[] {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight"
        };

        public class Coord
        {
            public int x;
            public int y;
            public Coord(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        List<Coord> bombCoords = new List<Coord>();
        public Coord RandomCoord(int min, int max)
        {
            Coord c = new Coord(rand.Next(min, max), rand.Next(min, max));
            while(bombCoords.Any(x => x.x == c.x && x.y == c.y))
            {
                c = new Coord(rand.Next(min, max), rand.Next(min, max));
            }
            return c;
        }


        string Wrap(string ins)
        {
            return $"||:{ins}:||";
        }

        bool[,] grid = null;
        
        int GetSurr(int x, int y)
        {
            if (checkBoxTrollMode.Checked)
            {
                return 1;
            }
            else
            {
                int res = 0;
                for (int y2 = y-1; y2 <= y+1; y2++)
                {
                    if (y2 < 0 || y2 >= grid.GetLength(1)) continue;
                    for (int x2 = x - 1; x2 <= x + 1; x2++)
                    {
                        if (x2 < 0 || x2 >= grid.GetLength(0)) continue;
                        if (grid[x2, y2]) res++;
                    }
                }
                return res;
            }
        }
        private void buttonGenerateMS_Click(object sender, EventArgs e)
        {
            string res = "";
            int num = (int)numericUpDown1.Value;
            grid = new bool[num, num];
            int bombNum = (int)numericUpDownBombs.Value;
            bombCoords.Clear();
            for (int j = 0; j < bombNum; j++)
            {
                bombCoords.Add(RandomCoord(0, num));
            }

            for (int y = 0; y < num; y++)
            {
                for (int x = 0; x < num; x++)
                {
                    grid[x,y] = bombCoords.Any(a => a.x == x && a.y == y);
                }
            }
            bool firstZero = false;
            for (int y = 0; y < num; y++)
            {
                for (int x = 0; x < num; x++)
                {
                    if (grid[x, y])
                    {
                        res += Wrap(textBoxMSEmoteName.Text);
                    }
                    else
                    {
                        int sur = GetSurr(x, y);
                        if(!firstZero && sur == 0)
                        {
                            firstZero = true;
                            res += ":zero:";
                        }
                        else
                        {
                            res += Wrap(numbers[sur]);
                        }
                        
                    }
                }
                if(y != num - 1)
                {
                    res += "\r\n";
                }
            }
            textBoxMSOut.Text = res;
        }

        string Wrap2(string ins)
        {
            return $":{ins}:";
        }

        private void buttonGenSquare_Click(object sender, EventArgs e)
        {
            string[,] sqr = new string[8, 8];
            //outer
            for (int j = 0; j < 7; j++)
            {
                sqr[0, j] = Wrap2(textBoxL2.Text);
                sqr[j, 0] = Wrap2(textBoxL2.Text);
                sqr[6, j] = Wrap2(textBoxL2.Text);
                sqr[j, 6] = Wrap2(textBoxL2.Text);
            }
            for (int j = 1; j < 6; j++)
            {
                sqr[1, j] = Wrap2(textBoxL1.Text);
                sqr[j, 1] = Wrap2(textBoxL1.Text);
                sqr[5, j] = Wrap2(textBoxL1.Text);
                sqr[j, 5] = Wrap2(textBoxL1.Text);
            }
            for (int j = 2; j < 5; j++)
            {
                sqr[2, j] = Wrap2(textBoxL0.Text);
                sqr[j, 2] = Wrap2(textBoxL0.Text);
                sqr[4, j] = Wrap2(textBoxL0.Text);
                sqr[j, 4] = Wrap2(textBoxL0.Text);
            }
            sqr[3, 3] = Wrap2(textBoxCenter.Text);
            string res = "";
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    res += sqr[x, y];
                }
                if(y != 6)res += "\r\n";
            }
            textBoxSquare.Text = res;
        }

        string[] cols = new string[]
        {
            "red",
            "lime",
            "blue"
        };
        int citer = 0;
        private void textBoxBoomIn_TextChanged(object sender, EventArgs e)
        {
            string res = "";
            var tt = textBoxBoomIn.Text;
            for (int j = 0; j < textBoxBoomIn.Text.Length; j++)
            {
                res += $"<color={cols[citer++]}>" + tt[j] + "</color>";
                if (citer >= cols.Length) citer = 0;
            }
            textBoxBoomOut.Text = res;
        }


        private static string Escape(string str)
        {
            if (str.Length < 2) return str;
            const char ESC = '\\';
            int len = str.Length;
            int lenMn1 = len - 1;
            char[] res = new char[len];
            int newLen = 0;
            for (int j = 0; j < len; j++)
            {
                if (str[j] == ESC && j < lenMn1)
                {
                    switch (str[j + 1])
                    {
                        case 'r':
                            res[newLen] = '\r';
                            break;
                        case 'n':
                            res[newLen] = '\n';
                            break;
                        case 't':
                            res[newLen] = '\t';
                            break;
                        case '\\':
                            res[newLen] = '\\';
                            break;
                        default:
                            //res[newLen++] = '\\';
                            res[newLen] = str[j + 1];
                            break;
                    }
                    j++;
                }
                else
                {
                    //copy
                    res[newLen] = str[j];
                }
                newLen++;
            }
            return new string(res, 0, newLen);
        }

        private void textBoxEscape_TextChanged(object sender, EventArgs e)
        {
            textBoxEscaped.Text = Escape(textBoxEscape.Text);
        }

        private void buttonSliceGif_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Gif files (*.gif) | *.gif"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxOutput.Text = ImageSplitter.SplitGif(openFile.FileName, string.IsNullOrEmpty(textBoxName.Text) ? "em" : textBoxName.Text);
                    openFile.OpenFile().Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        class WRList 
        {
            public string[] strs;
            public int Count { get; private set; }

            public WRList(string[] str)
            {
                strs = str;
                Count = str.Length;
            }

            public string this[int ind]
            {
                get
                {
                    return strs[ind % Count];
                }
                set { strs[ind % Count] = value; }
            }
        }

        private void buttonConf_Click(object sender, EventArgs e)
        {
            WRList ls = new WRList(confIn.Text.Split(' '));
            int a = ls[0].Length;
            int l = ls[1].Length;
            int b = (l % 2 == 0 ? l : a + 1);

            //Take first char
            char[] buf = new char[ls.Count];
            for (int j = 0; j < ls.Count; j++)
            {
                buf[j] = ls[j][0];
                if (ls[j].Length == 1)
                {
                    ls[j] = "";
                }
                else
                {
                    ls[j] = ls[j].Substring(1);
                }
            }

            for (int j = 0; j < buf.Length; j++)
            {
                ls[j+a] = buf[j] + ls[j + a];
            }

            //Take last
            for (int j = 0; j < ls.Count; j++)
            {
                buf[j] = ls[j][ls[j].Length-1];
                if (ls[j].Length == 1)
                {
                    ls[j] = "";
                }
                else
                {
                    ls[j] = ls[j].Substring(0,ls[j].Length-1);
                }
            }
            for (int j = 0; j < buf.Length; j++)
            {
                ls[j + a] = ls[j + a] + buf[j];
            }

            confOut.Text = string.Join(" ", ls.strs);
        }
    }
}
