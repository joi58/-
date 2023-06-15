namespace Пользователь
{
    partial class DogovotPredpriytia
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label nameOrgLabel;
            System.Windows.Forms.Label fullnameLandLabel;
            System.Windows.Forms.Label nameOrgaLabel;
            System.Windows.Forms.Label fullnameTenatsLabel;
            System.Windows.Forms.Label landPlotLabel;
            System.Windows.Forms.Label buildingLabel;
            System.Windows.Forms.Label structuresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogovotPredpriytia));
            this.пользовательDataSet = new Пользователь.ПользовательDataSet();
            this.dogovorPostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dogovorPostTableAdapter = new Пользователь.ПользовательDataSetTableAdapters.DogovorPostTableAdapter();
            this.tableAdapterManager = new Пользователь.ПользовательDataSetTableAdapters.TableAdapterManager();
            this.dogovorPredTableAdapter = new Пользователь.ПользовательDataSetTableAdapters.DogovorPredTableAdapter();
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
            this.dogovorPredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameOrgTextBox = new System.Windows.Forms.TextBox();
            this.fullnameLandTextBox = new System.Windows.Forms.TextBox();
            this.nameOrgaTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTenatsTextBox = new System.Windows.Forms.TextBox();
            this.landPlotTextBox = new System.Windows.Forms.TextBox();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.structuresTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            nameOrgLabel = new System.Windows.Forms.Label();
            fullnameLandLabel = new System.Windows.Forms.Label();
            nameOrgaLabel = new System.Windows.Forms.Label();
            fullnameTenatsLabel = new System.Windows.Forms.Label();
            landPlotLabel = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            structuresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingNavigator)).BeginInit();
            this.dogovorPostBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPredBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 36);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 1;
            cityLabel.Text = "City:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(342, 36);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // nameOrgLabel
            // 
            nameOrgLabel.AutoSize = true;
            nameOrgLabel.Location = new System.Drawing.Point(12, 71);
            nameOrgLabel.Name = "nameOrgLabel";
            nameOrgLabel.Size = new System.Drawing.Size(156, 13);
            nameOrgLabel.TabIndex = 5;
            nameOrgLabel.Text = "ООО (название организации)";
            // 
            // fullnameLandLabel
            // 
            fullnameLandLabel.AutoSize = true;
            fullnameLandLabel.Location = new System.Drawing.Point(12, 97);
            fullnameLandLabel.Name = "fullnameLandLabel";
            fullnameLandLabel.Size = new System.Drawing.Size(206, 13);
            fullnameLandLabel.TabIndex = 7;
            fullnameLandLabel.Text = "В лице генерального директора(ФИО):";
            // 
            // nameOrgaLabel
            // 
            nameOrgaLabel.AutoSize = true;
            nameOrgaLabel.Location = new System.Drawing.Point(12, 123);
            nameOrgaLabel.Name = "nameOrgaLabel";
            nameOrgaLabel.Size = new System.Drawing.Size(123, 13);
            nameOrgaLabel.TabIndex = 9;
            nameOrgaLabel.Text = "С одной стороны ООО:";
            // 
            // fullnameTenatsLabel
            // 
            fullnameTenatsLabel.AutoSize = true;
            fullnameTenatsLabel.Location = new System.Drawing.Point(12, 152);
            fullnameTenatsLabel.Name = "fullnameTenatsLabel";
            fullnameTenatsLabel.Size = new System.Drawing.Size(173, 13);
            fullnameTenatsLabel.TabIndex = 11;
            fullnameTenatsLabel.Text = "В лице генерального директора:";
            // 
            // landPlotLabel
            // 
            landPlotLabel.AutoSize = true;
            landPlotLabel.Location = new System.Drawing.Point(12, 209);
            landPlotLabel.Name = "landPlotLabel";
            landPlotLabel.Size = new System.Drawing.Size(103, 13);
            landPlotLabel.TabIndex = 13;
            landPlotLabel.Text = "Земляной участок:";
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Location = new System.Drawing.Point(12, 239);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(47, 13);
            buildingLabel.TabIndex = 15;
            buildingLabel.Text = "Здание:";
            // 
            // structuresLabel
            // 
            structuresLabel.AutoSize = true;
            structuresLabel.Location = new System.Drawing.Point(12, 265);
            structuresLabel.Name = "structuresLabel";
            structuresLabel.Size = new System.Drawing.Size(72, 13);
            structuresLabel.TabIndex = 17;
            structuresLabel.Text = "Сооружение:";
            // 
            // пользовательDataSet
            // 
            this.пользовательDataSet.DataSetName = "ПользовательDataSet";
            this.пользовательDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogovorPostBindingSource
            // 
            this.dogovorPostBindingSource.DataMember = "DogovorPost";
            this.dogovorPostBindingSource.DataSource = this.пользовательDataSet;
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
            this.tableAdapterManager.DogovorPredTableAdapter = this.dogovorPredTableAdapter;
            this.tableAdapterManager.DovorPostPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Пользователь.ПользовательDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dogovorPredTableAdapter
            // 
            this.dogovorPredTableAdapter.ClearBeforeFill = true;
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
            this.dogovorPostBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.dogovorPostBindingNavigator.TabIndex = 0;
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
            // dogovorPredBindingSource
            // 
            this.dogovorPredBindingSource.DataMember = "DogovorPred";
            this.dogovorPredBindingSource.DataSource = this.пользовательDataSet;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(45, 33);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 2;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dogovorPredBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(381, 33);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // nameOrgTextBox
            // 
            this.nameOrgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "NameOrg", true));
            this.nameOrgTextBox.Location = new System.Drawing.Point(171, 68);
            this.nameOrgTextBox.Name = "nameOrgTextBox";
            this.nameOrgTextBox.Size = new System.Drawing.Size(241, 20);
            this.nameOrgTextBox.TabIndex = 6;
            // 
            // fullnameLandTextBox
            // 
            this.fullnameLandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "FullnameLand", true));
            this.fullnameLandTextBox.Location = new System.Drawing.Point(224, 94);
            this.fullnameLandTextBox.Name = "fullnameLandTextBox";
            this.fullnameLandTextBox.Size = new System.Drawing.Size(200, 20);
            this.fullnameLandTextBox.TabIndex = 8;
            // 
            // nameOrgaTextBox
            // 
            this.nameOrgaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "NameOrga", true));
            this.nameOrgaTextBox.Location = new System.Drawing.Point(141, 120);
            this.nameOrgaTextBox.Name = "nameOrgaTextBox";
            this.nameOrgaTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameOrgaTextBox.TabIndex = 10;
            // 
            // fullnameTenatsTextBox
            // 
            this.fullnameTenatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "FullnameTenats", true));
            this.fullnameTenatsTextBox.Location = new System.Drawing.Point(191, 149);
            this.fullnameTenatsTextBox.Name = "fullnameTenatsTextBox";
            this.fullnameTenatsTextBox.Size = new System.Drawing.Size(233, 20);
            this.fullnameTenatsTextBox.TabIndex = 12;
            // 
            // landPlotTextBox
            // 
            this.landPlotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "LandPlot", true));
            this.landPlotTextBox.Location = new System.Drawing.Point(121, 206);
            this.landPlotTextBox.Name = "landPlotTextBox";
            this.landPlotTextBox.Size = new System.Drawing.Size(200, 20);
            this.landPlotTextBox.TabIndex = 14;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "Building", true));
            this.buildingTextBox.Location = new System.Drawing.Point(121, 232);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(200, 20);
            this.buildingTextBox.TabIndex = 16;
            // 
            // structuresTextBox
            // 
            this.structuresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovorPredBindingSource, "Structures", true));
            this.structuresTextBox.Location = new System.Drawing.Point(121, 258);
            this.structuresTextBox.Name = "structuresTextBox";
            this.structuresTextBox.Size = new System.Drawing.Size(200, 20);
            this.structuresTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Именуемый(ая) в дальнейшем \"Арендодатель\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Действующего на основании Устава,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Именумый(ая) в дальнейшем \"Арендатор\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "действущего на";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(508, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "основании Устава с другой стороны, заключили договор аренды предприятия о нижесле" +
    "дующем:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 24;
            // 
            // DogovotPredpriytia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(nameOrgLabel);
            this.Controls.Add(this.nameOrgTextBox);
            this.Controls.Add(fullnameLandLabel);
            this.Controls.Add(this.fullnameLandTextBox);
            this.Controls.Add(nameOrgaLabel);
            this.Controls.Add(this.nameOrgaTextBox);
            this.Controls.Add(fullnameTenatsLabel);
            this.Controls.Add(this.fullnameTenatsTextBox);
            this.Controls.Add(landPlotLabel);
            this.Controls.Add(this.landPlotTextBox);
            this.Controls.Add(buildingLabel);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(structuresLabel);
            this.Controls.Add(this.structuresTextBox);
            this.Controls.Add(this.dogovorPostBindingNavigator);
            this.Name = "DogovotPredpriytia";
            this.Text = "DogovotPredpriytia";
            this.Load += new System.EventHandler(this.DogovotPredpriytia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пользовательDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPostBindingNavigator)).EndInit();
            this.dogovorPostBindingNavigator.ResumeLayout(false);
            this.dogovorPostBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorPredBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private ПользовательDataSetTableAdapters.DogovorPredTableAdapter dogovorPredTableAdapter;
        private System.Windows.Forms.BindingSource dogovorPredBindingSource;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox nameOrgTextBox;
        private System.Windows.Forms.TextBox fullnameLandTextBox;
        private System.Windows.Forms.TextBox nameOrgaTextBox;
        private System.Windows.Forms.TextBox fullnameTenatsTextBox;
        private System.Windows.Forms.TextBox landPlotTextBox;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox structuresTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}