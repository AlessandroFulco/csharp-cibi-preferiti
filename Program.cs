
string[] cibiPreferiti = { "Pizza", "Lasagna", "Carbonara", "Tagliatelle ai funghi", "Kebab", "Tacos", "Cinese" };

//stampa lunghezza array
int count = 0;

for(; count < cibiPreferiti.Length;)
{
    count++;
}
    Console.WriteLine(count);


// stampa lista cibi preferiti
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

//stampa il cibo top
Console.WriteLine(cibiPreferiti[0]);

//stampa il cibo meno preferito
Console.WriteLine(cibiPreferiti[6]);

