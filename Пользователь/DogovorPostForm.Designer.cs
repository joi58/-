namespace Пользователь
{
    partial class DogovorPostForm
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label fullnameSupplierLabel;
            System.Windows.Forms.Label postSupLabel;
            System.Windows.Forms.Label fullnameBuyerLabel;
            System.Windows.Forms.Label postBuyLabel;
            System.Windows.Forms.Label name1Label;
            System.Windows.Forms.Label quantity1Label;
            System.Windows.Forms.Label individFoatProduct1Label;
            System.Windows.Forms.Label c1Label;
            System.Windows.Forms.Label po1Label;
            System.Windows.Forms.Label name2Label;
            System.Windows.Forms.Label quantity2Label;
            System.Windows.Forms.Label individFoatProduct2Label;
            System.Windows.Forms.Label c2Label;
            System.Windows.Forms.Label po2Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogovorPostForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name1TextBox = new System.Windows.Forms.TextBox();
            this.dovorPostPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательDataSet = new Пользователь.ПользовательDataSet();
            this.quantity1TextBox = new System.Windows.Forms.TextBox();
            this.individFoatProduct1TextBox = new System.Windows.Forms.TextBox();
            this.c1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.po1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.quantity2TextBox = new System.Windows.Forms.TextBox();
            this.individFoatProduct2TextBox = new System.Windows.Forms.TextBox();
            this.c2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.po2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dogovorPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fullnameSupplierTextBox = new System.Windows.Forms.TextBox();
            this.postSupTextBox = new System.Windows.Forms.TextBox();
            this.fullnameBuyerTextBox = new System.Windows.Forms.TextBox();
            this.postBuyTextBox = new System.Windows.Forms.TextBox();
            this.dogovorPostBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dogovorPostBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dogovorPostTableAdapter = new Пользователь.ПользовательDataSetTableAdapters.DogovorPostTableAdapter();
            this.tableAdapterManager = new Пользователь.ПользовательDataSetTableAdapters.TableAdapterManager();
            this.dovorPostPTableAdapter = new Пользователь.ПользовательDataSetTableAdapters.DovorPostPTableAdapter();
            cityLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            fullnameSupplierLabel = new System.Windows.Forms.Label();
            postSupLabel = new System.Windows.Forms.Label();
            fullnameBuyerLabel = new System.Windows.Forms.Label();
            postBuyLabel = new System.Windows.Forms.Label();
            name1Label = new System.Windows.Forms.Label();
            quantity1Label = new System.Windows.Forms.Label();
            individFoatProduct1Label = new System.Windows.Forms.Label();
            c1Label = new System.Windows.Forms.Label();
            po1Label = new System.Windows.Forms.Label();
            name2Label = new System.Windows.Forms.Label();
            quantity2Label = new System.Windows.Forms.Label();
            individFoatProduct2Label = new System.Windows.Forms.Label();
            c2Label = new System.Windows.Forms.Label();
            po2Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dovorPostPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingNavigator)).BeginInit();
            this.dogovorPostBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(3, 36);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(40, 13);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "Город:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(467, 36);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Дата:";
            // 
            // fullnameSupplierLabel
            // 
            fullnameSupplierLabel.AutoSize = true;
            fullnameSupplierLabel.Location = new System.Drawing.Point(304, 86);
            fullnameSupplierLabel.Name = "fullnameSupplierLabel";
            fullnameSupplierLabel.Size = new System.Drawing.Size(233, 13);
            fullnameSupplierLabel.TabIndex = 4;
            fullnameSupplierLabel.Text = "Именуемый(ая) в дальнейшем \"Поставщик\"";
            // 
            // postSupLabel
            // 
            postSupLabel.AutoSize = true;
            postSupLabel.Location = new System.Drawing.Point(12, 121);
            postSupLabel.Name = "postSupLabel";
            postSupLabel.Size = new System.Drawing.Size(111, 13);
            postSupLabel.TabIndex = 6;
            postSupLabel.Text = "В лице (Должность):";
            // 
            // fullnameBuyerLabel
            // 
            fullnameBuyerLabel.AutoSize = true;
            fullnameBuyerLabel.Location = new System.Drawing.Point(304, 158);
            fullnameBuyerLabel.Name = "fullnameBuyerLabel";
            fullnameBuyerLabel.Size = new System.Drawing.Size(265, 13);
            fullnameBuyerLabel.TabIndex = 8;
            fullnameBuyerLabel.Text = "Именуемый(ая) себя в дальнейшем \"Покупатель\":";
            // 
            // postBuyLabel
            // 
            postBuyLabel.AutoSize = true;
            postBuyLabel.Location = new System.Drawing.Point(12, 200);
            postBuyLabel.Name = "postBuyLabel";
            postBuyLabel.Size = new System.Drawing.Size(108, 13);
            postBuyLabel.TabIndex = 10;
            postBuyLabel.Text = "В лице (должность):";
            // 
            // name1Label
            // 
            name1Label.AutoSize = true;
            name1Label.Location = new System.Drawing.Point(12, 334);
            name1Label.Name = "name1Label";
            name1Label.Size = new System.Drawing.Size(86, 13);
            name1Label.TabIndex = 12;
            name1Label.Text = "Наименование:";
            // 
            // quantity1Label
            // 
            quantity1Label.AutoSize = true;
            quantity1Label.Location = new System.Drawing.Point(368, 334);
            quantity1Label.Name = "quantity1Label";
            quantity1Label.Size = new System.Drawing.Size(69, 13);
            quantity1Label.TabIndex = 14;
            quantity1Label.Text = "Количество:";
            // 
            // individFoatProduct1Label
            // 
            individFoatProduct1Label.AutoSize = true;
            individFoatProduct1Label.Location = new System.Drawing.Point(12, 368);
            individFoatProduct1Label.Name = "individFoatProduct1Label";
            individFoatProduct1Label.Size = new System.Drawing.Size(218, 13);
            individFoatProduct1Label.TabIndex = 16;
            individFoatProduct1Label.Text = "Индивидуализирующие признаки товара:";
            // 
            // c1Label
            // 
            c1Label.AutoSize = true;
            c1Label.Location = new System.Drawing.Point(470, 368);
            c1Label.Name = "c1Label";
            c1Label.Size = new System.Drawing.Size(17, 13);
            c1Label.TabIndex = 18;
            c1Label.Text = "С:";
            // 
            // po1Label
            // 
            po1Label.AutoSize = true;
            po1Label.Location = new System.Drawing.Point(621, 368);
            po1Label.Name = "po1Label";
            po1Label.Size = new System.Drawing.Size(26, 13);
            po1Label.TabIndex = 20;
            po1Label.Text = "ПО:";
            // 
            // name2Label
            // 
            name2Label.AutoSize = true;
            name2Label.Location = new System.Drawing.Point(12, 428);
            name2Label.Name = "name2Label";
            name2Label.Size = new System.Drawing.Size(86, 13);
            name2Label.TabIndex = 22;
            name2Label.Text = "Наименование:";
            // 
            // quantity2Label
            // 
            quantity2Label.AutoSize = true;
            quantity2Label.Location = new System.Drawing.Point(368, 428);
            quantity2Label.Name = "quantity2Label";
            quantity2Label.Size = new System.Drawing.Size(69, 13);
            quantity2Label.TabIndex = 24;
            quantity2Label.Text = "Количество:";
            // 
            // individFoatProduct2Label
            // 
            individFoatProduct2Label.AutoSize = true;
            individFoatProduct2Label.Location = new System.Drawing.Point(12, 464);
            individFoatProduct2Label.Name = "individFoatProduct2Label";
            individFoatProduct2Label.Size = new System.Drawing.Size(218, 13);
            individFoatProduct2Label.TabIndex = 26;
            individFoatProduct2Label.Text = "Индивидуализирующие признаки товара:";
            // 
            // c2Label
            // 
            c2Label.AutoSize = true;
            c2Label.Location = new System.Drawing.Point(470, 464);
            c2Label.Name = "c2Label";
            c2Label.Size = new System.Drawing.Size(17, 13);
            c2Label.TabIndex = 28;
            c2Label.Text = "С:";
            // 
            // po2Label
            // 
            po2Label.AutoSize = true;
            po2Label.Location = new System.Drawing.Point(621, 464);
            po2Label.Name = "po2Label";
            po2Label.Size = new System.Drawing.Size(26, 13);
            po2Label.TabIndex = 30;
            po2Label.Text = "ПО:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(name1Label);
            this.panel1.Controls.Add(this.name1TextBox);
            this.panel1.Controls.Add(quantity1Label);
            this.panel1.Controls.Add(this.quantity1TextBox);
            this.panel1.Controls.Add(individFoatProduct1Label);
            this.panel1.Controls.Add(this.individFoatProduct1TextBox);
            this.panel1.Controls.Add(c1Label);
            this.panel1.Controls.Add(this.c1DateTimePicker);
            this.panel1.Controls.Add(po1Label);
            this.panel1.Controls.Add(this.po1DateTimePicker);
            this.panel1.Controls.Add(name2Label);
            this.panel1.Controls.Add(this.name2TextBox);
            this.panel1.Controls.Add(quantity2Label);
            this.panel1.Controls.Add(this.quantity2TextBox);
            this.panel1.Controls.Add(individFoatProduct2Label);
            this.panel1.Controls.Add(this.individFoatProduct2TextBox);
            this.panel1.Controls.Add(c2Label);
            this.panel1.Controls.Add(this.c2DateTimePicker);
            this.panel1.Controls.Add(po2Label);
            this.panel1.Controls.Add(this.po2DateTimePicker);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(dateLabel);
            this.panel1.Controls.Add(this.dateDateTimePicker);
            this.panel1.Controls.Add(fullnameSupplierLabel);
            this.panel1.Controls.Add(this.fullnameSupplierTextBox);
            this.panel1.Controls.Add(postSupLabel);
            this.panel1.Controls.Add(this.postSupTextBox);
            this.panel1.Controls.Add(fullnameBuyerLabel);
            this.panel1.Controls.Add(this.fullnameBuyerTextBox);
            this.panel1.Controls.Add(postBuyLabel);
            this.panel1.Controls.Add(this.postBuyTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 504);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Партия2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Партия1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Стороны согласовали следующие сроки поставки продукции/товаров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "Стороны Совместно заключили договор, о нижеследующем:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "С одной стороны,";
            // 
            // name1TextBox
            // 
            this.name1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dovorPostPBindingSource, "Name1", true));
            this.name1TextBox.Location = new System.Drawing.Point(104, 331);
            this.name1TextBox.Name = "name1TextBox";
            this.name1TextBox.Size = new System.Drawing.Size(258, 20);
            this.name1TextBox.TabIndex = 13;
            // 
            // dovorPostPBindingSource
            // 
            this.dovorPostPBindingSource.DataMember = "DovorPostP";
            this.dovorPostPBindingSource.DataSource = this.пользовательDataSet;
            // 
            // пользовательDataSet
            // 
            this.пользовательDataSet.DataSetName = "ПользовательDataSet";
            this.пользовательDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quantity1TextBox
            // 
            this.quantity1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dovorPostPBindingSource, "Quantity1", true));
            this.quantity1TextBox.Location = new System.Drawing.Point(443, 331);
            this.quantity1TextBox.Name = "quantity1TextBox";
            this.quantity1TextBox.Size = new System.Drawing.Size(94, 20);
            this.quantity1TextBox.TabIndex = 15;
            // 
            // individFoatProduct1TextBox
            // 
            this.individFoatProduct1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dovorPostPBindingSource, "IndividFoatProduct1", true));
            this.individFoatProduct1TextBox.Location = new System.Drawing.Point(236, 365);
            this.individFoatProduct1TextBox.Name = "individFoatProduct1TextBox";
            this.individFoatProduct1TextBox.Size = new System.Drawing.Size(228, 20);
            this.individFoatProduct1TextBox.TabIndex = 17;
            // 
            // c1DateTimePicker
            // 
            this.c1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dovorPostPBindingSource, "c1", true));
            this.c1DateTimePicker.Location = new System.Drawing.Point(493, 365);
            this.c1DateTimePicker.Name = "c1DateTimePicker";
            this.c1DateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.c1DateTimePicker.TabIndex = 19;
            // 
            // po1DateTimePicker
            // 
            this.po1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dovorPostPBindingSource, "Po1", true));
            this.po1DateTimePicker.Location = new System.Drawing.Point(653, 365);
            this.po1DateTimePicker.Name = "po1DateTimePicker";
            this.po1DateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.po1DateTimePicker.TabIndex = 21;
            // 
            // name2TextBox
            // 
            this.name2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dovorPostPBindingSource, "Name2", true));
            this.name2TextBox.Location = new System.Drawing.Point(104, 425);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(258, 20);
            this.name2TextBox.TabIndex = 23;
            // 
            // quantity2TextBox
            // 
            this.quantity2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dovorPostPBindingSource, "Quantity2", true));
            this.quantity2TextBox.Location = new System.Drawing.Point(443, 425);
            this.quantity2TextBox.Name = "quantity2TextBox";
            this.quantity2TextBox.Size = new System.Drawing.Size(103, 20);
            this.quantity2TextBox.TabIndex = 25;
            // 
            // individFoatProduct2TextBox
            // 
            this.individFoatProduct2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dovorPostPBindingSource, "IndividFoatProduct2", true));
            this.individFoatProduct2TextBox.Location = new System.Drawing.Point(236, 461);
            this.individFoatProduct2TextBox.Name = "individFoatProduct2TextBox";
            this.individFoatProduct2TextBox.Size = new System.Drawing.Size(228, 20);
            this.individFoatProduct2TextBox.TabIndex = 27;
            // 
            // c2DateTimePicker
            // 
            this.c2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dovorPostPBindingSource, "c2", true));
            this.c2DateTimePicker.Location = new System.Drawing.Point(498, 461);
            this.c2DateTimePicker.Name = "c2DateTimePicker";
            this.c2DateTimePicker.Size = new System.Drawing.Size(117, 20);
            this.c2DateTimePicker.TabIndex = 29;
            // 
            // po2DateTimePicker
            // 
            this.po2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dovorPostPBindingSource, "Po2", true));
            this.po2DateTimePicker.Location = new System.Drawing.Point(653, 461);
            this.po2DateTimePicker.Name = "po2DateTimePicker";
            this.po2DateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.po2DateTimePicker.TabIndex = 31;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPostBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(49, 33);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 1;
            // 
            // dogovorPostBindingSource
            // 
            this.dogovorPostBindingSource.DataMember = "DogovorPost";
            this.dogovorPostBindingSource.DataSource = this.пользовательDataSet;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dogovorPostBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(506, 33);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // fullnameSupplierTextBox
            // 
            this.fullnameSupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPostBindingSource, "FullnameSupplier", true));
            this.fullnameSupplierTextBox.Location = new System.Drawing.Point(49, 83);
            this.fullnameSupplierTextBox.Name = "fullnameSupplierTextBox";
            this.fullnameSupplierTextBox.Size = new System.Drawing.Size(249, 20);
            this.fullnameSupplierTextBox.TabIndex = 5;
            // 
            // postSupTextBox
            // 
            this.postSupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPostBindingSource, "PostSup", true));
            this.postSupTextBox.Location = new System.Drawing.Point(126, 118);
            this.postSupTextBox.Name = "postSupTextBox";
            this.postSupTextBox.Size = new System.Drawing.Size(236, 20);
            this.postSupTextBox.TabIndex = 7;
            // 
            // fullnameBuyerTextBox
            // 
            this.fullnameBuyerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPostBindingSource, "FullnameBuyer", true));
            this.fullnameBuyerTextBox.Location = new System.Drawing.Point(49, 155);
            this.fullnameBuyerTextBox.Name = "fullnameBuyerTextBox";
            this.fullnameBuyerTextBox.Size = new System.Drawing.Size(249, 20);
            this.fullnameBuyerTextBox.TabIndex = 9;
            // 
            // postBuyTextBox
            // 
            this.postBuyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPostBindingSource, "PostBuy", true));
            this.postBuyTextBox.Location = new System.Drawing.Point(126, 200);
            this.postBuyTextBox.Name = "postBuyTextBox";
            this.postBuyTextBox.Size = new System.Drawing.Size(236, 20);
            this.postBuyTextBox.TabIndex = 11;
            // 
            // dogovorPostBindingNavigator
            // 
            this.dogovorPostBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dogovorPostBindingNavigator.BindingSource = this.dogovorPostBindingSource;
            this.dogovorPostBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dogovorPostBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dogovorPostBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dogovorPostBindingNavigatorSaveItem});
            this.dogovorPostBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dogovorPostBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dogovorPostBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dogovorPostBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dogovorPostBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dogovorPostBindingNavigator.Name = "dogovorPostBindingNavigator";
            this.dogovorPostBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dogovorPostBindingNavigator.Size = new System.Drawing.Size(801, 25);
            this.dogovorPostBindingNavigator.TabIndex = 1;
            this.dogovorPostBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dogovorPostBindingNavigatorSaveItem
            // 
            this.dogovorPostBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dogovorPostBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dogovorPostBindingNavigatorSaveItem.Image")));
            this.dogovorPostBindingNavigatorSaveItem.Name = "dogovorPostBindingNavigatorSaveItem";
            this.dogovorPostBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dogovorPostBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.dogovorPostBindingNavigatorSaveItem.Click += new System.EventHandler(this.dogovorPostBindingNavigatorSaveItem_Click);
            // 
            // dogovorPostTableAdapter
            // 
            this.dogovorPostTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DogovorAutoTableAdapter = null;
            this.tableAdapterManager.DogovorPostTableAdapter = this.dogovorPostTableAdapter;
            this.tableAdapterManager.DogovorPredTableAdapter = null;
            this.tableAdapterManager.DovorPostPTableAdapter = this.dovorPostPTableAdapter;
            this.tableAdapterManager.UpdateOrder = Пользователь.ПользовательDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dovorPostPTableAdapter
            // 
            this.dovorPostPTableAdapter.ClearBeforeFill = true;
            // 
            // DogovorPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 504);
            this.Controls.Add(this.dogovorPostBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "DogovorPostForm";
            this.Text = "DogovorPostForm";
            this.Load += new System.EventHandler(this.DogovorPostForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dovorPostPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingNavigator)).EndInit();
            this.dogovorPostBindingNavigator.ResumeLayout(false);
            this.dogovorPostBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ПользовательDataSet пользовательDataSet;
        private System.Windows.Forms.BindingSource dogovorPostBindingSource;
        private ПользовательDataSetTableAdapters.DogovorPostTableAdapter dogovorPostTableAdapter;
        private ПользовательDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dogovorPostBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dogovorPostBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox fullnameSupplierTextBox;
        private System.Windows.Forms.TextBox postSupTextBox;
        private System.Windows.Forms.TextBox fullnameBuyerTextBox;
        private System.Windows.Forms.TextBox postBuyTextBox;
        private ПользовательDataSetTableAdapters.DovorPostPTableAdapter dovorPostPTableAdapter;
        private System.Windows.Forms.BindingSource dovorPostPBindingSource;
        private System.Windows.Forms.TextBox name1TextBox;
        private System.Windows.Forms.TextBox quantity1TextBox;
        private System.Windows.Forms.TextBox individFoatProduct1TextBox;
        private System.Windows.Forms.DateTimePicker c1DateTimePicker;
        private System.Windows.Forms.DateTimePicker po1DateTimePicker;
        private System.Windows.Forms.TextBox name2TextBox;
        private System.Windows.Forms.TextBox quantity2TextBox;
        private System.Windows.Forms.TextBox individFoatProduct2TextBox;
        private System.Windows.Forms.DateTimePicker c2DateTimePicker;
        private System.Windows.Forms.DateTimePicker po2DateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}