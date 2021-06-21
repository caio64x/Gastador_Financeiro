using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gastador
{
    public class Backup : Conexao
    {
        MySqlConnection banco;

        public Backup()
        {
            this.banco = Conexao.getConnection();
        }

        public int GerarBackup()
        {
            
            Task.Delay(3000).Wait();

            string folder = @"C:\Gastador\Backup"; //nome do diretorio a ser criado

            //Se o diretório não existir...

            if (!Directory.Exists(folder))
            {

                //Criamos um com o nome folder
                Directory.CreateDirectory(folder);

            }
            String local = "C:\\Gastador\\Backup";

            // define o nome do arquivo de backup de acordo com a data e hora.
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.ToLongTimeString().Replace(":", "");
            string nomeDoArquivo = dia + mes + ano + "_" + hora;

            // fim

            // gera o conteúdo do arquivo de backup e salva no local definido no config.dat
            string arquivo = local + "\\" + nomeDoArquivo + ".sql";

            try
            {
                using (MySqlConnection conn = banco)
                {
                    conn.Close();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(arquivo);
                            conn.Close();
                        }
                    }
                }
                // fim

                return 1;
            }
            catch
            {
                return 0;
            }

        }

        public int RestauraBacukp(string file)
        {
            // string file = "C:\\backup.sql";
            try
            {
                using (MySqlConnection conn = (banco))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            conn.Close();
                        }
                    }
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
