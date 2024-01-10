int number = 9;

void star (int number){
    Console.Write($" {number},");
    number-- ;
    if (number > 1) star(number);
    else {
        Console.Write(" 1");
        return;
    }
}

Console.Write($" N = {number} -> ");
star(number);