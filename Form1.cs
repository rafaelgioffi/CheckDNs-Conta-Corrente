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

namespace CheckDNs___Conta_Corrente
{
    public partial class Form1 : Form
    {
        string fileName;
        string[] allFile = { };
        string[] actualDn;
        string verifingDN;
        int actualQuant = 0;
        List<string> DNs = new List<string>();
        List<int> Quants = new List<int>();
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            opFile.ShowDialog();
            fileName = opFile.FileName;
            
            try
            {
                if(File.Exists(fileName))
                {
                    allFile = File.ReadAllLines(fileName);
                    
                    for (int i = 0;i < allFile.Length; i++)
                    {
                        actualDn = allFile[i].Split('#');
                        if (i == 0)
                        {
                            verifingDN = actualDn[0];
                        }

                        if (actualDn[0] == verifingDN)
                        {
                            actualQuant++;
                        }
                        else
                        {
                            DNs.Add(verifingDN);
                            Quants.Add(actualQuant);
                            actualQuant = 1;
                        }
                        verifingDN = actualDn[0];                        
                    }
                    for (int i = 0;i < DNs.Count; i++)
                    {
                        dataGridView1.Rows.Add(DNs[i], Quants[i]);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Falha ao ler o arquivo.\n {ex.Message}");
            }
        }

      
    }
}
