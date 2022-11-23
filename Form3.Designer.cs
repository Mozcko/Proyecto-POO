
namespace Proyecto_POO
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ataque1 = new System.Windows.Forms.Button();
            this.Ataque2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turno del jugador 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roquemon: ";
            // 
            // Ataque1
            // 
            this.Ataque1.Location = new System.Drawing.Point(97, 204);
            this.Ataque1.Name = "Ataque1";
            this.Ataque1.Size = new System.Drawing.Size(75, 23);
            this.Ataque1.TabIndex = 2;
            this.Ataque1.Text = "button1";
            this.Ataque1.UseVisualStyleBackColor = true;
            this.Ataque1.Click += new System.EventHandler(this.Ataque1_Click);
            // 
            // Ataque2
            // 
            this.Ataque2.Location = new System.Drawing.Point(200, 206);
            this.Ataque2.Name = "Ataque2";
            this.Ataque2.Size = new System.Drawing.Size(75, 23);
            this.Ataque2.TabIndex = 3;
            this.Ataque2.Text = "button2";
            this.Ataque2.UseVisualStyleBackColor = true;
            this.Ataque2.Click += new System.EventHandler(this.Ataque2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 255);
            this.Controls.Add(this.Ataque2);
            this.Controls.Add(this.Ataque1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ataque1;
        private System.Windows.Forms.Button Ataque2;
    }
}