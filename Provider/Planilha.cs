using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Provider
{
    public class Planilha
    {
        /// <summary>
        /// Preenche planilha com a razão social de acordo com cada cliente, 
        /// de acordo com dados já salvos.
        /// </summary>
        /// <param name="planilha"></param>
        public void PreencherPlanilha(string planilha)
        {
            Microsoft.Office.Interop.Excel.Application preencherApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook preencherWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet preencherWorkSheet;
            Microsoft.Office.Interop.Excel.Range preencherRange;

            Microsoft.Office.Interop.Excel.Application buscaApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook buscaWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet buscaWorkSheet;
            Microsoft.Office.Interop.Excel.Range buscaRange;

            int rowsCount;
            int numEmpresas = 0;

            preencherWorkBook = preencherApp.Workbooks.Open(planilha, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            preencherWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)preencherWorkBook.Worksheets.Item[1];

            preencherRange = preencherWorkSheet.UsedRange;

            numEmpresas = preencherRange.Rows.Count;

            Microsoft.Office.Interop.Excel.Range formatacao;

            //Célula Prestador
            formatacao = preencherWorkSheet.Range["B1", "B1"];
            formatacao.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
            formatacao.Cells.Value2 = "Prestador";
            formatacao.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            formatacao.Font.Bold = true;
            formatacao.Font.Name = "Calibri";
            formatacao.Font.Size = 11;

            //Célula Empresa
            formatacao = preencherWorkSheet.Range["A1", "A1"];
            formatacao.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
            formatacao.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Célula Valor
            formatacao = preencherWorkSheet.Range["C1", "C1"];
            formatacao.Interior.Color = ColorTranslator.ToOle(Color.LightGreen);
            formatacao.Cells.Value2 = "Valor";
            formatacao.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            formatacao.Font.Bold = true;
            formatacao.Font.Name = "Calibri";
            formatacao.Font.Size = 11;

            preencherRange = preencherWorkSheet.UsedRange;
            preencherRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            //Fecha e salva planilha
            preencherWorkBook.Save();
            preencherWorkBook.Close(true, planilha);
            preencherApp.Quit();
        }
    }
}
