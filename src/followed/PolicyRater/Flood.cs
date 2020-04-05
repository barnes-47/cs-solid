using Solid.Followed.Contract;

namespace Solid.Followed.PolicyRater
{
    public class Flood : Rater
    {
        private readonly RatingEngine _engine;
        private readonly ILogger _logger;

        public Flood(RatingEngine engine, ILogger logger)
        {
            _engine = engine;
            _logger = logger;
        }


        public override void Rate(Policy policy)
        {

        }
    }
}
