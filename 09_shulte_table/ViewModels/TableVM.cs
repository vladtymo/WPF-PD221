using _09_shulte_table.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _09_shulte_table.ViewModels
{
    public class TableVM
    {
        private IList<CellVM> cells = new List<CellVM>();

        // -------- Binding Properties --------
        public IEnumerable<CellVM> Cells => cells; 
        public int Size { get; }

        public const int EYE_NUMBER = 0;
        public int FirstNumber { get; } = 1;
        public int LastNumber { get; }

        public TableVM(int size)
        {
            Size = size;
            LastNumber = Size * Size - 1; // due to one eye-cell on the center

            GenerateCells();
        }

        private void GenerateCells()
        {
            for (int i = FirstNumber; i <= LastNumber; ++i)
            {
                cells.Add(new CellVM(i));
            }
            this.cells.Shuffle();

            cells.Insert(cells.Count / 2, new CellVM(EYE_NUMBER, CellColor.White));
        }
    }
}
