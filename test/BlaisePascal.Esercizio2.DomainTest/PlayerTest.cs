using System;
using BlaisePascal.Esercizio2.Domain;
using Xunit;

namespace BlaisePascal.Esercizio2.DomainTest
{
    public class PlayerTest
    {
        [Fact]
        public void Player_ShouldStartAtLevelOne_True()
        {
            Player player = new Player("Zeb98");
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_getName()
        {
            Player player = new Player("Zeb98");
            Assert.Equal("Zeb98", player.Name);
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

        [Fact]
        public void Player_ShouldStartWithZeroExperience()
        {
            Player player = new Player("Zeb98");
            Assert.Equal(0, player.Expirience);
        }

        [Fact]
        public void Player_ShouldStartWithMaxHealth()
        {
            Player player = new Player("Zeb98");
            Assert.Equal(100, player.MaxHealth);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_ShouldStartAlive()
        {
            Player player = new Player("Zeb98");
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Player_ShouldStartWithZeroGold()
        {
            Player player = new Player("Zeb98");
            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void Player_AddExpirience_ValidAmount()
        {
            Player player = new Player("Zeb98");
            player.AddExpirience(50);
            Assert.Equal(50, player.Expirience);
            Assert.Equal(1, player.Level);
        }

        [Fact]
        public void Player_AddExpirience_NegativeAmount_ThrowsException()
        {
            Player player = new Player("Zeb98");
            Assert.Throws<ArgumentException>(() => player.AddExpirience(-10));
        }

        [Fact]
        public void Player_AddExpirience_LevelUp()
        {
            Player player = new Player("Zeb98");
            player.AddExpirience(120);
            Assert.Equal(2, player.Level);
            Assert.Equal(20, player.Expirience);
        }

        [Fact]
        public void Player_ResetExpirience()
        {
            Player player = new Player("Zeb98");
            player.AddExpirience(50);
            player.ResetExpirience();
            Assert.Equal(0, player.Expirience);
        }

        [Fact]
        public void Player_TakeDamage_ValidAmount()
        {
            Player player = new Player("Zeb98");
            player.TakeDamage(30);
            Assert.Equal(70, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Player_TakeDamage_NegativeAmount_ThrowsException()
        {
            Player player = new Player("Zeb98");
            Assert.Throws<ArgumentException>(() => player.TakeDamage(-10));
        }

        [Fact]
        public void Player_TakeDamage_LethalDamage_PlayerDies()
        {
            Player player = new Player("Zeb98");
            player.TakeDamage(100);
            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void Player_TakeDamage_Overkill_HealthClampsToZero()
        {
            Player player = new Player("Zeb98");
            player.TakeDamage(150);
            Assert.Equal(0, player.Health);
            Assert.False(player.IsAlive);
        }

        [Fact]
        public void Player_Heal_ValidAmount()
        {
            Player player = new Player("Zeb98");
            player.TakeDamage(50);
            player.Heal(20);
            Assert.Equal(70, player.Health);
        }

        [Fact]
        public void Player_Heal_NegativeAmount_ThrowsException()
        {
            Player player = new Player("Zeb98");
            Assert.Throws<ArgumentException>(() => player.Heal(-10));
        }

        [Fact]
        public void Player_Heal_OverHeal_ClampsToMaxHealth()
        {
            Player player = new Player("Zeb98");
            player.TakeDamage(20);
            player.Heal(50);
            Assert.Equal(100, player.Health);
        }

        [Fact]
        public void Player_ResetHealth()
        {
            Player player = new Player("Zeb98");
            player.TakeDamage(100);
            player.ResetHealth();
            Assert.Equal(100, player.Health);
            Assert.True(player.IsAlive);
        }

        [Fact]
        public void Player_AddGold_ValidAmount()
        {
            Player player = new Player("Zeb98");
            player.AddGold(50);
            Assert.Equal(50, player.Gold);
        }

        [Fact]
        public void Player_AddGold_NegativeAmount_ThrowsException()
        {
            Player player = new Player("Zeb98");
            Assert.Throws<ArgumentException>(() => player.AddGold(-50));
        }
    }
}