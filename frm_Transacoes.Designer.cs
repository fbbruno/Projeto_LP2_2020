namespace ProjetoIF
{
    partial class frm_Transacoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Transacoes));
            System.Windows.Forms.Label id_TransacaoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label tempoLabel;
            System.Windows.Forms.Label data_DevolucaoLabel;
            System.Windows.Forms.Label retornouLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label id_LivroLabel;
            System.Windows.Forms.Label autorizacaoLabel;
            this.bDProjetoIFDataSet = new ProjetoIF.BDProjetoIFDataSet();
            this.transacoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transacoesTableAdapter = new ProjetoIF.BDProjetoIFDataSetTableAdapters.TransacoesTableAdapter();
            this.tableAdapterManager = new ProjetoIF.BDProjetoIFDataSetTableAdapters.TableAdapterManager();
            this.transacoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.transacoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_TransacaoTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tempoTextBox = new System.Windows.Forms.TextBox();
            this.data_DevolucaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.retornouDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.id_LivroTextBox = new System.Windows.Forms.TextBox();
            this.autorizacaoTextBox = new System.Windows.Forms.TextBox();
            this.transacoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_TransacaoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            tempoLabel = new System.Windows.Forms.Label();
            data_DevolucaoLabel = new System.Windows.Forms.Label();
            retornouLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_LivroLabel = new System.Windows.Forms.Label();
            autorizacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoIFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingNavigator)).BeginInit();
            this.transacoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDProjetoIFDataSet
            // 
            this.bDProjetoIFDataSet.DataSetName = "BDProjetoIFDataSet";
            this.bDProjetoIFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transacoesBindingSource
            // 
            this.transacoesBindingSource.DataMember = "Transacoes";
            this.transacoesBindingSource.DataSource = this.bDProjetoIFDataSet;
            // 
            // transacoesTableAdapter
            // 
            this.transacoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.systemTableTableAdapter = null;
            this.tableAdapterManager.TransacoesTableAdapter = this.transacoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoIF.BDProjetoIFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transacoesBindingNavigator
            // 
            this.transacoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transacoesBindingNavigator.BindingSource = this.transacoesBindingSource;
            this.transacoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transacoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transacoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.transacoesBindingNavigatorSaveItem});
            this.transacoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transacoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transacoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transacoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transacoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transacoesBindingNavigator.Name = "transacoesBindingNavigator";
            this.transacoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transacoesBindingNavigator.Size = new System.Drawing.Size(873, 25);
            this.transacoesBindingNavigator.TabIndex = 0;
            this.transacoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // transacoesBindingNavigatorSaveItem
            // 
            this.transacoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transacoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transacoesBindingNavigatorSaveItem.Image")));
            this.transacoesBindingNavigatorSaveItem.Name = "transacoesBindingNavigatorSaveItem";
            this.transacoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.transacoesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.transacoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.transacoesBindingNavigatorSaveItem_Click);
            // 
            // id_TransacaoLabel
            // 
            id_TransacaoLabel.AutoSize = true;
            id_TransacaoLabel.Location = new System.Drawing.Point(11, 42);
            id_TransacaoLabel.Name = "id_TransacaoLabel";
            id_TransacaoLabel.Size = new System.Drawing.Size(73, 13);
            id_TransacaoLabel.TabIndex = 1;
            id_TransacaoLabel.Text = "Id Transacao:";
            // 
            // id_TransacaoTextBox
            // 
            this.id_TransacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transacoesBindingSource, "Id_Transacao", true));
            this.id_TransacaoTextBox.Location = new System.Drawing.Point(105, 39);
            this.id_TransacaoTextBox.Name = "id_TransacaoTextBox";
            this.id_TransacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_TransacaoTextBox.TabIndex = 2;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(11, 69);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transacoesBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(105, 65);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // tempoLabel
            // 
            tempoLabel.AutoSize = true;
            tempoLabel.Location = new System.Drawing.Point(11, 94);
            tempoLabel.Name = "tempoLabel";
            tempoLabel.Size = new System.Drawing.Size(43, 13);
            tempoLabel.TabIndex = 5;
            tempoLabel.Text = "Tempo:";
            // 
            // tempoTextBox
            // 
            this.tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transacoesBindingSource, "Tempo", true));
            this.tempoTextBox.Location = new System.Drawing.Point(105, 91);
            this.tempoTextBox.Name = "tempoTextBox";
            this.tempoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tempoTextBox.TabIndex = 6;
            // 
            // data_DevolucaoLabel
            // 
            data_DevolucaoLabel.AutoSize = true;
            data_DevolucaoLabel.Location = new System.Drawing.Point(11, 121);
            data_DevolucaoLabel.Name = "data_DevolucaoLabel";
            data_DevolucaoLabel.Size = new System.Drawing.Size(88, 13);
            data_DevolucaoLabel.TabIndex = 7;
            data_DevolucaoLabel.Text = "Data Devolucao:";
            // 
            // data_DevolucaoDateTimePicker
            // 
            this.data_DevolucaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transacoesBindingSource, "Data_Devolucao", true));
            this.data_DevolucaoDateTimePicker.Location = new System.Drawing.Point(105, 117);
            this.data_DevolucaoDateTimePicker.Name = "data_DevolucaoDateTimePicker";
            this.data_DevolucaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_DevolucaoDateTimePicker.TabIndex = 8;
            // 
            // retornouLabel
            // 
            retornouLabel.AutoSize = true;
            retornouLabel.Location = new System.Drawing.Point(11, 147);
            retornouLabel.Name = "retornouLabel";
            retornouLabel.Size = new System.Drawing.Size(54, 13);
            retornouLabel.TabIndex = 9;
            retornouLabel.Text = "Retornou:";
            // 
            // retornouDateTimePicker
            // 
            this.retornouDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transacoesBindingSource, "Retornou", true));
            this.retornouDateTimePicker.Location = new System.Drawing.Point(105, 143);
            this.retornouDateTimePicker.Name = "retornouDateTimePicker";
            this.retornouDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.retornouDateTimePicker.TabIndex = 10;
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(11, 172);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(54, 13);
            id_ClienteLabel.TabIndex = 11;
            id_ClienteLabel.Text = "Id Cliente:";
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transacoesBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(105, 169);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_ClienteTextBox.TabIndex = 12;
            // 
            // id_LivroLabel
            // 
            id_LivroLabel.AutoSize = true;
            id_LivroLabel.Location = new System.Drawing.Point(11, 198);
            id_LivroLabel.Name = "id_LivroLabel";
            id_LivroLabel.Size = new System.Drawing.Size(45, 13);
            id_LivroLabel.TabIndex = 13;
            id_LivroLabel.Text = "Id Livro:";
            // 
            // id_LivroTextBox
            // 
            this.id_LivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transacoesBindingSource, "Id_Livro", true));
            this.id_LivroTextBox.Location = new System.Drawing.Point(105, 195);
            this.id_LivroTextBox.Name = "id_LivroTextBox";
            this.id_LivroTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_LivroTextBox.TabIndex = 14;
            // 
            // autorizacaoLabel
            // 
            autorizacaoLabel.AutoSize = true;
            autorizacaoLabel.Location = new System.Drawing.Point(11, 224);
            autorizacaoLabel.Name = "autorizacaoLabel";
            autorizacaoLabel.Size = new System.Drawing.Size(66, 13);
            autorizacaoLabel.TabIndex = 15;
            autorizacaoLabel.Text = "Autorizacao:";
            // 
            // autorizacaoTextBox
            // 
            this.autorizacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transacoesBindingSource, "Autorizacao", true));
            this.autorizacaoTextBox.Location = new System.Drawing.Point(105, 221);
            this.autorizacaoTextBox.Name = "autorizacaoTextBox";
            this.autorizacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.autorizacaoTextBox.TabIndex = 16;
            // 
            // transacoesDataGridView
            // 
            this.transacoesDataGridView.AutoGenerateColumns = false;
            this.transacoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transacoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.transacoesDataGridView.DataSource = this.transacoesBindingSource;
            this.transacoesDataGridView.Location = new System.Drawing.Point(14, 247);
            this.transacoesDataGridView.Name = "transacoesDataGridView";
            this.transacoesDataGridView.Size = new System.Drawing.Size(838, 339);
            this.transacoesDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Transacao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Transacao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tempo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_Devolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data_Devolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Retornou";
            this.dataGridViewTextBoxColumn5.HeaderText = "Retornou";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_Cliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id_Cliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_Livro";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_Livro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Autorizacao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Autorizacao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frm_Transacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 598);
            this.Controls.Add(this.transacoesDataGridView);
            this.Controls.Add(id_TransacaoLabel);
            this.Controls.Add(this.id_TransacaoTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(tempoLabel);
            this.Controls.Add(this.tempoTextBox);
            this.Controls.Add(data_DevolucaoLabel);
            this.Controls.Add(this.data_DevolucaoDateTimePicker);
            this.Controls.Add(retornouLabel);
            this.Controls.Add(this.retornouDateTimePicker);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(id_LivroLabel);
            this.Controls.Add(this.id_LivroTextBox);
            this.Controls.Add(autorizacaoLabel);
            this.Controls.Add(this.autorizacaoTextBox);
            this.Controls.Add(this.transacoesBindingNavigator);
            this.Name = "frm_Transacoes";
            this.Text = "Transacoes";
            this.Load += new System.EventHandler(this.frm_Transacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoIFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesBindingNavigator)).EndInit();
            this.transacoesBindingNavigator.ResumeLayout(false);
            this.transacoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transacoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProjetoIFDataSet bDProjetoIFDataSet;
        private System.Windows.Forms.BindingSource transacoesBindingSource;
        private BDProjetoIFDataSetTableAdapters.TransacoesTableAdapter transacoesTableAdapter;
        private BDProjetoIFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transacoesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton transacoesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_TransacaoTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox tempoTextBox;
        private System.Windows.Forms.DateTimePicker data_DevolucaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker retornouDateTimePicker;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.TextBox id_LivroTextBox;
        private System.Windows.Forms.TextBox autorizacaoTextBox;
        private System.Windows.Forms.DataGridView transacoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}