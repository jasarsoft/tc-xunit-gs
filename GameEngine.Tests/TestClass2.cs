using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Tests
{
    [Collection("GameState collection")]
    public class TestClass2
    {
        private readonly GameStateFixture _gameStateFixture;
        private readonly ITestOutputHelper _outputHelper;

        public TestClass2(GameStateFixture gameStateFixture, ITestOutputHelper outputHelper)
        {
            _gameStateFixture = gameStateFixture;
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Test3()
        {
            _outputHelper.WriteLine($"GameState ID={_gameStateFixture.State.Id}");
        }

        [Fact]
        public void Test4()
        {
            _outputHelper.WriteLine($"GameState ID={_gameStateFixture.State.Id}");
        }
    }
}
