using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Interfaces
{
    public interface IInputData
    {
        void InitializeSetup();
        void InitializeInputMin();
        void InitializeInputMax();
        void InitializeInputAttempts();
        int InputMin();
        int InputMax();
        int InputAttempts();
    }
}
