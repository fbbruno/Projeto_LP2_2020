namespace ProjetoIF
{
    partial class frm_Departamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Departamentos));
            System.Windows.Forms.Label id_DepartamentoLabel;
            System.Windows.Forms.Label nome_DepartamentoLabel;
            System.Windows.Forms.Label codigoRackLabel;
            this.bDProjetoIFDataSet = new ProjetoIF.BDProjetoIFDataSet();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new ProjetoIF.BDProjetoIFDataSetTableAdapters.DepartamentosTableAdapter();
            this.tableAdapterManager = new ProjetoIF.BDProjetoIFDataSetTableAdapters.TableAdapterManager();
            this.departamentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.departamentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_DepartamentoTextBox = new System.Windows.Forms.TextBox();
            this.nome_DepartamentoTextBox = new System.Windows.Forms.TextBox();
            this.codigoRackTextBox = new System.Windows.Forms.TextBox();
            this.departamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_DepartamentoLabel = new System.Windows.Forms.Label();
            nome_DepartamentoLabel = new System.Windows.Forms.Label();
            codigoRackLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoIFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingNavigator)).BeginInit();
            this.departamentosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bDProjetoIFDataSet
            // 
            this.bDProjetoIFDataSet.DataSetName = "BDProjetoIFDataSet";
            this.bDProjetoIFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.bDProjetoIFDataSet;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = this.departamentosTableAdapter;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.systemTableTableAdapter = null;
            this.tableAdapterManager.TransacoesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoIF.BDProjetoIFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departamentosBindingNavigator
            // 
            this.departamentosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departamentosBindingNavigator.BindingSource = this.departamentosBindingSource;
            this.departamentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departamentosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departamentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departamentosBindingNavigatorSaveItem});
            this.departamentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.departamentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departamentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departamentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departamentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departamentosBindingNavigator.Name = "departamentosBindingNavigator";
            this.departamentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departamentosBindingNavigator.Size = new System.Drawing.Size(873, 25);
            this.departamentosBindingNavigator.TabIndex = 0;
            this.departamentosBindingNavigator.Text = "bindingNavigator1";
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
            // departamentosBindingNavigatorSaveItem
            // 
            this.departamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.departamentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("departamentosBindingNavigatorSaveItem.Image")));
            this.departamentosBindingNavigatorSaveItem.Name = "departamentosBindingNavigatorSaveItem";
            this.departamentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.departamentosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.departamentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.departamentosBindingNavigatorSaveItem_Click);
            // 
            // id_DepartamentoLabel
            // 
            id_DepartamentoLabel.AutoSize = true;
            id_DepartamentoLabel.Location = new System.Drawing.Point(14, 47);
            id_DepartamentoLabel.Name = "id_DepartamentoLabel";
            id_DepartamentoLabel.Size = new System.Drawing.Size(89, 13);
            id_DepartamentoLabel.TabIndex = 1;
            id_DepartamentoLabel.Text = "Id Departamento:";
            // 
            // id_DepartamentoTextBox
            // 
            this.id_DepartamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentosBindingSource, "Id_Departamento", true));
            this.id_DepartamentoTextBox.Location = new System.Drawing.Point(128, 44);
            this.id_DepartamentoTextBox.Name = "id_DepartamentoTextBox";
            this.id_DepartamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_DepartamentoTextBox.TabIndex = 2;
            // 
            // nome_DepartamentoLabel
            // 
            nome_DepartamentoLabel.AutoSize = true;
            nome_DepartamentoLabel.Location = new System.Drawing.Point(14, 73);
            nome_DepartamentoLabel.Name = "nome_DepartamentoLabel";
            nome_DepartamentoLabel.Size = new System.Drawing.Size(108, 13);
            nome_DepartamentoLabel.TabIndex = 3;
            nome_DepartamentoLabel.Text = "Nome Departamento:";
            // 
            // nome_DepartamentoTextBox
            // 
            this.nome_DepartamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentosBindingSource, "Nome_Departamento", true));
            this.nome_DepartamentoTextBox.Location = new System.Drawing.Point(128, 70);
            this.nome_DepartamentoTextBox.Name = "nome_DepartamentoTextBox";
            this.nome_DepartamentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_DepartamentoTextBox.TabIndex = 4;
            // 
            // codigoRackLabel
            // 
            codigoRackLabel.AutoSize = true;
            codigoRackLabel.Location = new System.Drawing.Point(14, 99);
            codigoRackLabel.Name = "codigoRackLabel";
            codigoRackLabel.Size = new System.Drawing.Size(72, 13);
            codigoRackLabel.TabIndex = 5;
            codigoRackLabel.Text = "Codigo Rack:";
            // 
            // codigoRackTextBox
            // 
            this.codigoRackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentosBindingSource, "CodigoRack", true));
            this.codigoRackTextBox.Location = new System.Drawing.Point(128, 96);
            this.codigoRackTextBox.Name = "codigoRackTextBox";
            this.codigoRackTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoRackTextBox.TabIndex = 6;
            // 
            // departamentosDataGridView
            // 
            this.departamentosDataGridView.AutoGenerateColumns = false;
            this.departamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departamentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.departamentosDataGridView.DataSource = this.departamentosBindingSource;
            this.departamentosDataGridView.Location = new System.Drawing.Point(17, 122);
            this.departamentosDataGridView.Name = "departamentosDataGridView";
            this.departamentosDataGridView.Size = new System.Drawing.Size(343, 340);
            this.departamentosDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Departamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Departamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Departamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome_Departamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoRack";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodigoRack";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frm_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 474);
            this.Controls.Add(this.departamentosDataGridView);
            this.Controls.Add(id_DepartamentoLabel);
            this.Controls.Add(this.id_DepartamentoTextBox);
            this.Controls.Add(nome_DepartamentoLabel);
            this.Controls.Add(this.nome_DepartamentoTextBox);
            this.Controls.Add(codigoRackLabel);
            this.Controls.Add(this.codigoRackTextBox);
            this.Controls.Add(this.departamentosBindingNavigator);
            this.Name = "frm_Departamentos";
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.frm_Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoIFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingNavigator)).EndInit();
            this.departamentosBindingNavigator.ResumeLayout(false);
            this.departamentosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProjetoIFDataSet bDProjetoIFDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private BDProjetoIFDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private BDProjetoIFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator departamentosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton departamentosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_DepartamentoTextBox;
        private System.Windows.Forms.TextBox nome_DepartamentoTextBox;
        private System.Windows.Forms.TextBox codigoRackTextBox;
        private System.Windows.Forms.DataGridView departamentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}