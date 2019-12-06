using BTH5.Utils;
using BTH5.Utils.EnumUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH5
{
    public class Student
    {
        public string Sv_name { get; set; }
        public string Id { get; set; }
        public string Sv_class { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public int Phone { get; set; }
        public string Areacode { get; set; }
        public string Mail { get; set; }

    }

    [TypeConverter(typeof(GenderConverter))]
    public enum Gender
    {
        [Description("Nam")]
        Male = 0,
        [Description("Nữ")]
        Female = 1,
        [Description("Khác")]
        Other = 2
    }

}
