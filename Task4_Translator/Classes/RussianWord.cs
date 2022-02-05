public struct RussianWord
{
    public int Id { get; set; }
    public string? Word { get; set; }

    public RussianWord(int id, string word)
    {
        Id = id;
        Word = word;
    }
}

