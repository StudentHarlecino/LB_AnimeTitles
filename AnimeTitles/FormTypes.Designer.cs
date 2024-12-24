namespace AnimeTitles
{
    partial class FormTypes
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
            flowLayoutPanelTop = new Panel();
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            panelFill = new Panel();
            dataGridViewType = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewType).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(buttonTypeDelete);
            flowLayoutPanelTop.Controls.Add(buttonTypeEdit);
            flowLayoutPanelTop.Controls.Add(buttonTypeAdd);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelTop.Size = new Size(1257, 133);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Location = new Point(324, 12);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(137, 34);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            // 
            // buttonTypeEdit
            // 
            buttonTypeEdit.Location = new Point(162, 12);
            buttonTypeEdit.Name = "buttonTypeEdit";
            buttonTypeEdit.Size = new Size(156, 34);
            buttonTypeEdit.TabIndex = 1;
            buttonTypeEdit.Text = "Редактировать";
            buttonTypeEdit.UseVisualStyleBackColor = true;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Location = new Point(19, 12);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(137, 34);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewType);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 133);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1257, 617);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewType
            // 
            dataGridViewType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewType.BackgroundColor = Color.White;
            dataGridViewType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewType.Dock = DockStyle.Fill;
            dataGridViewType.Location = new Point(10, 10);
            dataGridViewType.MultiSelect = false;
            dataGridViewType.Name = "dataGridViewType";
            dataGridViewType.ReadOnly = true;
            dataGridViewType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewType.Size = new Size(1237, 597);
            dataGridViewType.TabIndex = 0;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypes";
            Text = "Типы аниме";
            Load += FormType_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel flowLayoutPanelTop;
        private Button buttonTypeAdd;
        private Button buttonTypeDelete;
        private Button buttonTypeEdit;
        private Panel panelFill;
        private DataGridView dataGridViewType;
    }
}