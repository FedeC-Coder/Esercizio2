using System.Numerics;
using BlaisePascal.Esercizio2.Domain;

namespace BlaisePascal.Esercizio2.DomainTest
{
    public class PlayerTest
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne_True()
        {
            Player player = new Player("Zeb98");
            Assert.Equal(1,player.Level);
        }

        [Fact]
        public void Player_getName()
        {
            Player player = new Player("Zeb98");
            Assert.Equal("Zeb89", player.Name);
        }

        [Fact]
        public void Player_setVoidName()
        {
            Player player = new Player("Zeb98");
            Assert.Throws<ArgumentException>(() => player.Name = " ");
        }

        [Fact]
        public void Player_setValidName()
        {
            Player player = new Player("Zeb98");
            Assert.Equal("www", player.Name = "www");
        }
    }
}
