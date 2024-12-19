namespace AnimeTitles
{
    partial class FormUsers
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
            panel1 = new Panel();
            bttnAdd = new Button();
            bttnEdit = new Button();
            bttnDelete = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(bttnDelete);
            panel1.Controls.Add(bttnEdit);
            panel1.Controls.Add(bttnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 17, 16, 17);
            panel1.Size = new Size(1257, 133);
            panel1.TabIndex = 0;
            // 
            // bttnAdd
            // 
            bttnAdd.Location = new Point(19, 12);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(137, 34);
            bttnAdd.TabIndex = 0;
            bttnAdd.Text = "Добавить";
            bttnAdd.UseVisualStyleBackColor = true;
            // 
            // bttnEdit
            // 
            bttnEdit.Location = new Point(162, 12);
            bttnEdit.Name = "bttnEdit";
            bttnEdit.Size = new Size(156, 34);
            bttnEdit.TabIndex = 1;
            bttnEdit.Text = "Редактировать";
            bttnEdit.UseVisualStyleBackColor = true;
            // 
            // bttnDelete
            // 
            bttnDelete.Location = new Point(324, 12);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(137, 34);
            bttnDelete.TabIndex = 2;
            bttnDelete.Text = "Удалить";
            bttnDelete.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1257, 617);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1237, 597);
            dataGridView1.TabIndex = 0;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormUsers";
            Text = "Пользователи";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bttnAdd;
        private Button bttnDelete;
        private Button bttnEdit;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}