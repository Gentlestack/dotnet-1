﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromProg1
{
    public class Remainder : Operation
    {
        double operand1;
        double operand2;

        public double Operand1
        {
            get => operand1;
            set => operand1 = value;
        }
        public double Operand2
        {
            get => operand2;
            set => operand2 = value;
        }
        public Remainder(double op1, double op2)
        {
            operand1 = op1;
            operand2 = op2;
        }
        public override double GetResult()
        {
            return operand1 % operand2;
        }
        public override string ToString()
        {
            return $"{ operand1 } % { operand2 }";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType().Name == GetType().Name)
            {
                Remainder rem = obj as Remainder;
                return rem.Operand1 == Operand1 && rem.Operand2 == Operand2;
            }
            return false;
        }
    }
}
