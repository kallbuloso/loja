﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.XtraReports.UI;
using Loja.DAL.Models;
using Loja.DAL.DAO;

namespace Loja
{
    public partial class frmVendas : DevExpress.XtraEditors.XtraForm
    {

        #region Variáveis

        #endregion

        #region Form Events

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            txtDatFim.DateTime = DateTime.Now;
            txtDatInicio.DateTime = DateTime.Now.AddDays(-DateTime.Now.Day).AddDays(1);

            SU_CarregaProdutos();
            SU_CarregaTipoVenda();

        }

        #endregion

        #region Botões
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            using (Reports.relVendas relatorio = new Reports.relVendas())
            {

                ReportPrintTool printTool = new ReportPrintTool(relatorio);

                int codproduto = cmbProduto.EditValue == null ? 0 : (int)cmbProduto.EditValue;
                int codtipovenda = cmbTipoVenda.EditValue == null ? 0 : (int)cmbTipoVenda.EditValue;

                relatorio.SU_SetParam(txtDatInicio.DateTime, txtDatFim.DateTime, codproduto, codtipovenda);

                printTool.ShowRibbonPreviewDialog();
                printTool.ShowRibbonPreview(UserLookAndFeel.Default);
            }
        }

        private void btnEstornar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma estornar essa venda?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            int codigo = FU_PegaCodigoGrid();
            int codvenda = FU_PegaCodigoVenda();

            Cadastros.EstornaVenda(codvenda, codigo, "");


            MessageBox.Show("Item estornado com sucesso");

            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SU_CarregaVendas();
        }


        #endregion

        #region Funções
        void SU_CarregaProdutos()
        {
            var produtos = Consultas.ObterProdutosAtivos();
            cmbProduto.Properties.DataSource = produtos;

        }

        void SU_CarregaTipoVenda()
        {
            var TipoVenda = Consultas.ObterTipoVendaCombo();
            cmbTipoVenda.Properties.DataSource = TipoVenda;
        }

        void SU_CarregaVendas() {

            DateTime inicio = DateTime.Parse(txtDatInicio.DateTime.ToShortDateString());
            DateTime fim = DateTime.Parse(txtDatFim.DateTime.ToShortDateString()).AddDays(1).AddMinutes(-1);

            var saidas = Consultas.ObterVendas(inicio, fim);
            grdDados.DataSource = saidas;

        }

        int FU_PegaCodigoGrid()
        {
            int codigo = -1;

            int linha = gridDados.GetSelectedRows()[0];
            codigo = (int)gridDados.GetRowCellValue(linha, colCodigounico);

            return codigo;
        }

        int FU_PegaCodigoVenda()
        {
            int codigo = -1;

            int linha = gridDados.GetSelectedRows()[0];
            codigo = (int)gridDados.GetRowCellValue(linha, colCodVenda);

            return codigo;
        }

#endregion


    }
}