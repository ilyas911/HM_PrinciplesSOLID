using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Interfaces
{
    public interface IOutputInfo
    {
        void OutputGameStarting();
        void OutputConditions(object min, object max);
        void OutputCongratulations();
        void OutputRemainingAttempts(int attempts);
        void OutputGameFinished(object targetNumber);
        void OutputNumberIsGreater();
        void OutputNumberIsLess();
    }
}
