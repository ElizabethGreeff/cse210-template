using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
            if (unhiddenWords.Count == 0)
            {
                break;
            }
            Random random = new Random();
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }
        public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}