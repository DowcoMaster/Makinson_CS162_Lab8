using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Makinson_CS162_Exam2
{
    public abstract class Employee
    {
        private string name;
        private int number;

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int Number
        {
            get => default;
            set
            {
            }
        }

        public void CalculateGrossMonthly()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateInformation()
        {
            throw new System.NotImplementedException();
        }

        public void ViewInformation()
        {
            throw new System.NotImplementedException();
        }
    }
}