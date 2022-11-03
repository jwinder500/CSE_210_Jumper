class Display
{
    //this writes what should be written based on the number of lives

    public Display(Lives){
        lives = Lives
    }
    public string translate_lives()
    {
        if (lives = 5){
            Console.WriteLine("  ___");
            Console.WriteLine(" /___\ ");
            Console.WriteLine(" \   /");
            Console.WriteLine("  \ /");
            Console.WriteLine("   O");
            Console.WriteLine("  /|\ ");
            Console.WriteLine("  / \ ");
        }
        if (lives = 4){
            Console.WriteLine(" /___\ ");
            Console.WriteLine(" \   /");
            Console.WriteLine("  \ /");
            Console.WriteLine("   O");
            Console.WriteLine("  /|\ ");
            Console.WriteLine("  / \ ");
        }
        if (lives = 3){
            Console.WriteLine("  ");
            Console.WriteLine(" _____ ");
            Console.WriteLine(" \   /");
            Console.WriteLine("  \ /");
            Console.WriteLine("   O");
            Console.WriteLine("  /|\ ");
            Console.WriteLine("  / \ ");
        }
        if (lives = 2){
            Console.WriteLine("  ");
            Console.WriteLine(" ");
            Console.WriteLine(" \   /");
            Console.WriteLine("  \ /");
            Console.WriteLine("   O");
            Console.WriteLine("  /|\ ");
            Console.WriteLine("  / \ ");
        if (lives = 1){
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine(" ");
            Console.WriteLine("  \ /");
            Console.WriteLine("   O");
            Console.WriteLine("  /|\ ");
            Console.WriteLine("  / \ ");
        if (lives = 0){
            Console.WriteLine("u ded");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("  ");
            Console.WriteLine("   X");
            Console.WriteLine("  /|\ ");
            Console.WriteLine("  / \ ");
    }
    
}