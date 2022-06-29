using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearn
{
    public class ModifyPrice
    {
        private readonly List<IComand> comands;
        private IComand comand;

        public ModifyPrice()
        {
            comands = new List<IComand>();
        }

        public void SetComand(IComand _comand) => comand = _comand;

        public void Invoke()
        {
            comands.Add(comand);
            comand.ExecuteAction();
        }
    }
}
