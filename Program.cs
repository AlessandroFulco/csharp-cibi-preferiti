
string[] cibiPreferiti = { "Pizza", "Lasagna", "Carbonara", "Tagse ai funghi", "Kebab", "Tacos", "Cinese" };

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


// cibo di mezza classifica
if( count % 2 == 0 )
{
    Console.WriteLine("I cibi di mezza classifica sono: " + cibiPreferiti[(count / 2) - 1] + " " + cibiPreferiti[count / 2]);
} else
{
    Console.WriteLine("Il cibo di mezza classifica é: " + cibiPreferiti[count / 2]);
}