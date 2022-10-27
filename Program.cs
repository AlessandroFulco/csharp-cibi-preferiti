
//Create un progetto App Console csharp-cibi-preferiti con VS2022.
//Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
//L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//La lunghezza della classifica
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//Il vostro cibo top (prima posizione della classifica)
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica 
//con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

string[] cibiPreferiti = { "Pizza", "Lasagna", "Carbonara", "Tagliatelle ai funghi", "Kebab", "Tacos", "Cinese" };

//stampa lunghezza array v1
int count = cibiPreferiti.Length;
Console.WriteLine("La lunghezza della classsifica è: " + count);

//stampa lunghezza array v2
Console.WriteLine("lunghezza classifica cibi: {0}", cibiPreferiti.Length);

Console.WriteLine();

// stampa lista cibi preferiti
Console.WriteLine("La classifica dei miei cibi preferiti:");
for (int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine( (i + 1 + ". ") + cibiPreferiti[i]);
}

Console.WriteLine();

//stampa il cibo top v1
Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);

Console.WriteLine();

//stampa il cibo meno preferito
Console.WriteLine("Il mio cibo meno preferito è: " + cibiPreferiti[count - 1]);

Console.WriteLine();

// cibo di mezza classifica
if ( count % 2 == 0 )
{
    Console.WriteLine("I cibi di mezza classifica sono: " + cibiPreferiti[(count / 2) - 1] + " " + cibiPreferiti[count / 2]);
} else
{
    Console.WriteLine("Il cibo di mezza classifica é: " + cibiPreferiti[count / 2]);
}