public class Reference
{
    public string _text;
    public string _book;
    public string _verse;

    public Reference()
    {
        Random rnd = new Random();
        switch(rnd.Next(6))
        {
            case 0:        
                _book = "Proverbs 3";
                _verse = "5-6";
                _text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
                break;
            case 1:        
                _book = "Moses 1";
                _verse = "39";
                _text = "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.";
                break;
            case 2:        
                _book = "Romans 1";
                _verse = "16";
                _text = "For I am not ashamed of the gospel of Christ: for it is the power of God unto salvation to every one that believeth; to the Jew first, and also to the Greek.";
                break;
            case 3:        
                _book = "Alma 32";
                _verse = "21";
                _text = "And now as I said concerning faith faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
                break;
            case 4:        
                _book = "D&C 10";
                _verse = "5";
                _text = "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.";
                break;
            case 5:        
                _book = "Ether 12";
                _verse = "27";
                _text = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
                break;

        }
}


}