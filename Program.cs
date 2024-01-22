// Zahid Afsar
// 8/13/23
// Mini Challenge 6
// Ask the user to enter a number and say if it is even or odd.
// Peer Reviewed by : Alexander Soria            
//  Peer Comment : The program runs as intended and guides the user well should they make an error when making inputs into the program. More clarification is recommended (e.g. when asking for integer "Incorrect format. Please input a number.")

Console.Clear();

bool playTrue = true;
string playAgain = "yes";
while(playTrue == true){

    Console.WriteLine("I will tell you if a number is odd or even");
Console.WriteLine("Please enter a number : ");

string input = "";

bool success = true;

int num;

while(success != Int32.TryParse(Console.ReadLine(), out num)){
    Console.WriteLine("Input invalid. Please enter another number");
}


if(success){
    Console.WriteLine($"Your number is {num}");
    playTrue = false;
}else{
    Console.WriteLine($"{num} is not a number ");
}

int num1 = Convert.ToInt32(num);

if(num % 2 == 0){
    Console.WriteLine(num + " is an even number");
 }else{
      Console.WriteLine(num + " is an odd number");
 }
  string correctFormat = "no";

while(correctFormat == "no"){
Console.WriteLine("Do you want to play again. Yes or No");
 playAgain = Console.ReadLine().ToLower();
if(playAgain == "no" || playAgain == "yes"){
    correctFormat = "yes";
}
else{
    Console.WriteLine("Please enter correct format");
}
}
if(playAgain == "yes"){
    playTrue = true;
}
}

Console.WriteLine("Thanks for playing!");
