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
            lstConta = Conta.GeraContas();
            lstCategoria = (new Categoria()).GeraCategorias();
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
            carregaComboCategoria()
            
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

    }
}

