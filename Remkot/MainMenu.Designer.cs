namespace Remkot
{
    partial class MainMenu
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
            panel_main = new Panel();
            button_application = new Button();
            button_clients = new Button();
            panel_main.SuspendLayout();
            SuspendLayout();
            // 
            // panel_main
            // 
            panel_main.Controls.Add(button_application);
            panel_main.Controls.Add(button_clients);
            panel_main.Location = new Point(12, 12);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(258, 329);
            panel_main.TabIndex = 0;
            // 
            // button_application
            // 
            button_application.Location = new Point(70, 172);
            button_application.Name = "button_application";
            button_application.Size = new Size(120, 40);
            button_application.TabIndex = 1;
            button_application.Text = "Заявки";
            button_application.UseVisualStyleBackColor = true;
            button_application.Click += button_application_Click;
            // 
            // button_clients
            // 
            button_clients.Location = new Point(70, 111);
            button_clients.Name = "button_clients";
            button_clients.Size = new Size(120, 40);
            button_clients.TabIndex = 0;
            button_clients.Text = "Клиенты";
            button_clients.UseVisualStyleBackColor = true;
            button_clients.Click += button_clients_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 353);
            Controls.Add(panel_main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            panel_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_main;
        private Button button_clients;
        private Button button_application;
    }
}