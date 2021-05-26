
namespace WindowsFormsApp3
{
    partial class Kiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kiosk));
            this.kioskTableAdapter1 = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSetTableAdapters.KioskTableAdapter();
            this._Индивидуальное_задание_25_04DataSet1 = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1();
            this.kioskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kioskTableAdapter = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.KioskTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager();
            this.kioskBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kioskDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.kioskBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingNavigator)).BeginInit();
            this.kioskBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kioskDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kioskTableAdapter1
            // 
            this.kioskTableAdapter1.ClearBeforeFill = true;
            // 
            // _Индивидуальное_задание_25_04DataSet1
            // 
            this._Индивидуальное_задание_25_04DataSet1.DataSetName = "_Индивидуальное_задание_25_04DataSet1";
            this._Индивидуальное_задание_25_04DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kioskBindingSource
            // 
            this.kioskBindingSource.DataMember = "Kiosk";
            this.kioskBindingSource.DataSource = this._Индивидуальное_задание_25_04DataSet1;
            // 
            // kioskTableAdapter
            // 
            this.kioskTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialyTableAdapter = null;
            this.tableAdapterManager.Kategoriya_sotrudnikovTableAdapter = null;
            this.tableAdapterManager.KioskTableAdapter = this.kioskTableAdapter;
            this.tableAdapterManager.OborudovaniyeTableAdapter = null;
            this.tableAdapterManager.PostavkaTableAdapter = null;
            this.tableAdapterManager.PostavshchikiTableAdapter = null;
            this.tableAdapterManager.ProdazhaTableAdapter = null;
            this.tableAdapterManager.Raspredeleniye_tovarovTableAdapter = null;
            this.tableAdapterManager.SkidkaTableAdapter = null;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.Tip_zakazaTableAdapter = null;
            this.tableAdapterManager.TovaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vypolneniye_uslugiTableAdapter = null;
            // 
            // kioskBindingNavigator
            // 
            this.kioskBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kioskBindingNavigator.BindingSource = this.kioskBindingSource;
            this.kioskBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kioskBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kioskBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kioskBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kioskBindingNavigatorSaveItem});
            this.kioskBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kioskBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kioskBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kioskBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kioskBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kioskBindingNavigator.Name = "kioskBindingNavigator";
            this.kioskBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kioskBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.kioskBindingNavigator.TabIndex = 0;
            this.kioskBindingNavigator.Text = "bindingNavigator1";
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
            // kioskDataGridView
            // 
            this.kioskDataGridView.AutoGenerateColumns = false;
            this.kioskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kioskDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.kioskDataGridView.DataSource = this.kioskBindingSource;
            this.kioskDataGridView.Location = new System.Drawing.Point(0, 30);
            this.kioskDataGridView.Name = "kioskDataGridView";
            this.kioskDataGridView.RowHeadersWidth = 51;
            this.kioskDataGridView.Size = new System.Drawing.Size(430, 454);
            this.kioskDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Kiosk";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Kiosk";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Adres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nazvaniye";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazvaniye";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // kioskBindingNavigatorSaveItem
            // 
            this.kioskBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kioskBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kioskBindingNavigatorSaveItem.Image")));
            this.kioskBindingNavigatorSaveItem.Name = "kioskBindingNavigatorSaveItem";
            this.kioskBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.kioskBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kioskBindingNavigatorSaveItem.Click += new System.EventHandler(this.kioskBindingNavigatorSaveItem_Click);
            // 
            // Kiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kioskDataGridView);
            this.Controls.Add(this.kioskBindingNavigator);
            this.Name = "Kiosk";
            this.Text = "Kiosk";
            this.Load += new System.EventHandler(this.Kiosk_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kioskBindingNavigator)).EndInit();
            this.kioskBindingNavigator.ResumeLayout(false);
            this.kioskBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kioskDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Индивидуальное_задание_25_04DataSetTableAdapters.KioskTableAdapter kioskTableAdapter1;
        private _Индивидуальное_задание_25_04DataSet1 _Индивидуальное_задание_25_04DataSet1;
        private System.Windows.Forms.BindingSource kioskBindingSource;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.KioskTableAdapter kioskTableAdapter;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kioskBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kioskBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kioskDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}