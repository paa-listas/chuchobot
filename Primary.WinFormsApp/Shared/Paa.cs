using Primary.Data;
using Primary.Data.Orders;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primary.WinFormsApp
{
    internal class Paa
    {
        internal static Task<string> ShowComoComprarOrden(InstrumentDetail instrument, decimal nominales, decimal precio)
        {
            string orden = $"VENDER {nominales:#,##0} nominales de {instrument.InstrumentId.SymbolWithoutPrefix()} a {precio}";
            MessageBox.Show(orden, "Operar esto:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Task.Run(() => orden);
        }

        internal static Task<string> ShowComoVenderOrden(InstrumentDetail instrument, decimal nominales, decimal precio)
        {
            string orden = $"COMPRAR {nominales:#,##0} nominales de {instrument.InstrumentId.SymbolWithoutPrefix()} a {precio}";
            MessageBox.Show(orden, "Operar esto:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Task.Run(() => orden);
        }
    }
}
