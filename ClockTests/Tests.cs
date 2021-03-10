using ClockHands;
using NUnit.Framework;

namespace ClockTests
{
    [TestFixture]
    public class Tests
    {

        //12:00 = 0 degrees
        //3:00 = 90 degrees
        //6:00 = 180 degrees
        //9:00 = 90 degrees
        [TestCase(12,  0)]
        [TestCase(3,  90)]
        [TestCase(6,  180)]
        [TestCase(7,  150)]
        [TestCase(9,  90)]
        public void GetAngle_OnTheHour_ReturnsAngle(int hour, int expectedDegrees)     
        {
            Assert.AreEqual(expectedDegrees, Clock.GetAngle(hour, 0));
        }

        
        [TestCase(3, 5, 62.5)]
        public void GetAngle_NonZeroMinutes_ReturnsAngle(int hour, int minute, double expectedDegrees)
        {
            Assert.AreEqual(expectedDegrees, Clock.GetAngle(hour, minute));
        }

        [Test]
        public void GetAngle_MinuteHandGreaterThanHourHand_ReturnsPositiveAngle()
        {
            Assert.AreEqual(52.5, Clock.GetAngle(1, 15));
        }
        
        
    }
}