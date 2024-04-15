bool guess = false;
Random rnd = new Random();

Console.Write("Give lowest number in range: ");
int low = Convert.ToInt32(Console.ReadLine());
Console.Write("Give higest number in range: ");
int high = Convert.ToInt32(Console.ReadLine());

int num;
while (guess == false) {
    num = (low + high)/2;
    Console.WriteLine("This is my guess " + num + " type yes if its correct, lower if its to high, higher if its to low");
    string feedBack = Console.ReadLine();
    if (feedBack.ToLower() == "lower") {
        high = num;
    } else if (feedBack.ToLower() == "higher") {
        low = num;
    } else {
        Console.WriteLine(num + " Was right thanks for playing");
        guess = true;
    }
}