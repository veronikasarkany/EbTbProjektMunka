namespace bejelentkezes
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.Label befizetesekOsszLabel;
            System.Windows.Forms.Label kezelesiKoltsegLabel;
            System.Windows.Forms.Label rendelkezesreAlloLabel;
            System.Windows.Forms.Label gazdiIDLabel;
            System.Windows.Forms.Label datumLabel;
            this.adatbazisKiskedvDataSet = new bejelentkezes.AdatbazisKiskedvDataSet();
            this.befizetesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.befizetesekTableAdapter = new bejelentkezes.AdatbazisKiskedvDataSetTableAdapters.BefizetesekTableAdapter();
            this.tableAdapterManager = new bejelentkezes.AdatbazisKiskedvDataSetTableAdapters.TableAdapterManager();
            this.befizetesekBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.befizetesekBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.befizetesekOsszTextBox = new System.Windows.Forms.TextBox();
            this.kezelesiKoltsegTextBox = new System.Windows.Forms.TextBox();
            this.rendelkezesreAlloTextBox = new System.Windows.Forms.TextBox();
            this.gazdiIDTextBox = new System.Windows.Forms.TextBox();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            befizetesekOsszLabel = new System.Windows.Forms.Label();
            kezelesiKoltsegLabel = new System.Windows.Forms.Label();
            rendelkezesreAlloLabel = new System.Windows.Forms.Label();
            gazdiIDLabel = new System.Windows.Forms.Label();
            datumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingNavigator)).BeginInit();
            this.befizetesekBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adatbazisKiskedvDataSet
            // 
            this.adatbazisKiskedvDataSet.DataSetName = "AdatbazisKiskedvDataSet";
            this.adatbazisKiskedvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // befizetesekBindingSource
            // 
            this.befizetesekBindingSource.DataMember = "Befizetesek";
            this.befizetesekBindingSource.DataSource = this.adatbazisKiskedvDataSet;
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
            this.befizetesekBindingNavigatorSaveItem});
            this.befizetesekBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.befizetesekBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.befizetesekBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.befizetesekBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.befizetesekBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.befizetesekBindingNavigator.Name = "befizetesekBindingNavigator";
            this.befizetesekBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.befizetesekBindingNavigator.Size = new System.Drawing.Size(775, 31);
            this.befizetesekBindingNavigator.TabIndex = 0;
            this.befizetesekBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // befizetesekBindingNavigatorSaveItem
            // 
            this.befizetesekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.befizetesekBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("befizetesekBindingNavigatorSaveItem.Image")));
            this.befizetesekBindingNavigatorSaveItem.Name = "befizetesekBindingNavigatorSaveItem";
            this.befizetesekBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.befizetesekBindingNavigatorSaveItem.Text = "Save Data";
            this.befizetesekBindingNavigatorSaveItem.Click += new System.EventHandler(this.befizetesekBindingNavigatorSaveItem_Click);
            // 
            // befizetesekOsszLabel
            // 
            befizetesekOsszLabel.AutoSize = true;
            befizetesekOsszLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            befizetesekOsszLabel.Location = new System.Drawing.Point(12, 68);
            befizetesekOsszLabel.Name = "befizetesekOsszLabel";
            befizetesekOsszLabel.Size = new System.Drawing.Size(170, 25);
            befizetesekOsszLabel.TabIndex = 1;
            befizetesekOsszLabel.Text = "Befizetesek Ossz:";
            // 
            // befizetesekOsszTextBox
            // 
            this.befizetesekOsszTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "BefizetesekOssz", true));
            this.befizetesekOsszTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.befizetesekOsszTextBox.Location = new System.Drawing.Point(224, 68);
            this.befizetesekOsszTextBox.Name = "befizetesekOsszTextBox";
            this.befizetesekOsszTextBox.Size = new System.Drawing.Size(152, 30);
            this.befizetesekOsszTextBox.TabIndex = 2;
            // 
            // kezelesiKoltsegLabel
            // 
            kezelesiKoltsegLabel.AutoSize = true;
            kezelesiKoltsegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            kezelesiKoltsegLabel.Location = new System.Drawing.Point(12, 96);
            kezelesiKoltsegLabel.Name = "kezelesiKoltsegLabel";
            kezelesiKoltsegLabel.Size = new System.Drawing.Size(164, 25);
            kezelesiKoltsegLabel.TabIndex = 3;
            kezelesiKoltsegLabel.Text = "Kezelesi Koltseg:";
            // 
            // kezelesiKoltsegTextBox
            // 
            this.kezelesiKoltsegTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "KezelesiKoltseg", true));
            this.kezelesiKoltsegTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kezelesiKoltsegTextBox.Location = new System.Drawing.Point(224, 96);
            this.kezelesiKoltsegTextBox.Name = "kezelesiKoltsegTextBox";
            this.kezelesiKoltsegTextBox.Size = new System.Drawing.Size(152, 30);
            this.kezelesiKoltsegTextBox.TabIndex = 4;
            // 
            // rendelkezesreAlloLabel
            // 
            rendelkezesreAlloLabel.AutoSize = true;
            rendelkezesreAlloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            rendelkezesreAlloLabel.Location = new System.Drawing.Point(12, 124);
            rendelkezesreAlloLabel.Name = "rendelkezesreAlloLabel";
            rendelkezesreAlloLabel.Size = new System.Drawing.Size(186, 25);
            rendelkezesreAlloLabel.TabIndex = 5;
            rendelkezesreAlloLabel.Text = "Rendelkezesre Allo:";
            // 
            // rendelkezesreAlloTextBox
            // 
            this.rendelkezesreAlloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "RendelkezesreAllo", true));
            this.rendelkezesreAlloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rendelkezesreAlloTextBox.Location = new System.Drawing.Point(224, 124);
            this.rendelkezesreAlloTextBox.Name = "rendelkezesreAlloTextBox";
            this.rendelkezesreAlloTextBox.Size = new System.Drawing.Size(152, 30);
            this.rendelkezesreAlloTextBox.TabIndex = 6;
            // 
            // gazdiIDLabel
            // 
            gazdiIDLabel.AutoSize = true;
            gazdiIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            gazdiIDLabel.Location = new System.Drawing.Point(12, 152);
            gazdiIDLabel.Name = "gazdiIDLabel";
            gazdiIDLabel.Size = new System.Drawing.Size(93, 25);
            gazdiIDLabel.TabIndex = 7;
            gazdiIDLabel.Text = "Gazdi ID:";
            // 
            // gazdiIDTextBox
            // 
            this.gazdiIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "GazdiID", true));
            this.gazdiIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gazdiIDTextBox.Location = new System.Drawing.Point(224, 152);
            this.gazdiIDTextBox.Name = "gazdiIDTextBox";
            this.gazdiIDTextBox.Size = new System.Drawing.Size(152, 30);
            this.gazdiIDTextBox.TabIndex = 8;
            // 
            // datumLabel
            // 
            datumLabel.AutoSize = true;
            datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            datumLabel.Location = new System.Drawing.Point(12, 180);
            datumLabel.Name = "datumLabel";
            datumLabel.Size = new System.Drawing.Size(75, 25);
            datumLabel.TabIndex = 9;
            datumLabel.Text = "Dátum:";
            // 
            // datumTextBox
            // 
            this.datumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.befizetesekBindingSource, "Datum", true));
            this.datumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumTextBox.Location = new System.Drawing.Point(224, 180);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(152, 30);
            this.datumTextBox.TabIndex = 10;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.DataGridView.DataSource = this.befizetesekBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(15, 285);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(733, 309);
            this.DataGridView.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.58389F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.41611F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(461, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 29);
            this.tableLayoutPanel1.TabIndex = 54;
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
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(104, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(162, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(586, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.labelTotal.Location = new System.Drawing.Point(382, 246);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(260, 22);
            this.labelTotal.TabIndex = 55;
            this.labelTotal.Text = "Rendelkezésre Álló Összeg:";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dátum";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GazdiID";
            this.dataGridViewTextBoxColumn4.HeaderText = "GazdiID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BefizetesekOssz";
            this.dataGridViewTextBoxColumn1.HeaderText = "Befizetések Összesen";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KezelesiKoltseg";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kezelési Költségek";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RendelkezesreAllo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rendelkezésre Álló Összeg";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 657);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(befizetesekOsszLabel);
            this.Controls.Add(this.befizetesekOsszTextBox);
            this.Controls.Add(kezelesiKoltsegLabel);
            this.Controls.Add(this.kezelesiKoltsegTextBox);
            this.Controls.Add(rendelkezesreAlloLabel);
            this.Controls.Add(this.rendelkezesreAlloTextBox);
            this.Controls.Add(gazdiIDLabel);
            this.Controls.Add(this.gazdiIDTextBox);
            this.Controls.Add(datumLabel);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.befizetesekBindingNavigator);
            this.MinimumSize = new System.Drawing.Size(793, 704);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adatbazisKiskedvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.befizetesekBindingNavigator)).EndInit();
            this.befizetesekBindingNavigator.ResumeLayout(false);
            this.befizetesekBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox befizetesekOsszTextBox;
        private System.Windows.Forms.TextBox kezelesiKoltsegTextBox;
        private System.Windows.Forms.TextBox rendelkezesreAlloTextBox;
        private System.Windows.Forms.TextBox gazdiIDTextBox;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}