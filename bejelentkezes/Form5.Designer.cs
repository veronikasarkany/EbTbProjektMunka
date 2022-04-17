namespace bejelentkezes
{
    partial class Form5
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
            System.Windows.Forms.Label egyebVedooltasokParazitaLabel;
            System.Windows.Forms.Label allatIDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.buttonF3Back = new System.Windows.Forms.Button();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oltasokKezelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adatbazisKiskedvDataSet1 = new bejelentkezes.AdatbazisKiskedvDataSet1();
            this.allatIDTextBox = new System.Windows.Forms.TextBox();
            this.egyebVedooltasokParazitaTextBox = new System.Windows.Forms.TextBox();
            this.oltasokKezelesekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oltasokKezelesekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTabelsDataSet1 = new bejelentkezes.dbTabelsDataSet1();
            this.labelTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonF3K = new System.Windows.Forms.Button();
            this.buttonF5K = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOUJ = new System.Windows.Forms.Button();
            this.buttonF5Back = new System.Windows.Forms.Button();
            this.labelOlt = new System.Windows.Forms.Label();
            this.oltasokKezelesekTableAdapter = new bejelentkezes.AdatbazisKiskedvDataSet1TableAdapters.OltasokKezelesekTableAdapter();
            this.tableAdapterManager = new bejelentkezes.AdatbazisKiskedvDataSet1TableAdapters.TableAdapterManager();
            this.oltasokKezelesekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oltasokKezelesekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.oltasokKezelesekTableAdapter1 = new bejelentkezes.dbTabelsDataSet1TableAdapters.OltasokKezelesekTableAdapter();
            datumLabel = new System.Windows.Forms.Label();
            egyebVedooltasokParazitaLabel = new System.Windows.Forms.Label();
            allatIDLabel = new System.Windows.Forms.Label();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabelsDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekBindingNavigator)).BeginInit();
            this.oltasokKezelesekBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            datumLabel.Location = new System.Drawing.Point(52, 129);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(70, 20);
            datumLabel.TabIndex = 49;
            datumLabel.Text = "Dátum:";
            datumLabel.Click += new System.EventHandler(this.datumLabel_Click);
            // 
            // egyebVedooltasokParazitaLabel
            // 
            egyebVedooltasokParazitaLabel.AutoSize = true;
            egyebVedooltasokParazitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            egyebVedooltasokParazitaLabel.Location = new System.Drawing.Point(52, 216);
            egyebVedooltasokParazitaLabel.Name = "egyebVedooltasokParazitaLabel";
            egyebVedooltasokParazitaLabel.Size = new System.Drawing.Size(296, 20);
            egyebVedooltasokParazitaLabel.TabIndex = 50;
            egyebVedooltasokParazitaLabel.Text = "Egyéb Védőoltások Parazita ellen:";
            egyebVedooltasokParazitaLabel.Click += new System.EventHandler(this.egyebVedooltasokParazitaLabel_Click);
            // 
            // allatIDLabel
            // 
            allatIDLabel.AutoSize = true;
            allatIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            allatIDLabel.Location = new System.Drawing.Point(52, 179);
            allatIDLabel.Name = "allatIDLabel";
            allatIDLabel.Size = new System.Drawing.Size(78, 20);
            allatIDLabel.TabIndex = 51;
            allatIDLabel.Text = "Állat ID:";
            allatIDLabel.Click += new System.EventHandler(this.allatIDLabel_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelChildForm.Controls.Add(this.buttonF3Back);
            this.panelChildForm.Controls.Add(this.datumDateTimePicker);
            this.panelChildForm.Controls.Add(allatIDLabel);
            this.panelChildForm.Controls.Add(this.allatIDTextBox);
            this.panelChildForm.Controls.Add(egyebVedooltasokParazitaLabel);
            this.panelChildForm.Controls.Add(this.egyebVedooltasokParazitaTextBox);
            this.panelChildForm.Controls.Add(datumLabel);
            this.panelChildForm.Controls.Add(this.oltasokKezelesekDataGridView);
            this.panelChildForm.Controls.Add(this.labelTotal);
            this.panelChildForm.Controls.Add(this.tableLayoutPanel1);
            this.panelChildForm.Controls.Add(this.buttonF3K);
            this.panelChildForm.Controls.Add(this.buttonF5K);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.buttonOUJ);
            this.panelChildForm.Controls.Add(this.buttonF5Back);
            this.panelChildForm.Controls.Add(this.labelOlt);
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(748, 698);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(748, 698);
            this.panelChildForm.TabIndex = 0;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // buttonF3Back
            // 
            this.buttonF3Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF3Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF3Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF3Back.Location = new System.Drawing.Point(367, 623);
            this.buttonF3Back.Name = "buttonF3Back";
            this.buttonF3Back.Size = new System.Drawing.Size(144, 34);
            this.buttonF3Back.TabIndex = 54;
            this.buttonF3Back.Text = "Módosítás";
            this.buttonF3Back.UseVisualStyleBackColor = false;
            this.buttonF3Back.Click += new System.EventHandler(this.buttonF3Back_Click);
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oltasokKezelesekBindingSource, "Datum", true));
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(147, 127);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datumDateTimePicker.TabIndex = 53;
            this.datumDateTimePicker.ValueChanged += new System.EventHandler(this.datumDateTimePicker_ValueChanged);
            // 
            // oltasokKezelesekBindingSource
            // 
            this.oltasokKezelesekBindingSource.DataMember = "OltasokKezelesek";
            this.oltasokKezelesekBindingSource.DataSource = this.adatbazisKiskedvDataSet1;
            this.oltasokKezelesekBindingSource.CurrentChanged += new System.EventHandler(this.oltasokKezelesekBindingSource_CurrentChanged);
            // 
            // adatbazisKiskedvDataSet1
            // 
            this.adatbazisKiskedvDataSet1.DataSetName = "AdatbazisKiskedvDataSet1";
            this.adatbazisKiskedvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allatIDTextBox
            // 
            this.allatIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oltasokKezelesekBindingSource, "AllatID", true));
            this.allatIDTextBox.Location = new System.Drawing.Point(147, 177);
            this.allatIDTextBox.Name = "allatIDTextBox";
            this.allatIDTextBox.Size = new System.Drawing.Size(201, 22);
            this.allatIDTextBox.TabIndex = 52;
            this.allatIDTextBox.TextChanged += new System.EventHandler(this.allatIDTextBox_TextChanged);
            // 
            // egyebVedooltasokParazitaTextBox
            // 
            this.egyebVedooltasokParazitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oltasokKezelesekBindingSource, "EgyebVedooltasokParazita", true));
            this.egyebVedooltasokParazitaTextBox.Location = new System.Drawing.Point(55, 244);
            this.egyebVedooltasokParazitaTextBox.Multiline = true;
            this.egyebVedooltasokParazitaTextBox.Name = "egyebVedooltasokParazitaTextBox";
            this.egyebVedooltasokParazitaTextBox.Size = new System.Drawing.Size(293, 93);
            this.egyebVedooltasokParazitaTextBox.TabIndex = 51;
            this.egyebVedooltasokParazitaTextBox.TextChanged += new System.EventHandler(this.egyebVedooltasokParazitaTextBox_TextChanged);
            // 
            // oltasokKezelesekDataGridView
            // 
            this.oltasokKezelesekDataGridView.AllowUserToOrderColumns = true;
            this.oltasokKezelesekDataGridView.AutoGenerateColumns = false;
            this.oltasokKezelesekDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.oltasokKezelesekDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.oltasokKezelesekDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.oltasokKezelesekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oltasokKezelesekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.oltasokKezelesekDataGridView.DataSource = this.oltasokKezelesekBindingSource1;
            this.oltasokKezelesekDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.oltasokKezelesekDataGridView.Location = new System.Drawing.Point(42, 352);
            this.oltasokKezelesekDataGridView.Name = "oltasokKezelesekDataGridView";
            this.oltasokKezelesekDataGridView.RowHeadersWidth = 51;
            this.oltasokKezelesekDataGridView.RowTemplate.Height = 24;
            this.oltasokKezelesekDataGridView.Size = new System.Drawing.Size(645, 240);
            this.oltasokKezelesekDataGridView.TabIndex = 49;
            this.oltasokKezelesekDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oltasokKezelesekDataGridView_CellClick);
            this.oltasokKezelesekDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.oltasokKezelesekDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dátum";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AllatID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ÁllatID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EgyebVedooltasokParazita";
            this.dataGridViewTextBoxColumn2.HeaderText = "Védőoltások & Kezelések";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // oltasokKezelesekBindingSource1
            // 
            this.oltasokKezelesekBindingSource1.DataMember = "OltasokKezelesek";
            this.oltasokKezelesekBindingSource1.DataSource = this.dbTabelsDataSet1;
            // 
            // dbTabelsDataSet1
            // 
            this.dbTabelsDataSet1.DataSetName = "dbTabelsDataSet1";
            this.dbTabelsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.labelTotal.Location = new System.Drawing.Point(405, 244);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(152, 20);
            this.labelTotal.TabIndex = 49;
            this.labelTotal.Text = "Találatok száma:";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41611F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(409, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 29);
            this.tableLayoutPanel1.TabIndex = 48;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonF3K
            // 
            this.buttonF3K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF3K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF3K.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF3K.Location = new System.Drawing.Point(534, 171);
            this.buttonF3K.Name = "buttonF3K";
            this.buttonF3K.Size = new System.Drawing.Size(144, 34);
            this.buttonF3K.TabIndex = 2;
            this.buttonF3K.Text = "Keresés";
            this.buttonF3K.UseVisualStyleBackColor = false;
            this.buttonF3K.Click += new System.EventHandler(this.buttonF3K_Click);
            // 
            // buttonF5K
            // 
            this.buttonF5K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF5K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF5K.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF5K.Location = new System.Drawing.Point(42, 623);
            this.buttonF5K.Name = "buttonF5K";
            this.buttonF5K.Size = new System.Drawing.Size(144, 34);
            this.buttonF5K.TabIndex = 45;
            this.buttonF5K.Text = "Összesen";
            this.buttonF5K.UseVisualStyleBackColor = false;
            this.buttonF5K.Click += new System.EventHandler(this.buttonF5K_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(55, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 10);
            this.panel1.TabIndex = 44;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonOUJ
            // 
            this.buttonOUJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonOUJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOUJ.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOUJ.Location = new System.Drawing.Point(203, 623);
            this.buttonOUJ.Name = "buttonOUJ";
            this.buttonOUJ.Size = new System.Drawing.Size(144, 34);
            this.buttonOUJ.TabIndex = 27;
            this.buttonOUJ.Text = "Új Bejegyzés";
            this.buttonOUJ.UseVisualStyleBackColor = false;
            this.buttonOUJ.Click += new System.EventHandler(this.buttonOUJ_Click);
            // 
            // buttonF5Back
            // 
            this.buttonF5Back.BackColor = System.Drawing.Color.Red;
            this.buttonF5Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF5Back.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF5Back.Location = new System.Drawing.Point(534, 623);
            this.buttonF5Back.Name = "buttonF5Back";
            this.buttonF5Back.Size = new System.Drawing.Size(144, 34);
            this.buttonF5Back.TabIndex = 26;
            this.buttonF5Back.Text = "Törlés";
            this.buttonF5Back.UseVisualStyleBackColor = false;
            this.buttonF5Back.Click += new System.EventHandler(this.buttonF5Back_Click);
            // 
            // labelOlt
            // 
            this.labelOlt.AutoSize = true;
            this.labelOlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOlt.Location = new System.Drawing.Point(50, 39);
            this.labelOlt.Name = "labelOlt";
            this.labelOlt.Size = new System.Drawing.Size(568, 29);
            this.labelOlt.TabIndex = 24;
            this.labelOlt.Text = "Egyéb védőoltások és Parazita elleni kezelések";
            this.labelOlt.Click += new System.EventHandler(this.labelOlt_Click);
            // 
            // oltasokKezelesekTableAdapter
            // 
            this.oltasokKezelesekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OltasokKezelesekTableAdapter = this.oltasokKezelesekTableAdapter;
            this.tableAdapterManager.UpdateOrder = bejelentkezes.AdatbazisKiskedvDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oltasokKezelesekBindingNavigator
            // 
            this.oltasokKezelesekBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oltasokKezelesekBindingNavigator.BindingSource = this.oltasokKezelesekBindingSource;
            this.oltasokKezelesekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oltasokKezelesekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oltasokKezelesekBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.oltasokKezelesekBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.oltasokKezelesekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oltasokKezelesekBindingNavigatorSaveItem,
            this.toolStripProgressBar1});
            this.oltasokKezelesekBindingNavigator.Location = new System.Drawing.Point(0, 667);
            this.oltasokKezelesekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oltasokKezelesekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oltasokKezelesekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oltasokKezelesekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oltasokKezelesekBindingNavigator.Name = "oltasokKezelesekBindingNavigator";
            this.oltasokKezelesekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oltasokKezelesekBindingNavigator.Size = new System.Drawing.Size(748, 31);
            this.oltasokKezelesekBindingNavigator.TabIndex = 1;
            this.oltasokKezelesekBindingNavigator.Text = "bindingNavigator1";
            this.oltasokKezelesekBindingNavigator.RefreshItems += new System.EventHandler(this.oltasokKezelesekBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Click += new System.EventHandler(this.bindingNavigatorCountItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator.Click += new System.EventHandler(this.bindingNavigatorSeparator_Click);
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
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator1.Click += new System.EventHandler(this.bindingNavigatorSeparator1_Click);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            this.bindingNavigatorSeparator2.Click += new System.EventHandler(this.bindingNavigatorSeparator2_Click);
            // 
            // oltasokKezelesekBindingNavigatorSaveItem
            // 
            this.oltasokKezelesekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oltasokKezelesekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oltasokKezelesekBindingNavigatorSaveItem.Image")));
            this.oltasokKezelesekBindingNavigatorSaveItem.Name = "oltasokKezelesekBindingNavigatorSaveItem";
            this.oltasokKezelesekBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.oltasokKezelesekBindingNavigatorSaveItem.Text = "Save Data";
            this.oltasokKezelesekBindingNavigatorSaveItem.Click += new System.EventHandler(this.oltasokKezelesekBindingNavigatorSaveItem_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // oltasokKezelesekTableAdapter1
            // 
            this.oltasokKezelesekTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 698);
            this.Controls.Add(this.oltasokKezelesekBindingNavigator);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(748, 698);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabelsDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oltasokKezelesekBindingNavigator)).EndInit();
            this.oltasokKezelesekBindingNavigator.ResumeLayout(false);
            this.oltasokKezelesekBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label labelOlt;
        private System.Windows.Forms.Button buttonOUJ;
        private System.Windows.Forms.Button buttonF5Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonF5K;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button buttonF3K;
        private System.Windows.Forms.Label labelTotal;
        private AdatbazisKiskedvDataSet1 adatbazisKiskedvDataSet1;
        private System.Windows.Forms.BindingSource oltasokKezelesekBindingSource;
        private AdatbazisKiskedvDataSet1TableAdapters.OltasokKezelesekTableAdapter oltasokKezelesekTableAdapter;
        private AdatbazisKiskedvDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oltasokKezelesekBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oltasokKezelesekBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox allatIDTextBox;
        private System.Windows.Forms.TextBox egyebVedooltasokParazitaTextBox;
        private System.Windows.Forms.DataGridView oltasokKezelesekDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.Button buttonF3Back;
        private dbTabelsDataSet1 dbTabelsDataSet1;
        private System.Windows.Forms.BindingSource oltasokKezelesekBindingSource1;
        private dbTabelsDataSet1TableAdapters.OltasokKezelesekTableAdapter oltasokKezelesekTableAdapter1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}