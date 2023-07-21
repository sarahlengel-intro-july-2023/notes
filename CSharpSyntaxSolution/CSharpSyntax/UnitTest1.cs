namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddTwoNumbers()
        {
            // Given
            int a = 10; int b = 20; int answer;
            // When
            answer = a + b; // System Under Test
            // Then
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(10,20,30)]
        [InlineData(2,8, 10)]
        [InlineData(2,2,4)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData("Jeff", "Gonzalez", "Gonzalez, Jeff")]
        [InlineData("Han", "Solo", "Solo, Han")]
        [InlineData("Luke", "Skywalker", "Skywalker, Luke")]
        [InlineData(" Leiah ", "    Organa ", "Organa, Leiah")]
        public void FormattingMyName(string first, string last, string expected)
        {
            string fullName = Utils.FormatName(first, last);

            Assert.Equal(expected, fullName);
        }
    }
}