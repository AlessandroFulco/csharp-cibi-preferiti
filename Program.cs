
string[] cibiPreferiti = { "Pizza", "Lasagna", "Carbonara", "Tagliatelle ai funghi", "Kebab", "Tacos", "Cinese" };

//stampa lunghezza array
int count = cibiPreferiti.Length;
Console.WriteLine("La lunghezza della classsifica è: " + count);

// stampa lista cibi preferiti
Console.WriteLine("La classifica dei miei cibi preferiti:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}


//stampa il cibo top v1
Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);

//stampa il cibo meno preferito
Console.WriteLine("Il mio cibo meno preferito è: " + cibiPreferiti[count - 1]);

