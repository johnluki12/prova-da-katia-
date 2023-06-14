using Database;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clienteId_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void clienteTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente requisicao = new Cliente();

            if (TxtData.Text == null || TxtData.Text == "") 
            {
              
                requisicao.Horario = TxtHorario.Text;
                requisicao.Modelo = clienteModelo.Text;
                requisicao.Placa= TxtPlaca.Text;
            }
            else 
            {
               
                requisicao.Horario = TxtHorario.Text;
                requisicao.Placa = TxtPlaca.Text;
                requisicao.Modelo = clienteModelo.Text;
            }
            requisicao.Salvar(); 


            LimpaCampos(); 
            GetClientes(); 
        }
        private void LimpaCampos()
        {
           
            TxtData.Text = "";
            TxtHorario.Text = "";
            TxtPlaca.Text = "";
            clienteModelo.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente placa = new Cliente();
            var id = int.Parse(TxtData.Text);
            placa.Excluir(id);
            GetClientes();
        }

        private void tableClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Cliente().CriarTabela();
            GetClientes(); 
        }

        private void GetClientes()
        {
            tableClientes.AutoGenerateColumns = false;

            Cliente cliente = new Cliente();
            tableClientes.DataSource = cliente.Todos()[0];
        }

        private void GetCliente()
        {
            tableClientes.AutoGenerateColumns = false; 
          
            Cliente cliente = new Cliente();

            var id = int.Parse(TxtData.Text);

            var retorno = cliente.Buscar<Cliente>(id).FirstOrDefault(); 

            if (retorno == null)
            {
                MessageBox.Show("Não encontrado");
                LimpaCampos();
                GetClientes();
                return;
            }

            
            TxtHorario.Text = retorno.Horario;
            TxtData.Text = retorno.Data;
            TxtPlaca.Text = retorno.Placa;

            tableClientes.DataSource = new List<Cliente>() { retorno };
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            GetCliente();
        }

        private void btnPgClientes_Click(object sender, EventArgs e)
        {

        }


        private void btnPgFrotas_Click(object sender, EventArgs e)
        {

        }

        private void btnPgEncomendas_Click(object sender, EventArgs e)
        {

        }
    }
}
