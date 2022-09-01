namespace TabControlMaskedTextBox
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lstDatas = new System.Windows.Forms.ListBox();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.mtxData = new System.Windows.Forms.MaskedTextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCandidato3 = new System.Windows.Forms.TextBox();
            this.txtCandidato2 = new System.Windows.Forms.TextBox();
            this.txtCandidato1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCandidatos = new System.Windows.Forms.ListBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.lstDatas);
            this.tabPage1.Controls.Add(this.lstEventos);
            this.tabPage1.Controls.Add(this.mtxData);
            this.tabPage1.Controls.Add(this.txtEvento);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluir.Location = new System.Drawing.Point(41, 388);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lstDatas
            // 
            this.lstDatas.FormattingEnabled = true;
            this.lstDatas.ItemHeight = 16;
            this.lstDatas.Location = new System.Drawing.Point(215, 111);
            this.lstDatas.Name = "lstDatas";
            this.lstDatas.Size = new System.Drawing.Size(157, 260);
            this.lstDatas.TabIndex = 3;
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.ItemHeight = 16;
            this.lstEventos.Location = new System.Drawing.Point(41, 111);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(157, 260);
            this.lstEventos.TabIndex = 3;
            // 
            // mtxData
            // 
            this.mtxData.Location = new System.Drawing.Point(99, 70);
            this.mtxData.Mask = "00/00/0000";
            this.mtxData.Name = "mtxData";
            this.mtxData.Size = new System.Drawing.Size(68, 22);
            this.mtxData.TabIndex = 2;
            this.mtxData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxData_KeyPress);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(99, 31);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(152, 22);
            this.txtEvento.TabIndex = 1;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Evento:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Votação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLimpar.Location = new System.Drawing.Point(16, 385);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(370, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCandidato3);
            this.groupBox2.Controls.Add(this.txtCandidato2);
            this.groupBox2.Controls.Add(this.txtCandidato1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // txtCandidato3
            // 
            this.txtCandidato3.Location = new System.Drawing.Point(112, 145);
            this.txtCandidato3.Name = "txtCandidato3";
            this.txtCandidato3.Size = new System.Drawing.Size(100, 22);
            this.txtCandidato3.TabIndex = 1;
            this.txtCandidato3.Text = "0";
            // 
            // txtCandidato2
            // 
            this.txtCandidato2.Location = new System.Drawing.Point(112, 89);
            this.txtCandidato2.Name = "txtCandidato2";
            this.txtCandidato2.Size = new System.Drawing.Size(100, 22);
            this.txtCandidato2.TabIndex = 1;
            this.txtCandidato2.Text = "0";
            // 
            // txtCandidato1
            // 
            this.txtCandidato1.Location = new System.Drawing.Point(112, 42);
            this.txtCandidato1.Name = "txtCandidato1";
            this.txtCandidato1.Size = new System.Drawing.Size(100, 22);
            this.txtCandidato1.TabIndex = 1;
            this.txtCandidato1.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Candidato 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Candidato 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Candidato 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCandidatos);
            this.groupBox1.Controls.Add(this.btnVotar);
            this.groupBox1.Location = new System.Drawing.Point(16, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidatos";
            // 
            // lstCandidatos
            // 
            this.lstCandidatos.FormattingEnabled = true;
            this.lstCandidatos.ItemHeight = 16;
            this.lstCandidatos.Items.AddRange(new object[] {
            "Candidato 01",
            "Candidato 02",
            "Candidato 03"});
            this.lstCandidatos.Location = new System.Drawing.Point(6, 31);
            this.lstCandidatos.Name = "lstCandidatos";
            this.lstCandidatos.Size = new System.Drawing.Size(358, 52);
            this.lstCandidatos.TabIndex = 1;
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVotar.Location = new System.Drawing.Point(6, 89);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(358, 23);
            this.btnVotar.TabIndex = 0;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 480);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Exemplo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mtxData;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDatas;
        private System.Windows.Forms.ListBox lstEventos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCandidatos;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCandidato3;
        private System.Windows.Forms.TextBox txtCandidato2;
        private System.Windows.Forms.TextBox txtCandidato1;
        private System.Windows.Forms.Button btnExcluir;
    }
}

