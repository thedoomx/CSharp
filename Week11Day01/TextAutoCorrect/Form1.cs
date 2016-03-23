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

namespace TextAutoCorrect
{
    public partial class Form1 : Form
    {
        private int PrevSpaceIndex { get; set; }
        private int LastSpaceIndex { get; set; }
        private int TextBoxLength { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > TextBoxLength)
            {
                TextBoxLength++;
            }
            else if (textBox1.Text.Length < TextBoxLength)
            {
                TextBoxLength--;
                PrevSpaceIndex = 0;
                LastSpaceIndex = 0;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text[i].Equals(' '))
                    {
                        if (LastSpaceIndex == 0)
                        {
                            LastSpaceIndex = i;
                        }
                        else
                        {
                            PrevSpaceIndex = LastSpaceIndex;
                            LastSpaceIndex = i;
                        }
                    }
                }
            }

            if ((textBox1.Text.Length > 0) && (textBox1.Text[textBox1.Text.Length - 1].Equals(' ')))
            {
                if (LastSpaceIndex < textBox1.Text.Length - 1)
                {
                    PrevSpaceIndex = LastSpaceIndex;
                    LastSpaceIndex = textBox1.Text.Length - 1;
                }
                
                string newWord;
                if (PrevSpaceIndex == 0)
                {
                    newWord = compareWord(textBox1.Text.Substring(PrevSpaceIndex, LastSpaceIndex - PrevSpaceIndex));
                }
                else
                {
                    newWord = compareWord(textBox1.Text.Substring(PrevSpaceIndex, LastSpaceIndex - PrevSpaceIndex));
                }

                if (PrevSpaceIndex == 0)
                {
                    textBox1.Text = newWord + " ";
                }
                else if (PrevSpaceIndex != 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, PrevSpaceIndex + 1) + newWord + " ";
                }
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private static string compareWord(string word)
        {
            string tempWord = word;
            if (word[0].Equals(' '))
            {
               word = word.Remove(0, 1);
            }
            int tempInt;
            double tempDouble;
            if ((word.Length < 2)
                || (int.TryParse(word, out tempInt) == true)
                || (double.TryParse(word, out tempDouble) == true))
                return word;

            using (var reader = new StreamReader("D:\\winformsDict.txt"))
            {
                int minDifferences = word.Length;
                string lastPossible = "";
                List<string> possibilities = new List<string>();

                //filter all words
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (word.Equals(line))
                    {
                        return line;
                    }
                    else if (word.Length != line.Length)
                    {
                        string a = word;
                        string b = line;

                        for (int i = 0; i < line.Length; i++)
                        {
                            if (a.Contains(line[i]))
                            {
                                a = a.Remove(a.IndexOf(line[i]), 1);
                                b = b.Remove(b.IndexOf(line[i]), 1);
                            }
                        }

                        if (a.Length < 2 && b.Length < 2)
                        {
                            possibilities.Add(line);
                            lastPossible = line;
                        }
                    }
                    else if (word.Length == line.Length)
                    {
                        string a = word;
                        string b = line;

                        for (int i = 0; i < line.Length; i++)
                        {
                            if (a.Contains(line[i]))
                            {
                                a = a.Remove(a.IndexOf(line[i]), 1);
                                b = b.Remove(b.IndexOf(line[i]), 1);
                            }
                        }

                        if (a.Length < 2 && b.Length < 2)
                        {
                            possibilities.Add(line);
                            lastPossible = line;
                        }
                    }
                    line = reader.ReadLine();
                }

                //select one from filtered
                if ((possibilities.Count == 0) && (lastPossible.Length == 0))
                {
                    return word;
                }
                else
                {
                    List<string> firstAndLast = possibilities.Where(w => w[0].Equals(word[0])
                                                            && w[w.Length - 1].Equals(word[word.Length - 1])).ToList();
                    List<string> firstAndSecond = new List<string>();

                    if (possibilities.Where(w => w.Length >= word.Length
                                             && w[0].Equals(word[0])
                                             && w[1].Equals(word[1])).ToList().FirstOrDefault() != null)
                    {
                        firstAndSecond = possibilities.Where(w => w[0].Equals(word[0])
                                                            && w[1].Equals(word[1])).ToList();
                    }


                    if (firstAndLast.Count == 0)
                    {
                        if (possibilities.Where(w => w.Length > 2 
                                                    && w[0].Equals(word[0])
                                                    && w[1].Equals(word[1])
                                                    && w[2].Equals(word[2])).ToList().FirstOrDefault() != null)
                        {
                            return possibilities.Where(w => w.Length > 2
                                                    && w[0].Equals(word[0])
                                                    && w[1].Equals(word[1])
                                                    && w[2].Equals(word[2])).First();
                        }
                        else if (possibilities.Where(w => w[w.Length - 1].Equals(word[word.Length - 1])
                                                        && w[w.Length - 2].Equals(word[word.Length - 2])).FirstOrDefault() != null)
                        {
                            return possibilities.Where(w => w[w.Length - 1].Equals(word[word.Length - 1])
                                                        && w[w.Length - 2].Equals(word[word.Length - 2])).First();
                        }
                        else
                        {
                            return possibilities.Where(w => w[0].Equals(word[0])
                                                        || w[w.Length - 1].Equals(word[word.Length - 1])).FirstOrDefault();
                        }
                    }
                    else if (firstAndLast.Intersect(firstAndSecond).ToList().Count == 0)
                    {
                        return firstAndLast.First();
                    }
                    else
                    {
                        return firstAndLast.Intersect(firstAndSecond).ToList().Where(w => w[0].Equals(word[0])).First();
                    }

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
