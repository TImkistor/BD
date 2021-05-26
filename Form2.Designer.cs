
namespace WindowsFormsApp3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this._Индивидуальное_задание_25_04DataSet1 = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1();
            this.kategoriya_sotrudnikovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategoriya_sotrudnikovTableAdapter = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.Kategoriya_sotrudnikovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager();
            this.kategoriya_sotrudnikovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kategoriya_sotrudnikovDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriya_sotrudnikovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriya_sotrudnikovBindingNavigator)).BeginInit();
            this.kategoriya_sotrudnikovBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriya_sotrudnikovDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _Индивидуальное_задание_25_04DataSet1
            // 
            this._Индивидуальное_задание_25_04DataSet1.DataSetName = "_Индивидуальное_задание_25_04DataSet1";
            this._Индивидуальное_задание_25_04DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategoriya_sotrudnikovBindingSource
            // 
            this.kategoriya_sotrudnikovBindingSource.DataMember = "Kategoriya sotrudnikov";
            this.kategoriya_sotrudnikovBindingSource.DataSource = this._Индивидуальное_задание_25_04DataSet1;
            // 
            // kategoriya_sotrudnikovTableAdapter
            // 
            this.kategoriya_sotrudnikovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialyTableAdapter = null;
            this.tableAdapterManager.Kategoriya_sotrudnikovTableAdapter = this.kategoriya_sotrudnikovTableAdapter;
            this.tableAdapterManager.KioskTableAdapter = null;
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
            // kategoriya_sotrudnikovBindingNavigator
            // 
            this.kategoriya_sotrudnikovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kategoriya_sotrudnikovBindingNavigator.BindingSource = this.kategoriya_sotrudnikovBindingSource;
            this.kategoriya_sotrudnikovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kategoriya_sotrudnikovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kategoriya_sotrudnikovBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kategoriya_sotrudnikovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem});
            this.kategoriya_sotrudnikovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kategoriya_sotrudnikovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kategoriya_sotrudnikovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kategoriya_sotrudnikovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kategoriya_sotrudnikovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kategoriya_sotrudnikovBindingNavigator.Name = "kategoriya_sotrudnikovBindingNavigator";
            this.kategoriya_sotrudnikovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kategoriya_sotrudnikovBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.kategoriya_sotrudnikovBindingNavigator.TabIndex = 1;
            this.kategoriya_sotrudnikovBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // kategoriya_sotrudnikovBindingNavigatorSaveItem
            // 
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kategoriya_sotrudnikovBindingNavigatorSaveItem.Image")));
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem.Name = "kategoriya_sotrudnikovBindingNavigatorSaveItem";
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kategoriya_sotrudnikovBindingNavigatorSaveItem.Click += new System.EventHandler(this.kategoriya_sotrudnikovBindingNavigatorSaveItem_Click);
            // 
            // kategoriya_sotrudnikovDataGridView
            // 
            this.kategoriya_sotrudnikovDataGridView.AutoGenerateColumns = false;
            this.kategoriya_sotrudnikovDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategoriya_sotrudnikovDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kategoriya_sotrudnikovDataGridView.DataSource = this.kategoriya_sotrudnikovBindingSource;
            this.kategoriya_sotrudnikovDataGridView.Location = new System.Drawing.Point(12, 32);
            this.kategoriya_sotrudnikovDataGridView.Name = "kategoriya_sotrudnikovDataGridView";
            this.kategoriya_sotrudnikovDataGridView.RowHeadersWidth = 51;
            this.kategoriya_sotrudnikovDataGridView.Size = new System.Drawing.Size(556, 453);
            this.kategoriya_sotrudnikovDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Kategoriya";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Kategoriya";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Sotrudnikov";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Sotrudnikov";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ZP";
            this.dataGridViewTextBoxColumn3.HeaderText = "ZP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Naimenovaniye";
            this.dataGridViewTextBoxColumn4.HeaderText = "Naimenovaniye";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 638);
            this.Controls.Add(this.kategoriya_sotrudnikovDataGridView);
            this.Controls.Add(this.kategoriya_sotrudnikovBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriya_sotrudnikovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriya_sotrudnikovBindingNavigator)).EndInit();
            this.kategoriya_sotrudnikovBindingNavigator.ResumeLayout(false);
            this.kategoriya_sotrudnikovBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriya_sotrudnikovDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private _Индивидуальное_задание_25_04DataSet1 _Индивидуальное_задание_25_04DataSet1;
        private System.Windows.Forms.BindingSource kategoriya_sotrudnikovBindingSource;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.Kategoriya_sotrudnikovTableAdapter kategoriya_sotrudnikovTableAdapter;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kategoriya_sotrudnikovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kategoriya_sotrudnikovBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kategoriya_sotrudnikovDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}