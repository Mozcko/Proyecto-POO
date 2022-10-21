
namespace Proyecto_POO
{
    partial class InputBox
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
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.Label_player = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(12, 68);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(189, 20);
            this.text_nombre.TabIndex = 0;
            // 
            // Label_player
            // 
            this.Label_player.AutoSize = true;
            this.Label_player.Location = new System.Drawing.Point(47, 31);
            this.Label_player.Name = "Label_player";
            this.Label_player.Size = new System.Drawing.Size(35, 13);
            this.Label_player.TabIndex = 1;
            this.Label_player.Text = "label1";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(75, 96);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 131);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Label_player);
            this.Controls.Add(this.text_nombre);
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label Label_player;
        private System.Windows.Forms.Button Aceptar;
    }
}