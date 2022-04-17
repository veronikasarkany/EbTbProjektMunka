namespace bejelentkezes
{
    partial class Form7
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
            System.Windows.Forms.Label befizetesekOsszLabel;
            System.Windows.Forms.Label kezelesiKoltsegLabel;
            System.Windows.Forms.Label rendelkezesreAlloLabel;
            System.Windows.Forms.Label gazdiIDLabel;
            System.Windows.Forms.Label datumLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panelF7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.befizetesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adatbazisKiskedvDataSet = new bejelentkezes.AdatbazisKiskedvDataSet();
            this.btnF7All = new System.Windows.Forms.Button();
            this.rendelkezesreAlloTextBox = new System.Windows.Forms.TextBox();
            this.befizetesekDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.befizetesekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTabelsDataSet2 = new bejelentkezes.dbTabelsDataSet2();
            this.kezelesiKoltsegTextBox = new System.Windows.Forms.TextBox();
            this.gazdiIDTextBox = new System.Windows.Forms.TextBox();
            this.befizetesekOsszTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonF3K = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonF3Keres = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.befizetesekTableAdapter = new bejelentkezes.AdatbazisKiskedvDataSetTableAdapters.BefizetesekTableAdapter();
            this.tableAdapterManager = new bejelentkezes.AdatbazisKiskedvDataSetTableAdapters.TableAdapterManager();
            this.befizetesekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.befizetesekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.befizetesekTableAdapter1 = new bejelentkezes.dbTabelsDataSet2TableAdapters.BefizetesekTableAdapter();
            befizetesekOsszLabel = new System.Windows.Forms.Label();
            kezelesiKoltsegLabel = new System.Windows.Forms.Label();
            rendelkezesreAlloLabel = new System.Windows.Forms.Label();
            gazdiIDLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            this.panelF7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabelsDataSet2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingNavigator)).BeginInit();
            this.befizetesekBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // befizetesekOsszLabel
            // 
            befizetesekOsszLabel.AutoSize = true;
            befizetesekOsszLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            befizetesekOsszLabel.Location = new System.Drawing.Point(7, 165);
            befizetesekOsszLabel.Name = "befizetesekOsszLabel";
            befizetesekOsszLabel.Size = new System.Drawing.Size(204, 20);
            befizetesekOsszLabel.TabIndex = 52;
            befizetesekOsszLabel.Text = "Befizetések Összesen:";
            // 
            // kezelesiKoltsegLabel
            // 
            kezelesiKoltsegLabel.AutoSize = true;
            kezelesiKoltsegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kezelesiKoltsegLabel.Location = new System.Drawing.Point(7, 195);
            kezelesiKoltsegLabel.Name = "kezelesiKoltsegLabel";
            kezelesiKoltsegLabel.Size = new System.Drawing.Size(156, 20);
            kezelesiKoltsegLabel.TabIndex = 54;
            kezelesiKoltsegLabel.Text = "Kezelési Költség:";
            // 
            // rendelkezesreAlloLabel
            // 
            rendelkezesreAlloLabel.AutoSize = true;
            rendelkezesreAlloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rendelkezesreAlloLabel.Location = new System.Drawing.Point(7, 281);
            rendelkezesreAlloLabel.Name = "rendelkezesreAlloLabel";
            rendelkezesreAlloLabel.Size = new System.Drawing.Size(247, 20);
            rendelkezesreAlloLabel.TabIndex = 56;
            rendelkezesreAlloLabel.Text = "Rendelkezésre Álló Összeg:";
            // 
            // gazdiIDLabel
            // 
            gazdiIDLabel.AutoSize = true;
            gazdiIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            gazdiIDLabel.Location = new System.Drawing.Point(7, 91);
            gazdiIDLabel.Name = "gazdiIDLabel";
            gazdiIDLabel.Size = new System.Drawing.Size(89, 20);
            gazdiIDLabel.TabIndex = 58;
            gazdiIDLabel.Text = "Gazdi ID:";
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            datumLabel.Location = new System.Drawing.Point(7, 131);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(70, 20);
            datumLabel.TabIndex = 60;
            datumLabel.Text = "Dátum:";
            // 
            // panelF7
            // 
            this.panelF7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelF7.Controls.Add(this.label5);
            this.panelF7.Controls.Add(this.label4);
            this.panelF7.Controls.Add(this.label2);
            this.panelF7.Controls.Add(this.btnSzamol);
            this.panelF7.Controls.Add(this.datumDateTimePicker);
            this.panelF7.Controls.Add(this.btnF7All);
            this.panelF7.Controls.Add(this.rendelkezesreAlloTextBox);
            this.panelF7.Controls.Add(datumLabel);
            this.panelF7.Controls.Add(rendelkezesreAlloLabel);
            this.panelF7.Controls.Add(this.befizetesekDataGridView);
            this.panelF7.Controls.Add(kezelesiKoltsegLabel);
            this.panelF7.Controls.Add(this.kezelesiKoltsegTextBox);
            this.panelF7.Controls.Add(this.gazdiIDTextBox);
            this.panelF7.Controls.Add(this.befizetesekOsszTextBox);
            this.panelF7.Controls.Add(this.tableLayoutPanel1);
            this.panelF7.Controls.Add(befizetesekOsszLabel);
            this.panelF7.Controls.Add(this.buttonF3K);
            this.panelF7.Controls.Add(this.labelTotal);
            this.panelF7.Controls.Add(this.buttonPrint);
            this.panelF7.Controls.Add(this.button1);
            this.panelF7.Controls.Add(this.buttonF3Keres);
            this.panelF7.Controls.Add(gazdiIDLabel);
            this.panelF7.Controls.Add(this.panel1);
            this.panelF7.Controls.Add(this.label1);
            this.panelF7.Location = new System.Drawing.Point(7, -2);
            this.panelF7.MinimumSize = new System.Drawing.Size(682, 698);
            this.panelF7.Name = "panelF7";
            this.panelF7.Size = new System.Drawing.Size(695, 698);
            this.panelF7.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(397, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Ft.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(397, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Ft.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(397, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Ft.";
            // 
            // btnSzamol
            // 
            this.btnSzamol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSzamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzamol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnSzamol.Location = new System.Drawing.Point(318, 223);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 65;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = false;
            this.btnSzamol.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // datumDateTimePicker
            // 
            this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.befizetesekBindingSource, "Datum", true));
            this.datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDateTimePicker.Location = new System.Drawing.Point(254, 129);
            this.datumDateTimePicker.Name = "datumDateTimePicker";
            this.datumDateTimePicker.Size = new System.Drawing.Size(139, 22);
            this.datumDateTimePicker.TabIndex = 64;
            // 
            // befizetesekBindingSource
            // 
            this.befizetesekBindingSource.DataMember = "Befizetesek";
            this.befizetesekBindingSource.DataSource = this.adatbazisKiskedvDataSet;
            // 
            // adatbazisKiskedvDataSet
            // 
            this.adatbazisKiskedvDataSet.DataSetName = "AdatbazisKiskedvDataSet";
            this.adatbazisKiskedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnF7All
            // 
            this.btnF7All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnF7All.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnF7All.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnF7All.Location = new System.Drawing.Point(0, 614);
            this.btnF7All.Name = "btnF7All";
            this.btnF7All.Size = new System.Drawing.Size(144, 34);
            this.btnF7All.TabIndex = 63;
            this.btnF7All.Text = "Összes";
            this.btnF7All.UseVisualStyleBackColor = false;
            this.btnF7All.Click += new System.EventHandler(this.btnF7All_Click);
            // 
            // rendelkezesreAlloTextBox
            // 
            this.rendelkezesreAlloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "RendelkezesreAllo", true));
            this.rendelkezesreAlloTextBox.Location = new System.Drawing.Point(254, 279);
            this.rendelkezesreAlloTextBox.Name = "rendelkezesreAlloTextBox";
            this.rendelkezesreAlloTextBox.Size = new System.Drawing.Size(139, 22);
            this.rendelkezesreAlloTextBox.TabIndex = 57;
            this.rendelkezesreAlloTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // befizetesekDataGridView
            // 
            this.befizetesekDataGridView.AutoGenerateColumns = false;
            this.befizetesekDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.befizetesekDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.befizetesekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.befizetesekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.befizetesekDataGridView.DataSource = this.befizetesekBindingSource1;
            this.befizetesekDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.befizetesekDataGridView.Location = new System.Drawing.Point(5, 366);
            this.befizetesekDataGridView.Name = "befizetesekDataGridView";
            this.befizetesekDataGridView.RowHeadersWidth = 51;
            this.befizetesekDataGridView.RowTemplate.Height = 24;
            this.befizetesekDataGridView.Size = new System.Drawing.Size(664, 220);
            this.befizetesekDataGridView.TabIndex = 62;
            this.befizetesekDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.befizetesekDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dátum";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GazdiID";
            this.dataGridViewTextBoxColumn4.HeaderText = "GazdiID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RendelkezesreAllo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rendelkzésre Álló Összeg";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KezelesiKoltseg";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kezelési Költéség";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BefizetesekOssz";
            this.dataGridViewTextBoxColumn1.HeaderText = "Befizetések Összesen";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // befizetesekBindingSource1
            // 
            this.befizetesekBindingSource1.DataMember = "Befizetesek";
            this.befizetesekBindingSource1.DataSource = this.dbTabelsDataSet2;
            // 
            // dbTabelsDataSet2
            // 
            this.dbTabelsDataSet2.DataSetName = "dbTabelsDataSet2";
            this.dbTabelsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kezelesiKoltsegTextBox
            // 
            this.kezelesiKoltsegTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "KezelesiKoltseg", true));
            this.kezelesiKoltsegTextBox.Location = new System.Drawing.Point(254, 195);
            this.kezelesiKoltsegTextBox.Name = "kezelesiKoltsegTextBox";
            this.kezelesiKoltsegTextBox.Size = new System.Drawing.Size(139, 22);
            this.kezelesiKoltsegTextBox.TabIndex = 55;
            this.kezelesiKoltsegTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gazdiIDTextBox
            // 
            this.gazdiIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "GazdiID", true));
            this.gazdiIDTextBox.Location = new System.Drawing.Point(254, 86);
            this.gazdiIDTextBox.Name = "gazdiIDTextBox";
            this.gazdiIDTextBox.Size = new System.Drawing.Size(139, 22);
            this.gazdiIDTextBox.TabIndex = 59;
            this.gazdiIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // befizetesekOsszTextBox
            // 
            this.befizetesekOsszTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "BefizetesekOssz", true));
            this.befizetesekOsszTextBox.Location = new System.Drawing.Point(254, 163);
            this.befizetesekOsszTextBox.Name = "befizetesekOsszTextBox";
            this.befizetesekOsszTextBox.Size = new System.Drawing.Size(139, 22);
            this.befizetesekOsszTextBox.TabIndex = 53;
            this.befizetesekOsszTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41611F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(400, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 29);
            this.tableLayoutPanel1.TabIndex = 52;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(104, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "GazdiID";
            // 
            // buttonF3K
            // 
            this.buttonF3K.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF3K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF3K.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF3K.Location = new System.Drawing.Point(525, 117);
            this.buttonF3K.Name = "buttonF3K";
            this.buttonF3K.Size = new System.Drawing.Size(144, 34);
            this.buttonF3K.TabIndex = 51;
            this.buttonF3K.Text = "Keresés";
            this.buttonF3K.UseVisualStyleBackColor = false;
            this.buttonF3K.Click += new System.EventHandler(this.buttonF3K_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.labelTotal.Location = new System.Drawing.Point(468, 195);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(152, 20);
            this.labelTotal.TabIndex = 50;
            this.labelTotal.Text = "Találatok száma:";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrint.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPrint.Location = new System.Drawing.Point(472, 614);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(194, 34);
            this.buttonPrint.TabIndex = 49;
            this.buttonPrint.Text = "Számla Nyomtatása";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(310, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 48;
            this.button1.Text = "Módosítás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonF3Keres
            // 
            this.buttonF3Keres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonF3Keres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonF3Keres.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonF3Keres.Location = new System.Drawing.Point(150, 614);
            this.buttonF3Keres.Name = "buttonF3Keres";
            this.buttonF3Keres.Size = new System.Drawing.Size(144, 34);
            this.buttonF3Keres.TabIndex = 47;
            this.buttonF3Keres.Text = "Új Bejegyzés";
            this.buttonF3Keres.UseVisualStyleBackColor = false;
            this.buttonF3Keres.Click += new System.EventHandler(this.buttonF3Keres_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(23, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 10);
            this.panel1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Befizetések:";
            // 
            // befizetesekTableAdapter
            // 
            this.befizetesekTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BefizetesekTableAdapter = this.befizetesekTableAdapter;
            this.tableAdapterManager.UpdateOrder = bejelentkezes.AdatbazisKiskedvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // befizetesekBindingNavigator
            // 
            this.befizetesekBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.befizetesekBindingNavigator.BindingSource = this.befizetesekBindingSource;
            this.befizetesekBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.befizetesekBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.befizetesekBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.befizetesekBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.befizetesekBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.befizetesekBindingNavigatorSaveItem,
            this.toolStripProgressBar1});
            this.befizetesekBindingNavigator.Location = new System.Drawing.Point(0, 695);
            this.befizetesekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.befizetesekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.befizetesekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.befizetesekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.befizetesekBindingNavigator.Name = "befizetesekBindingNavigator";
            this.befizetesekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.befizetesekBindingNavigator.Size = new System.Drawing.Size(702, 31);
            this.befizetesekBindingNavigator.TabIndex = 1;
            this.befizetesekBindingNavigator.Text = "bindingNavigator1";
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
            // befizetesekBindingNavigatorSaveItem
            // 
            this.befizetesekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.befizetesekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("befizetesekBindingNavigatorSaveItem.Image")));
            this.befizetesekBindingNavigatorSaveItem.Name = "befizetesekBindingNavigatorSaveItem";
            this.befizetesekBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.befizetesekBindingNavigatorSaveItem.Text = "Save Data";
            this.befizetesekBindingNavigatorSaveItem.Click += new System.EventHandler(this.befizetesekBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            // 
            // befizetesekTableAdapter1
            // 
            this.befizetesekTableAdapter1.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 726);
            this.Controls.Add(this.befizetesekBindingNavigator);
            this.Controls.Add(this.panelF7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(682, 698);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panelF7.ResumeLayout(false);
            this.panelF7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTabelsDataSet2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingNavigator)).EndInit();
            this.befizetesekBindingNavigator.ResumeLayout(false);
            this.befizetesekBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelF7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonF3Keres;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button buttonF3K;
        private AdatbazisKiskedvDataSet adatbazisKiskedvDataSet;
        private System.Windows.Forms.BindingSource befizetesekBindingSource;
        private AdatbazisKiskedvDataSetTableAdapters.BefizetesekTableAdapter befizetesekTableAdapter;
        private AdatbazisKiskedvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator befizetesekBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton befizetesekBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox rendelkezesreAlloTextBox;
        private System.Windows.Forms.TextBox kezelesiKoltsegTextBox;
        private System.Windows.Forms.TextBox befizetesekOsszTextBox;
        private System.Windows.Forms.TextBox gazdiIDTextBox;
        private System.Windows.Forms.DataGridView befizetesekDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnF7All;
        private System.Windows.Forms.DateTimePicker datumDateTimePicker;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private dbTabelsDataSet2 dbTabelsDataSet2;
        private System.Windows.Forms.BindingSource befizetesekBindingSource1;
        private dbTabelsDataSet2TableAdapters.BefizetesekTableAdapter befizetesekTableAdapter1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}