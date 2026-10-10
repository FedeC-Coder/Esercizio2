using BlaisePascal.Esercizio2.Domain;
using BlaisePascal.Exercise2.Domain;
public class Program
{
    public static void Main(string[] args)
    {
        // Player
        Player player = new Player("Zeb89");

        // Test proprietà
        Console.WriteLine($"Nome: {player.Name}");
        Console.WriteLine($"Livello: {player.Level}");
        Console.WriteLine($"XP: {player.Expirience}");
        Console.WriteLine($"HP: {player.Health}/{player.MaxHealth}");
        Console.WriteLine($"In Vita: {player.IsAlive}");
        Console.WriteLine($"Oro: {player.Gold}");

        // Test metodi
        player.AddExpirience(120);
        Console.WriteLine($"XP dopo AddExpirience: {player.Expirience}, Livello: {player.Level}");

        player.ResetExpirience();
        Console.WriteLine($"XP dopo ResetExpirience: {player.Expirience}");

        player.AddGold(50);
        Console.WriteLine($"Oro dopo AddGold: {player.Gold}");

        player.TakeDamage(40);
        Console.WriteLine($"HP dopo TakeDamage 40: {player.Health}, IsAlive: {player.IsAlive}");

        player.Heal(100);
        Console.WriteLine($"HP dopo Heal 100 (Overheal): {player.Health}");

        player.TakeDamage(150);
        Console.WriteLine($"HP dopo TakeDamage 150 (Overkill): {player.Health}, IsAlive: {player.IsAlive}");

        player.ResetHealth();
        Console.WriteLine($"HP dopo ResetHealth: {player.Health}, IsAlive: {player.IsAlive}");

        try
        {
            player.TakeDamage(-10);
        }
        catch
        {
            Console.WriteLine("Eccezione catturata per danno negativo");
        }

        try
        {
            player.Name = "   ";
        }
        catch
        {
            Console.WriteLine("Eccezione catturata per nome non valido");
        }
    }
}