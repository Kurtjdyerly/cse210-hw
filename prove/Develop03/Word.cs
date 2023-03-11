public class Word
{
    private string _word;
    public bool _hidden;

    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }
    public void display()
    {   
        if (_hidden)
        {   
            for (int i = 0; i < _word.Length; i++)
            {
                Console.Write("_");
            }      
            Console.Write(" ");
        } 
        else  
            Console.Write(_word + " ");
    }

}