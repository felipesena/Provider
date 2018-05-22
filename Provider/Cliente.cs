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
        public static List<Cliente> clientes { get; private set; }

        [JsonProperty]
        public string Nome { get; private set; }
        [JsonProperty]
        public string Prestador { get; private set; }
        [JsonProperty]
        public List<string> Email { get; private set; }

        private const string FILE_BASE = @".\clientes.json";

        /// <summary>
        /// Inicializa lista de clientes
        /// </summary>
        public static void Inicializa()
        {
            clientes = LeJson().OrderBy(x => x.Nome).ToList<Cliente>();
        }     
        
        /// <summary>
        /// Adiciona novo cliente na lista
        /// </summary>
        /// <param name="cliente"></param>
        public static void Novo(Cliente cliente)
        {
            clientes.Add(cliente);
            clientes = clientes.OrderBy(x => x.Nome).ToList<Cliente>();
            SalvaJson(clientes);
        }
        /// <summary>
        /// Alterar cliente informado na lista com dados do parâmetro
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="nome"></param>
        /// <param name="prestador"></param>
        /// <param name="email"></param>
        public static void Altera(Cliente cliente, string nome, string prestador, List<string> email)
        {
            int index;
            index = clientes.IndexOf(cliente);

            clientes[index].Nome = nome;
            clientes[index].Prestador = prestador;
            clientes[index].Email = email;

            SalvaJson(clientes);
        }

        /// <summary>
        /// Apaga cliente da lista
        /// </summary>
        /// <param name="cliente"></param>
        public static void Apaga(Cliente cliente)
        {
            clientes.Remove(cliente);
            SalvaJson(clientes);
        }

        /// <summary>
        /// Instancia novo objeto Cliente vazio
        /// </summary>
        private Cliente()
        {

        }

        /// <summary>
        /// Instancia novo objeto Cliente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="prestador"></param>
        public Cliente(string nome, string prestador)
        {
            this.Nome = nome;
            this.Prestador = prestador;
        }

        /// <summary>
        /// Instancia novo objeto Cliente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="prestador"></param>
        /// <param name="email"></param>
        public Cliente(string nome, string prestador, List<string> email)
        {
            this.Nome = nome;
            this.Prestador = prestador;
            this.Email = email;
        }

        public static void Importar(string planilha)
        {    
            if (!File.Exists(planilha))
                throw new FileNotFoundException("Arquivo de importação não existe.", planilha);

            int rowCount;
            string nome, fornecedor;
            List<Cliente> clientes = LeJson();

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
                    fornecedor = (importaRange.Cells[i, 2] as Microsoft.Office.Interop.Excel.Range).Value2;

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

        private static List<Cliente> LeJson()
        {
            List<Cliente> clientes;
            string json;

            if (File.Exists(FILE_BASE))
            {
                json = File.ReadAllText(FILE_BASE);
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(json);
            }
            else
                clientes = new List<Cliente>();

            return clientes;
        }

        private static void SalvaJson(List<Cliente> clientes)
        {            
            File.WriteAllText(FILE_BASE, JsonConvert.SerializeObject(clientes));
        }        
    }
}
