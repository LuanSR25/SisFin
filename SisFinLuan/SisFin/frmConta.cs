using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmConta : Form
    {

        private Conta conta = new Conta();
        private List<Conta> lstConta = new List<Conta>();
        private List<Categoria> lstCategoria = new List<Categoria>();
        private BindingSource bsConta;
        private BindingSource bsCategoria;

        public frmConta()
        {
            InitializeComponent();
            lstConta = conta.geraContas();
            lstCategoria = (new Categoria()).GeraCategorias();
        }

        private void carregaGridConta()
        {
            bsConta = new BindingSource();
            bsConta.DataSource = lstConta;
            //bsConta.Rows.Clear();
            dgConta.DataSource = bsConta;
            dgConta.Refresh();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            carregaComboCategoria();

            dgConta.ColumnCount = 4;
            dgConta.AutoGenerateColumns = false;
            dgConta.Columns[0].Width = 50;
            dgConta.Columns[0].HeaderText = "ID";
            dgConta.Columns[0].DataPropertyName = "Id";
            dgConta.Columns[0].Visible = true;
            dgConta.Columns[1].Width = 200;
            dgConta.Columns[1].HeaderText = "NOME";
            dgConta.Columns[1].DataPropertyName = "Nome";
            dgConta.Columns[2].Width = 450;
            dgConta.Columns[2].HeaderText = "DESCRIÇÃO";
            dgConta.Columns[2].DataPropertyName = "Descricao";
            /*dgConta.Columns[3].Width = 50;
            dgConta.Columns[3].HeaderText = "TIPO";
            dgConta.Columns[3].DataPropertyName = "Tipo";
            dgConta.Columns[4].Width = 50;*/
            dgConta.Columns[3].Width = 50;
            dgConta.Columns[3].HeaderText = "STATUS";
            dgConta.Columns[3].DataPropertyName = "Status";
            dgConta.Columns[3].Visible = false;



            dgConta.AllowUserToAddRows = false;
            dgConta.AllowUserToDeleteRows = false;
            dgConta.MultiSelect = false;
            dgConta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridConta();
            





        }

        public void GeraContas()
        {

        }
        
        private void carregaComboCategoria(int id=0)
        {
            bsCategoria = new BindingSource();
            bsCategoria.DataSource = lstCategoria;
            CboCategoria.DataSource = bsCategoria;
            CboCategoria.DisplayMember = "Nome";
            CboCategoria.SelectedItem = "id";

            if(id>0)
            {
                foreach (var c in lstCategoria)
                {
                    if (c.Id == id)
                    {
                        int index = CboCategoria.FindString(c.Nome);
                        CboCategoria.SelectedIndex = index;
                    }
                }
            }
            CboCategoria.Refresh();
        }

        private void dgConta_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgConta.RowCount > 0)
            {
                int _id = Convert.ToInt32(dgConta.Rows[e.RowIndex].Cells[0].Value);
                carregaComboCategoria(_id);

                txtNome.Text = dgConta.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescricao.Text = dgConta.Rows[e.RowIndex].Cells[2].Value.ToString();

                if (Convert.ToInt16(dgConta.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    chkStatus.Checked = true;
                else
                    chkStatus.Checked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

