
namespace projeto_loja
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.List_Produtos = new System.Windows.Forms.ListBox();
            this.List_Descrição = new System.Windows.Forms.ListBox();
            this.List_Preço = new System.Windows.Forms.ListBox();
            this.pic_carrinho1 = new System.Windows.Forms.PictureBox();
            this.check_produto1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carrinho1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.check_produto1);
            this.groupBox1.Controls.Add(this.pic_carrinho1);
            this.groupBox1.Controls.Add(this.List_Preço);
            this.groupBox1.Controls.Add(this.List_Descrição);
            this.groupBox1.Controls.Add(this.List_Produtos);
            this.groupBox1.Location = new System.Drawing.Point(1, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // List_Produtos
            // 
            this.List_Produtos.FormattingEnabled = true;
            this.List_Produtos.Location = new System.Drawing.Point(56, 19);
            this.List_Produtos.Name = "List_Produtos";
            this.List_Produtos.Size = new System.Drawing.Size(111, 225);
            this.List_Produtos.TabIndex = 0;
            // 
            // List_Descrição
            // 
            this.List_Descrição.FormattingEnabled = true;
            this.List_Descrição.Location = new System.Drawing.Point(203, 19);
            this.List_Descrição.Name = "List_Descrição";
            this.List_Descrição.Size = new System.Drawing.Size(117, 225);
            this.List_Descrição.TabIndex = 1;
            // 
            // List_Preço
            // 
            this.List_Preço.FormattingEnabled = true;
            this.List_Preço.Location = new System.Drawing.Point(359, 19);
            this.List_Preço.Name = "List_Preço";
            this.List_Preço.Size = new System.Drawing.Size(118, 225);
            this.List_Preço.TabIndex = 2;
            // 
            // pic_carrinho1
            // 
            this.pic_carrinho1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_carrinho1.BackgroundImage")));
            this.pic_carrinho1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_carrinho1.Location = new System.Drawing.Point(542, 81);
            this.pic_carrinho1.Name = "pic_carrinho1";
            this.pic_carrinho1.Size = new System.Drawing.Size(204, 180);
            this.pic_carrinho1.TabIndex = 3;
            this.pic_carrinho1.TabStop = false;
            // 
            // check_produto1
            // 
            this.check_produto1.AutoSize = true;
            this.check_produto1.Location = new System.Drawing.Point(542, 30);
            this.check_produto1.Name = "check_produto1";
            this.check_produto1.Size = new System.Drawing.Size(72, 17);
            this.check_produto1.TabIndex = 4;
            this.check_produto1.Text = "Produto 1";
            this.check_produto1.UseVisualStyleBackColor = true;
            this.check_produto1.CheckedChanged += new System.EventHandler(this.check_produto1_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(657, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(27, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_carrinho1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox check_produto1;
        private System.Windows.Forms.PictureBox pic_carrinho1;
        private System.Windows.Forms.ListBox List_Preço;
        private System.Windows.Forms.ListBox List_Descrição;
        private System.Windows.Forms.ListBox List_Produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

