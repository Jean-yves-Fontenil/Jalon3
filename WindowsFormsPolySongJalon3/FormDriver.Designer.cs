namespace WindowsFormsPolySongJalon3
{
    partial class FormDriver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDriver));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelToolbox = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLabels = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDriver = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPlaces = new System.Windows.Forms.TextBox();
            this.vDriverActivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda07_bd1DataSet = new WindowsFormsPolySongJalon3.cda07_bd1DataSet();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPlaces = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelInformations = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPlacesAssigned = new System.Windows.Forms.TextBox();
            this.labelPlacesToBeAssigned = new System.Windows.Forms.Label();
            this.labelPlacesAssigned = new System.Windows.Forms.Label();
            this.textBoxToBeAssigned = new System.Windows.Forms.TextBox();
            this.dataGridViewDriver = new System.Windows.Forms.DataGridView();
            this.lIEUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_Driver_ActivityTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.v_Driver_ActivityTableAdapter();
            this.v_Assigned_CarPoolerTableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.v_Assigned_CarPoolerTableAdapter();
            this.freE_DRIVER_PLACETableAdapter = new WindowsFormsPolySongJalon3.cda07_bd1DataSetTableAdapters.FREE_DRIVER_PLACETableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chauffeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelToolbox.SuspendLayout();
            this.groupBoxLabels.SuspendLayout();
            this.tableLayoutPanelDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDriverActivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda07_bd1DataSet)).BeginInit();
            this.groupBoxInformation.SuspendLayout();
            this.tableLayoutPanelInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelToolbox, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewDriver, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(484, 237);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelToolbox
            // 
            this.tableLayoutPanelToolbox.ColumnCount = 2;
            this.tableLayoutPanelToolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelToolbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelToolbox.Controls.Add(this.groupBoxLabels, 0, 0);
            this.tableLayoutPanelToolbox.Controls.Add(this.groupBoxInformation, 1, 0);
            this.tableLayoutPanelToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelToolbox.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelToolbox.Name = "tableLayoutPanelToolbox";
            this.tableLayoutPanelToolbox.RowCount = 1;
            this.tableLayoutPanelToolbox.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelToolbox.Size = new System.Drawing.Size(478, 111);
            this.tableLayoutPanelToolbox.TabIndex = 0;
            // 
            // groupBoxLabels
            // 
            this.groupBoxLabels.Controls.Add(this.tableLayoutPanelDriver);
            this.groupBoxLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLabels.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLabels.Name = "groupBoxLabels";
            this.groupBoxLabels.Size = new System.Drawing.Size(233, 111);
            this.groupBoxLabels.TabIndex = 0;
            this.groupBoxLabels.TabStop = false;
            this.groupBoxLabels.Text = "Chauffeur";
            // 
            // tableLayoutPanelDriver
            // 
            this.tableLayoutPanelDriver.ColumnCount = 2;
            this.tableLayoutPanelDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDriver.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDriver.Controls.Add(this.textBoxPlaces, 1, 2);
            this.tableLayoutPanelDriver.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanelDriver.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanelDriver.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanelDriver.Controls.Add(this.labelPlaces, 0, 2);
            this.tableLayoutPanelDriver.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanelDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDriver.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelDriver.Name = "tableLayoutPanelDriver";
            this.tableLayoutPanelDriver.RowCount = 3;
            this.tableLayoutPanelDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDriver.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelDriver.Size = new System.Drawing.Size(227, 92);
            this.tableLayoutPanelDriver.TabIndex = 0;
            // 
            // textBoxPlaces
            // 
            this.textBoxPlaces.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDriverActivityBindingSource, "NOMBRE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxPlaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlaces.Enabled = false;
            this.textBoxPlaces.Location = new System.Drawing.Point(102, 55);
            this.textBoxPlaces.Name = "textBoxPlaces";
            this.textBoxPlaces.Size = new System.Drawing.Size(122, 20);
            this.textBoxPlaces.TabIndex = 5;
            // 
            // vDriverActivityBindingSource
            // 
            this.vDriverActivityBindingSource.DataMember = "v_Driver_Activity";
            this.vDriverActivityBindingSource.DataSource = this.cda07_bd1DataSet;
            // 
            // cda07_bd1DataSet
            // 
            this.cda07_bd1DataSet.DataSetName = "cda07_bd1DataSet";
            this.cda07_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDriverActivityBindingSource, "NOM", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(102, 29);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(122, 20);
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
            this.labelPlaces.Size = new System.Drawing.Size(93, 13);
            this.labelPlaces.TabIndex = 2;
            this.labelPlaces.Text = "Nombre de places";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDriverActivityBindingSource, "PRENOM", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textBoxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(102, 3);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(122, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.tableLayoutPanelInformations);
            this.groupBoxInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInformation.Location = new System.Drawing.Point(242, 3);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(233, 111);
            this.groupBoxInformation.TabIndex = 1;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Informations sur les places";
            // 
            // tableLayoutPanelInformations
            // 
            this.tableLayoutPanelInformations.ColumnCount = 2;
            this.tableLayoutPanelInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelInformations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInformations.Controls.Add(this.textBoxPlacesAssigned, 1, 1);
            this.tableLayoutPanelInformations.Controls.Add(this.labelPlacesToBeAssigned, 0, 0);
            this.tableLayoutPanelInformations.Controls.Add(this.labelPlacesAssigned, 0, 1);
            this.tableLayoutPanelInformations.Controls.Add(this.textBoxToBeAssigned, 1, 0);
            this.tableLayoutPanelInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInformations.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelInformations.Name = "tableLayoutPanelInformations";
            this.tableLayoutPanelInformations.RowCount = 2;
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInformations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInformations.Size = new System.Drawing.Size(227, 92);
            this.tableLayoutPanelInformations.TabIndex = 0;
            // 
            // textBoxPlacesAssigned
            // 
            this.textBoxPlacesAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlacesAssigned.Enabled = false;
            this.textBoxPlacesAssigned.Location = new System.Drawing.Point(97, 49);
            this.textBoxPlacesAssigned.Name = "textBoxPlacesAssigned";
            this.textBoxPlacesAssigned.Size = new System.Drawing.Size(127, 20);
            this.textBoxPlacesAssigned.TabIndex = 3;
            // 
            // labelPlacesToBeAssigned
            // 
            this.labelPlacesToBeAssigned.AutoSize = true;
            this.labelPlacesToBeAssigned.Location = new System.Drawing.Point(3, 0);
            this.labelPlacesToBeAssigned.Name = "labelPlacesToBeAssigned";
            this.labelPlacesToBeAssigned.Size = new System.Drawing.Size(66, 13);
            this.labelPlacesToBeAssigned.TabIndex = 0;
            this.labelPlacesToBeAssigned.Text = "Places libres";
            // 
            // labelPlacesAssigned
            // 
            this.labelPlacesAssigned.AutoSize = true;
            this.labelPlacesAssigned.Location = new System.Drawing.Point(3, 46);
            this.labelPlacesAssigned.Name = "labelPlacesAssigned";
            this.labelPlacesAssigned.Size = new System.Drawing.Size(88, 13);
            this.labelPlacesAssigned.TabIndex = 1;
            this.labelPlacesAssigned.Text = "Places attribuées";
            // 
            // textBoxToBeAssigned
            // 
            this.textBoxToBeAssigned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxToBeAssigned.Enabled = false;
            this.textBoxToBeAssigned.Location = new System.Drawing.Point(97, 3);
            this.textBoxToBeAssigned.Name = "textBoxToBeAssigned";
            this.textBoxToBeAssigned.Size = new System.Drawing.Size(127, 20);
            this.textBoxToBeAssigned.TabIndex = 2;
            // 
            // dataGridViewDriver
            // 
            this.dataGridViewDriver.AllowUserToAddRows = false;
            this.dataGridViewDriver.AllowUserToDeleteRows = false;
            this.dataGridViewDriver.AutoGenerateColumns = false;
            this.dataGridViewDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDriver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIEUDataGridViewTextBoxColumn,
            this.tITREDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn});
            this.dataGridViewDriver.DataSource = this.vDriverActivityBindingSource;
            this.dataGridViewDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDriver.Location = new System.Drawing.Point(3, 120);
            this.dataGridViewDriver.Name = "dataGridViewDriver";
            this.dataGridViewDriver.ReadOnly = true;
            this.dataGridViewDriver.RowHeadersVisible = false;
            this.dataGridViewDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDriver.Size = new System.Drawing.Size(478, 114);
            this.dataGridViewDriver.StandardTab = true;
            this.dataGridViewDriver.TabIndex = 1;
            this.dataGridViewDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriver_CellDoubleClick_1);
            this.dataGridViewDriver.SelectionChanged += new System.EventHandler(this.dataGridViewDriver_SelectionChanged);
            this.dataGridViewDriver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDriver_KeyDown);
            // 
            // lIEUDataGridViewTextBoxColumn
            // 
            this.lIEUDataGridViewTextBoxColumn.DataPropertyName = "LIEU";
            this.lIEUDataGridViewTextBoxColumn.HeaderText = "LIEU";
            this.lIEUDataGridViewTextBoxColumn.Name = "lIEUDataGridViewTextBoxColumn";
            this.lIEUDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIEUDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tITREDataGridViewTextBoxColumn
            // 
            this.tITREDataGridViewTextBoxColumn.DataPropertyName = "TITRE";
            this.tITREDataGridViewTextBoxColumn.HeaderText = "TITRE";
            this.tITREDataGridViewTextBoxColumn.Name = "tITREDataGridViewTextBoxColumn";
            this.tITREDataGridViewTextBoxColumn.ReadOnly = true;
            this.tITREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // v_Driver_ActivityTableAdapter
            // 
            this.v_Driver_ActivityTableAdapter.ClearBeforeFill = true;
            // 
            // v_Assigned_CarPoolerTableAdapter
            // 
            this.v_Assigned_CarPoolerTableAdapter.ClearBeforeFill = true;
            // 
            // freE_DRIVER_PLACETableAdapter
            // 
            this.freE_DRIVER_PLACETableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chauffeurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chauffeurToolStripMenuItem
            // 
            this.chauffeurToolStripMenuItem.Name = "chauffeurToolStripMenuItem";
            this.chauffeurToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.chauffeurToolStripMenuItem.Text = "&Chauffeur";
            // 
            // FormDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDriver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chauffeurs";
            this.Activated += new System.EventHandler(this.FormDriver_Activated);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelToolbox.ResumeLayout(false);
            this.groupBoxLabels.ResumeLayout(false);
            this.tableLayoutPanelDriver.ResumeLayout(false);
            this.tableLayoutPanelDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vDriverActivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda07_bd1DataSet)).EndInit();
            this.groupBoxInformation.ResumeLayout(false);
            this.tableLayoutPanelInformations.ResumeLayout(false);
            this.tableLayoutPanelInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelToolbox;
        private System.Windows.Forms.GroupBox groupBoxLabels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDriver;
        private System.Windows.Forms.TextBox textBoxPlaces;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPlaces;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInformations;
        private System.Windows.Forms.TextBox textBoxPlacesAssigned;
        private System.Windows.Forms.Label labelPlacesToBeAssigned;
        private System.Windows.Forms.Label labelPlacesAssigned;
        private System.Windows.Forms.TextBox textBoxToBeAssigned;
        private System.Windows.Forms.DataGridView dataGridViewDriver;
        private cda07_bd1DataSet cda07_bd1DataSet;
        private System.Windows.Forms.BindingSource vDriverActivityBindingSource;
        private cda07_bd1DataSetTableAdapters.v_Driver_ActivityTableAdapter v_Driver_ActivityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIEUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private cda07_bd1DataSetTableAdapters.v_Assigned_CarPoolerTableAdapter v_Assigned_CarPoolerTableAdapter;
        private cda07_bd1DataSetTableAdapters.FREE_DRIVER_PLACETableAdapter freE_DRIVER_PLACETableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chauffeurToolStripMenuItem;
    }
}