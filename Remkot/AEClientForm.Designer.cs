namespace Remkot
{
    partial class AEClientForm
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
            label_phone = new Label();
            label_fio = new Label();
            textBox_phone = new TextBox();
            textBox_fio = new TextBox();
            button_action = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label_phone);
            panel1.Controls.Add(label_fio);
            panel1.Controls.Add(textBox_phone);
            panel1.Controls.Add(textBox_fio);
            panel1.Controls.Add(button_action);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 329);
            panel1.TabIndex = 0;
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(38, 143);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(69, 20);
            label_phone.TabIndex = 2;
            label_phone.Text = "Телефон";
            // 
            // label_fio
            // 
            label_fio.AutoSize = true;
            label_fio.Location = new Point(38, 97);
            label_fio.Name = "label_fio";
            label_fio.Size = new Size(42, 20);
            label_fio.TabIndex = 2;
            label_fio.Text = "ФИО";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(115, 140);
            textBox_phone.MaxLength = 12;
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(200, 27);
            textBox_phone.TabIndex = 1;
            // 
            // textBox_fio
            // 
            textBox_fio.Location = new Point(115, 94);
            textBox_fio.Name = "textBox_fio";
            textBox_fio.Size = new Size(200, 27);
            textBox_fio.TabIndex = 1;
            // 
            // button_action
            // 
            button_action.Location = new Point(127, 230);
            button_action.Name = "button_action";
            button_action.Size = new Size(94, 29);
            button_action.TabIndex = 0;
            button_action.Text = "button1";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // AEClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AEClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AEClientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_fio;
        private TextBox textBox_fio;
        private Button button_action;
        private Label label_phone;
        private TextBox textBox_phone;
    }
}