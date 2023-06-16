using System;

namespace _09_shulte_table.ViewModels
{
    public enum CellColor
    {
        White, Green, Purple, Yellow, Blue, Red
    };
    public enum CellState
    {
        Current, Closed, Next
    }

    public class CellVM
    {
        private static Random rnd = new();
        // command

        // -------- Binding Properties --------
        public int Number { get; }
        public CellColor Color { get; set; }
        public CellState State { get; set; }
        public bool IsWrong { get; set; }

        public CellVM(int number) : this(number, GetRandomColor()) { }
        public CellVM(int number, CellColor color)
        {
            Number = number;
            Color = color;

            IsWrong = true;
        }
        private static CellColor GetRandomColor()
        {
            return (CellColor)rnd.Next(Enum.GetValues(typeof(CellColor)).Length);
        }
    }
}
