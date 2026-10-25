int choice;
int score;
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");
choice = Convert.ToInt32(System.Console.ReadLine());
if (choice == 1 || choice == 4)
{
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    System.Console.Write("Score: ");
    score = Convert.ToInt32(System.Console.ReadLine());
    while (score > 100 || score < 0) {
        System.Console.WriteLine("A score must be between 0 and 100.");
        System.Console.Write("Score: ");
        score = Convert.ToInt32(System.Console.ReadLine());
    } 
    if (score >= 90)
    {
        System.Console.WriteLine($"{score} earns an A.");
    }
    else if (score < 90 && score >= 80)
    {
        System.Console.WriteLine($"{score} earns a B.");
    }
    else if (score < 80 && score >= 70)
    {
        System.Console.WriteLine($"{score} earns a C.");
    }
    else if (score < 70 && score >= 60)
    {
        System.Console.WriteLine($"{score} earns a D.");
    }
    else
    {
        System.Console.WriteLine($"{score} earns an F");
    }
    
}
if (choice == 2 || choice == 4)
{
    
}
if (choice == 3 || choice == 4)
{
    
}