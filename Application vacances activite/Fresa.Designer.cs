namespace Application_vacances_activite
{
    partial class Fresa
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
            this.mesResa = new System.Windows.Forms.Label();
            this.ListMesResa = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.user = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mesResa
            // 
            this.mesResa.AutoSize = true;
            this.mesResa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesResa.Location = new System.Drawing.Point(143, 75);
            this.mesResa.Name = "mesResa";
            this.mesResa.Size = new System.Drawing.Size(258, 37);
            this.mesResa.TabIndex = 6;
            this.mesResa.Text = "Mes reservations";
            // 
            // ListMesResa
            // 
            this.ListMesResa.FormattingEnabled = true;
            this.ListMesResa.ItemHeight = 20;
            this.ListMesResa.Location = new System.Drawing.Point(12, 127);
            this.ListMesResa.Name = "ListMesResa";
            this.ListMesResa.Size = new System.Drawing.Size(501, 344);
            this.ListMesResa.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(230, 548);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Retour";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(237, 37);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(51, 20);
            this.user.TabIndex = 9;
            this.user.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Suprimer une réservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Fresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ListMesResa);
            this.Controls.Add(this.mesResa);
            this.Name = "Fresa";
            this.Text = "Fresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mesResa;
        private System.Windows.Forms.ListBox ListMesResa;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button button1;
    }
}