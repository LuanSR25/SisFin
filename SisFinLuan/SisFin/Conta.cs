using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Conta
    {
        private int id;
        private String nome;
        private String descricao;
        private int categoria;
        private int status;
        private List<Conta> _lstConta = new List<Conta>();

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Status { get => status; set => status = value; }
        internal List<Conta> LstConta { get => _lstConta; set => _lstConta = value; }

        public Conta()
        {

        }

        public Conta(int id, string nome, string descricao, int categoria, int status)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.categoria = categoria;
            this.status = status;
        }
            public List<Conta> geraContas()
            {
                Conta _cnt1 = new Conta(1, "Salário Unicamp", "Salário recebido da UNICAMP", 1, 1);
                Conta _cnt2 = new Conta(2, "Abastecimento Onix", "Combustivel Onix", 2, 0);
                _lstConta.Add(_cnt1);
                _lstConta.Add(_cnt2);
                return _lstConta;
            }

            public List<Conta> ToList()
            {
                return _lstConta;
            }

            public void AddToList(int id, string nome, string descricao, int categoria, int status)
            {
                _lstConta.Add(new Conta(id, nome, descricao, categoria, status));
            }
    }
}
