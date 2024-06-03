using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_PrinciplesSOLID.Classes
{
    public class Settings
    {
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int MaxAttempts { get; private set; }

        public Settings(int minValue, int maxValue, int maxAttempts)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            MaxAttempts = maxAttempts;
        }

        public void UpdateSettings(int minValue, int maxValue, int maxAttempts)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            MaxAttempts = maxAttempts;
        }
    }
}
