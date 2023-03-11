public class Scripture
{
    private List<Word> _words = new List<Word>();
    private List<int> _hiddenWords = new List<int>();
    private List<int> _nonHiddenWords = new List<int>();
    private Reference _reference = new Reference();

    public Scripture()
    {
        GetListOfWords();
        for (int i = 0; i < _words.Count; i++)
            _nonHiddenWords.Add(i);
        
    }

    public void AddHiddenWord()
    {   
        if (_nonHiddenWords.Count > 0 )
        {
            Random rnd = new Random();
            int index = rnd.Next(_nonHiddenWords.Count);
            int newHiddenWord = _nonHiddenWords[index];
            _hiddenWords.Add(newHiddenWord);
            _words[newHiddenWord]._hidden = true;
            _nonHiddenWords.RemoveAt(index);
        }
    }

    public void GetListOfWords()
    {
        string[] wordsSepareated = _reference._text.Split(" ");
        List<Word> words = new List<Word>();
        
        int index = 0;
        bool hidden = false; 
        
        foreach (string word in wordsSepareated)
        {
            Word newWord = new Word(word, hidden);
            _words.Add(newWord);
            index++;
        }
    }

    public void Display()
    {
        Console.Write(_reference._book + ":" + _reference._verse + " ");
        foreach (Word word in _words)
        {
            word.display();
        }

        Console.WriteLine("\n\nPlease enter to continue of type 'quit' to finish: ");
    }

}