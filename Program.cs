//N. Harrison Wilkins
//10-20-2022
//GitHub Project Part 2 - ADDING NUMBERS
//this console project will allow the user to enter one number after the other,   the console will output the sum of the two numbers
//PEER REVIEW IN README

Console.Clear();

//VARIABLES ARE DEFINED HERE
string playAgain;
string num1, num2;
int intNum1, intNum2;
intNum1 = 0;
intNum2 = 0;
bool isNum1, isNum2;


Console.WriteLine("LET'S ADD TWO NUMBERS!");
//GAME LOOP                "Y" GOES TO HERE
do{
    isNum1 = false;
    isNum2 = false;

    while(!isNum1){
        Console.WriteLine("WHAT IS YOUR FIRST NUMBER?");  


num1 = Console.ReadLine();
isNum1 = int.TryParse(num1, out intNum1);
    if(isNum1 == false){
        Console.WriteLine("I STRICTLY ACCEPT NUMBERS! TRY AGAIN");
    }
//NUMBER1 HAS BEEN VALIDATED OR REJECTED
    }
    while(!isNum2){
Console.WriteLine("WHAT IS YOUR SECOND NUMBER?");
num2 = Console.ReadLine();
isNum2 = int.TryParse(num2, out intNum2);

if(isNum2 == false){
        Console.WriteLine("I STRICTLY ACCEPT NUMBERS! TRY AGAIN");

}
//NUMBER2 HAS BEEN VALIDATED OR REJECTED
}
 Console.WriteLine("THE SUM OF "+intNum1+" AND "+intNum2+" IS " + (intNum1 + intNum2));
 Console.WriteLine("ENTER \"Y\" TO TRY AGAIN OR ENTER ANY KEY TO EXIT.");
 playAgain = Console.ReadLine().ToUpper();
}while(playAgain == "Y");