using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cartoon
    {
        protected string Lineart;
        protected string type;
        protected string name;

        public virtual int Get_high()
        {
            return 10;
        }
    }
}
