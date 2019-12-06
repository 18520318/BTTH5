using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH5
{
    public class Model
    {
        public BindingList<string> AreaCode { get; set; } = new BindingList<string>() {
            "+84", "+86", "+79", "+888888"
        };
    }
}