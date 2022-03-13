
namespace D_Anjolell_cc5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.patientInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._D_AnjolellMedicalDataSet = new D_Anjolell_cc5._D_AnjolellMedicalDataSet();
            this.patientInfoTableAdapter = new D_Anjolell_cc5._D_AnjolellMedicalDataSetTableAdapters.patientInfoTableAdapter();
            this.tableAdapterManager = new D_Anjolell_cc5._D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager();
            this.btnHeight = new System.Windows.Forms.Button();
            this.btnWeightOver = new System.Windows.Forms.Button();
            this.btnWeightUnder = new System.Windows.Forms.Button();
            this.btnA1c = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingNavigator)).BeginInit();
            this.patientInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_AnjolellMedicalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // patientInfoBindingNavigator
            // 
            this.patientInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientInfoBindingNavigator.BindingSource = this.patientInfoBindingSource;
            this.patientInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientInfoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientInfoBindingNavigatorSaveItem});
            this.patientInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientInfoBindingNavigator.Name = "patientInfoBindingNavigator";
            this.patientInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientInfoBindingNavigator.Size = new System.Drawing.Size(1144, 27);
            this.patientInfoBindingNavigator.TabIndex = 0;
            this.patientInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            // patientInfoBindingNavigatorSaveItem
            // 
            this.patientInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientInfoBindingNavigatorSaveItem.Image")));
            this.patientInfoBindingNavigatorSaveItem.Name = "patientInfoBindingNavigatorSaveItem";
            this.patientInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.patientInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.patientInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientInfoBindingNavigatorSaveItem_Click);
            // 
            // patientInfoDataGridView
            // 
            this.patientInfoDataGridView.AutoGenerateColumns = false;
            this.patientInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.patientInfoDataGridView.DataSource = this.patientInfoBindingSource;
            this.patientInfoDataGridView.Location = new System.Drawing.Point(12, 41);
            this.patientInfoDataGridView.Name = "patientInfoDataGridView";
            this.patientInfoDataGridView.RowHeadersWidth = 51;
            this.patientInfoDataGridView.RowTemplate.Height = 24;
            this.patientInfoDataGridView.Size = new System.Drawing.Size(1083, 310);
            this.patientInfoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "height";
            this.dataGridViewTextBoxColumn3.HeaderText = "height";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "weight";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "a1cvalue";
            this.dataGridViewTextBoxColumn5.HeaderText = "a1cvalue";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn6.HeaderText = "age";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // patientInfoBindingSource
            // 
            this.patientInfoBindingSource.DataMember = "patientInfo";
            this.patientInfoBindingSource.DataSource = this._D_AnjolellMedicalDataSet;
            // 
            // _D_AnjolellMedicalDataSet
            // 
            this._D_AnjolellMedicalDataSet.DataSetName = "_D_AnjolellMedicalDataSet";
            this._D_AnjolellMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInfoTableAdapter
            // 
            this.patientInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patientInfoTableAdapter = this.patientInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = D_Anjolell_cc5._D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnHeight
            // 
            this.btnHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnHeight.Location = new System.Drawing.Point(12, 375);
            this.btnHeight.Name = "btnHeight";
            this.btnHeight.Size = new System.Drawing.Size(174, 73);
            this.btnHeight.TabIndex = 2;
            this.btnHeight.Text = "Sort by Height Desc";
            this.btnHeight.UseVisualStyleBackColor = true;
            this.btnHeight.Click += new System.EventHandler(this.btnHeight_Click);
            // 
            // btnWeightOver
            // 
            this.btnWeightOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnWeightOver.Location = new System.Drawing.Point(234, 375);
            this.btnWeightOver.Name = "btnWeightOver";
            this.btnWeightOver.Size = new System.Drawing.Size(174, 73);
            this.btnWeightOver.TabIndex = 3;
            this.btnWeightOver.Text = "Weight > 200";
            this.btnWeightOver.UseVisualStyleBackColor = true;
            this.btnWeightOver.Click += new System.EventHandler(this.btnWeightOver_Click);
            // 
            // btnWeightUnder
            // 
            this.btnWeightUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnWeightUnder.Location = new System.Drawing.Point(451, 375);
            this.btnWeightUnder.Name = "btnWeightUnder";
            this.btnWeightUnder.Size = new System.Drawing.Size(174, 73);
            this.btnWeightUnder.TabIndex = 4;
            this.btnWeightUnder.Text = "Weight < 100";
            this.btnWeightUnder.UseVisualStyleBackColor = true;
            this.btnWeightUnder.Click += new System.EventHandler(this.btnWeightUnder_Click);
            // 
            // btnA1c
            // 
            this.btnA1c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnA1c.Location = new System.Drawing.Point(680, 375);
            this.btnA1c.Name = "btnA1c";
            this.btnA1c.Size = new System.Drawing.Size(194, 73);
            this.btnA1c.TabIndex = 5;
            this.btnA1c.Text = "A1cvalue > 5.7";
            this.btnA1c.UseVisualStyleBackColor = true;
            this.btnA1c.Click += new System.EventHandler(this.btnA1c_Click);
            // 
            // btnAge
            // 
            this.btnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAge.Location = new System.Drawing.Point(921, 375);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(174, 73);
            this.btnAge.TabIndex = 6;
            this.btnAge.Text = "Age > 70";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 475);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnA1c);
            this.Controls.Add(this.btnWeightUnder);
            this.Controls.Add(this.btnWeightOver);
            this.Controls.Add(this.btnHeight);
            this.Controls.Add(this.patientInfoDataGridView);
            this.Controls.Add(this.patientInfoBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingNavigator)).EndInit();
            this.patientInfoBindingNavigator.ResumeLayout(false);
            this.patientInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_AnjolellMedicalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _D_AnjolellMedicalDataSet _D_AnjolellMedicalDataSet;
        private System.Windows.Forms.BindingSource patientInfoBindingSource;
        private _D_AnjolellMedicalDataSetTableAdapters.patientInfoTableAdapter patientInfoTableAdapter;
        private _D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView patientInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnHeight;
        private System.Windows.Forms.Button btnWeightOver;
        private System.Windows.Forms.Button btnWeightUnder;
        private System.Windows.Forms.Button btnA1c;
        private System.Windows.Forms.Button btnAge;
    }
}

