using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Unir_PDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_file_1_Click(object sender, EventArgs e)
        {
            openFile1.InitialDirectory = Environment.SpecialFolder.CommonDocuments.ToString();
            openFile1.Filter = "Adobe Acrobat Document PDF (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFile1.FilterIndex = 1;
            openFile1.RestoreDirectory = true;
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file1.Text = openFile1.SafeFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            openFile1.Dispose();
        }

        private void open_file_2_Click(object sender, EventArgs e)
        {
            openFile2.InitialDirectory = Environment.SpecialFolder.CommonDocuments.ToString();
            openFile2.Filter = "Adobe Acrobat Document PDF (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFile2.FilterIndex = 1;
            openFile2.RestoreDirectory = true;
            if (openFile2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file2.Text = openFile2.SafeFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            openFile2.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile1.SafeFileName == "" || openFile2.SafeFileName == "")
            {
                MessageBox.Show("No haz seleccionado ningún PDF", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Se unira \"" + openFile1.SafeFileName + "\" con \"" + openFile2.SafeFileName + "\"");
            saveFile.Filter = "Adobe Acrobat Document PDF (*.pdf)|*.pdf";
            saveFile.FilterIndex = 1;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Se guardara en la siguiente ruta:\n" + saveFile.FileName);

                FileStream myStream = new FileStream(saveFile.FileName,FileMode.OpenOrCreate);

                PdfReader reader  = new PdfReader(openFile1.FileName);
                PdfReader reader2 = new PdfReader(openFile2.FileName);
                Document document = new Document(reader.GetPageSizeWithRotation(1));
                PdfCopy writer = new PdfCopy(document, myStream);
                document.Open();
                document.AddCreationDate();
                document.AddAuthor("Eli Alejandro Moreno López");
                document.AddHeader("Reporte final de residencia", "Informe final");
                document.AddKeywords("Residencia Profesional, ITTG, Instituto Tecnológico de Tuxtla Gutiérrez, Web Page, Página Web, PHP, Zend Framework");
                document.AddProducer();
                document.AddTitle("Reporte Final de Residencia Profesional");
                // Calculando incremento
                progressBar.Refresh();
                int incremento = (int)(100 / (reader.NumberOfPages + reader2.NumberOfPages));
                MessageBox.Show("Incremento es: " + incremento);
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    writer.AddPage(writer.GetImportedPage(reader, i));
                    progressBar.PerformStep();
                }
                progressBar.Increment(50);
                for (int i = 1; i <= reader2.NumberOfPages; i++)
                {
                    writer.AddPage(writer.GetImportedPage(reader2, i));
                    progressBar.PerformStep();
                }
                progressBar.Increment(100);
                document.Close();
            }
        }

    }
}
