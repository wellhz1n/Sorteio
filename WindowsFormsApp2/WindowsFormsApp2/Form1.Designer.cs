using System.IO;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cadastra = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortear = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SorteioList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cadastra
            // 
            this.Cadastra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cadastra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cadastra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cadastra.Location = new System.Drawing.Point(339, 65);
            this.Cadastra.Name = "Cadastra";
            this.Cadastra.Size = new System.Drawing.Size(75, 23);
            this.Cadastra.TabIndex = 0;
            this.Cadastra.Text = "Cadastrar";
            this.Cadastra.UseVisualStyleBackColor = false;
            this.Cadastra.Click += new System.EventHandler(this.Cadastra_Click);
            // 
            // Nome
            // 
            this.Nome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nome.Location = new System.Drawing.Point(226, 37);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(367, 22);
            this.Nome.TabIndex = 1;
            this.Nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 212);
            this.listBox1.TabIndex = 2;
            // 
            // sortear
            // 
            this.sortear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sortear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sortear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sortear.Location = new System.Drawing.Point(420, 65);
            this.sortear.Name = "sortear";
            this.sortear.Size = new System.Drawing.Size(75, 23);
            this.sortear.TabIndex = 3;
            this.sortear.Text = "Sortear";
            this.sortear.UseVisualStyleBackColor = false;
            this.sortear.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultado.Location = new System.Drawing.Point(218, 338);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 37);
            this.resultado.TabIndex = 4;
            this.resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // SorteioList
            // 
            this.SorteioList.FormattingEnabled = true;
            this.SorteioList.Location = new System.Drawing.Point(667, 23);
            this.SorteioList.Name = "SorteioList";
            this.SorteioList.Size = new System.Drawing.Size(121, 21);
            this.SorteioList.TabIndex = 10;
            this.SorteioList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sorteio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SorteioList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.sortear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Cadastra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio Tupperware";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastra;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sortear;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SorteioList;
        private System.Windows.Forms.Label label3;
    }
}

