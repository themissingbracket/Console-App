using System;
namespace Sandbox.Lib
{
    public class RandomGenerator
    {
        private int _lowerRange;
        private int _upperRange;
        private int _randomNumber;
        private static  RandomGenerator _instance;

        RandomGenerator(int lowerRange = 1, int upperRange = 100)
        {
            _lowerRange = lowerRange;
            _upperRange = upperRange;
        }


        public static RandomGenerator GetInstance()
        {
            if ( RandomGenerator._instance == null )
            {
                RandomGenerator._instance = new RandomGenerator();

            }
            return RandomGenerator._instance;
        } 

        public int LowerRange
        {
            get { return _lowerRange; }
            set { _lowerRange = value; }
        }

        public int UpperRange { get; set; }

        private Random _random = new Random();

        public void Generate()
        {
            _randomNumber = _random.Next(_lowerRange, _upperRange);

        }

        public int RandomNumber
        {
            get { return _randomNumber; }
            
        }

        
    }
}
