using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlMaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtEvento.Text != string.Empty)
                    mtxData.Focus();
            }
        }

        private void mtxData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                try {
                    DateTime data = Convert.ToDateTime(mtxData.Text);
                    lstEventos.Items.Add(txtEvento.Text);
                    lstDatas.Items.Add(mtxData.Text);
                    txtEvento.Clear();
                    mtxData.Clear();
                    txtEvento.Focus();
                }
            
                catch (Exception ex) 
                {
                    MessageBox.Show("Data inválida", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(ex.ToString());
                    mtxData.Focus();
                }
           }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (lstCandidatos.SelectedIndex == 0)
                txtCandidato1.Text = (int.Parse(txtCandidato1.Text) + 1).ToString();
            else if (lstCandidatos.SelectedIndex == 1)
                txtCandidato2.Text = (int.Parse(txtCandidato2.Text) + 1).ToString();
            else if (lstCandidatos.SelectedIndex == 2)
                txtCandidato3.Text = (int.Parse(txtCandidato3.Text) + 1).ToString();
            else
                MessageBox.Show("Selecione um candidato", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lstCandidatos.ClearSelected();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCandidato1.Text = "0";
            txtCandidato2.Text = "0";
            txtCandidato3.Text = "0";
        }

        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                lstDatas.Items.RemoveAt(lstEventos.SelectedIndex);
                lstEventos.Items.RemoveAt(lstEventos.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um evento", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
