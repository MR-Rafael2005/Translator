
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
            this.PagesControl = new System.Windows.Forms.TabControl();
            this.BinPage = new System.Windows.Forms.TabPage();
            this.BinBtn1 = new System.Windows.Forms.Button();
            this.BinBtn0 = new System.Windows.Forms.Button();
            this.BinOutBox = new System.Windows.Forms.TextBox();
            this.BinInpBox = new System.Windows.Forms.TextBox();
            this.HexPage = new System.Windows.Forms.TabPage();
            this.OctPage = new System.Windows.Forms.TabPage();
            this.ASCIIPage = new System.Windows.Forms.TabPage();
            this.BinBtn2 = new System.Windows.Forms.Button();
            this.BinBtn3 = new System.Windows.Forms.Button();
            this.BinBtn4 = new System.Windows.Forms.Button();
            this.BinBtn5 = new System.Windows.Forms.Button();
            this.BinBtn6 = new System.Windows.Forms.Button();
            this.PagesControl.SuspendLayout();
            this.BinPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagesControl
            // 
            this.PagesControl.Controls.Add(this.BinPage);
            this.PagesControl.Controls.Add(this.HexPage);
            this.PagesControl.Controls.Add(this.OctPage);
            this.PagesControl.Controls.Add(this.ASCIIPage);
            this.PagesControl.Location = new System.Drawing.Point(0, 0);
            this.PagesControl.Name = "PagesControl";
            this.PagesControl.SelectedIndex = 0;
            this.PagesControl.Size = new System.Drawing.Size(585, 362);
            this.PagesControl.TabIndex = 0;
            // 
            // BinPage
            // 
            this.BinPage.Controls.Add(this.BinBtn6);
            this.BinPage.Controls.Add(this.BinBtn5);
            this.BinPage.Controls.Add(this.BinBtn4);
            this.BinPage.Controls.Add(this.BinBtn3);
            this.BinPage.Controls.Add(this.BinBtn2);
            this.BinPage.Controls.Add(this.BinBtn1);
            this.BinPage.Controls.Add(this.BinBtn0);
            this.BinPage.Controls.Add(this.BinOutBox);
            this.BinPage.Controls.Add(this.BinInpBox);
            this.BinPage.Location = new System.Drawing.Point(4, 22);
            this.BinPage.Name = "BinPage";
            this.BinPage.Padding = new System.Windows.Forms.Padding(3);
            this.BinPage.Size = new System.Drawing.Size(577, 336);
            this.BinPage.TabIndex = 0;
            this.BinPage.Text = "Binary";
            this.BinPage.UseVisualStyleBackColor = true;
            // 
            // BinBtn1
            // 
            this.BinBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn1.Location = new System.Drawing.Point(110, 160);
            this.BinBtn1.Name = "BinBtn1";
            this.BinBtn1.Size = new System.Drawing.Size(50, 50);
            this.BinBtn1.TabIndex = 3;
            this.BinBtn1.Text = "1";
            this.BinBtn1.UseVisualStyleBackColor = true;
            // 
            // BinBtn0
            // 
            this.BinBtn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn0.Location = new System.Drawing.Point(32, 160);
            this.BinBtn0.Name = "BinBtn0";
            this.BinBtn0.Size = new System.Drawing.Size(50, 50);
            this.BinBtn0.TabIndex = 2;
            this.BinBtn0.Text = "0";
            this.BinBtn0.UseVisualStyleBackColor = true;
            // 
            // BinOutBox
            // 
            this.BinOutBox.Location = new System.Drawing.Point(292, 0);
            this.BinOutBox.Multiline = true;
            this.BinOutBox.Name = "BinOutBox";
            this.BinOutBox.ReadOnly = true;
            this.BinOutBox.Size = new System.Drawing.Size(285, 150);
            this.BinOutBox.TabIndex = 1;
            // 
            // BinInpBox
            // 
            this.BinInpBox.Location = new System.Drawing.Point(0, 0);
            this.BinInpBox.Multiline = true;
            this.BinInpBox.Name = "BinInpBox";
            this.BinInpBox.ReadOnly = true;
            this.BinInpBox.Size = new System.Drawing.Size(285, 150);
            this.BinInpBox.TabIndex = 0;
            // 
            // HexPage
            // 
            this.HexPage.Location = new System.Drawing.Point(4, 22);
            this.HexPage.Name = "HexPage";
            this.HexPage.Padding = new System.Windows.Forms.Padding(3);
            this.HexPage.Size = new System.Drawing.Size(577, 336);
            this.HexPage.TabIndex = 1;
            this.HexPage.Text = "Hexadecimal";
            this.HexPage.UseVisualStyleBackColor = true;
            // 
            // OctPage
            // 
            this.OctPage.Location = new System.Drawing.Point(4, 22);
            this.OctPage.Name = "OctPage";
            this.OctPage.Padding = new System.Windows.Forms.Padding(3);
            this.OctPage.Size = new System.Drawing.Size(577, 336);
            this.OctPage.TabIndex = 2;
            this.OctPage.Text = "Octal";
            this.OctPage.UseVisualStyleBackColor = true;
            // 
            // ASCIIPage
            // 
            this.ASCIIPage.Location = new System.Drawing.Point(4, 22);
            this.ASCIIPage.Name = "ASCIIPage";
            this.ASCIIPage.Padding = new System.Windows.Forms.Padding(3);
            this.ASCIIPage.Size = new System.Drawing.Size(577, 336);
            this.ASCIIPage.TabIndex = 3;
            this.ASCIIPage.Text = "ASCII";
            this.ASCIIPage.UseVisualStyleBackColor = true;
            // 
            // BinBtn2
            // 
            this.BinBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn2.Location = new System.Drawing.Point(187, 160);
            this.BinBtn2.Name = "BinBtn2";
            this.BinBtn2.Size = new System.Drawing.Size(50, 50);
            this.BinBtn2.TabIndex = 4;
            this.BinBtn2.Text = "2";
            this.BinBtn2.UseVisualStyleBackColor = true;
            // 
            // BinBtn3
            // 
            this.BinBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn3.Location = new System.Drawing.Point(32, 216);
            this.BinBtn3.Name = "BinBtn3";
            this.BinBtn3.Size = new System.Drawing.Size(50, 50);
            this.BinBtn3.TabIndex = 5;
            this.BinBtn3.Text = "3";
            this.BinBtn3.UseVisualStyleBackColor = true;
            // 
            // BinBtn4
            // 
            this.BinBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn4.Location = new System.Drawing.Point(110, 216);
            this.BinBtn4.Name = "BinBtn4";
            this.BinBtn4.Size = new System.Drawing.Size(50, 50);
            this.BinBtn4.TabIndex = 6;
            this.BinBtn4.Text = "4";
            this.BinBtn4.UseVisualStyleBackColor = true;
            // 
            // BinBtn5
            // 
            this.BinBtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn5.Location = new System.Drawing.Point(187, 216);
            this.BinBtn5.Name = "BinBtn5";
            this.BinBtn5.Size = new System.Drawing.Size(50, 50);
            this.BinBtn5.TabIndex = 7;
            this.BinBtn5.Text = "5";
            this.BinBtn5.UseVisualStyleBackColor = true;
            // 
            // BinBtn6
            // 
            this.BinBtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinBtn6.Location = new System.Drawing.Point(32, 272);
            this.BinBtn6.Name = "BinBtn6";
            this.BinBtn6.Size = new System.Drawing.Size(50, 50);
            this.BinBtn6.TabIndex = 8;
            this.BinBtn6.Text = "6";
            this.BinBtn6.UseVisualStyleBackColor = true;
            // 
            // TranslatorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.PagesControl);
            this.MaximizeBox = false;
            this.Name = "TranslatorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translator";
            this.PagesControl.ResumeLayout(false);
            this.BinPage.ResumeLayout(false);
            this.BinPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PagesControl;
        private System.Windows.Forms.TabPage BinPage;
        private System.Windows.Forms.TabPage HexPage;
        private System.Windows.Forms.TabPage OctPage;
        private System.Windows.Forms.TabPage ASCIIPage;
        private System.Windows.Forms.Button BinBtn1;
        private System.Windows.Forms.Button BinBtn0;
        private System.Windows.Forms.TextBox BinOutBox;
        private System.Windows.Forms.TextBox BinInpBox;
        private System.Windows.Forms.Button BinBtn6;
        private System.Windows.Forms.Button BinBtn5;
        private System.Windows.Forms.Button BinBtn4;
        private System.Windows.Forms.Button BinBtn3;
        private System.Windows.Forms.Button BinBtn2;
    }
}

