using System;

class Program{
    public static void Main(){

Console.WriteLine("enter the number to begin counting");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the order => asc for ascending and dsc for descending order");
string order = Console.ReadLine();

if(order == "asc"){
    for(int i=1; i<=num; i++){
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
}else if(order == "dsc"){
     for(int i=1; i<=num; i--){
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
}else{
    Console.WriteLine("Invalid order");
}


    }
}
