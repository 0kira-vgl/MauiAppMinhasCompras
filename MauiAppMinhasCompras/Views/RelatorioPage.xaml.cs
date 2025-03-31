using MauiAppMinhasCompras.Models;
using SQLite;
using System.Linq;

namespace MauiAppMinhasCompras.Views
{
    public partial class RelatorioPage : ContentPage
    {
        private SQLiteConnection _database;

        public RelatorioPage(SQLiteConnection database)
        {
            InitializeComponent();
            _database = database;
        }

        private void FiltrarCompras(object sender, EventArgs e)
        {
            DateTime inicio = dpInicio.Date;
            DateTime fim = dpFim.Date;
            var compras = _database.Table<Produto>().Where(p => p.DataCadastro >= inicio && p.DataCadastro <= fim).ToList();
            lstRelatorio.ItemsSource = compras;
        }
    }
}
