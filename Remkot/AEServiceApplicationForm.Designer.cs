namespace Remkot
{
    partial class AEServiceApplicationForm
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
            comboBox_doc = new ComboBox();
            comboBox_part = new ComboBox();
            label_doc = new Label();
            comboBox_client = new ComboBox();
            label_part = new Label();
            comboBox_cashier = new ComboBox();
            label_client = new Label();
            label_service = new Label();
            label_cashier = new Label();
            textBox_service = new TextBox();
            button_action = new Button();
            comboBox_document = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox_doc);
            panel1.Controls.Add(comboBox_part);
            panel1.Controls.Add(label_doc);
            panel1.Controls.Add(comboBox_client);
            panel1.Controls.Add(label_part);
            panel1.Controls.Add(comboBox_cashier);
            panel1.Controls.Add(label_client);
            panel1.Controls.Add(label_service);
            panel1.Controls.Add(label_cashier);
            panel1.Controls.Add(textBox_service);
            panel1.Controls.Add(button_action);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 329);
            panel1.TabIndex = 1;
            // 
            // comboBox_doc
            // 
            comboBox_doc.FormattingEnabled = true;
            comboBox_doc.Location = new Point(115, 169);
            comboBox_doc.Name = "comboBox_doc";
            comboBox_doc.Size = new Size(200, 28);
            comboBox_doc.TabIndex = 3;
            // 
            // comboBox_part
            // 
            comboBox_part.FormattingEnabled = true;
            comboBox_part.Location = new Point(115, 122);
            comboBox_part.Name = "comboBox_part";
            comboBox_part.Size = new Size(200, 28);
            comboBox_part.TabIndex = 3;
            // 
            // label_doc
            // 
            label_doc.AutoSize = true;
            label_doc.Location = new Point(38, 169);
            label_doc.Name = "label_doc";
            label_doc.Size = new Size(76, 20);
            label_doc.TabIndex = 2;
            label_doc.Text = "Документ";
            // 
            // comboBox_client
            // 
            comboBox_client.FormattingEnabled = true;
            comboBox_client.Location = new Point(115, 77);
            comboBox_client.Name = "comboBox_client";
            comboBox_client.Size = new Size(200, 28);
            comboBox_client.TabIndex = 3;
            // 
            // label_part
            // 
            label_part.AutoSize = true;
            label_part.Location = new Point(38, 125);
            label_part.Name = "label_part";
            label_part.Size = new Size(71, 20);
            label_part.TabIndex = 2;
            label_part.Text = "Запчасть";
            // 
            // comboBox_cashier
            // 
            comboBox_cashier.FormattingEnabled = true;
            comboBox_cashier.Location = new Point(115, 32);
            comboBox_cashier.Name = "comboBox_cashier";
            comboBox_cashier.Size = new Size(200, 28);
            comboBox_cashier.TabIndex = 3;
            // 
            // label_client
            // 
            label_client.AutoSize = true;
            label_client.Location = new Point(38, 80);
            label_client.Name = "label_client";
            label_client.Size = new Size(58, 20);
            label_client.TabIndex = 2;
            label_client.Text = "Клиент";
            // 
            // label_service
            // 
            label_service.AutoSize = true;
            label_service.Location = new Point(38, 213);
            label_service.Name = "label_service";
            label_service.Size = new Size(60, 20);
            label_service.TabIndex = 2;
            label_service.Text = "Работы";
            // 
            // label_cashier
            // 
            label_cashier.AutoSize = true;
            label_cashier.Location = new Point(38, 35);
            label_cashier.Name = "label_cashier";
            label_cashier.Size = new Size(58, 20);
            label_cashier.TabIndex = 2;
            label_cashier.Text = "Кассир";
            // 
            // textBox_service
            // 
            textBox_service.Location = new Point(115, 210);
            textBox_service.MaxLength = 12;
            textBox_service.Name = "textBox_service";
            textBox_service.Size = new Size(200, 27);
            textBox_service.TabIndex = 1;
            // 
            // button_action
            // 
            button_action.Location = new Point(127, 257);
            button_action.Name = "button_action";
            button_action.Size = new Size(94, 29);
            button_action.TabIndex = 0;
            button_action.Text = "button1";
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // comboBox_document
            // 
            comboBox_document.FormattingEnabled = true;
            comboBox_document.Location = new Point(115, 166);
            comboBox_document.Name = "comboBox_document";
            comboBox_document.Size = new Size(200, 28);
            comboBox_document.TabIndex = 3;
            // 
            // AEServiceApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 353);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AEServiceApplicationForm";
            Text = "AEServiceApplicationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_cashier;
        private TextBox textBox_fio;
        private Button button_action;
        private ComboBox comboBox_doc;
        private ComboBox comboBox_part;
        private Label label_doc;
        private ComboBox comboBox_client;
        private Label label_part;
        private ComboBox comboBox_cashier;
        private Label label_client;
        private Label label_service;
        private TextBox textBox_service;
        private ComboBox comboBox_document;
    }
}