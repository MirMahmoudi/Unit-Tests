using System;

namespace InDotNetFramework48.Fundamentals
{
    public class DemeritPointsCalculator
    {
        private const int MaxSpeed = 300;
        private const int SpeedLimit = 65;
        
        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MaxSpeed)
                throw new ArgumentOutOfRangeException();
            
            if (speed <= SpeedLimit) return 0; 
            
            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - SpeedLimit)/kmPerDemeritPoint;

            return demeritPoints;
        }        
    }
}