namespace ChamadosTecnicosTec55.Adicionar
{
    partial class tecnico
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
            this.txb_nometec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_especialidadetec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_emailtec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_senhatec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_obstec = new System.Windows.Forms.TextBox();
            this.btnSalvartec = new System.Windows.Forms.Button();
            this.btnlimpartec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Técnico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txb_nometec
            // 
            this.txb_nometec.Location = new System.Drawing.Point(12, 84);
            this.txb_nometec.Name = "txb_nometec";
            this.txb_nometec.Size = new System.Drawing.Size(251, 20);
            this.txb_nometec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Especialidade";
            // 
            // txb_especialidadetec
            // 
            this.txb_especialidadetec.Location = new System.Drawing.Point(12, 150);
            this.txb_especialidadetec.Name = "txb_especialidadetec";
            this.txb_especialidadetec.Size = new System.Drawing.Size(251, 20);
            this.txb_especialidadetec.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txb_emailtec
            // 
            this.txb_emailtec.Location = new System.Drawing.Point(12, 215);
            this.txb_emailtec.Name = "txb_emailtec";
            this.txb_emailtec.Size = new System.Drawing.Size(251, 20);
            this.txb_emailtec.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha";
            // 
            // txb_senhatec
            // 
            this.txb_senhatec.Location = new System.Drawing.Point(12, 281);
            this.txb_senhatec.Name = "txb_senhatec";
            this.txb_senhatec.Size = new System.Drawing.Size(251, 20);
            this.txb_senhatec.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Observações";
            // 
            // txb_obstec
            // 
            this.txb_obstec.Location = new System.Drawing.Point(12, 338);
            this.txb_obstec.Multiline = true;
            this.txb_obstec.Name = "txb_obstec";
            this.txb_obstec.Size = new System.Drawing.Size(376, 59);
            this.txb_obstec.TabIndex = 12;
            // 
            // btnSalvartec
            // 
            this.btnSalvartec.Location = new System.Drawing.Point(78, 432);
            this.btnSalvartec.Name = "btnSalvartec";
            this.btnSalvartec.Size = new System.Drawing.Size(75, 23);
            this.btnSalvartec.TabIndex = 13;
            this.btnSalvartec.Text = "&Salvar";
            this.btnSalvartec.UseVisualStyleBackColor = true;
            this.btnSalvartec.Click += new System.EventHandler(this.btnSalvartec_Click);
            // 
            // btnlimpartec
            // 
            this.btnlimpartec.Location = new System.Drawing.Point(242, 432);
            this.btnlimpartec.Name = "btnlimpartec";
            this.btnlimpartec.Size = new System.Drawing.Size(75, 23);
            this.btnlimpartec.TabIndex = 14;
            this.btnlimpartec.Text = "&Limpar";
            this.btnlimpartec.UseVisualStyleBackColor = true;
            this.btnlimpartec.Click += new System.EventHandler(this.btnlimpartec_Click);
            // 
            // tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 481);
            this.Controls.Add(this.btnlimpartec);
            this.Controls.Add(this.btnSalvartec);
            this.Controls.Add(this.txb_obstec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_senhatec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_emailtec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_especialidadetec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_nometec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tecnico";
            this.Text = "tecnico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_nometec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_especialidadetec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_emailtec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_senhatec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_obstec;
        private System.Windows.Forms.Button btnSalvartec;
        private System.Windows.Forms.Button btnlimpartec;
    }
}