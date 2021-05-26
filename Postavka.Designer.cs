
namespace WindowsFormsApp3
{
    partial class Postavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavka));
            this._Индивидуальное_задание_25_04DataSet1 = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1();
            this.postavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavkaTableAdapter = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.PostavkaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3._Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager();
            this.postavkaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postavkaDataGridView = new System.Windows.Forms.DataGridView();
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
            this.postavkaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingNavigator)).BeginInit();
            this.postavkaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _Индивидуальное_задание_25_04DataSet1
            // 
            this._Индивидуальное_задание_25_04DataSet1.DataSetName = "_Индивидуальное_задание_25_04DataSet1";
            this._Индивидуальное_задание_25_04DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postavkaBindingSource
            // 
            this.postavkaBindingSource.DataMember = "Postavka";
            this.postavkaBindingSource.DataSource = this._Индивидуальное_задание_25_04DataSet1;
            // 
            // postavkaTableAdapter
            // 
            this.postavkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilialyTableAdapter = null;
            this.tableAdapterManager.Kategoriya_sotrudnikovTableAdapter = null;
            this.tableAdapterManager.KioskTableAdapter = null;
            this.tableAdapterManager.OborudovaniyeTableAdapter = null;
            this.tableAdapterManager.PostavkaTableAdapter = this.postavkaTableAdapter;
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
            // postavkaBindingNavigator
            // 
            this.postavkaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postavkaBindingNavigator.BindingSource = this.postavkaBindingSource;
            this.postavkaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postavkaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postavkaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.postavkaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postavkaBindingNavigatorSaveItem});
            this.postavkaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postavkaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postavkaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postavkaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postavkaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postavkaBindingNavigator.Name = "postavkaBindingNavigator";
            this.postavkaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postavkaBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.postavkaBindingNavigator.TabIndex = 0;
            this.postavkaBindingNavigator.Text = "bindingNavigator1";
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
            // postavkaDataGridView
            // 
            this.postavkaDataGridView.AutoGenerateColumns = false;
            this.postavkaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postavkaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.postavkaDataGridView.DataSource = this.postavkaBindingSource;
            this.postavkaDataGridView.Location = new System.Drawing.Point(0, 30);
            this.postavkaDataGridView.Name = "postavkaDataGridView";
            this.postavkaDataGridView.RowHeadersWidth = 51;
            this.postavkaDataGridView.Size = new System.Drawing.Size(554, 220);
            this.postavkaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Postavka";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Postavka";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kolichestvo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kolichestvo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_Tovary";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_Tovary";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_Postavshiki";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_Postavshiki";
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
            // postavkaBindingNavigatorSaveItem
            // 
            this.postavkaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postavkaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postavkaBindingNavigatorSaveItem.Image")));
            this.postavkaBindingNavigatorSaveItem.Name = "postavkaBindingNavigatorSaveItem";
            this.postavkaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.postavkaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.postavkaBindingNavigatorSaveItem.Click += new System.EventHandler(this.postavkaBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Главная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Postavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.postavkaDataGridView);
            this.Controls.Add(this.postavkaBindingNavigator);
            this.Name = "Postavka";
            this.Text = "Postavka";
            this.Load += new System.EventHandler(this.Postavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Индивидуальное_задание_25_04DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaBindingNavigator)).EndInit();
            this.postavkaBindingNavigator.ResumeLayout(false);
            this.postavkaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postavkaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Индивидуальное_задание_25_04DataSet1 _Индивидуальное_задание_25_04DataSet1;
        private System.Windows.Forms.BindingSource postavkaBindingSource;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.PostavkaTableAdapter postavkaTableAdapter;
        private _Индивидуальное_задание_25_04DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postavkaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postavkaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView postavkaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}