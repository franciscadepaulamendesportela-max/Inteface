using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp2
{
    public class OrdemServico
    {
        public int Numero { get; set; }

        public string NomeCliente { get; set; } = "";

        public string NomeServico { get; set; } = "";

        public decimal Valor { get; set; }

        public DateTime DataAbertura { get; set; }

        public string Status { get; set; } = "";
    }
}
