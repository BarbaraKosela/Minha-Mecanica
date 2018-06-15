﻿using MinhaMecanica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class ListaCarro : Form
    {
        List<Carro> carros = new List<Carro>();
        public ListaCarro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtAno.Text = "";
            txtMarca.Text = "";
            txtValor.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carro = new Carro();

                {


                    carro.Nome = txtNome.Text;
                    carro.Marca = txtMarca.Text;
                    carro.Ano = Convert.ToInt16(txtAno.Text);
                    carro.Valor = Convert.ToDecimal(txtValor.Text);
                };
                carros.Add(carro);
                LimparCampos();
                AdicionarCarroATabela(carro);
                tabControl1.SelectedIndex = 0;
            }

            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void AdicionarCarroATabela(Carro carro)
        {
            dataGridView1.Rows.Add(new Object[]{
                carro.Nome, carro.Marca, carro.Ano, carro.Valor
            });
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre um carro");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um arquivo para apagar");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            for (int i = 0; i < carros.Count(); i++)
            {
                Carro carro = carros[i];
                if (carro.Nome == nome)
                {
                    carros.RemoveAt(i);
                }
            }
            
            dataGridView1.Rows.RemoveAt(linhaSelecionada);
        }
    }
}