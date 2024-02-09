namespace MeusLivros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            tsbNovo = new ToolStripButton();
            tsbCancelar = new ToolStripButton();
            tsbGravar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbExcluir = new ToolStripButton();
            tsbImprimir = new ToolStripButton();
            tsbSobre = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            tstISBNBuscar = new ToolStripTextBox();
            tsbProcurar = new ToolStripButton();
            label1 = new Label();
            txtId = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            txtNomeLivro = new TextBox();
            txtISBN = new TextBox();
            label3 = new Label();
            txtAutores = new Label();
            txtEdicao = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtAnoEdicao = new TextBox();
            label7 = new Label();
            txtEditora = new TextBox();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNovo, tsbCancelar, tsbGravar, tsbEditar, tsbExcluir, tsbImprimir, tsbSobre, toolStripSeparator1, toolStripLabel1, tstISBNBuscar, tsbProcurar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1146, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            tsbNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNovo.Image = (Image)resources.GetObject("tsbNovo.Image");
            tsbNovo.ImageTransparentColor = Color.Magenta;
            tsbNovo.Name = "tsbNovo";
            tsbNovo.Size = new Size(29, 24);
            tsbNovo.Text = "Novo";
            // 
            // tsbCancelar
            // 
            tsbCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbCancelar.Image = (Image)resources.GetObject("tsbCancelar.Image");
            tsbCancelar.ImageTransparentColor = Color.Magenta;
            tsbCancelar.Name = "tsbCancelar";
            tsbCancelar.Size = new Size(29, 24);
            tsbCancelar.Text = "Cancelar";
            // 
            // tsbGravar
            // 
            tsbGravar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbGravar.Image = (Image)resources.GetObject("tsbGravar.Image");
            tsbGravar.ImageTransparentColor = Color.Magenta;
            tsbGravar.Name = "tsbGravar";
            tsbGravar.Size = new Size(29, 24);
            tsbGravar.Text = "Gravar";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(29, 24);
            tsbEditar.Text = "Editar";
            // 
            // tsbExcluir
            // 
            tsbExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbExcluir.Image = (Image)resources.GetObject("tsbExcluir.Image");
            tsbExcluir.ImageTransparentColor = Color.Magenta;
            tsbExcluir.Name = "tsbExcluir";
            tsbExcluir.Size = new Size(29, 24);
            tsbExcluir.Text = "Excluir";
            // 
            // tsbImprimir
            // 
            tsbImprimir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbImprimir.Image = (Image)resources.GetObject("tsbImprimir.Image");
            tsbImprimir.ImageTransparentColor = Color.Magenta;
            tsbImprimir.Name = "tsbImprimir";
            tsbImprimir.Size = new Size(29, 24);
            tsbImprimir.Text = "Imprimir";
            // 
            // tsbSobre
            // 
            tsbSobre.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSobre.Image = (Image)resources.GetObject("tsbSobre.Image");
            tsbSobre.ImageTransparentColor = Color.Magenta;
            tsbSobre.Name = "tsbSobre";
            tsbSobre.Size = new Size(29, 24);
            tsbSobre.Text = "Sobre";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(115, 24);
            toolStripLabel1.Text = "Buscar por ISBN";
            // 
            // tstISBNBuscar
            // 
            tstISBNBuscar.Name = "tstISBNBuscar";
            tstISBNBuscar.Size = new Size(100, 27);
            // 
            // tsbProcurar
            // 
            tsbProcurar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbProcurar.Image = (Image)resources.GetObject("tsbProcurar.Image");
            tsbProcurar.ImageTransparentColor = Color.Magenta;
            tsbProcurar.Name = "tsbProcurar";
            tsbProcurar.Size = new Size(29, 24);
            tsbProcurar.Text = "Procurar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 88);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(140, 81);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 27);
            txtId.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(140, 398);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Lido";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 127);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "ISBN";
            label2.Click += label2_Click;
            // 
            // txtNomeLivro
            // 
            txtNomeLivro.Location = new Point(140, 160);
            txtNomeLivro.Name = "txtNomeLivro";
            txtNomeLivro.Size = new Size(69, 27);
            txtNomeLivro.TabIndex = 5;
            txtNomeLivro.TextChanged += textBox1_TextChanged;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(140, 120);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(69, 27);
            txtISBN.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 167);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 7;
            label3.Text = "Nome do livro";
            // 
            // txtAutores
            // 
            txtAutores.AutoSize = true;
            txtAutores.Location = new Point(13, 215);
            txtAutores.Name = "txtAutores";
            txtAutores.Size = new Size(121, 20);
            txtAutores.TabIndex = 8;
            txtAutores.Text = "Autor(a)/Autores";
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(140, 256);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(69, 27);
            txtEdicao.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(140, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 27);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 263);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 11;
            label5.Text = "Edição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 302);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 12;
            label6.Text = "Ano da edição";
            // 
            // txtAnoEdicao
            // 
            txtAnoEdicao.Location = new Point(140, 295);
            txtAnoEdicao.Name = "txtAnoEdicao";
            txtAnoEdicao.Size = new Size(69, 27);
            txtAnoEdicao.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 349);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 14;
            label7.Text = "Editora";
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(140, 342);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(69, 27);
            txtEditora.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(486, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(660, 532);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 526);
            Controls.Add(pictureBox1);
            Controls.Add(txtEditora);
            Controls.Add(label7);
            Controls.Add(txtAnoEdicao);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(txtEdicao);
            Controls.Add(txtAutores);
            Controls.Add(label3);
            Controls.Add(txtISBN);
            Controls.Add(txtNomeLivro);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "v";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNovo;
        private ToolStripButton tsbCancelar;
        private ToolStripButton tsbGravar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbExcluir;
        private ToolStripButton tsbImprimir;
        private ToolStripButton tsbSobre;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox tstISBNBuscar;
        private ToolStripButton tsbProcurar;
        private Label label1;
        private TextBox txtId;
        private CheckBox checkBox1;
        private Label label2;
        private TextBox txtNomeLivro;
        private TextBox txtISBN;
        private Label label3;
        private Label txtAutores;
        private TextBox txtEdicao;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox txtAnoEdicao;
        private Label label7;
        private TextBox txtEditora;
        private PictureBox pictureBox1;
    }
}
