// Create a Random object to generate random numbers
Random dice = new Random();

// Generate three random dice rolls between 1 and 6
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Calculate the total of the three rolls
int total = roll1 + roll2 + roll3;

// Print the individual rolls and the total to the console
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Check if there are any doubles (two dice showing the same number)
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    // Add a +2 bonus to the total if there are any doubles
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// Check if there are any triples (all three dice showing the same number)
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    // Add a +6 bonus to the total if there are any triples
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

// Check if the total is greater than or equal to 15
if (total >= 15)
{
    // Print "You win!" if the total is 15 or greater
    Console.WriteLine("You win!");
}

// Check if the total is less than 15
if (total < 15)
{
    // Print "Sorry, you lose." if the total is less than 15
    Console.WriteLine("Sorry, you lose.");
}
