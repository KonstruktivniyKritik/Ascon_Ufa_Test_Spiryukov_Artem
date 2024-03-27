namespace Ascon_Ufa_Test_Spiryukov_Artem
{
    partial class DBConnectionForm
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
            textBox_ConnectionString = new TextBox();
            label1 = new Label();
            button_DBConnect = new Button();
            button_Cancel = new Button();
            label_ConnectionInfo = new Label();
            SuspendLayout();
            // 
            // textBox_ConnectionString
            // 
            textBox_ConnectionString.Location = new Point(11, 43);
            textBox_ConnectionString.Name = "textBox_ConnectionString";
            textBox_ConnectionString.Size = new Size(596, 27);
            textBox_ConnectionString.TabIndex = 0;
            textBox_ConnectionString.Text = "Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите строку подключения";
            // 
            // button_DBConnect
            // 
            button_DBConnect.Location = new Point(11, 76);
            button_DBConnect.Name = "button_DBConnect";
            button_DBConnect.Size = new Size(123, 29);
            button_DBConnect.TabIndex = 2;
            button_DBConnect.Text = "Поделючиться";
            button_DBConnect.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(513, 76);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 29);
            button_Cancel.TabIndex = 3;
            button_Cancel.Text = "Отмена";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // label_ConnectionInfo
            // 
            label_ConnectionInfo.AutoSize = true;
            label_ConnectionInfo.Location = new Point(264, 80);
            label_ConnectionInfo.Name = "label_ConnectionInfo";
            label_ConnectionInfo.Size = new Size(119, 20);
            label_ConnectionInfo.TabIndex = 4;
            label_ConnectionInfo.Text = "Не подключено";
            // 
            // DBConnectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_Cancel;
            ClientSize = new Size(619, 114);
            ControlBox = false;
            Controls.Add(label_ConnectionInfo);
            Controls.Add(button_Cancel);
            Controls.Add(button_DBConnect);
            Controls.Add(label1);
            Controls.Add(textBox_ConnectionString);
            MaximumSize = new Size(637, 161);
            MinimumSize = new Size(637, 161);
            Name = "DBConnectionForm";
            Text = "DBConnectionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ConnectionString;
        private Label label1;
        private Button button_DBConnect;
        private Button button_Cancel;
        private Label label_ConnectionInfo;
    }
}