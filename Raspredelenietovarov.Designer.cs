
namespace WindowsFormsApp3
{
    partial class Raspredelenietovarov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raspredelenietovarov));
            this._Индивидуальное_задание_25_04DataSet1 = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1();
            this.raspredeleniye_tovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspredeleniye_tovarovTableAdapter = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.Raspredeleniye_tovarovTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager();
            this.raspredeleniye_tovarovBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.raspredeleniye_tovarovDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.raspredeleniye_tovarovBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspredeleniye_tovarovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspredeleniye_tovarovBindingNavigator)).BeginInit();
            this.raspredeleniye_tovarovBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspredeleniye_tovarovDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _Индивидуальное_задание_25_04DataSet1
            // 
            this._Индивидуальное_задание_25_04DataSet1.DataSetName = "_Индивидуальное_задание_25_04DataSet1";
            this._Индивидуальное_задание_25_04DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raspredeleniye_tovarovBindingSource
            // 
            this.raspredeleniye_tovarovBindingSource.DataMember = "Raspredeleniye tovarov";
            this.raspredeleniye_tovarovBindingSource.DataSource = this._Индивидуальное_задание_25_04DataSet1;
            // 
            // raspredeleniye_tovarovTableAdapter
            // 
            this.raspredeleniye_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialyTableAdapter = null;
            this.tableAdapterManager.Kategoriya_sotrudnikovTableAdapter = null;
            this.tableAdapterManager.KioskTableAdapter = null;
            this.tableAdapterManager.OborudovaniyeTableAdapter = null;
            this.tableAdapterManager.PostavkaTableAdapter = null;
            this.tableAdapterManager.PostavshchikiTableAdapter = null;
            this.tableAdapterManager.ProdazhaTableAdapter = null;
            this.tableAdapterManager.Raspredeleniye_tovarovTableAdapter = this.raspredeleniye_tovarovTableAdapter;
            this.tableAdapterManager.SkidkaTableAdapter = null;
            this.tableAdapterManager.SotrudnikiTableAdapter = null;
            this.tableAdapterManager.Tip_zakazaTableAdapter = null;
            this.tableAdapterManager.TovaryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vypolneniye_uslugiTableAdapter = null;
            // 
            // raspredeleniye_tovarovBindingNavigator
            // 
            this.raspredeleniye_tovarovBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.raspredeleniye_tovarovBindingNavigator.BindingSource = this.raspredeleniye_tovarovBindingSource;
            this.raspredeleniye_tovarovBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.raspredeleniye_tovarovBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.raspredeleniye_tovarovBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.raspredeleniye_tovarovBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.raspredeleniye_tovarovBindingNavigatorSaveItem});
            this.raspredeleniye_tovarovBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.raspredeleniye_tovarovBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.raspredeleniye_tovarovBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.raspredeleniye_tovarovBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.raspredeleniye_tovarovBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.raspredeleniye_tovarovBindingNavigator.Name = "raspredeleniye_tovarovBindingNavigator";
            this.raspredeleniye_tovarovBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.raspredeleniye_tovarovBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.raspredeleniye_tovarovBindingNavigator.TabIndex = 0;
            this.raspredeleniye_tovarovBindingNavigator.Text = "bindingNavigator1";
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
            // raspredeleniye_tovarovDataGridView
            // 
            this.raspredeleniye_tovarovDataGridView.AutoGenerateColumns = false;
            this.raspredeleniye_tovarovDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raspredeleniye_tovarovDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.raspredeleniye_tovarovDataGridView.DataSource = this.raspredeleniye_tovarovBindingSource;
            this.raspredeleniye_tovarovDataGridView.Location = new System.Drawing.Point(0, 30);
            this.raspredeleniye_tovarovDataGridView.Name = "raspredeleniye_tovarovDataGridView";
            this.raspredeleniye_tovarovDataGridView.RowHeadersWidth = 51;
            this.raspredeleniye_tovarovDataGridView.Size = new System.Drawing.Size(561, 220);
            this.raspredeleniye_tovarovDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Raspredeleniye";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Raspredeleniye";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Postavka";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Postavka";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Kiosk";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Kiosk";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Filialy";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Filialy";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
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
            // raspredeleniye_tovarovBindingNavigatorSaveItem
            // 
            this.raspredeleniye_tovarovBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.raspredeleniye_tovarovBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("raspredeleniye_tovarovBindingNavigatorSaveItem.Image")));
            this.raspredeleniye_tovarovBindingNavigatorSaveItem.Name = "raspredeleniye_tovarovBindingNavigatorSaveItem";
            this.raspredeleniye_tovarovBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.raspredeleniye_tovarovBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.raspredeleniye_tovarovBindingNavigatorSaveItem.Click += new System.EventHandler(this.raspredeleniye_tovarovBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Raspredelenietovarov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.raspredeleniye_tovarovDataGridView);
            this.Controls.Add(this.raspredeleniye_tovarovBindingNavigator);
            this.Name = "Raspredelenietovarov";
            this.Text = "Raspredelenietovarov";
            this.Load += new System.EventHandler(this.Raspredelenietovarov_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspredeleniye_tovarovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspredeleniye_tovarovBindingNavigator)).EndInit();
            this.raspredeleniye_tovarovBindingNavigator.ResumeLayout(false);
            this.raspredeleniye_tovarovBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raspredeleniye_tovarovDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Индивидуальное_задание_25_04DataSet1 _Индивидуальное_задание_25_04DataSet1;
        private System.Windows.Forms.BindingSource raspredeleniye_tovarovBindingSource;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.Raspredeleniye_tovarovTableAdapter raspredeleniye_tovarovTableAdapter;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator raspredeleniye_tovarovBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton raspredeleniye_tovarovBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView raspredeleniye_tovarovDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}