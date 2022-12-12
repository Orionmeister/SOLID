using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /* 
                Liskov Substitution Principle
    
    * Objects in a program should be replaceable with instances of their subtypes 
    without altering the correctness of that program.

    * Base class instance replaced/ substitution by its sub type instance
    with no change in functionality.

    *Extension of the open-close principle.
    
    */



    //Bad approach
    public class SumCalculatorBad
    {
        protected readonly int[] _numbers;
        public SumCalculatorBad(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate()
        {
            return _numbers.Sum();
        }
    }

    public class EvenNumbersSumCalculatorBad: SumCalculatorBad
    {
        public EvenNumbersSumCalculatorBad(int[] numbers)
            : base(numbers)
        {
            
        }

        public new int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }

    //Better approach

    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }

    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers)
            :base(numbers)
        {

        }

        public override int Calculate()
        {
            return _numbers.Sum();
        }
    }

    public class EvenNumbersSumCalculator: Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            :base(numbers)
        {

        }

        public override int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }


}
