// Reference: https://www.youtube.com/watch?v=dqheDZH_mNc
internal class Game
{
    public string? Name { get; set; }
    public int rating { get; set; }
}

internal class StarRating
{
    public string? Name { get; internal set; }
    public double Stars { get; internal set; }
}