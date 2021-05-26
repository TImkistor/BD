
namespace WindowsFormsApp3
{
    partial class Postavshiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavshiki));
            this._Индивидуальное_задание_25_04DataSet1 = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1();
            this.postavshchikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshchikiTableAdapter = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.PostavshchikiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager();
            this.postavshchikiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postavshchikiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.postavshchikiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikiBindingNavigator)).BeginInit();
            this.postavshchikiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _Индивидуальное_задание_25_04DataSet1
            // 
            this._Индивидуальное_задание_25_04DataSet1.DataSetName = "_Индивидуальное_задание_25_04DataSet1";
            this._Индивидуальное_задание_25_04DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavshchikiBindingSource
            // 
            this.postavshchikiBindingSource.DataMember = "Postavshchiki";
            this.postavshchikiBindingSource.DataSource = this._Индивидуальное_задание_25_04DataSet1;
            // 
            // postavshchikiTableAdapter
            // 
            this.postavshchikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialyTableAdapter = null;
            this.tableAdapterManager.Kategoriya_sotrudnikovTableAdapter = null;
            this.tableAdapterManager.KioskTableAdapter = null;
            this.tableAdapterManager.OborudovaniyeTableAdapter = null;
            this.tableAdapterManager.PostavkaTableAdapter = null;
            this.tableAdapterManager.PostavshchikiTableAdapter = this.postavshchikiTableAdapter;
            this.tableAdapterManager.ProdazhaTableAdapter = null;
            this.tableAdapterManager.Raspredeleniye_tovarovTableAdapter = null;
            this.tableAdapterManager.SkidkaTableAdapter = null;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.Tip_zakazaTableAdapter = null;
            this.tableAdapterManager.TovaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vypolneniye_uslugiTableAdapter = null;
            // 
            // postavshchikiBindingNavigator
            // 
            this.postavshchikiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postavshchikiBindingNavigator.BindingSource = this.postavshchikiBindingSource;
            this.postavshchikiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postavshchikiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postavshchikiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.postavshchikiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postavshchikiBindingNavigatorSaveItem});
            this.postavshchikiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postavshchikiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postavshchikiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postavshchikiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postavshchikiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postavshchikiBindingNavigator.Name = "postavshchikiBindingNavigator";
            this.postavshchikiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postavshchikiBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.postavshchikiBindingNavigator.TabIndex = 0;
            this.postavshchikiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // postavshchikiDataGridView
            // 
            this.postavshchikiDataGridView.AutoGenerateColumns = false;
            this.postavshchikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavshchikiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.postavshchikiDataGridView.DataSource = this.postavshchikiBindingSource;
            this.postavshchikiDataGridView.Location = new System.Drawing.Point(12, 34);
            this.postavshchikiDataGridView.Name = "postavshchikiDataGridView";
            this.postavshchikiDataGridView.RowHeadersWidth = 51;
            this.postavshchikiDataGridView.Size = new System.Drawing.Size(431, 220);
            this.postavshchikiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Postavshchiki";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Postavshchiki";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naimenovaniye";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naimenovaniye";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // postavshchikiBindingNavigatorSaveItem
            // 
            this.postavshchikiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postavshchikiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postavshchikiBindingNavigatorSaveItem.Image")));
            this.postavshchikiBindingNavigatorSaveItem.Name = "postavshchikiBindingNavigatorSaveItem";
            this.postavshchikiBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.postavshchikiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postavshchikiBindingNavigatorSaveItem.Click += new System.EventHandler(this.postavshchikiBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Postavshiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.postavshchikiDataGridView);
            this.Controls.Add(this.postavshchikiBindingNavigator);
            this.Name = "Postavshiki";
            this.Text = "Postavshiki";
            this.Load += new System.EventHandler(this.Postavshiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikiBindingNavigator)).EndInit();
            this.postavshchikiBindingNavigator.ResumeLayout(false);
            this.postavshchikiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavshchikiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Индивидуальное_задание_25_04DataSet1 _Индивидуальное_задание_25_04DataSet1;
        private System.Windows.Forms.BindingSource postavshchikiBindingSource;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.PostavshchikiTableAdapter postavshchikiTableAdapter;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postavshchikiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postavshchikiBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView postavshchikiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}