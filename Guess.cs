class Guess
{
    //public Guess Letter_List =  List<string> Guess(word.Letter_List);
    public Guess(Letter_List){
        letter_list = Letter_List;
    }
    public List<string> Alphabet = new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
    "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

    public List<string> Already_Guessed = new List<string> {};

    public bool Check_Letter(guess){
        if (ToUpper(guess) in Alphabet){
            return true;
        }
        else{
            return false;
        }
    }
    public bool Check_History(guess){
        if (ToUpper(guess) in Already_Guessed){
            return true;
        }
        else{
            Already_Guessed.Add(ToUpper(guess));
            return false;
        }
    }
    public bool Check_Correct(guess){
        if (ToUpper(guess) in Create_Letter_List){
            return true;
        }
        else {
            return false;
        }
    }
}