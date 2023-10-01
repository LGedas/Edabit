using EdabitTasks;

namespace EdabitTests
{
    public class PowerRangerTests
    {
        [Fact]
        public void powerRange_2_49_65_return2()
        {
            int power = 2;
            int lowerLimmit = 49;
            int uperLimit = 65;
            int expeted = 2;

            int actual = PowerRanger.powerRanger(power, lowerLimmit, uperLimit);

            Assert.Equal(expeted, actual);
        }

        [Fact]
        public void powerRange_3_1_27_return3()
        {
            int power = 3;
            int lowerLimmit = 1;
            int uperLimit = 27;
            int expeted = 3;

            int actual = PowerRanger.powerRanger(power, lowerLimmit, uperLimit);

            Assert.Equal(expeted, actual);
        }

        [Fact]
        public void powerRange_10_1_5_return1()
        {
            int power = 10;
            int lowerLimmit = 1;
            int uperLimit = 5;
            int expeted = 1;

            int actual = PowerRanger.powerRanger(power, lowerLimmit, uperLimit);

            Assert.Equal(expeted, actual);
        }

        [Fact]
        public void powerRange_5_31_33_return1()
        {
            int power = 5;
            int lowerLimmit = 31;
            int uperLimit = 33;
            int expeted = 1;

            int actual = PowerRanger.powerRanger(power, lowerLimmit, uperLimit);

            Assert.Equal(expeted, actual);
        }

        [Fact]
        public void powerRange_4_250_1300_return_3()
        {
            int power = 4;
            int lowerLimmit = 250;
            int uperLimit = 1300;
            int expeted = 1;

            int actual = PowerRanger.powerRanger(power, lowerLimmit, uperLimit);

            Assert.Equal(expeted, actual);
        }
    }
}
