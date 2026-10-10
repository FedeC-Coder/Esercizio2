namespace BlaisePascal.Esercizio2.DomainTest
{
    public class PlayerTest
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne_True()
        {
            Player player = new Player("Zeb98");
            Assert.Equals(1,player.Level);
        }
    }
}
