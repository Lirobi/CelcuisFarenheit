namespace CelcuisFarenheit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCelcius = new TextBox();
            txtFarenheit = new TextBox();
            lblCelcius = new Label();
            lblFarenheit = new Label();
            grpChoixSensDeConversion = new GroupBox();
            rdbFarenheitVersCelcius = new RadioButton();
            rdbCelcuisVersFarenheit = new RadioButton();
            btnRaz = new Button();
            btnQuitter = new Button();
            grpChoixSensDeConversion.SuspendLayout();
            SuspendLayout();
            // 
            // txtCelcius
            // 
            txtCelcius.Location = new Point(313, 111);
            txtCelcius.Name = "txtCelcius";
            txtCelcius.Size = new Size(200, 39);
            txtCelcius.TabIndex = 0;
            txtCelcius.TextChanged += txtCelcius_TextChanged;
            txtCelcius.KeyPress += txtCelcius_KeyPress;
            // 
            // txtFarenheit
            // 
            txtFarenheit.Location = new Point(313, 202);
            txtFarenheit.Name = "txtFarenheit";
            txtFarenheit.Size = new Size(200, 39);
            txtFarenheit.TabIndex = 1;
            txtFarenheit.TextChanged += txtFarenheit_TextChanged;
            txtFarenheit.KeyPress += txtFarenheit_KeyPress;
            // 
            // lblCelcius
            // 
            lblCelcius.AutoSize = true;
            lblCelcius.Location = new Point(178, 115);
            lblCelcius.Name = "lblCelcius";
            lblCelcius.Size = new Size(89, 32);
            lblCelcius.TabIndex = 2;
            lblCelcius.Text = "Celcius";
            // 
            // lblFarenheit
            // 
            lblFarenheit.AutoSize = true;
            lblFarenheit.Location = new Point(178, 209);
            lblFarenheit.Name = "lblFarenheit";
            lblFarenheit.Size = new Size(113, 32);
            lblFarenheit.TabIndex = 3;
            lblFarenheit.Text = "Farenheit";
            // 
            // grpChoixSensDeConversion
            // 
            grpChoixSensDeConversion.Controls.Add(rdbFarenheitVersCelcius);
            grpChoixSensDeConversion.Controls.Add(rdbCelcuisVersFarenheit);
            grpChoixSensDeConversion.Location = new Point(183, 367);
            grpChoixSensDeConversion.Name = "grpChoixSensDeConversion";
            grpChoixSensDeConversion.Size = new Size(400, 200);
            grpChoixSensDeConversion.TabIndex = 4;
            grpChoixSensDeConversion.TabStop = false;
            grpChoixSensDeConversion.Text = "Choix du sens de conversion";
            // 
            // rdbFarenheitVersCelcius
            // 
            rdbFarenheitVersCelcius.AutoSize = true;
            rdbFarenheitVersCelcius.Location = new Point(88, 136);
            rdbFarenheitVersCelcius.Name = "rdbFarenheitVersCelcius";
            rdbFarenheitVersCelcius.Size = new Size(269, 36);
            rdbFarenheitVersCelcius.TabIndex = 1;
            rdbFarenheitVersCelcius.TabStop = true;
            rdbFarenheitVersCelcius.Text = "Farenheit --> Celcius";
            rdbFarenheitVersCelcius.UseVisualStyleBackColor = true;
            rdbFarenheitVersCelcius.CheckedChanged += rdbFarenheitVersCelcius_CheckedChanged;
            // 
            // rdbCelcuisVersFarenheit
            // 
            rdbCelcuisVersFarenheit.AutoSize = true;
            rdbCelcuisVersFarenheit.Location = new Point(88, 80);
            rdbCelcuisVersFarenheit.Name = "rdbCelcuisVersFarenheit";
            rdbCelcuisVersFarenheit.Size = new Size(269, 36);
            rdbCelcuisVersFarenheit.TabIndex = 0;
            rdbCelcuisVersFarenheit.TabStop = true;
            rdbCelcuisVersFarenheit.Text = "Celcius --> Farenheit";
            rdbCelcuisVersFarenheit.UseVisualStyleBackColor = true;
            rdbCelcuisVersFarenheit.CheckedChanged += rdbCelcuisVersFarenheit_CheckedChanged;
            // 
            // btnRaz
            // 
            btnRaz.Location = new Point(1001, 788);
            btnRaz.Name = "btnRaz";
            btnRaz.Size = new Size(150, 46);
            btnRaz.TabIndex = 5;
            btnRaz.Text = "RAZ";
            btnRaz.UseVisualStyleBackColor = true;
            btnRaz.Click += btnRaz_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(1191, 788);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(150, 46);
            btnQuitter.TabIndex = 6;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 890);
            Controls.Add(btnQuitter);
            Controls.Add(btnRaz);
            Controls.Add(grpChoixSensDeConversion);
            Controls.Add(lblFarenheit);
            Controls.Add(lblCelcius);
            Controls.Add(txtFarenheit);
            Controls.Add(txtCelcius);
            Name = "Form1";
            Text = "Form1";
            grpChoixSensDeConversion.ResumeLayout(false);
            grpChoixSensDeConversion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelcius;
        private TextBox txtFarenheit;
        private Label lblCelcius;
        private Label lblFarenheit;
        private GroupBox grpChoixSensDeConversion;
        private RadioButton rdbFarenheitVersCelcius;
        private RadioButton rdbCelcuisVersFarenheit;
        private Button btnRaz;
        private Button btnQuitter;
    }
}