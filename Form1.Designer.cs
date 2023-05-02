
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
            this.PageControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.inpTBox = new System.Windows.Forms.TextBox();
            this.outTBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.binTBtn = new System.Windows.Forms.RadioButton();
            this.hexTBtn = new System.Windows.Forms.RadioButton();
            this.octTBtn = new System.Windows.Forms.RadioButton();
            this.decTBtn = new System.Windows.Forms.RadioButton();
            this.transBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.binCBtn = new System.Windows.Forms.RadioButton();
            this.hexCBtn = new System.Windows.Forms.RadioButton();
            this.octCBtn = new System.Windows.Forms.RadioButton();
            this.decCBtn = new System.Windows.Forms.RadioButton();
            this.creBtn = new System.Windows.Forms.Button();
            this.PageControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageControl
            // 
            this.PageControl.Controls.Add(this.tabPage1);
            this.PageControl.Controls.Add(this.tabPage2);
            this.PageControl.Controls.Add(this.tabPage3);
            this.PageControl.Location = new System.Drawing.Point(0, 0);
            this.PageControl.Name = "PageControl";
            this.PageControl.SelectedIndex = 0;
            this.PageControl.Size = new System.Drawing.Size(595, 335);
            this.PageControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.transBtn);
            this.tabPage1.Controls.Add(this.decTBtn);
            this.tabPage1.Controls.Add(this.octTBtn);
            this.tabPage1.Controls.Add(this.hexTBtn);
            this.tabPage1.Controls.Add(this.binTBtn);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.outTBox);
            this.tabPage1.Controls.Add(this.inpTBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Translate Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.creBtn);
            this.tabPage2.Controls.Add(this.decCBtn);
            this.tabPage2.Controls.Add(this.octCBtn);
            this.tabPage2.Controls.Add(this.hexCBtn);
            this.tabPage2.Controls.Add(this.binCBtn);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(587, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ajuda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // inpTBox
            // 
            this.inpTBox.Location = new System.Drawing.Point(0, 0);
            this.inpTBox.Multiline = true;
            this.inpTBox.Name = "inpTBox";
            this.inpTBox.Size = new System.Drawing.Size(290, 160);
            this.inpTBox.TabIndex = 0;
            // 
            // outTBox
            // 
            this.outTBox.Location = new System.Drawing.Point(297, 0);
            this.outTBox.Multiline = true;
            this.outTBox.Name = "outTBox";
            this.outTBox.ReadOnly = true;
            this.outTBox.Size = new System.Drawing.Size(290, 160);
            this.outTBox.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 286);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(587, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // binTBtn
            // 
            this.binTBtn.AutoSize = true;
            this.binTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binTBtn.Location = new System.Drawing.Point(0, 170);
            this.binTBtn.Name = "binTBtn";
            this.binTBtn.Size = new System.Drawing.Size(70, 21);
            this.binTBtn.TabIndex = 3;
            this.binTBtn.TabStop = true;
            this.binTBtn.Text = "Binário";
            this.binTBtn.UseVisualStyleBackColor = true;
            // 
            // hexTBtn
            // 
            this.hexTBtn.AutoSize = true;
            this.hexTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexTBtn.Location = new System.Drawing.Point(0, 200);
            this.hexTBtn.Name = "hexTBtn";
            this.hexTBtn.Size = new System.Drawing.Size(106, 21);
            this.hexTBtn.TabIndex = 4;
            this.hexTBtn.TabStop = true;
            this.hexTBtn.Text = "Hexadecimal";
            this.hexTBtn.UseVisualStyleBackColor = true;
            // 
            // octTBtn
            // 
            this.octTBtn.AutoSize = true;
            this.octTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octTBtn.Location = new System.Drawing.Point(0, 230);
            this.octTBtn.Name = "octTBtn";
            this.octTBtn.Size = new System.Drawing.Size(59, 21);
            this.octTBtn.TabIndex = 5;
            this.octTBtn.TabStop = true;
            this.octTBtn.Text = "Octal";
            this.octTBtn.UseVisualStyleBackColor = true;
            // 
            // decTBtn
            // 
            this.decTBtn.AutoSize = true;
            this.decTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decTBtn.Location = new System.Drawing.Point(0, 260);
            this.decTBtn.Name = "decTBtn";
            this.decTBtn.Size = new System.Drawing.Size(76, 21);
            this.decTBtn.TabIndex = 6;
            this.decTBtn.TabStop = true;
            this.decTBtn.Text = "Decimal";
            this.decTBtn.UseVisualStyleBackColor = true;
            // 
            // transBtn
            // 
            this.transBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transBtn.Location = new System.Drawing.Point(491, 230);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(96, 50);
            this.transBtn.TabIndex = 7;
            this.transBtn.Text = "Traduzir";
            this.transBtn.UseVisualStyleBackColor = true;
            this.transBtn.Click += new System.EventHandler(this.transBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 160);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(297, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(290, 160);
            this.textBox3.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(0, 286);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(587, 23);
            this.progressBar2.TabIndex = 2;
            // 
            // binCBtn
            // 
            this.binCBtn.AutoSize = true;
            this.binCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binCBtn.Location = new System.Drawing.Point(0, 170);
            this.binCBtn.Name = "binCBtn";
            this.binCBtn.Size = new System.Drawing.Size(70, 21);
            this.binCBtn.TabIndex = 3;
            this.binCBtn.TabStop = true;
            this.binCBtn.Text = "Binário";
            this.binCBtn.UseVisualStyleBackColor = true;
            // 
            // hexCBtn
            // 
            this.hexCBtn.AutoSize = true;
            this.hexCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexCBtn.Location = new System.Drawing.Point(0, 200);
            this.hexCBtn.Name = "hexCBtn";
            this.hexCBtn.Size = new System.Drawing.Size(106, 21);
            this.hexCBtn.TabIndex = 4;
            this.hexCBtn.TabStop = true;
            this.hexCBtn.Text = "Hexadecimal";
            this.hexCBtn.UseVisualStyleBackColor = true;
            // 
            // octCBtn
            // 
            this.octCBtn.AutoSize = true;
            this.octCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.octCBtn.Location = new System.Drawing.Point(0, 230);
            this.octCBtn.Name = "octCBtn";
            this.octCBtn.Size = new System.Drawing.Size(59, 21);
            this.octCBtn.TabIndex = 5;
            this.octCBtn.TabStop = true;
            this.octCBtn.Text = "Octal";
            this.octCBtn.UseVisualStyleBackColor = true;
            // 
            // decCBtn
            // 
            this.decCBtn.AutoSize = true;
            this.decCBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decCBtn.Location = new System.Drawing.Point(0, 260);
            this.decCBtn.Name = "decCBtn";
            this.decCBtn.Size = new System.Drawing.Size(76, 21);
            this.decCBtn.TabIndex = 6;
            this.decCBtn.TabStop = true;
            this.decCBtn.Text = "Decimal";
            this.decCBtn.UseVisualStyleBackColor = true;
            // 
            // creBtn
            // 
            this.creBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creBtn.Location = new System.Drawing.Point(491, 230);
            this.creBtn.Name = "creBtn";
            this.creBtn.Size = new System.Drawing.Size(96, 50);
            this.creBtn.TabIndex = 7;
            this.creBtn.Text = "Create";
            this.creBtn.UseVisualStyleBackColor = true;
            // 
            // TranslatorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 333);
            this.Controls.Add(this.PageControl);
            this.MaximizeBox = false;
            this.Name = "TranslatorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.PageControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PageControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button transBtn;
        private System.Windows.Forms.RadioButton decTBtn;
        private System.Windows.Forms.RadioButton octTBtn;
        private System.Windows.Forms.RadioButton hexTBtn;
        private System.Windows.Forms.RadioButton binTBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox outTBox;
        private System.Windows.Forms.TextBox inpTBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button creBtn;
        private System.Windows.Forms.RadioButton decCBtn;
        private System.Windows.Forms.RadioButton octCBtn;
        private System.Windows.Forms.RadioButton hexCBtn;
        private System.Windows.Forms.RadioButton binCBtn;
    }
}

