
namespace Products
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 11D);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createUpdateButton = new System.Windows.Forms.Button();
            this.createUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typesGridView = new System.Windows.Forms.DataGridView();
            this.TypeSIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStockStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUpdatedAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customProductGrid = new System.Windows.Forms.DataGridView();
            this.CustomProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomUpdatedAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomStatusTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMomentButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tMomentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tMomentTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.intervalDataGridView = new System.Windows.Forms.DataGridView();
            this.IntervalNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalBeginDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalEndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalDurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deltaDataGridView = new System.Windows.Forms.DataGridView();
            this.DeltaNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaDeltaPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaDeltaTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaUpdatedAtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customProductGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteComboBox);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.createUpdateButton);
            this.tabPage1.Controls.Add(this.createUpdateComboBox);
            this.tabPage1.Controls.Add(this.priceTextBox);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.typesGridView);
            this.tabPage1.Controls.Add(this.productsGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(998, 664);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crud";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(418, 496);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(157, 32);
            this.deleteComboBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(328, 544);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(246, 37);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stock Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // createUpdateButton
            // 
            this.createUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUpdateButton.Location = new System.Drawing.Point(31, 544);
            this.createUpdateButton.Name = "createUpdateButton";
            this.createUpdateButton.Size = new System.Drawing.Size(260, 37);
            this.createUpdateButton.TabIndex = 5;
            this.createUpdateButton.Text = "Create/Update";
            this.createUpdateButton.UseVisualStyleBackColor = true;
            this.createUpdateButton.Click += new System.EventHandler(this.CreateUpdateButton_Click);
            // 
            // createUpdateComboBox
            // 
            this.createUpdateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUpdateComboBox.FormattingEnabled = true;
            this.createUpdateComboBox.Location = new System.Drawing.Point(142, 498);
            this.createUpdateComboBox.Name = "createUpdateComboBox";
            this.createUpdateComboBox.Size = new System.Drawing.Size(150, 32);
            this.createUpdateComboBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(142, 455);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(150, 29);
            this.priceTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(142, 407);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 29);
            this.nameTextBox.TabIndex = 2;
            // 
            // typesGridView
            // 
            this.typesGridView.AllowUserToAddRows = false;
            this.typesGridView.AllowUserToDeleteRows = false;
            this.typesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeSIdColumn,
            this.TypeNameColumn});
            this.typesGridView.Location = new System.Drawing.Point(580, 6);
            this.typesGridView.Name = "typesGridView";
            this.typesGridView.ReadOnly = true;
            this.typesGridView.RowHeadersWidth = 51;
            this.typesGridView.Size = new System.Drawing.Size(413, 238);
            this.typesGridView.TabIndex = 1;
            // 
            // TypeSIdColumn
            // 
            this.TypeSIdColumn.HeaderText = "SId";
            this.TypeSIdColumn.MinimumWidth = 6;
            this.TypeSIdColumn.Name = "TypeSIdColumn";
            this.TypeSIdColumn.ReadOnly = true;
            this.TypeSIdColumn.Width = 125;
            // 
            // TypeNameColumn
            // 
            this.TypeNameColumn.HeaderText = "Name";
            this.TypeNameColumn.MinimumWidth = 6;
            this.TypeNameColumn.Name = "TypeNameColumn";
            this.TypeNameColumn.ReadOnly = true;
            this.TypeNameColumn.Width = 125;
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductStockStatusColumn,
            this.ProductUpdatedAtColumn});
            this.productsGridView.Location = new System.Drawing.Point(8, 6);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.RowHeadersWidth = 51;
            this.productsGridView.Size = new System.Drawing.Size(566, 392);
            this.productsGridView.TabIndex = 0;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Name";
            this.ProductNameColumn.MinimumWidth = 6;
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            this.ProductNameColumn.Width = 125;
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.MinimumWidth = 6;
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            this.ProductPriceColumn.ReadOnly = true;
            this.ProductPriceColumn.Width = 125;
            // 
            // ProductStockStatusColumn
            // 
            this.ProductStockStatusColumn.HeaderText = "Stock Status";
            this.ProductStockStatusColumn.MinimumWidth = 6;
            this.ProductStockStatusColumn.Name = "ProductStockStatusColumn";
            this.ProductStockStatusColumn.ReadOnly = true;
            this.ProductStockStatusColumn.Width = 125;
            // 
            // ProductUpdatedAtColumn
            // 
            this.ProductUpdatedAtColumn.HeaderText = "UpdatedAt";
            this.ProductUpdatedAtColumn.MinimumWidth = 6;
            this.ProductUpdatedAtColumn.Name = "ProductUpdatedAtColumn";
            this.ProductUpdatedAtColumn.ReadOnly = true;
            this.ProductUpdatedAtColumn.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customProductGrid);
            this.tabPage2.Controls.Add(this.tMomentButton);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tMomentDatePicker);
            this.tabPage2.Controls.Add(this.tMomentTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(998, 664);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stare Moment t";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customProductGrid
            // 
            this.customProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomProductNameColumn,
            this.CustomProductPriceColumn,
            this.CustomUpdatedAtColumn,
            this.CustomStatusTypeColumn});
            this.customProductGrid.Location = new System.Drawing.Point(259, 69);
            this.customProductGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customProductGrid.Name = "customProductGrid";
            this.customProductGrid.RowHeadersWidth = 51;
            this.customProductGrid.RowTemplate.Height = 24;
            this.customProductGrid.Size = new System.Drawing.Size(487, 304);
            this.customProductGrid.TabIndex = 6;
            // 
            // CustomProductNameColumn
            // 
            this.CustomProductNameColumn.HeaderText = "Product Name";
            this.CustomProductNameColumn.MinimumWidth = 6;
            this.CustomProductNameColumn.Name = "CustomProductNameColumn";
            this.CustomProductNameColumn.ReadOnly = true;
            this.CustomProductNameColumn.Width = 125;
            // 
            // CustomProductPriceColumn
            // 
            this.CustomProductPriceColumn.HeaderText = "Price";
            this.CustomProductPriceColumn.MinimumWidth = 6;
            this.CustomProductPriceColumn.Name = "CustomProductPriceColumn";
            this.CustomProductPriceColumn.ReadOnly = true;
            this.CustomProductPriceColumn.Width = 125;
            // 
            // CustomUpdatedAtColumn
            // 
            this.CustomUpdatedAtColumn.HeaderText = "Updated At";
            this.CustomUpdatedAtColumn.MinimumWidth = 6;
            this.CustomUpdatedAtColumn.Name = "CustomUpdatedAtColumn";
            this.CustomUpdatedAtColumn.ReadOnly = true;
            this.CustomUpdatedAtColumn.Width = 125;
            // 
            // CustomStatusTypeColumn
            // 
            this.CustomStatusTypeColumn.HeaderText = "Status Type";
            this.CustomStatusTypeColumn.MinimumWidth = 6;
            this.CustomStatusTypeColumn.Name = "CustomStatusTypeColumn";
            this.CustomStatusTypeColumn.ReadOnly = true;
            this.CustomStatusTypeColumn.Width = 125;
            // 
            // tMomentButton
            // 
            this.tMomentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMomentButton.Location = new System.Drawing.Point(315, 524);
            this.tMomentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tMomentButton.Name = "tMomentButton";
            this.tMomentButton.Size = new System.Drawing.Size(382, 36);
            this.tMomentButton.TabIndex = 5;
            this.tMomentButton.Text = "Evaluate";
            this.tMomentButton.UseVisualStyleBackColor = true;
            this.tMomentButton.Click += new System.EventHandler(this.CustomProductButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 478);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // tMomentDatePicker
            // 
            this.tMomentDatePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            this.tMomentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMomentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tMomentDatePicker.Location = new System.Drawing.Point(401, 478);
            this.tMomentDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tMomentDatePicker.Name = "tMomentDatePicker";
            this.tMomentDatePicker.Size = new System.Drawing.Size(297, 29);
            this.tMomentDatePicker.TabIndex = 2;
            // 
            // tMomentTextBox
            // 
            this.tMomentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMomentTextBox.Location = new System.Drawing.Point(401, 435);
            this.tMomentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tMomentTextBox.Name = "tMomentTextBox";
            this.tMomentTextBox.Size = new System.Drawing.Size(297, 29);
            this.tMomentTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.intervalDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(998, 664);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "IntervalMaxim";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // intervalDataGridView
            // 
            this.intervalDataGridView.AllowUserToAddRows = false;
            this.intervalDataGridView.AllowUserToDeleteRows = false;
            this.intervalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.intervalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntervalNameColumn,
            this.IntervalPriceColumn,
            this.IntervalBeginDateColumn,
            this.IntervalEndDateColumn,
            this.IntervalDurationColumn});
            this.intervalDataGridView.Location = new System.Drawing.Point(6, 6);
            this.intervalDataGridView.Name = "intervalDataGridView";
            this.intervalDataGridView.ReadOnly = true;
            this.intervalDataGridView.Size = new System.Drawing.Size(983, 357);
            this.intervalDataGridView.TabIndex = 0;
            // 
            // IntervalNameColumn
            // 
            this.IntervalNameColumn.HeaderText = "Name";
            this.IntervalNameColumn.Name = "IntervalNameColumn";
            this.IntervalNameColumn.ReadOnly = true;
            // 
            // IntervalPriceColumn
            // 
            this.IntervalPriceColumn.HeaderText = "Price";
            this.IntervalPriceColumn.Name = "IntervalPriceColumn";
            this.IntervalPriceColumn.ReadOnly = true;
            // 
            // IntervalBeginDateColumn
            // 
            this.IntervalBeginDateColumn.HeaderText = "BeginDate";
            this.IntervalBeginDateColumn.Name = "IntervalBeginDateColumn";
            this.IntervalBeginDateColumn.ReadOnly = true;
            // 
            // IntervalEndDateColumn
            // 
            this.IntervalEndDateColumn.HeaderText = "EndDate";
            this.IntervalEndDateColumn.Name = "IntervalEndDateColumn";
            this.IntervalEndDateColumn.ReadOnly = true;
            // 
            // IntervalDurationColumn
            // 
            this.IntervalDurationColumn.HeaderText = "Duration";
            this.IntervalDurationColumn.Name = "IntervalDurationColumn";
            this.IntervalDurationColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deltaDataGridView);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(998, 664);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(8, 24);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Points.Add(dataPoint2);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(981, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(783, 458);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // deltaDataGridView
            // 
            this.deltaDataGridView.AllowUserToAddRows = false;
            this.deltaDataGridView.AllowUserToDeleteRows = false;
            this.deltaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deltaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeltaNameColumn,
            this.DeltaPriceColumn,
            this.DeltaDeltaPriceColumn,
            this.DeltaDeltaTimeColumn,
            this.DeltaUpdatedAtColumn});
            this.deltaDataGridView.Location = new System.Drawing.Point(29, 354);
            this.deltaDataGridView.Name = "deltaDataGridView";
            this.deltaDataGridView.ReadOnly = true;
            this.deltaDataGridView.Size = new System.Drawing.Size(717, 293);
            this.deltaDataGridView.TabIndex = 3;
            // 
            // DeltaNameColumn
            // 
            this.DeltaNameColumn.HeaderText = "Name";
            this.DeltaNameColumn.Name = "DeltaNameColumn";
            this.DeltaNameColumn.ReadOnly = true;
            // 
            // DeltaPriceColumn
            // 
            this.DeltaPriceColumn.HeaderText = "Price";
            this.DeltaPriceColumn.Name = "DeltaPriceColumn";
            this.DeltaPriceColumn.ReadOnly = true;
            // 
            // DeltaDeltaPriceColumn
            // 
            this.DeltaDeltaPriceColumn.HeaderText = "DeltaPrice";
            this.DeltaDeltaPriceColumn.Name = "DeltaDeltaPriceColumn";
            this.DeltaDeltaPriceColumn.ReadOnly = true;
            // 
            // DeltaDeltaTimeColumn
            // 
            this.DeltaDeltaTimeColumn.HeaderText = "DeltaTime";
            this.DeltaDeltaTimeColumn.Name = "DeltaDeltaTimeColumn";
            this.DeltaDeltaTimeColumn.ReadOnly = true;
            // 
            // DeltaUpdatedAtColumn
            // 
            this.DeltaUpdatedAtColumn.HeaderText = "UpdatedAt";
            this.DeltaUpdatedAtColumn.Name = "DeltaUpdatedAtColumn";
            this.DeltaUpdatedAtColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 688);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customProductGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView typesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeNameColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUpdateButton;
        private System.Windows.Forms.ComboBox createUpdateComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStockStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUpdatedAtColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.Button tMomentButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker tMomentDatePicker;
        private System.Windows.Forms.TextBox tMomentTextBox;
        private System.Windows.Forms.DataGridView customProductGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomUpdatedAtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomStatusTypeColumn;
        private System.Windows.Forms.DataGridView intervalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalBeginDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalEndDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalDurationColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView deltaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaDeltaPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaDeltaTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaUpdatedAtColumn;
    }
}

