
Random rng = new Random(4000);

int choice; // module selection
int score; //module 1 score input var

int rollCount = 0; //how many total rolls
int roll1; //value of roll1
int roll2; //value of roll2
int valueRolled = 0; //total value of roll
int rollsWon = 0; //how many rolls are won
string rollChoice = "y"; 

int[] scoresArray = new int[5];
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
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
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
    while (rollChoice == "y") {
        rollCount += 1;
        roll1 = rng.Next(1,7);
        roll2 = rng.Next(1,7);
        valueRolled = 0;
        valueRolled += roll1 +roll2;
        if (valueRolled == 2)
    {
        System.Console.WriteLine($"Roll {rollCount}: a {roll1} and {roll1}, total {valueRolled}. Snake eyes.");
    }
    else if (roll1 == roll2)
    {
        System.Console.WriteLine($"Roll {rollCount}: a {roll1} and {roll1}, total {valueRolled}. Doubles!");
    } 
    else if (valueRolled == 7 || valueRolled == 11)
        {
            System.Console.WriteLine($"Roll {rollCount}: a {roll1} and {roll1}, total {valueRolled}. A winner.");
            rollsWon += 1;
        }
        else
        {
            System.Console.WriteLine($"Roll {rollCount}: a {roll1} and {roll1}, total {valueRolled}.");
        }
    System.Console.Write("Roll again? (y/n): ");
    rollChoice = System.Console.ReadLine();
    while (rollChoice != "y" && rollChoice != "n") {
        System.Console.WriteLine("Invalid Choice.");
        System.Console.Write("Roll again? (y/n): ");
        rollChoice = System.Console.ReadLine();
    } 
    }
    System.Console.WriteLine($"You rolled {rollCount} times and won {rollsWon}.");
    
} 
if (choice == 3 || choice == 4)
{
    for (int i = 0; i < scoresArray.Length; i++)
    {
        System.Console.Write($"Score {i + 1}: ");
        scoresArray[i] = Convert.ToInt32(System.Console.ReadLine());
    }

}