namespace WindowsFormsPolySongJalon3
{
    partial class FormCarPooler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarPooler));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCarPooler = new System.Windows.Forms.DataGridView();
            this.lIEUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCarPoolerActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda07_bd1DataSet = new WindowsFormsPolySongJalon3.cda07_bd1DataSet();
            this.tableLayoutPanelDriver = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelInfoDriver = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPlaces = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPlaces = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.vAssignedCarPoolerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCar = new System.Windows.Forms.BindingSource(this.components);
            this.v_CarPooler_ActivityTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.v_CarPooler_ActivityTableAdapter();
            this.covoiturageTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.covoiturageTableAdapter();
            this.v_Assigned_CarPoolerTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.v_Assigned_CarPoolerTableAdapter();
            this.souhaite_une_placeTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.souhaite_une_placeTableAdapter();
            this.propose_placeTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.propose_placeTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPooler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarPoolerActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda07_bd1DataSet)).BeginInit();
            this.tableLayoutPanelDriver.SuspendLayout();
            this.groupBoxDriver.SuspendLayout();
            this.tableLayoutPanelInfoDriver.SuspendLayout();
            this.groupBoxCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vAssignedCarPoolerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewCarPooler, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelDriver, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(484, 237);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // dataGridViewCarPooler
            // 
            this.dataGridViewCarPooler.AllowUserToAddRows = false;
            this.dataGridViewCarPooler.AllowUserToDeleteRows = false;
            this.dataGridViewCarPooler.AutoGenerateColumns = false;
            this.dataGridViewCarPooler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarPooler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarPooler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIEUDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn});
            this.dataGridViewCarPooler.DataSource = this.vCarPoolerActivityBindingSource;
            this.dataGridViewCarPooler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCarPooler.Location = new System.Drawing.Point(3, 126);
            this.dataGridViewCarPooler.Name = "dataGridViewCarPooler";
            this.dataGridViewCarPooler.ReadOnly = true;
            this.dataGridViewCarPooler.RowHeadersVisible = false;
            this.dataGridViewCarPooler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarPooler.Size = new System.Drawing.Size(478, 108);
            this.dataGridViewCarPooler.StandardTab = true;
            this.dataGridViewCarPooler.TabIndex = 0;
            this.dataGridViewCarPooler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarPooler_CellDoubleClick);
            this.dataGridViewCarPooler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCarPooler_KeyDown);
            // 
            // lIEUDataGridViewTextBoxColumn
            // 
            this.lIEUDataGridViewTextBoxColumn.DataPropertyName = "LIEU";
            this.lIEUDataGridViewTextBoxColumn.HeaderText = "LIEU";
            this.lIEUDataGridViewTextBoxColumn.Name = "lIEUDataGridViewTextBoxColumn";
            this.lIEUDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIEUDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            this.pRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRENOMDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vCarPoolerActivityBindingSource
            // 
            this.vCarPoolerActivityBindingSource.DataMember = "v_CarPooler_Activity";
            this.vCarPoolerActivityBindingSource.DataSource = this.cda07_bd1DataSet;
            // 
            // cda07_bd1DataSet
            // 
            this.cda07_bd1DataSet.DataSetName = "cda07_bd1DataSet";
            this.cda07_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanelDriver
            // 
            this.tableLayoutPanelDriver.ColumnCount = 2;
            this.tableLayoutPanelDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDriver.Controls.Add(this.groupBoxDriver, 0, 0);
            this.tableLayoutPanelDriver.Controls.Add(this.groupBoxCar, 1, 0);
            this.tableLayoutPanelDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDriver.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDriver.Name = "tableLayoutPanelDriver";
            this.tableLayoutPanelDriver.RowCount = 1;
            this.tableLayoutPanelDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDriver.Size = new System.Drawing.Size(478, 117);
            this.tableLayoutPanelDriver.TabIndex = 1;
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.tableLayoutPanelInfoDriver);
            this.groupBoxDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDriver.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(233, 111);
            this.groupBoxDriver.TabIndex = 0;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Chauffeur";
            // 
            // tableLayoutPanelInfoDriver
            // 
            this.tableLayoutPanelInfoDriver.ColumnCount = 2;
            this.tableLayoutPanelInfoDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInfoDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInfoDriver.Controls.Add(this.textBoxPlaces, 1, 2);
            this.tableLayoutPanelInfoDriver.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanelInfoDriver.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanelInfoDriver.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanelInfoDriver.Controls.Add(this.labelPlaces, 0, 2);
            this.tableLayoutPanelInfoDriver.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanelInfoDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfoDriver.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelInfoDriver.Name = "tableLayoutPanelInfoDriver";
            this.tableLayoutPanelInfoDriver.RowCount = 3;
            this.tableLayoutPanelInfoDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInfoDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInfoDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelInfoDriver.Size = new System.Drawing.Size(227, 92);
            this.tableLayoutPanelInfoDriver.TabIndex = 0;
            // 
            // textBoxPlaces
            // 
            this.textBoxPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlaces.Enabled = false;
            this.textBoxPlaces.Location = new System.Drawing.Point(52, 55);
            this.textBoxPlaces.Name = "textBoxPlaces";
            this.textBoxPlaces.Size = new System.Drawing.Size(172, 20);
            this.textBoxPlaces.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(52, 29);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(172, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(3, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(43, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Prénom";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(3, 26);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(29, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Nom";
            // 
            // labelPlaces
            // 
            this.labelPlaces.AutoSize = true;
            this.labelPlaces.Location = new System.Drawing.Point(3, 52);
            this.labelPlaces.Name = "labelPlaces";
            this.labelPlaces.Size = new System.Drawing.Size(39, 13);
            this.labelPlaces.TabIndex = 2;
            this.labelPlaces.Text = "Places";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(52, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(172, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.listBoxCar);
            this.groupBoxCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCar.Location = new System.Drawing.Point(242, 3);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(233, 111);
            this.groupBoxCar.TabIndex = 1;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Véhicule";
            // 
            // listBoxCar
            // 
            this.listBoxCar.DataSource = this.vAssignedCarPoolerBindingSource;
            this.listBoxCar.DisplayMember = "PERSONNE";
            this.listBoxCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Location = new System.Drawing.Point(3, 16);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(227, 92);
            this.listBoxCar.TabIndex = 0;
            this.listBoxCar.ValueMember = "ACTIVITE";
            this.listBoxCar.DoubleClick += new System.EventHandler(this.listBoxCar_DoubleClick);
            this.listBoxCar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxCar_KeyDown);
            // 
            // vAssignedCarPoolerBindingSource
            // 
            this.vAssignedCarPoolerBindingSource.DataMember = "v_Assigned_CarPooler";
            this.vAssignedCarPoolerBindingSource.DataSource = this.cda07_bd1DataSet;
            // 
            // v_CarPooler_ActivityTableAdapter
            // 
            this.v_CarPooler_ActivityTableAdapter.ClearBeforeFill = true;
            // 
            // covoiturageTableAdapter
            // 
            this.covoiturageTableAdapter.ClearBeforeFill = true;
            // 
            // v_Assigned_CarPoolerTableAdapter
            // 
            this.v_Assigned_CarPoolerTableAdapter.ClearBeforeFill = true;
            // 
            // souhaite_une_placeTableAdapter
            // 
            this.souhaite_une_placeTableAdapter.ClearBeforeFill = true;
            // 
            // propose_placeTableAdapter
            // 
            this.propose_placeTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coToolStripMenuItem
            // 
            this.coToolStripMenuItem.Name = "coToolStripMenuItem";
            this.coToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.coToolStripMenuItem.Text = "&Covoitureur";
            // 
            // FormCarPooler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "FormCarPooler";
            this.Text = "Coivoitureur";
            this.Activated += new System.EventHandler(this.FormCarPooler_Activated);
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPooler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCarPoolerActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda07_bd1DataSet)).EndInit();
            this.tableLayoutPanelDriver.ResumeLayout(false);
            this.groupBoxDriver.ResumeLayout(false);
            this.tableLayoutPanelInfoDriver.ResumeLayout(false);
            this.tableLayoutPanelInfoDriver.PerformLayout();
            this.groupBoxCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vAssignedCarPoolerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewCarPooler;
        private cda07_bd1DataSet cda07_bd1DataSet;
        private System.Windows.Forms.BindingSource vCarPoolerActivityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIEUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDriver;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfoDriver;
        private System.Windows.Forms.TextBox textBoxPlaces;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPlaces;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.ListBox listBoxCar;
        private cda07_bd1DataSetTableAdapters.v_CarPooler_ActivityTableAdapter v_CarPooler_ActivityTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceCar;
        private cda07_bd1DataSetTableAdapters.covoiturageTableAdapter covoiturageTableAdapter;
        private System.Windows.Forms.BindingSource vAssignedCarPoolerBindingSource;
        private cda07_bd1DataSetTableAdapters.v_Assigned_CarPoolerTableAdapter v_Assigned_CarPoolerTableAdapter;
        private cda07_bd1DataSetTableAdapters.souhaite_une_placeTableAdapter souhaite_une_placeTableAdapter;
        private cda07_bd1DataSetTableAdapters.propose_placeTableAdapter propose_placeTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coToolStripMenuItem;
    }
}