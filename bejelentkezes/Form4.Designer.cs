namespace bejelentkezes
{
    partial class Form4
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
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.Label diagnozisLabel;
            System.Windows.Forms.Label terapiaLabel;
            System.Windows.Forms.Label allatIDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel4 = new System.Windows.Forms.Panel();
            this.datumDTP = new System.Windows.Forms.DateTimePicker();
            this.bejegyzesekKezelesekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bejegyzesekKezelesekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTabelsDataSet = new bejelentkezes.dbTabelsDataSet();
            this.diagnozisTextBox = new System.Windows.Forms.TextBox();
            this.bejegyzesekKezelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adatbazisKiskedvDataSet2 = new bejelentkezes.AdatbazisKiskedvDataSet2();
            this.terapiaTextBox = new System.Windows.Forms.TextBox();
            this.allatIDTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnF4Keres = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonF3K = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFUB = new System.Windows.Forms.Button();
            this.labelEg = new System.Windows.Forms.Label();
            this.buttonF3Back = new System.Windows.Forms.Button();
            this.bejegyzesekKezelesekTableAdapter = new bejelentkezes.AdatbazisKiskedvDataSet2TableAdapters.BejegyzesekKezelesekTableAdapter();
            this.tableAdapterManager = new bejelentkezes.AdatbazisKiskedvDataSet2TableAdapters.TableAdapterManager();
            this.bejegyzesekKezelesekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bejegyzesekKezelesekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.bejegyzesekKezelesekTableAdapter1 = new bejelentkezes.dbTabelsDataSetTableAdapters.BejegyzesekKezelesekTableAdapter();
            datumLabel = new System.Windows.Forms.Label();
            diagnozisLabel = new System.Windows.Forms.Label();
            terapiaLabel = new System.Windows.Forms.Label();
            allatIDLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabelsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekBindingNavigator)).BeginInit();
            this.bejegyzesekKezelesekBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            datumLabel.Location = new System.Drawing.Point(49, 163);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(70, 20);
            datumLabel.TabIndex = 46;
            datumLabel.Text = "Dátum:";
            // 
            // diagnozisLabel
            // 
            diagnozisLabel.AutoSize = true;
            diagnozisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            diagnozisLabel.Location = new System.Drawing.Point(49, 207);
            diagnozisLabel.Name = "diagnozisLabel";
            diagnozisLabel.Size = new System.Drawing.Size(99, 20);
            diagnozisLabel.TabIndex = 48;
            diagnozisLabel.Text = "Diagnózis:";
            // 
            // terapiaLabel
            // 
            terapiaLabel.AutoSize = true;
            terapiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            terapiaLabel.Location = new System.Drawing.Point(320, 239);
            terapiaLabel.Name = "terapiaLabel";
            terapiaLabel.Size = new System.Drawing.Size(78, 20);
            terapiaLabel.TabIndex = 50;
            terapiaLabel.Text = "Terápia:";
            // 
            // allatIDLabel
            // 
            allatIDLabel.AutoSize = true;
            allatIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            allatIDLabel.Location = new System.Drawing.Point(49, 114);
            allatIDLabel.Name = "allatIDLabel";
            allatIDLabel.Size = new System.Drawing.Size(78, 20);
            allatIDLabel.TabIndex = 52;
            allatIDLabel.Text = "Állat ID:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.datumDTP);
            this.panel4.Controls.Add(this.bejegyzesekKezelesekDataGridView);
            this.panel4.Controls.Add(datumLabel);
            this.panel4.Controls.Add(diagnozisLabel);
            this.panel4.Controls.Add(this.diagnozisTextBox);
            this.panel4.Controls.Add(terapiaLabel);
            this.panel4.Controls.Add(this.terapiaTextBox);
            this.panel4.Controls.Add(allatIDLabel);
            this.panel4.Controls.Add(this.allatIDTextBox);
            this.panel4.Controls.Add(this.buttonDelete);
            this.panel4.Controls.Add(this.labelTotal);
            this.panel4.Controls.Add(this.btnF4Keres);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.buttonF3K);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.buttonFUB);
            this.panel4.Controls.Add(this.labelEg);
            this.panel4.Controls.Add(this.buttonF3Back);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(748, 698);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(748, 698);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // datumDTP
            // 
            this.datumDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDTP.Location = new System.Drawing.Point(144, 163);
            this.datumDTP.Name = "datumDTP";
            this.datumDTP.Size = new System.Drawing.Size(151, 22);
            this.datumDTP.TabIndex = 54;
            // 
            // bejegyzesekKezelesekDataGridView
            // 
            this.bejegyzesekKezelesekDataGridView.AutoGenerateColumns = false;
            this.bejegyzesekKezelesekDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bejegyzesekKezelesekDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bejegyzesekKezelesekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bejegyzesekKezelesekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.bejegyzesekKezelesekDataGridView.DataSource = this.bejegyzesekKezelesekBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bejegyzesekKezelesekDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.bejegyzesekKezelesekDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.bejegyzesekKezelesekDataGridView.Location = new System.Drawing.Point(44, 383);
            this.bejegyzesekKezelesekDataGridView.Name = "bejegyzesekKezelesekDataGridView";
            this.bejegyzesekKezelesekDataGridView.RowHeadersWidth = 51;
            this.bejegyzesekKezelesekDataGridView.RowTemplate.Height = 24;
            this.bejegyzesekKezelesekDataGridView.Size = new System.Drawing.Size(642, 221);
            this.bejegyzesekKezelesekDataGridView.TabIndex = 53;
            this.bejegyzesekKezelesekDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bejegyzesekKezelesekDataGridView_CellClick);
            this.bejegyzesekKezelesekDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bejegyzesekKezelesekDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AllatID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ÁllatID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dátum";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Diagnozis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Diagnózis";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Terapia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Terápia";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // bejegyzesekKezelesekBindingSource1
            // 
            this.bejegyzesekKezelesekBindingSource1.DataMember = "BejegyzesekKezelesek";
            this.bejegyzesekKezelesekBindingSource1.DataSource = this.dbTabelsDataSet;
            // 
            // dbTabelsDataSet
            // 
            this.dbTabelsDataSet.DataSetName = "dbTabelsDataSet";
            this.dbTabelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnozisTextBox
            // 
            this.diagnozisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bejegyzesekKezelesekBindingSource, "Diagnozis", true));
            this.diagnozisTextBox.Location = new System.Drawing.Point(53, 240);
            this.diagnozisTextBox.Multiline = true;
            this.diagnozisTextBox.Name = "diagnozisTextBox";
            this.diagnozisTextBox.Size = new System.Drawing.Size(242, 116);
            this.diagnozisTextBox.TabIndex = 49;
            // 
            // bejegyzesekKezelesekBindingSource
            // 
            this.bejegyzesekKezelesekBindingSource.DataMember = "BejegyzesekKezelesek";
            this.bejegyzesekKezelesekBindingSource.DataSource = this.adatbazisKiskedvDataSet2;
            // 
            // adatbazisKiskedvDataSet2
            // 
            this.adatbazisKiskedvDataSet2.DataSetName = "AdatbazisKiskedvDataSet2";
            this.adatbazisKiskedvDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terapiaTextBox
            // 
            this.terapiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bejegyzesekKezelesekBindingSource, "Terapia", true));
            this.terapiaTextBox.Location = new System.Drawing.Point(414, 239);
            this.terapiaTextBox.Multiline = true;
            this.terapiaTextBox.Name = "terapiaTextBox";
            this.terapiaTextBox.Size = new System.Drawing.Size(259, 117);
            this.terapiaTextBox.TabIndex = 51;
            // 
            // allatIDTextBox
            // 
            this.allatIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bejegyzesekKezelesekBindingSource, "AllatID", true));
            this.allatIDTextBox.Location = new System.Drawing.Point(133, 112);
            this.allatIDTextBox.Name = "allatIDTextBox";
            this.allatIDTextBox.Size = new System.Drawing.Size(162, 22);
            this.allatIDTextBox.TabIndex = 53;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDelete.Location = new System.Drawing.Point(542, 627);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 34);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.labelTotal.Location = new System.Drawing.Point(404, 195);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(152, 20);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Találatok száma:";
            // 
            // btnF4Keres
            // 
            this.btnF4Keres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnF4Keres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnF4Keres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnF4Keres.Location = new System.Drawing.Point(35, 627);
            this.btnF4Keres.Name = "btnF4Keres";
            this.btnF4Keres.Size = new System.Drawing.Size(144, 34);
            this.btnF4Keres.TabIndex = 3;
            this.btnF4Keres.Text = "Összes";
            this.btnF4Keres.UseVisualStyleBackColor = false;
            this.btnF4Keres.Click += new System.EventHandler(this.btnF4Keres_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41611F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(407, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 29);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(104, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÁllatokID";
            // 
            // buttonF3K
            // 
            this.buttonF3K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF3K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF3K.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF3K.Location = new System.Drawing.Point(532, 149);
            this.buttonF3K.Name = "buttonF3K";
            this.buttonF3K.Size = new System.Drawing.Size(144, 34);
            this.buttonF3K.TabIndex = 2;
            this.buttonF3K.Text = "Keresés";
            this.buttonF3K.UseVisualStyleBackColor = false;
            this.buttonF3K.Click += new System.EventHandler(this.buttonF3K_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(53, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 10);
            this.panel1.TabIndex = 44;
            // 
            // buttonFUB
            // 
            this.buttonFUB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonFUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFUB.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFUB.Location = new System.Drawing.Point(204, 627);
            this.buttonFUB.Name = "buttonFUB";
            this.buttonFUB.Size = new System.Drawing.Size(144, 34);
            this.buttonFUB.TabIndex = 4;
            this.buttonFUB.Text = "Új Bejegyzés";
            this.buttonFUB.UseVisualStyleBackColor = false;
            this.buttonFUB.Click += new System.EventHandler(this.buttonFUB_Click);
            // 
            // labelEg
            // 
            this.labelEg.AutoSize = true;
            this.labelEg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEg.Location = new System.Drawing.Point(48, 40);
            this.labelEg.Name = "labelEg";
            this.labelEg.Size = new System.Drawing.Size(628, 29);
            this.labelEg.TabIndex = 23;
            this.labelEg.Text = "Fontosabb egészségügyi Bejegyzések és kezelések:";
            // 
            // buttonF3Back
            // 
            this.buttonF3Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF3Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF3Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF3Back.Location = new System.Drawing.Point(376, 627);
            this.buttonF3Back.Name = "buttonF3Back";
            this.buttonF3Back.Size = new System.Drawing.Size(144, 34);
            this.buttonF3Back.TabIndex = 6;
            this.buttonF3Back.Text = "Módosítás";
            this.buttonF3Back.UseVisualStyleBackColor = false;
            this.buttonF3Back.Click += new System.EventHandler(this.buttonF3Back_Click);
            // 
            // bejegyzesekKezelesekTableAdapter
            // 
            this.bejegyzesekKezelesekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BejegyzesekKezelesekTableAdapter = this.bejegyzesekKezelesekTableAdapter;
            this.tableAdapterManager.UpdateOrder = bejelentkezes.AdatbazisKiskedvDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bejegyzesekKezelesekBindingNavigator
            // 
            this.bejegyzesekKezelesekBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bejegyzesekKezelesekBindingNavigator.BindingSource = this.bejegyzesekKezelesekBindingSource;
            this.bejegyzesekKezelesekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bejegyzesekKezelesekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bejegyzesekKezelesekBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bejegyzesekKezelesekBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bejegyzesekKezelesekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bejegyzesekKezelesekBindingNavigatorSaveItem,
            this.toolStripProgressBar1});
            this.bejegyzesekKezelesekBindingNavigator.Location = new System.Drawing.Point(0, 667);
            this.bejegyzesekKezelesekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bejegyzesekKezelesekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bejegyzesekKezelesekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bejegyzesekKezelesekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bejegyzesekKezelesekBindingNavigator.Name = "bejegyzesekKezelesekBindingNavigator";
            this.bejegyzesekKezelesekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bejegyzesekKezelesekBindingNavigator.Size = new System.Drawing.Size(748, 31);
            this.bejegyzesekKezelesekBindingNavigator.TabIndex = 1;
            this.bejegyzesekKezelesekBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bejegyzesekKezelesekBindingNavigatorSaveItem
            // 
            this.bejegyzesekKezelesekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bejegyzesekKezelesekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bejegyzesekKezelesekBindingNavigatorSaveItem.Image")));
            this.bejegyzesekKezelesekBindingNavigatorSaveItem.Name = "bejegyzesekKezelesekBindingNavigatorSaveItem";
            this.bejegyzesekKezelesekBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.bejegyzesekKezelesekBindingNavigatorSaveItem.Text = "Save Data";
            this.bejegyzesekKezelesekBindingNavigatorSaveItem.Click += new System.EventHandler(this.bejegyzesekKezelesekBindingNavigatorSaveItem_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // bejegyzesekKezelesekTableAdapter1
            // 
            this.bejegyzesekKezelesekTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 698);
            this.Controls.Add(this.bejegyzesekKezelesekBindingNavigator);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(748, 698);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabelsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bejegyzesekKezelesekBindingNavigator)).EndInit();
            this.bejegyzesekKezelesekBindingNavigator.ResumeLayout(false);
            this.bejegyzesekKezelesekBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelEg;
        private System.Windows.Forms.Button buttonF3Back;
        private System.Windows.Forms.Button buttonFUB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonF3K;
        private System.Windows.Forms.Button btnF4Keres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonDelete;
        private AdatbazisKiskedvDataSet2 adatbazisKiskedvDataSet2;
        private System.Windows.Forms.BindingSource bejegyzesekKezelesekBindingSource;
        private AdatbazisKiskedvDataSet2TableAdapters.BejegyzesekKezelesekTableAdapter bejegyzesekKezelesekTableAdapter;
        private AdatbazisKiskedvDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bejegyzesekKezelesekBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bejegyzesekKezelesekBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bejegyzesekKezelesekDataGridView;
        private System.Windows.Forms.TextBox diagnozisTextBox;
        private System.Windows.Forms.TextBox terapiaTextBox;
        private System.Windows.Forms.TextBox allatIDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DateTimePicker datumDTP;
        private dbTabelsDataSet dbTabelsDataSet;
        private System.Windows.Forms.BindingSource bejegyzesekKezelesekBindingSource1;
        private dbTabelsDataSetTableAdapters.BejegyzesekKezelesekTableAdapter bejegyzesekKezelesekTableAdapter1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}