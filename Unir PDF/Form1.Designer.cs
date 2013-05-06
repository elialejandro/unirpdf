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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Unir Archivos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(48, 45);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(236, 20);
            this.file1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archivo 2";
            // 
            // file2
            // 
            this.file2.Location = new System.Drawing.Point(48, 103);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(236, 20);
            this.file2.TabIndex = 4;
            // 
            // open_file_1
            // 
            this.open_file_1.Location = new System.Drawing.Point(291, 41);
            this.open_file_1.Name = "open_file_1";
            this.open_file_1.Size = new System.Drawing.Size(75, 23);
            this.open_file_1.TabIndex = 5;
            this.open_file_1.Text = "Buscar";
            this.open_file_1.UseVisualStyleBackColor = true;
            this.open_file_1.Click += new System.EventHandler(this.open_file_1_Click);
            // 
            // open_file_2
            // 
            this.open_file_2.Location = new System.Drawing.Point(291, 99);
            this.open_file_2.Name = "open_file_2";
            this.open_file_2.Size = new System.Drawing.Size(75, 23);
            this.open_file_2.TabIndex = 6;
            this.open_file_2.Text = "Buscar";
            this.open_file_2.UseVisualStyleBackColor = true;
            this.open_file_2.Click += new System.EventHandler(this.open_file_2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(48, 159);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(192, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 211);
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
    }
}

