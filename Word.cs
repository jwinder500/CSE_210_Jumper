class Word
{
    //This is to store words to be used to hangman
    List<string> words = new List<string> {"HEPATITIS", "WORCESTERSHIRE SAUCE", "CATTYWAMPUS", "COLLYWOBBLES", "BOONDOGGLE"};
    
    public string pick_random_word()
    {   var random = new Random();
        int index = random.Next(words.Count);
        string a = words[index];
        return a;

    }
    public string word = new Word.pick_random_word();

    int letter_count;

    List<string> letters = new List<string>{};

    public Word(string w, int c){
        word = w;
        letter_count = c;
    }

    public List<string> Create_Letter_List(string word){
        foreach (string i in word){
            letters.Add(i);
        }
        return letters;
    }
}

