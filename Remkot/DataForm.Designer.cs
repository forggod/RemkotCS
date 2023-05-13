namespace Remkot
{
    partial class DataForm
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
            components = new System.ComponentModel.Container();
            dataGridView_table = new DataGridView();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_add = new ToolStripMenuItem();
            toolStripMenuItem_edit = new ToolStripMenuItem();
            toolStripMenuItem_delete = new ToolStripMenuItem();
            timer_update = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_table).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_table
            // 
            dataGridView_table.AllowUserToAddRows = false;
            dataGridView_table.AllowUserToDeleteRows = false;
            dataGridView_table.AllowUserToResizeRows = false;
            dataGridView_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_table.BackgroundColor = Color.WhiteSmoke;
            dataGridView_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_table.Dock = DockStyle.Fill;
            dataGridView_table.Location = new Point(0, 28);
            dataGridView_table.MultiSelect = false;
            dataGridView_table.Name = "dataGridView_table";
            dataGridView_table.ReadOnly = true;
            dataGridView_table.RowHeadersWidth = 51;
            dataGridView_table.RowTemplate.Height = 29;
            dataGridView_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_table.Size = new Size(982, 425);
            dataGridView_table.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_add, toolStripMenuItem_edit, toolStripMenuItem_delete });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // toolStripMenuItem_add
            // 
            toolStripMenuItem_add.Name = "toolStripMenuItem_add";
            toolStripMenuItem_add.Size = new Size(161, 26);
            toolStripMenuItem_add.Text = "Добавить";
            toolStripMenuItem_add.Click += toolStripMenuItem_add_Click;
            // 
            // toolStripMenuItem_edit
            // 
            toolStripMenuItem_edit.Name = "toolStripMenuItem_edit";
            toolStripMenuItem_edit.Size = new Size(161, 26);
            toolStripMenuItem_edit.Text = "Изменить";
            toolStripMenuItem_edit.Click += toolStripMenuItem_edit_Click;
            // 
            // toolStripMenuItem_delete
            // 
            toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            toolStripMenuItem_delete.Size = new Size(161, 26);
            toolStripMenuItem_delete.Text = "Удалить";
            toolStripMenuItem_delete.Click += toolStripMenuItem_delete_Click;
            // 
            // timer_update
            // 
            timer_update.Interval = 1000;
            timer_update.Tick += timer_update_Tick;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(dataGridView_table);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_table).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_table;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_add;
        private ToolStripMenuItem toolStripMenuItem_edit;
        private ToolStripMenuItem toolStripMenuItem_delete;
        private System.Windows.Forms.Timer timer_update;
    }
}