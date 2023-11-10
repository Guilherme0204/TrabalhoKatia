using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoKatia
{
    public class SalvarTxt
    {
        private string caminho = "C:\\Users\\gui26\\OneDrive\\Área de Trabalho\\Gravação Arquivos\\CheckOut.txt";
        public void gravar(string texto)
        {
            StreamWriter sw = File.AppendText(caminho);
            sw.WriteLine(texto);
            sw.Close();
        }
    }
}
