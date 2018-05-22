namespace Provider
{
    partial class frmNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovo));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.lbPrestador = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.rbAssiste = new System.Windows.Forms.RadioButton();
            this.rbOcupacional = new System.Windows.Forms.RadioButton();
            this.rtbEmails = new System.Windows.Forms.RichTextBox();
            this.lbEmails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(352, 252);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(72, 30);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeCliente.Location = new System.Drawing.Point(12, 43);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(96, 17);
            this.lbNomeCliente.TabIndex = 1;
            this.lbNomeCliente.Text = "Nome Cliente:";
            // 
            // lbPrestador
            // 
            this.lbPrestador.AutoSize = true;
            this.lbPrestador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrestador.Location = new System.Drawing.Point(34, 91);
            this.lbPrestador.Name = "lbPrestador";
            this.lbPrestador.Size = new System.Drawing.Size(74, 17);
            this.lbPrestador.TabIndex = 2;
            this.lbPrestador.Text = "Prestador:";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCliente.Location = new System.Drawing.Point(114, 43);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(194, 23);
            this.txbNomeCliente.TabIndex = 3;
            // 
            // rbAssiste
            // 
            this.rbAssiste.AutoSize = true;
            this.rbAssiste.Checked = true;
            this.rbAssiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAssiste.Location = new System.Drawing.Point(114, 91);
            this.rbAssiste.Name = "rbAssiste";
            this.rbAssiste.Size = new System.Drawing.Size(71, 21);
            this.rbAssiste.TabIndex = 4;
            this.rbAssiste.TabStop = true;
            this.rbAssiste.Text = "Assiste";
            this.rbAssiste.UseVisualStyleBackColor = true;
            // 
            // rbOcupacional
            // 
            this.rbOcupacional.AutoSize = true;
            this.rbOcupacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOcupacional.Location = new System.Drawing.Point(114, 118);
            this.rbOcupacional.Name = "rbOcupacional";
            this.rbOcupacional.Size = new System.Drawing.Size(105, 21);
            this.rbOcupacional.TabIndex = 5;
            this.rbOcupacional.Text = "Ocupacional";
            this.rbOcupacional.UseVisualStyleBackColor = true;
            // 
            // rtbEmails
            // 
            this.rtbEmails.Location = new System.Drawing.Point(114, 163);
            this.rtbEmails.Name = "rtbEmails";
            this.rtbEmails.Size = new System.Drawing.Size(194, 119);
            this.rtbEmails.TabIndex = 6;
            this.rtbEmails.Text = "";
            // 
            // lbEmails
            // 
            this.lbEmails.AutoSize = true;
            this.lbEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmails.Location = new System.Drawing.Point(57, 164);
            this.lbEmails.Name = "lbEmails";
            this.lbEmails.Size = new System.Drawing.Size(51, 17);
            this.lbEmails.TabIndex = 7;
            this.lbEmails.Text = "E-mail:";
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 294);
            this.Controls.Add(this.lbEmails);
            this.Controls.Add(this.rtbEmails);
            this.Controls.Add(this.rbOcupacional);
            this.Controls.Add(this.rbAssiste);
            this.Controls.Add(this.txbNomeCliente);
            this.Controls.Add(this.lbPrestador);
            this.Controls.Add(this.lbNomeCliente);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbPrestador;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.RadioButton rbAssiste;
        private System.Windows.Forms.RadioButton rbOcupacional;
        private System.Windows.Forms.RichTextBox rtbEmails;
        private System.Windows.Forms.Label lbEmails;
    }
}