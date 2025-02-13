using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestarArchivos
{
    public partial class Form1 : Form
    {
        private List<string> mainFileLines;
        private List<string> filterFileLines;

        public Form1()
        {
            InitializeComponent();
            var versiones = typeof(Form1).Assembly.GetName().Version;
            lblVersion.Text = "Versión " + versiones.ToString();
            lblArchivoOriginal.Text = string.Empty;
            lblArchivoDescontar.Text = string.Empty;
        }

        private void BtnArchivoOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    mainFileLines = File.ReadAllLines(openFileDialog.FileName)
                                        .Select(line => line.Trim())
                                        .ToList();
                    lblArchivoOriginal.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo Original: {ex.Message}");
            }
        }
    
        private void BtnArchivoRestar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filterFileLines = File.ReadAllLines(openFileDialog.FileName)
                                         .Select(line => line.Trim())
                                         .ToList();
                    lblArchivoDescontar .Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo a Descontar: {ex.Message}");
            }
            
        }

        private void BtnSaveResult_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (mainFileLines != null && filterFileLines != null)
                {
                    var resultLines = mainFileLines.Except(filterFileLines).ToList();
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(saveFileDialog.FileName, resultLines);
                        MessageBox.Show($"Se guardo el archivo {saveFileDialog.FileName}");
                    }
                    ReinicializarFormulario();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona ambos archivos primero.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}");
            }
        }
        private void ReinicializarFormulario()
        {
            // Restablecer controles y variables
            mainFileLines = null;
            filterFileLines = null;
            lblArchivoOriginal.Text = string.Empty;
            lblArchivoDescontar.Text = string.Empty;
        }
    }
}
