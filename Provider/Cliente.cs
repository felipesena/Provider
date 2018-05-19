using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Provider
{
    public class Cliente
    {
        private string nome;
        private string prestador;
        private const string FILE_BASE = @".\clientes.json";

        public Cliente(string nome, string prestador)
        {
            this.nome = nome;
            this.prestador = prestador;
        }

        public static void Importar(string planilha)
        {    
            if (!File.Exists(planilha))
                throw new FileNotFoundException("Arquivo de importação não existe.", planilha);

            int rowCount;
            string nome, fornecedor;
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                Microsoft.Office.Interop.Excel.Application importaApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook importaWorkBook = importaApp.Workbooks.Open(planilha);
                Microsoft.Office.Interop.Excel.Worksheet importaWorkSheet;
                Microsoft.Office.Interop.Excel.Range importaRange;

                importaWorkSheet = importaWorkBook.Worksheets.Item[1];

                importaRange = importaWorkSheet.UsedRange;

                rowCount = importaRange.Rows.Count;

                for (int i = 2; i <= rowCount; i++)
                {
                    nome = (importaRange.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2;
                    fornecedor = (importaRange.Cells[i, 1] as Microsoft.Office.Interop.Excel.Range).Value2;

                    if (!clientes.Contains(new Cliente(nome, fornecedor)))
                        clientes.Add(new Cliente(nome, fornecedor));
                }

                SalvaJson(clientes);
            }
            catch(COMException e)
            {
                throw e;
            }
            finally
            {
                Form frmMensagem = new frmNotification("Importado com sucesso");
                frmMensagem.Show();
            }
        }

        private static void SalvaJson(List<Cliente> clientes)
        {            
            File.WriteAllText(FILE_BASE, JsonConvert.SerializeObject(clientes));
        }
    }
}
