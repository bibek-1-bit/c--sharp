using System;

class RPS{
public static void Main(){
Random random = new Random();
string player;
string computer;
bool playAgain = true;

while(playAgain)
{

player = null;
computer = null;


while(player!="ROCK" && player!="PAPER" && player!="SCISSORS")
{
Console.Write("ENTER ROCK, PAPER or SCISSORS: ");
player = Console.ReadLine().ToUpper();

}

switch(random.Next(1,4)){
case 1:
computer = "ROCK";
break;
case 2:
computer = "PAPER";
break;
case 3:
computer = "SCISSORS" ;
break;
}
Console.WriteLine("you : " +player);
Console.WriteLine("computer : " +computer);

switch(player){
case "ROCK" :
if(computer=="ROCK"){
Console.WriteLine("It's a draw");

}
else if(computer=="PAPER"){
Console.WriteLine("you lose! ˙◠˙");

}else{
Console.WriteLine("you win! ˶ᵔ ᵕ ᵔ˶  ");

}
break;

case "PAPER" :
if(computer=="PAPER"){
Console.WriteLine("It's a draw");
}
else if(computer=="ROCK"){
Console.WriteLine("you lose! ˙◠˙");

}else{
Console.WriteLine("you win");
}
break;

case "SCISSORS" :
if(computer=="SCISSORS"){
Console.WriteLine("It's a draw");

}else if(computer=="ROCK"){
Console.WriteLine("you lose! ˙◠˙");
}else{
Console.WriteLine("you win! ˶ᵔ ᵕ ᵔ˶ ");
}
break;



}

Console.WriteLine();
Console.WriteLine("Do you want to play again? y/n : ");
string response;
response = Console.ReadLine().ToLower();
if(response=="y"){
playAgain = true;
}else{
playAgain = false;
}




}



}







}

