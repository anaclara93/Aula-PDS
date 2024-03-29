﻿using SpaceSistemas.Helpers;
using SpaceSistemas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SpaceSistemas.Views
{
    /// <summary>
    /// Lógica interna para FornecedorFormWindow.xaml
    /// </summary>
    public partial class FornecedorFormWindow : Window
    {
        private Fornecedor _fornecedor = new Fornecedor();

        public FornecedorFormWindow()
        {
            InitializeComponent();
            Loaded += FornecedorFormWindow_Loaded;
        }
        public FornecedorFormWindow(int id)
        {
            InitializeComponent();
            Loaded += FornecedorFormWindow_Loaded;

            _fornecedor.Id = id;
        }

        private void FornecedorFormWindow_Loaded(object sender, RoutedEventArgs e)
        {

           // MessageBox.Show("ID: " + _fornecedor.Id);
            try
            {
                comboBoxEstado.ItemsSource = Estado.List();
                if (_fornecedor.Id>0)
                {
                    var fornecedorDAO = new FornecedorDAO();
                    _fornecedor=fornecedorDAO.GetById(_fornecedor.Id);

                    txtId.Text = _fornecedor.Id.ToString();
                    txtRazaoSocial.Text = _fornecedor.RazaoSocial;
                    txtNomeFantasia.Text = _fornecedor.NomeFantasia;
                    txtCNPJ.Text = _fornecedor.CNPJ;
                    txtTelefone.Text= _fornecedor.Telefone;
                    txtRepresentante.Text= _fornecedor.Representante;

                }
            }
            catch {}
        }

        private void Btn_Salvar_Click(object sender, RoutedEventArgs e)
        {
            _fornecedor.RazaoSocial = txtRazaoSocial.Text;
            _fornecedor.NomeFantasia = txtNomeFantasia.Text;
            _fornecedor.CNPJ= txtCNPJ.Text;
            _fornecedor.Telefone = txtTelefone.Text;
            _fornecedor.Representante = txtRepresentante.Text;
            
            // Validação Verificar campos em branco

            try
            {
                var fornecedorDAO = new FornecedorDAO();

                if (_fornecedor.Id==0)
                {
                    fornecedorDAO.Insert(_fornecedor);

                    MessageBox.Show($"Fornecedor `{_fornecedor.RazaoSocial}` adicionado com sucesso!");
                }
                else
                {
                    fornecedorDAO.Update(_fornecedor);
                    MessageBox.Show($"Fornecedor `{_fornecedor.RazaoSocial}` atualizado com sucesso!");

                }
                this.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
