using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Interfaces
{
    public interface IRandomNumberGenerator
    {
        int Generate(int min, int max);
    }
}
