﻿namespace Loja
{
    partial class frmEntradas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbProduto = new DevExpress.XtraEditors.LookUpEdit();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDatFim = new DevExpress.XtraEditors.DateEdit();
            this.txtDatInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRetornar = new DevExpress.XtraEditors.SimpleButton();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVlrUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVlrFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigounico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDados = new DevExpress.XtraGrid.GridControl();
            this.gridDados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.cmbProduto);
            this.groupControl1.Controls.Add(this.btnImprimir);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnConsultar);
            this.groupControl1.Controls.Add(this.txtDatFim);
            this.groupControl1.Controls.Add(this.txtDatInicio);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnRetornar);
            this.groupControl1.Location = new System.Drawing.Point(12, 301);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(666, 125);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Opções e Filtros";
            // 
            // cmbProduto
            // 
            this.cmbProduto.EnterMoveNextControl = true;
            this.cmbProduto.Location = new System.Drawing.Point(234, 43);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cmbProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProduto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodProduto", 30, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesProduto", 100, "Descrição"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DesLocal", 10, "Local"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QtdProduto", 10, "Est.")});
            this.cmbProduto.Properties.DisplayMember = "DesProduto";
            this.cmbProduto.Properties.NullText = "[Selecione um produto]";
            this.cmbProduto.Properties.PopupFormMinSize = new System.Drawing.Size(400, 0);
            this.cmbProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbProduto.Properties.ValueMember = "codigounico";
            this.cmbProduto.Size = new System.Drawing.Size(242, 20);
            this.cmbProduto.TabIndex = 9;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(505, 97);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(234, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Produto";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(424, 97);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtDatFim
            // 
            this.txtDatFim.EditValue = null;
            this.txtDatFim.Location = new System.Drawing.Point(115, 43);
            this.txtDatFim.Name = "txtDatFim";
            this.txtDatFim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDatFim.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDatFim.Size = new System.Drawing.Size(100, 20);
            this.txtDatFim.TabIndex = 3;
            // 
            // txtDatInicio
            // 
            this.txtDatInicio.EditValue = null;
            this.txtDatInicio.Location = new System.Drawing.Point(9, 43);
            this.txtDatInicio.Name = "txtDatInicio";
            this.txtDatInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDatInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDatInicio.Size = new System.Drawing.Size(100, 20);
            this.txtDatInicio.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Período";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetornar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRetornar.Location = new System.Drawing.Point(586, 97);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 0;
            this.btnRetornar.Text = "&Retornar";
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Qtde.";
            this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidade.FieldName = "QtdProduto";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 4;
            this.colQuantidade.Width = 49;
            // 
            // colVlrUnitario
            // 
            this.colVlrUnitario.Caption = "Vlr. Unit.";
            this.colVlrUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVlrUnitario.FieldName = "VlrUnitario";
            this.colVlrUnitario.Name = "colVlrUnitario";
            this.colVlrUnitario.Visible = true;
            this.colVlrUnitario.VisibleIndex = 3;
            this.colVlrUnitario.Width = 73;
            // 
            // colVlrFinal
            // 
            this.colVlrFinal.Caption = "Vlr. Final";
            this.colVlrFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colVlrFinal.FieldName = "VlrTotal";
            this.colVlrFinal.Name = "colVlrFinal";
            this.colVlrFinal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colVlrFinal.Visible = true;
            this.colVlrFinal.VisibleIndex = 5;
            this.colVlrFinal.Width = 70;
            // 
            // colCodigounico
            // 
            this.colCodigounico.Caption = "Código Único";
            this.colCodigounico.FieldName = "codigounico";
            this.colCodigounico.Name = "colCodigounico";
            // 
            // colDesProduto
            // 
            this.colDesProduto.Caption = "Descrição";
            this.colDesProduto.FieldName = "DesProduto";
            this.colDesProduto.Name = "colDesProduto";
            this.colDesProduto.Visible = true;
            this.colDesProduto.VisibleIndex = 2;
            this.colDesProduto.Width = 267;
            // 
            // colCodProduto
            // 
            this.colCodProduto.Caption = "Código";
            this.colCodProduto.FieldName = "CodProduto";
            this.colCodProduto.Name = "colCodProduto";
            this.colCodProduto.Visible = true;
            this.colCodProduto.VisibleIndex = 1;
            this.colCodProduto.Width = 117;
            // 
            // colData
            // 
            this.colData.Caption = "Data";
            this.colData.DisplayFormat.FormatString = "d";
            this.colData.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData.FieldName = "DatEntrada";
            this.colData.GroupFormat.FormatString = "d";
            this.colData.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colData.Name = "colData";
            this.colData.OptionsColumn.AllowEdit = false;
            this.colData.OptionsColumn.ReadOnly = true;
            this.colData.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            this.colData.Width = 72;
            // 
            // grdDados
            // 
            this.grdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDados.Location = new System.Drawing.Point(12, 12);
            this.grdDados.MainView = this.gridDados;
            this.grdDados.Name = "grdDados";
            this.grdDados.Size = new System.Drawing.Size(666, 283);
            this.grdDados.TabIndex = 3;
            this.grdDados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDados});
            // 
            // gridDados
            // 
            this.gridDados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colData,
            this.colCodProduto,
            this.colDesProduto,
            this.colVlrUnitario,
            this.colQuantidade,
            this.colVlrFinal,
            this.colCodigounico,
            this.colDocEntrada});
            this.gridDados.GridControl = this.grdDados;
            this.gridDados.GroupPanelText = "Arraste uma coluna aqui para agrupar";
            this.gridDados.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "DatSaida", this.colData, "")});
            this.gridDados.Name = "gridDados";
            this.gridDados.OptionsView.ShowFooter = true;
            // 
            // colDocEntrada
            // 
            this.colDocEntrada.Caption = "Documento";
            this.colDocEntrada.FieldName = "DocEntrada";
            this.colDocEntrada.Name = "colDocEntrada";
            this.colDocEntrada.Visible = true;
            this.colDocEntrada.VisibleIndex = 6;
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdDados);
            this.Name = "frmEntradas";
            this.Text = "Relatório de Entradas";
            this.Load += new System.EventHandler(this.frmEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatFim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbProduto;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.DateEdit txtDatFim;
        private DevExpress.XtraEditors.DateEdit txtDatInicio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRetornar;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colVlrFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigounico;
        private DevExpress.XtraGrid.Columns.GridColumn colDesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.GridControl grdDados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDados;
        private DevExpress.XtraGrid.Columns.GridColumn colDocEntrada;
    }
}