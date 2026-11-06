using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiInterface
{
    public interface ApiInterface
    {
        public CarTypeList SelectAllCarType();
        public int UpdateCarType(CarType c);
    }
}
