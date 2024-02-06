using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CheckDNs___Conta_Corrente
{
    public partial class Form1 : Form
    {
        string fileNameTxt;
        string fileNameCsv;
        string[] allFileTxt = { };
        string[] allFileCsv = { };
        string[] actualDnTxt;
        string[] actualDnCsv;
        string[] DnJ;
        string[] DnK;
        string verifingDN;
        int actualQuant = 0;
        int inicial = 0;
        int final = 0;
        List<string> DNsTxt = new List<string>();
        List<string> DNsCsv = new List<string>();
        List<int> QuantsTxt = new List<int>();
        List<int> QuantsCsv = new List<int>();
        List<string> Duplicadas = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            opFile.ShowDialog();
            fileNameTxt = opFile.FileName;

            if (String.IsNullOrWhiteSpace(fileNameTxt))
            {
                btnTxt.BackColor = SystemColors.Control;
            }
            else
            {
                btnTxt.Font = new Font(btnTxt.Font, FontStyle.Italic);
                btnTxt.BackColor = SystemColors.GradientInactiveCaption;
            }
            VerificaBotoes();
        }
        private void btnCsv_Click(object sender, EventArgs e)
        {
            opFile.ShowDialog();
            fileNameCsv = opFile.FileName;

            if (String.IsNullOrWhiteSpace(fileNameCsv))
            {
                btnCsv.BackColor = SystemColors.Control;
            }
            else
            {
                btnCsv.Font = new Font(btnCsv.Font, FontStyle.Italic);
                btnCsv.BackColor = Color.Bisque;
            }
            VerificaBotoes();
        }

        public void VerificaBotoes()
        {
            if (!String.IsNullOrWhiteSpace(fileNameTxt) && !String.IsNullOrWhiteSpace(fileNameCsv))
            {
                btnCheck.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            btnCheck.Text = "Verificando...";
            if (String.IsNullOrWhiteSpace(fileNameTxt) || String.IsNullOrWhiteSpace(fileNameCsv))
            {
                MessageBox.Show("Selecione o TXT e CSV primeiro.");
                return;
            }

            try
            {
                dataGridView1.Rows.Clear();
                DNsTxt.Clear();
                DNsCsv.Clear();
                QuantsTxt.Clear();
                QuantsCsv.Clear();
                lblDuplicados.Text = "";
                if (File.Exists(fileNameTxt) && File.Exists(fileNameCsv))
                {
                    allFileTxt = File.ReadAllLines(fileNameTxt);
                    allFileCsv = File.ReadAllLines(fileNameCsv);

                    for (int i = 0; i < allFileCsv.Length; i++)
                    {
                        actualDnCsv = allFileCsv[i].Split(',');
                        DNsCsv.Add(actualDnCsv[0]);
                        int tempQuantCsv = 0;
                        int.TryParse(actualDnCsv[1], out tempQuantCsv);
                        QuantsCsv.Add(tempQuantCsv);
                    }

                    for (int i = 0; i <= allFileTxt.Length; i++)
                    {
                        if (i == allFileTxt.Length)
                        {
                            actualDnTxt = allFileTxt[i-1].Split('#');
                            verifingDN = actualDnTxt[0];
                            DNsTxt.Add(verifingDN);
                            QuantsTxt.Add(actualQuant);
                        }
                        else
                        {
                            actualDnTxt = allFileTxt[i].Split('#');
                        }

                        if (i == 0)
                        {
                            verifingDN = actualDnTxt[0];
                            //inicial = 0;
                        }

                        if (actualDnTxt[0] == verifingDN)
                        {
                            actualQuant++;
                        }
                        else
                        {
                            DNsTxt.Add(verifingDN);
                            QuantsTxt.Add(actualQuant);
                            //final = i;  //define a linha final
                            //Verificar se tem duplicada...
                            /*
                            for (int j = inicial; j < final; j++)
                            {
                                DnJ = allFileTxt[j].Split('#');
                                for (int k = inicial; k < final; k++)
                                {
                                    if (j == k) { k++; }
                                    DnK = allFileTxt[k].Split('#');
                                    if (DnJ[0] + DnJ[1] + DnJ[2] + DnJ[3] + DnJ[4] + DnJ[12] == DnK[0] + DnK[1] + DnK[2] + DnK[3] + DnK[4] + DnK[12])
                                    {
                                        Duplicadas.Add($"Linha {j} duplicada com a linha {k}");
                                    }
                                }
                            }
                            */
                            actualQuant = 1;
                            //inicial = final;
                        }
                        verifingDN = actualDnTxt[0];
                    }

                    for (int i = 0; i < DNsTxt.Count; i++)
                    {
                        int dntxt = int.Parse(DNsTxt[i]);
                        int quanttxt = QuantsTxt[i];
                        int dncsv = int.Parse(DNsCsv[i]);
                        int quantcsv = QuantsCsv[i];

                        dataGridView1.Rows.Add(dntxt, quanttxt, dncsv, quantcsv);
                        if (dntxt == dncsv && quanttxt == quantcsv)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                            lblDuplicados.Text += $"Divergências com o DN\t {dntxt}\n";
                        }
                    }
                    foreach (string d in Duplicadas)
                    {
                        lblDuplicados.Text = d;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao ler o arquivo.\n {ex.Message}");
            }
            btnCheck.Enabled = true;
            btnCheck.Text = "Verificar";
        }

    }
}
