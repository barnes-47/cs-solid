using Solid.Followed.Contract;
using System;

namespace Solid.Followed.PolicyRater
{
    public class Life : Rater
    {
        private readonly RatingEngine _engine;
        private readonly ILogger _logger;

        public Life(RatingEngine engine, ILogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating LIFE policy...");
            _logger.Log("Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                _logger.Log("Life policy must include Date of Birth.");
                return;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                _logger.Log("Centenarians are not eligible for coverage.");
                return;
            }
            if (policy.Amount == 0)
            {
                _logger.Log("Life policy must include an Amount.");
                return;
            }
            var age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if ((policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day) ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            var baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
                _engine.Rating = baseRate * 2;
            }
            _engine.Rating = baseRate;
        }
    }
}
