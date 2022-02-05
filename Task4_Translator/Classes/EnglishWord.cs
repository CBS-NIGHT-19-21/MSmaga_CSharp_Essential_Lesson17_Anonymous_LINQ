public struct EnglishWord
{
    public int Id { get; set; }
    public string? Word { get; set; }

    public EnglishWord( int id, string word)
    {
        Id = id;
        Word = word;
    }
}

