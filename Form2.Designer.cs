
namespace Proyecto_POO
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LabelMenu = new System.Windows.Forms.Label();
            this.p_Aguamon = new System.Windows.Forms.PictureBox();
            this.p_Fuegomon = new System.Windows.Forms.PictureBox();
            this.p_Plantamon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_Aguamon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Fuegomon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Plantamon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aguamon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fuegomon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Plantamon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LabelMenu
            // 
            this.LabelMenu.AutoSize = true;
            this.LabelMenu.Location = new System.Drawing.Point(122, 66);
            this.LabelMenu.Name = "LabelMenu";
            this.LabelMenu.Size = new System.Drawing.Size(155, 13);
            this.LabelMenu.TabIndex = 3;
            this.LabelMenu.Text = "Jugador1: escoje tu Roquemon";
            // 
            // p_Aguamon
            // 
            this.p_Aguamon.Image = global::Proyecto_POO.Properties.Resources.Aguamon;
            this.p_Aguamon.Location = new System.Drawing.Point(48, 115);
            this.p_Aguamon.Name = "p_Aguamon";
            this.p_Aguamon.Size = new System.Drawing.Size(75, 66);
            this.p_Aguamon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Aguamon.TabIndex = 4;
            this.p_Aguamon.TabStop = false;
            // 
            // p_Fuegomon
            // 
            this.p_Fuegomon.Image = global::Proyecto_POO.Properties.Resources.Fuegomon;
            this.p_Fuegomon.Location = new System.Drawing.Point(162, 115);
            this.p_Fuegomon.Name = "p_Fuegomon";
            this.p_Fuegomon.Size = new System.Drawing.Size(75, 66);
            this.p_Fuegomon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Fuegomon.TabIndex = 5;
            this.p_Fuegomon.TabStop = false;
            // 
            // p_Plantamon
            // 
            this.p_Plantamon.Image = global::Proyecto_POO.Properties.Resources.Plantamon;
            this.p_Plantamon.Location = new System.Drawing.Point(276, 115);
            this.p_Plantamon.Name = "p_Plantamon";
            this.p_Plantamon.Size = new System.Drawing.Size(75, 66);
            this.p_Plantamon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_Plantamon.TabIndex = 6;
            this.p_Plantamon.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.p_Plantamon);
            this.Controls.Add(this.p_Fuegomon);
            this.Controls.Add(this.p_Aguamon);
            this.Controls.Add(this.LabelMenu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roquemon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.p_Aguamon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Fuegomon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_Plantamon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label LabelMenu;
        private System.Windows.Forms.PictureBox p_Aguamon;
        private System.Windows.Forms.PictureBox p_Fuegomon;
        private System.Windows.Forms.PictureBox p_Plantamon;
    }
}