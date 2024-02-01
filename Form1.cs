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
        string[] DnJ;
        string[] DnK;
        string verifingDN;
        int actualQuant = 0;
        int inicial = 0;
        int final = 0;
        List<string> DNs = new List<string>();
        List<int> Quants = new List<int>();
        List<string> Duplicadas = new List<string>();
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
                            inicial = 0;
                        }

                        if (actualDn[0] == verifingDN)
                        {
                            actualQuant++;
                        }
                        else
                        {
                            DNs.Add(verifingDN);
                            Quants.Add(actualQuant);
                            final = i;  //define a linha final
                            //Verificar se tem duplicada...
                            for (int j = inicial; j < final; j++)
                            {
                                DnJ = allFile[j].Split('#');
                                for (int k = inicial; k < final; k++)
                                {
                                    if(j == k) { k++; }
                                    DnK = allFile[k].Split('#');
                                    if (DnJ[0] + DnJ[1] + DnJ[2] + DnJ[3] + DnJ[4] + DnJ[12] == DnK[0] + DnK[1] + DnK[2] + DnK[3] + DnK[4] + DnK[12])
                                    {
                                        Duplicadas.Add($"Linha {j} duplicada com a linha {k}");
                                    }
                                }
                            }
                            actualQuant = 1;
                            inicial = final;
                        }
                        verifingDN = actualDn[0];                        
                    }
                    for (int i = 0;i < DNs.Count; i++)
                    {
                        dataGridView1.Rows.Add(DNs[i], Quants[i]);
                    }
                    foreach (string d in Duplicadas)
                    {
                        lblDuplicados.Text = d;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Falha ao ler o arquivo.\n {ex.Message}");
            }
        }

      
    }
}
