namespace Tchat
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tchat_richTextBox = new System.Windows.Forms.RichTextBox();
            this.mon_textBox = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.mon_port_num = new System.Windows.Forms.NumericUpDown();
            this.cible_port_num = new System.Windows.Forms.NumericUpDown();
            this.cible_IP_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mon_IP_Label = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mon_port_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cible_port_num)).BeginInit();
            this.SuspendLayout();
            // 
            // Tchat_richTextBox
            // 
            this.Tchat_richTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tchat_richTextBox.Location = new System.Drawing.Point(92, 140);
            this.Tchat_richTextBox.Name = "Tchat_richTextBox";
            this.Tchat_richTextBox.ReadOnly = true;
            this.Tchat_richTextBox.Size = new System.Drawing.Size(461, 193);
            this.Tchat_richTextBox.TabIndex = 0;
            this.Tchat_richTextBox.Text = "";
            // 
            // mon_textBox
            // 
            this.mon_textBox.Location = new System.Drawing.Point(92, 377);
            this.mon_textBox.Name = "mon_textBox";
            this.mon_textBox.Size = new System.Drawing.Size(473, 20);
            this.mon_textBox.TabIndex = 1;
            this.mon_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mon_textBox_KeyDown);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(615, 62);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(151, 148);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connexion";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // mon_port_num
            // 
            this.mon_port_num.Location = new System.Drawing.Point(392, 71);
            this.mon_port_num.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.mon_port_num.Name = "mon_port_num";
            this.mon_port_num.Size = new System.Drawing.Size(67, 20);
            this.mon_port_num.TabIndex = 3;
            // 
            // cible_port_num
            // 
            this.cible_port_num.Location = new System.Drawing.Point(390, 106);
            this.cible_port_num.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.cible_port_num.Name = "cible_port_num";
            this.cible_port_num.Size = new System.Drawing.Size(69, 20);
            this.cible_port_num.TabIndex = 4;
            // 
            // cible_IP_textBox
            // 
            this.cible_IP_textBox.Location = new System.Drawing.Point(176, 106);
            this.cible_IP_textBox.Name = "cible_IP_textBox";
            this.cible_IP_textBox.Size = new System.Drawing.Size(93, 20);
            this.cible_IP_textBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Moi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adresse IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cible";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port";
            // 
            // mon_IP_Label
            // 
            this.mon_IP_Label.Location = new System.Drawing.Point(176, 75);
            this.mon_IP_Label.Name = "mon_IP_Label";
            this.mon_IP_Label.Size = new System.Drawing.Size(93, 20);
            this.mon_IP_Label.TabIndex = 10;
            // 
            // timer1
            // 

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mon_IP_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cible_IP_textBox);
            this.Controls.Add(this.cible_port_num);
            this.Controls.Add(this.mon_port_num);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.mon_textBox);
            this.Controls.Add(this.Tchat_richTextBox);
            this.Name = "Form1";
            this.Text = "Tchat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mon_port_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cible_port_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Tchat_richTextBox;
        private System.Windows.Forms.TextBox mon_textBox;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.NumericUpDown mon_port_num;
        private System.Windows.Forms.NumericUpDown cible_port_num;
        private System.Windows.Forms.TextBox cible_IP_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mon_IP_Label;
        private System.Windows.Forms.Timer timer1;
    }
}

