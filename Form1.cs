using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektForms
{
    public partial class Form1 : Form
    {
        Graphics gr;
        AVLTree tree;
        Graph graph;
        ReadWrite rw;
        string[] ipText = new string[4];
        byte[] ip1 = new byte[4];
        byte[] ip2 = new byte[4];
        int cost;
        int k;
        bool isIpCorrect = false;
        bool isIp2Correct = false;
        bool isKCorrect = false;
        bool isCostCorrect = false;
        public Form1()
        {
            tree = new AVLTree();
            graph = new Graph(tree); 
            InitializeComponent();
            rw = new ReadWrite();
            StatusLabel.Text = "Output";
            isIpCorrect = false;
            WrongAdress();
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Draw()
        {
            gr = GraphPanel.CreateGraphics();
            gr.Clear(GraphPanel.BackColor);
            Draw(tree.GetRoot(), GraphPanel.Width / 2 - 30, 10, 0, 0);
        }
        private void Draw(Node current, int x, int y, int prevX, int prevY)
        {
            if (current != null)
            {
                Pen pen = Pens.Black;
                Rectangle rect = new Rectangle(x, y, 50, 50);
                gr.DrawString(current.ToString(), this.Font, Brushes.Black, rect);
                gr.DrawRectangle(pen, rect);
                if(prevX != 0) gr.DrawLine(pen, x + 25, y, prevX + 25, prevY + 50);
                Draw(current.left, x - Math.Abs((x - prevX) / 2), 80 + y, x, y);
                Draw(current.right, x + Math.Abs((x - prevX) / 2), 80 + y, x, y);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (tree.Search(ip1)) StatusLabel.Text = "IP already in use";
            else StatusLabel.Text = ip1[0] + "." + ip1[1] + "." + ip1[2] + "." + ip1[3] + " added";
            byte[] ip4 = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                ip4[i] = ip1[i];
            }
            graph.AddRouter(ip4);
            tree.Add(ip4);
            Draw();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            if (!tree.Search(ip1)) StatusLabel.Text = ip1[0] + "." + ip1[1] + "." + ip1[2] + "." + ip1[3] + " not found";
            else StatusLabel.Text = ip1[0]+"."+ip1[1]+ "." + ip1[2]+ "." + ip1[3]+" deleted";
            tree.Delete(ip1);
            Draw();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (tree.Search(ip1)) StatusLabel.Text = ip1[0]+"."+ip1[1]+ "." + ip1[2]+ "." + ip1[3]+" found";
            else StatusLabel.Text = ip1[0]+"."+ip1[1]+ "." + ip1[2]+ "." + ip1[3]+ " not found";
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int computerCount = tree.Count(ip1);
            StatusLabel.Text = computerCount + " computers in " +  ip1[0]+"."+ip1[1]+ "." + ip1[2]+ ".0/24 subnet";
        }
        private void CorrectAdress()
        {
            if (isIpCorrect)
            {
                AddButton.Enabled = true;
                DeleteButton.Enabled = true;
                SearchButton.Enabled = true;
                if (ip1[3] == 0) CountButton.Enabled = true;
                if (isIp2Correct && isIpCorrect)
                {
                    if(ip1[3] == 0 && ip2[3] == 0)
                    {
                        DeleteConnectionButton.Enabled = true;
                        if (isCostCorrect)
                        {
                            AddConnectionButton.Enabled = true;
                        }
                    }
                    if (ip1[3] != 0 && ip2[3] != 0)
                    {
                        FCButton.Enabled = true;
                        if (isKCorrect)
                        {
                            FC2Button.Enabled = true;
                        }
                    }
                }
            }
        }
        private void WrongAdress()
        {
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            SearchButton.Enabled = false;
            CountButton.Enabled = false;
            AddConnectionButton.Enabled = false;
            DeleteConnectionButton.Enabled = false;
            FCButton.Enabled = false;
            FC2Button.Enabled = false;
            CorrectAdress();
        }
        private void IsAddress1Correct()
        {
            for(int i = 0; i < ipText.Length; i++)
            {
                if (ipText[i] != "" && Convert.ToInt32(ipText[i]) < 256) ip1[i] = Convert.ToByte(ipText[i]);
                else
                {
                    isIpCorrect = false;
                    WrongAdress();
                    return;
                }
            }
            isIpCorrect = true;
            CorrectAdress();
        }
        private void IsAddress2Correct()
        {
            for (int i = 0; i < ipText.Length; i++)
            {
                if (ipText[i] != "" && Convert.ToInt32(ipText[i]) < 256) ip2[i] = Convert.ToByte(ipText[i]);
                else
                {
                    isIp2Correct = false;
                    WrongAdress();
                    return;
                }
            }
            isIp2Correct = true;
            CorrectAdress();
        }
        private void IP1_TextChanged(object sender, EventArgs e)
        {
            ipText = IP1.Text.Split('.');
            if (ipText.Length == 4) IsAddress1Correct();
            else
            {
                isIpCorrect = false;
                WrongAdress();
            }
        }
        private void IP2_TextChanged(object sender, EventArgs e)
        {
            ipText = IP2.Text.Split('.');
            if (ipText.Length == 4) IsAddress2Correct();
            else
            {
                isIp2Correct = false;
                WrongAdress();
            }
        }
        private void avoidLetters(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void avoidLettersK(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            int res;
            rw.Read();
            Command[] commands = rw.GetCommands();
            List<string> resoult = new List<string>();
            foreach (Command c in commands)
            {
                switch (c.operation)
                {
                    case "DK":
                        graph.AddRouter(c.ip1);
                        tree.Add(c.ip1);
                        break;
                    case "UK":
                        tree.Delete(c.ip1);
                        break;
                    case "WK":
                        if (tree.Search(c.ip1)) resoult.Add("TAK");
                        else resoult.Add("NIE");
                        break;
                    case "LK":
                        resoult.Add(Convert.ToString(tree.Count(c.ip1)));
                        break;
                    case "WY":
                        tree.Print();
                        break;
                    case "DP":
                        graph.AddConnection(c.ip1, c.ip2, c.cost);
                        break;
                    case "UP":
                        graph.RemoveConnection(c.ip1, c.ip2);
                        break;
                    case "NP":
                        res = graph.FastestConnection(c.ip1, c.ip2);
                        if (res == 0) resoult.Add("NIE");
                        else resoult.Add(Convert.ToString(res));
                        break;
                    case "NP2":
                        res = graph.FastestConnection2(c.ip1, c.ip2, c.k);
                        if (res == 0) resoult.Add("NIE");
                        else resoult.Add(Convert.ToString(graph.FastestConnection2(c.ip1, c.ip2, c.k)));
                        break;
                }
            }
            rw.Write(resoult);
            Draw();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tree.Clear();
            Draw();
            StatusLabel.Text = "Tree removed";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void K_TextChanged(object sender, EventArgs e)
        {
            if (K.Text == "") k = 0;
            else k = Convert.ToInt32(K.Text);
            if (k < 4 && k > 0)
            {
                isKCorrect = true;
                StatusLabel.Text = "K correct";
            }
            else
            {
                isKCorrect = false;
                StatusLabel.Text = "K is too large";
            }
            CorrectAdress();
        }

        private void AddConnectionButton_Click(object sender, EventArgs e)
        {
            int costTemp;
            if(radioButtonG.Checked == true)
            {
                costTemp = 100 / cost;
            }
            else
            {
                costTemp = 100000 / cost;
            }
            graph.AddConnection(ip1, ip2, costTemp);
            StatusLabel.Text = "Connection added";

        }

        private void DeletConnectionButton_Click(object sender, EventArgs e)
        {
            graph.RemoveConnection(ip1, ip2);
            StatusLabel.Text = "Connection removed";
        }

        private void FCButton_Click(object sender, EventArgs e)
        {
            int res = graph.FastestConnection(ip1, ip2);
            if (res == 0) StatusLabel.Text = "Connection not found";
            else StatusLabel.Text = "Cost: " + res;
        }

        private void FC2Button_Click(object sender, EventArgs e)
        {
            int res = graph.FastestConnection2(ip1, ip2, k);
            if (res == 0) StatusLabel.Text = "Connection not found";
            else StatusLabel.Text = "Cost: " + res;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if(CostTextBox.Text == "")
            {
                cost = 0;
            }
            else
            {
                cost = Convert.ToInt32(CostTextBox.Text);
            }
            if(cost > 0)
            {
                isCostCorrect = true;
                CorrectAdress();
            }
            else
            {
                cost = 0;
                isCostCorrect = false;
                WrongAdress();
            }
        }

        private void InputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
