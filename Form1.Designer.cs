
namespace Translator
{
    partial class TranslatorPage
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
            this.inpBox = new System.Windows.Forms.TextBox();
            this.outBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.decIBtn = new System.Windows.Forms.RadioButton();
            this.octIBtn = new System.Windows.Forms.RadioButton();
            this.binIBtn = new System.Windows.Forms.RadioButton();
            this.hexIBtn = new System.Windows.Forms.RadioButton();
            this.decOBtn = new System.Windows.Forms.RadioButton();
            this.binOBtn = new System.Windows.Forms.RadioButton();
            this.hexOBtn = new System.Windows.Forms.RadioButton();
            this.octOBtn = new System.Windows.Forms.RadioButton();
            this.transBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inpBox
            // 
            this.inpBox.Location = new System.Drawing.Point(12, 12);
            this.inpBox.Multiline = true;
            this.inpBox.Name = "inpBox";
            this.inpBox.Size = new System.Drawing.Size(275, 150);
            this.inpBox.TabIndex = 0;
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(305, 12);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(275, 150);
            this.outBox.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 298);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(568, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // decIBtn
            // 
            this.decIBtn.AutoSize = true;
            this.decIBtn.Location = new System.Drawing.Point(12, 170);
            this.decIBtn.Name = "decIBtn";
            this.decIBtn.Size = new System.Drawing.Size(63, 17);
            this.decIBtn.TabIndex = 3;
            this.decIBtn.TabStop = true;
            this.decIBtn.Text = "Decimal";
            this.decIBtn.UseVisualStyleBackColor = true;
            // 
            // octIBtn
            // 
            this.octIBtn.AutoSize = true;
            this.octIBtn.Location = new System.Drawing.Point(12, 275);
            this.octIBtn.Name = "octIBtn";
            this.octIBtn.Size = new System.Drawing.Size(50, 17);
            this.octIBtn.TabIndex = 4;
            this.octIBtn.TabStop = true;
            this.octIBtn.Text = "Octal";
            this.octIBtn.UseVisualStyleBackColor = true;
            // 
            // binIBtn
            // 
            this.binIBtn.AutoSize = true;
            this.binIBtn.Location = new System.Drawing.Point(12, 205);
            this.binIBtn.Name = "binIBtn";
            this.binIBtn.Size = new System.Drawing.Size(57, 17);
            this.binIBtn.TabIndex = 5;
            this.binIBtn.TabStop = true;
            this.binIBtn.Text = "Binário";
            this.binIBtn.UseVisualStyleBackColor = true;
            // 
            // hexIBtn
            // 
            this.hexIBtn.AutoSize = true;
            this.hexIBtn.Location = new System.Drawing.Point(13, 240);
            this.hexIBtn.Name = "hexIBtn";
            this.hexIBtn.Size = new System.Drawing.Size(86, 17);
            this.hexIBtn.TabIndex = 6;
            this.hexIBtn.TabStop = true;
            this.hexIBtn.Text = "Hexadecimal";
            this.hexIBtn.UseVisualStyleBackColor = true;
            // 
            // decOBtn
            // 
            this.decOBtn.AutoSize = true;
            this.decOBtn.Location = new System.Drawing.Point(305, 170);
            this.decOBtn.Name = "decOBtn";
            this.decOBtn.Size = new System.Drawing.Size(63, 17);
            this.decOBtn.TabIndex = 7;
            this.decOBtn.TabStop = true;
            this.decOBtn.Text = "Decimal";
            this.decOBtn.UseVisualStyleBackColor = true;
            // 
            // binOBtn
            // 
            this.binOBtn.AutoSize = true;
            this.binOBtn.Location = new System.Drawing.Point(305, 205);
            this.binOBtn.Name = "binOBtn";
            this.binOBtn.Size = new System.Drawing.Size(57, 17);
            this.binOBtn.TabIndex = 8;
            this.binOBtn.TabStop = true;
            this.binOBtn.Text = "Binário";
            this.binOBtn.UseVisualStyleBackColor = true;
            // 
            // hexOBtn
            // 
            this.hexOBtn.AutoSize = true;
            this.hexOBtn.Location = new System.Drawing.Point(305, 240);
            this.hexOBtn.Name = "hexOBtn";
            this.hexOBtn.Size = new System.Drawing.Size(86, 17);
            this.hexOBtn.TabIndex = 9;
            this.hexOBtn.TabStop = true;
            this.hexOBtn.Text = "Hexadecimal";
            this.hexOBtn.UseVisualStyleBackColor = true;
            // 
            // octOBtn
            // 
            this.octOBtn.AutoSize = true;
            this.octOBtn.Location = new System.Drawing.Point(305, 275);
            this.octOBtn.Name = "octOBtn";
            this.octOBtn.Size = new System.Drawing.Size(50, 17);
            this.octOBtn.TabIndex = 10;
            this.octOBtn.TabStop = true;
            this.octOBtn.Text = "Octal";
            this.octOBtn.UseVisualStyleBackColor = true;
            // 
            // transBtn
            // 
            this.transBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transBtn.Location = new System.Drawing.Point(501, 240);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(79, 52);
            this.transBtn.TabIndex = 11;
            this.transBtn.Text = "Traduzir";
            this.transBtn.UseVisualStyleBackColor = true;
            // 
            // TranslatorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 333);
            this.Controls.Add(this.transBtn);
            this.Controls.Add(this.octOBtn);
            this.Controls.Add(this.hexOBtn);
            this.Controls.Add(this.binOBtn);
            this.Controls.Add(this.decOBtn);
            this.Controls.Add(this.hexIBtn);
            this.Controls.Add(this.binIBtn);
            this.Controls.Add(this.octIBtn);
            this.Controls.Add(this.decIBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.inpBox);
            this.MaximizeBox = false;
            this.Name = "TranslatorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpBox;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton decIBtn;
        private System.Windows.Forms.RadioButton octIBtn;
        private System.Windows.Forms.RadioButton binIBtn;
        private System.Windows.Forms.RadioButton hexIBtn;
        private System.Windows.Forms.RadioButton decOBtn;
        private System.Windows.Forms.RadioButton binOBtn;
        private System.Windows.Forms.RadioButton hexOBtn;
        private System.Windows.Forms.RadioButton octOBtn;
        private System.Windows.Forms.Button transBtn;
    }
}

