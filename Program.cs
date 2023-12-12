// Name: Elizabeth Trotter 

// Date Revised: 9/8/2023 

// Exercise: Mini Challenge # 3 - Asking Questions

// Brief Description: Create a brand new console project where you ask 2 questions. Display the answer in one sentence.
// What is your name?
// What time did you wake up?
// Output should be a sentence that says who the person is and what time they woke up.

// Peer Reviewer: Bronel Lazar

Console.Clear();

Console.WriteLine("Mini Challenge # 3");

string breakPoint = "-------------------------";
Console.WriteLine(breakPoint);

Console.WriteLine("What is your name?");
string? userName = Console.ReadLine();

Console.WriteLine("What time did you wake up?");
string? wakeTime = Console.ReadLine();

Console.WriteLine($"{userName} woke up today at {wakeTime}.");