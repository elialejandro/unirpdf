namespace Unir_PDF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.file2 = new System.Windows.Forms.TextBox();
            this.open_file_1 = new System.Windows.Forms.Button();
            this.open_file_2 = new System.Windows.Forms.Button();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.labelKeywords = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Unir Archivos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(411, 45);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(236, 20);
            this.file1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archivo 2";
            // 
            // file2
            // 
            this.file2.Location = new System.Drawing.Point(411, 103);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(236, 20);
            this.file2.TabIndex = 4;
            // 
            // open_file_1
            // 
            this.open_file_1.Location = new System.Drawing.Point(654, 41);
            this.open_file_1.Name = "open_file_1";
            this.open_file_1.Size = new System.Drawing.Size(75, 23);
            this.open_file_1.TabIndex = 5;
            this.open_file_1.Text = "Buscar";
            this.open_file_1.UseVisualStyleBackColor = true;
            this.open_file_1.Click += new System.EventHandler(this.open_file_1_Click);
            // 
            // open_file_2
            // 
            this.open_file_2.Location = new System.Drawing.Point(654, 99);
            this.open_file_2.Name = "open_file_2";
            this.open_file_2.Size = new System.Drawing.Size(75, 23);
            this.open_file_2.TabIndex = 6;
            this.open_file_2.Text = "Buscar";
            this.open_file_2.UseVisualStyleBackColor = true;
            this.open_file_2.Click += new System.EventHandler(this.open_file_2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(411, 159);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(192, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(51, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(315, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Titulo";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(13, 74);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(32, 13);
            this.labelAutor.TabIndex = 10;
            this.labelAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(51, 71);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(315, 20);
            this.txtAutor.TabIndex = 11;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(13, 106);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(67, 13);
            this.labelHeader.TabIndex = 12;
            this.labelHeader.Text = "Encabezado";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(86, 103);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(280, 20);
            this.txtHeader.TabIndex = 13;
            // 
            // labelKeywords
            // 
            this.labelKeywords.AutoSize = true;
            this.labelKeywords.Location = new System.Drawing.Point(13, 138);
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(53, 13);
            this.labelKeywords.TabIndex = 14;
            this.labelKeywords.Text = "Keywords";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(86, 135);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(280, 20);
            this.txtKeywords.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 203);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.labelKeywords);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.open_file_2);
            this.Controls.Add(this.open_file_1);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Unir PDFs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox file1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox file2;
        private System.Windows.Forms.Button open_file_1;
        private System.Windows.Forms.Button open_file_2;
        private System.Windows.Forms.OpenFileDialog openFile1;
        private System.Windows.Forms.OpenFileDialog openFile2;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.TextBox txtKeywords;
    }
}

