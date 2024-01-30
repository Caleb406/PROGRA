namespace GUIA1
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
            this.lbrecibido = new System.Windows.Forms.Label();
            this.REGRE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbrecibido
            // 
            this.lbrecibido.AutoSize = true;
            this.lbrecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecibido.Location = new System.Drawing.Point(321, 157);
            this.lbrecibido.Name = "lbrecibido";
            this.lbrecibido.Size = new System.Drawing.Size(70, 25);
            this.lbrecibido.TabIndex = 0;
            this.lbrecibido.Text = "label1";
            // 
            // REGRE
            // 
            this.REGRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGRE.Location = new System.Drawing.Point(604, 309);
            this.REGRE.Name = "REGRE";
            this.REGRE.Size = new System.Drawing.Size(125, 27);
            this.REGRE.TabIndex = 1;
            this.REGRE.Text = "Regresar";
            this.REGRE.UseVisualStyleBackColor = true;
            this.REGRE.Click += new System.EventHandler(this.REGRE_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.REGRE);
            this.Controls.Add(this.lbrecibido);
            this.Name = "Form2";
            this.Text = "Ventana 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbrecibido;
        private System.Windows.Forms.Button REGRE;
    }
}