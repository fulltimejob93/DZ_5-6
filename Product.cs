namespace Core.Model;

public class AnimeCharacter
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string AnimeTitle { get; set; }
    public required string Role { get; set; } // Например: Протагонист, Антагонист
    public int PowerLevel { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Anime: {AnimeTitle}, Role: {Role}, Power: {PowerLevel}";
    }
}