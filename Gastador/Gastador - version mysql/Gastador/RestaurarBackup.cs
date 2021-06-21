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

namespace Gastador
{
    public partial class RestaurarBackup : Form
    {
        Backup backup = new Backup();
        string filePath = string.Empty;

        public RestaurarBackup()
        {
            InitializeComponent();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string folder = @"C:\Gastador\Backup"; //nome do diretorio a ser criado

            //Se o diretório não existir...

            if (!Directory.Exists(folder))
            {
                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);
            }
            //abrir tela para escolher arquivo especifico
            if (selecionarSqlOpenFileDialog.ShowDialog() == DialogResult.OK)
                filePath = selecionarSqlOpenFileDialog.FileName;
            diretorioTextBox.Text = filePath.ToString();
        }

        private void restaurarButton_Click(object sender, EventArgs e)
        {

            if (backup.RestauraBacukp(filePath) == 1)
            {
                Task.Delay(3000).Wait();
                MessageBox.Show("Backup restaurado com sucesso, feche o sistema e abra novamente!");

            }
            else
            {
                MessageBox.Show("Houve um problema ao restaurar o backup");
            }

        }

        private void RestaurarBackup_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção, você está em uma operação de risco!!");
        }
    }
}
