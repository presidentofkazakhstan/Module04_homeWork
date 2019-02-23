using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_module04
{
    public partial class Motobike
    {
        public string showMotobikeInfo()
        {
            return "Название: " + _name + "\nЦвет: " + _color + "\nОбъём двигателя: " + _engineCapacity + "\nГод: " + _year + "\nКоличество лошадинных сил: " + _maxSpeed;
        }
    }
}
