using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СлепойКот.Models
{
    internal class MyDataClass
    {
        public ObservableCollection<Sale> MyCategory { get; set; } = new ObservableCollection<Sale>();
    }
}
