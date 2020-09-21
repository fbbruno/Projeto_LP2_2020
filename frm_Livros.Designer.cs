namespace ProjetoIF
{
    partial class frm_Livros
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
            System.Windows.Forms.Label id_LivroLabel;
            System.Windows.Forms.Label numero_LivroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label id_DepartamentoLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label capaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Livros));
            this.bDProjetoIFDataSet = new ProjetoIF.BDProjetoIFDataSet();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new ProjetoIF.BDProjetoIFDataSetTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new ProjetoIF.BDProjetoIFDataSetTableAdapters.TableAdapterManager();
            this.livrosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.livrosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.id_LivroTextBox = new System.Windows.Forms.TextBox();
            this.numero_LivroTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.id_DepartamentoTextBox = new System.Windows.Forms.TextBox();
            this.id_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.capaPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            id_LivroLabel = new System.Windows.Forms.Label();
            numero_LivroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            id_DepartamentoLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            capaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoIFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingNavigator)).BeginInit();
            this.livrosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_LivroLabel
            // 
            id_LivroLabel.AutoSize = true;
            id_LivroLabel.Location = new System.Drawing.Point(19, 44);
            id_LivroLabel.Name = "id_LivroLabel";
            id_LivroLabel.Size = new System.Drawing.Size(45, 13);
            id_LivroLabel.TabIndex = 1;
            id_LivroLabel.Text = "Id Livro:";
            // 
            // numero_LivroLabel
            // 
            numero_LivroLabel.AutoSize = true;
            numero_LivroLabel.Location = new System.Drawing.Point(19, 70);
            numero_LivroLabel.Name = "numero_LivroLabel";
            numero_LivroLabel.Size = new System.Drawing.Size(73, 13);
            numero_LivroLabel.TabIndex = 3;
            numero_LivroLabel.Text = "Numero Livro:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(19, 96);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 5;
            tituloLabel.Text = "Titulo:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Location = new System.Drawing.Point(19, 122);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(35, 13);
            autorLabel.TabIndex = 7;
            autorLabel.Text = "Autor:";
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Location = new System.Drawing.Point(19, 148);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(43, 13);
            editoraLabel.TabIndex = 9;
            editoraLabel.Text = "Editora:";
            // 
            // id_DepartamentoLabel
            // 
            id_DepartamentoLabel.AutoSize = true;
            id_DepartamentoLabel.Location = new System.Drawing.Point(19, 174);
            id_DepartamentoLabel.Name = "id_DepartamentoLabel";
            id_DepartamentoLabel.Size = new System.Drawing.Size(89, 13);
            id_DepartamentoLabel.TabIndex = 11;
            id_DepartamentoLabel.Text = "Id Departamento:";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(19, 200);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(54, 13);
            id_ClienteLabel.TabIndex = 13;
            id_ClienteLabel.Text = "Id Cliente:";
            // 
            // capaLabel
            // 
            capaLabel.AutoSize = true;
            capaLabel.Location = new System.Drawing.Point(339, 41);
            capaLabel.Name = "capaLabel";
            capaLabel.Size = new System.Drawing.Size(35, 13);
            capaLabel.TabIndex = 15;
            capaLabel.Text = "Capa:";
            // 
            // bDProjetoIFDataSet
            // 
            this.bDProjetoIFDataSet.DataSetName = "BDProjetoIFDataSet";
            this.bDProjetoIFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bDProjetoIFDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.systemTableTableAdapter = null;
            this.tableAdapterManager.TransacoesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoIF.BDProjetoIFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livrosBindingNavigator
            // 
            this.livrosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livrosBindingNavigator.BindingSource = this.livrosBindingSource;
            this.livrosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livrosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.livrosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.livrosBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.livrosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livrosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livrosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livrosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livrosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livrosBindingNavigator.Name = "livrosBindingNavigator";
            this.livrosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livrosBindingNavigator.Size = new System.Drawing.Size(873, 25);
            this.livrosBindingNavigator.TabIndex = 0;
            this.livrosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(108, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(62, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // livrosBindingNavigatorSaveItem
            // 
            this.livrosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livrosBindingNavigatorSaveItem.Image")));
            this.livrosBindingNavigatorSaveItem.Name = "livrosBindingNavigatorSaveItem";
            this.livrosBindingNavigatorSaveItem.Size = new System.Drawing.Size(94, 22);
            this.livrosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.livrosBindingNavigatorSaveItem.Click += new System.EventHandler(this.livrosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripButton1.Text = "Adicionar Imagem";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // id_LivroTextBox
            // 
            this.id_LivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Id_Livro", true));
            this.id_LivroTextBox.Location = new System.Drawing.Point(114, 41);
            this.id_LivroTextBox.Name = "id_LivroTextBox";
            this.id_LivroTextBox.Size = new System.Drawing.Size(219, 20);
            this.id_LivroTextBox.TabIndex = 2;
            // 
            // numero_LivroTextBox
            // 
            this.numero_LivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Numero_Livro", true));
            this.numero_LivroTextBox.Location = new System.Drawing.Point(114, 67);
            this.numero_LivroTextBox.Name = "numero_LivroTextBox";
            this.numero_LivroTextBox.Size = new System.Drawing.Size(219, 20);
            this.numero_LivroTextBox.TabIndex = 4;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(114, 93);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(219, 20);
            this.tituloTextBox.TabIndex = 6;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(114, 119);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(219, 20);
            this.autorTextBox.TabIndex = 8;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Editora", true));
            this.editoraTextBox.Location = new System.Drawing.Point(114, 145);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(219, 20);
            this.editoraTextBox.TabIndex = 10;
            // 
            // id_DepartamentoTextBox
            // 
            this.id_DepartamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Id_Departamento", true));
            this.id_DepartamentoTextBox.Location = new System.Drawing.Point(114, 171);
            this.id_DepartamentoTextBox.Name = "id_DepartamentoTextBox";
            this.id_DepartamentoTextBox.Size = new System.Drawing.Size(219, 20);
            this.id_DepartamentoTextBox.TabIndex = 12;
            // 
            // id_ClienteTextBox
            // 
            this.id_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Id_Cliente", true));
            this.id_ClienteTextBox.Location = new System.Drawing.Point(114, 197);
            this.id_ClienteTextBox.Name = "id_ClienteTextBox";
            this.id_ClienteTextBox.Size = new System.Drawing.Size(219, 20);
            this.id_ClienteTextBox.TabIndex = 14;
            // 
            // capaPictureBox
            // 
            this.capaPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.capaPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.livrosBindingSource, "Capa", true));
            this.capaPictureBox.Location = new System.Drawing.Point(380, 41);
            this.capaPictureBox.Name = "capaPictureBox";
            this.capaPictureBox.Size = new System.Drawing.Size(158, 172);
            this.capaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capaPictureBox.TabIndex = 16;
            this.capaPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.AutoGenerateColumns = false;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.livrosDataGridView.DataSource = this.livrosBindingSource;
            this.livrosDataGridView.Location = new System.Drawing.Point(12, 234);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.Size = new System.Drawing.Size(839, 220);
            this.livrosDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Livro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Livro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Numero_Livro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numero_Livro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Editora";
            this.dataGridViewTextBoxColumn5.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_Departamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id_Departamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_Cliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_Cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Capa";
            this.dataGridViewImageColumn1.HeaderText = "Capa";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // frm_Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 474);
            this.Controls.Add(this.livrosDataGridView);
            this.Controls.Add(capaLabel);
            this.Controls.Add(this.capaPictureBox);
            this.Controls.Add(id_LivroLabel);
            this.Controls.Add(this.id_LivroTextBox);
            this.Controls.Add(numero_LivroLabel);
            this.Controls.Add(this.numero_LivroTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(id_DepartamentoLabel);
            this.Controls.Add(this.id_DepartamentoTextBox);
            this.Controls.Add(id_ClienteLabel);
            this.Controls.Add(this.id_ClienteTextBox);
            this.Controls.Add(this.livrosBindingNavigator);
            this.Name = "frm_Livros";
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.frm_Livros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDProjetoIFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingNavigator)).EndInit();
            this.livrosBindingNavigator.ResumeLayout(false);
            this.livrosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDProjetoIFDataSet bDProjetoIFDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BDProjetoIFDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private BDProjetoIFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livrosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton livrosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_LivroTextBox;
        private System.Windows.Forms.TextBox numero_LivroTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.TextBox id_DepartamentoTextBox;
        private System.Windows.Forms.TextBox id_ClienteTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox capaPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}