
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

//string[] cibiPreferiti = { "Pizza", "Lasagna", "Carbonara", "Tagliatelle ai funghi", "Kebab", "Tacos", "Cinese" };

////stampa lunghezza array v1
//int count = cibiPreferiti.Length;
//Console.WriteLine("La lunghezza della classsifica è: " + count);

////stampa lunghezza array v2
//Console.WriteLine("lunghezza classifica cibi: {0}", cibiPreferiti.Length);

//Console.WriteLine();

//// stampa lista cibi preferiti
//Console.WriteLine("La classifica dei miei cibi preferiti:");
//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    // attenzione a queste 
//    Console.WriteLine((i + 1 + ". ") + cibiPreferiti[i]);
//}

//Console.WriteLine();

////stampa il cibo top v1
//Console.WriteLine("Il mio cibo preferito è: " + cibiPreferiti[0]);

//Console.WriteLine();

////stampa il cibo meno preferito
//Console.WriteLine("Il mio cibo meno preferito è: " + cibiPreferiti[count - 1]);

//Console.WriteLine();

//// cibo di mezza classifica
//if (count % 2 == 0)
//{
//    //v1
//    //Console.WriteLine("I cibi di mezza classifica sono: " + cibiPreferiti[(count / 2) - 1] + " " + cibiPreferiti[count / 2]);

//    //v2
//    int medianaSuperiore = count / 2;
//    int medianaInferiore = medianaSuperiore - 1;
//    Console.WriteLine("I cibi di mezza classifica sono: {0} e {1}", cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);

//}
//else
//{
//    Console.WriteLine("Il cibo di mezza classifica é: " + cibiPreferiti[count / 2]);
//}



////Snack1. L’utente inserisce due numeri in successione. Il software stampa il maggiore

////input utente 1
//Console.Write("Inserisci un numero: ");
//int input1 = Convert.ToInt32(Console.ReadLine());

////input utente 2
//Console.Write("Inserisci un numero: ");
//int input2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("I numeri selezionati sono : {0} e {1}", input1, input2);

//if (input1 > input2)
//{
//    Console.WriteLine(input1);
//}
//else
//{
//    Console.WriteLine(input2);
//}



////Snack 2.L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga

////input 1
//Console.Write("Inserisci una parola: ");
//string inputStringa1 = Console.ReadLine();

////input 1
//Console.Write("Inserisci una parola: ");
//string inputStringa2 = Console.ReadLine();

//if (inputStringa1.Length < inputStringa2.Length)
//{
//    Console.WriteLine(inputStringa1 + " " + inputStringa2);
//}
//else
//{
//    Console.WriteLine(inputStringa2 + " " + inputStringa1);
//}



////Snack 3.Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//int somma = 0;

//for (int i = 1; i <= 10; i++)
//{
//    Console.Write("inserisci un numero: ");
//    int input = Convert.ToInt32(Console.ReadLine());
//    somma += input;
//}
//Console.WriteLine(somma);



////Snack 4. Calcola la somma e la media dei numeri da 2 a 10.


//int somma = 0;
//int media = 0;
//for (int i = 2; i <= 10; i++)
//{
//    somma += i;
//    media = somma / 9;
//}
//Console.WriteLine("La somma è: {0}", somma);
//Console.WriteLine("La media dei numeri è: {0}", media);




////Snack 5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo

////input utente
//Console.Write("Inserisci un numero: ");
//int inputUtente = Convert.ToInt32(Console.ReadLine());

////dertermina se pari o dispari senno stampa il numero successivo
//if (inputUtente % 2 == 0)
//{
//    Console.WriteLine("Il numero è Pari: {0}", inputUtente);
//}
//else
//{
//    Console.WriteLine("Il numero inserito non è pari. Inserito: {0}, restituito: {1}", inputUtente, inputUtente + 1);
//}



////Snack 6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

//string[] invitati = { "Simone", "Mario", "Michele", "Alessandro" };

////input utente
//Console.Write("Inserisci il tuo nome: ");
//string inputStringa = Console.ReadLine();

//bool invitato = false;

////controllare se il nome è contenuto nell'array
//for (int i = 0; i < invitati.Length; i++)
//{
//    if (inputStringa == invitati[i])
//    {
//        invitato = true;
//        break;
//    }
//}

//if (invitato)
//{
//    Console.WriteLine("Puoi partecipare alla festa di Gatsby");
//}
//else
//{
//    Console.WriteLine("Non sei invitato alla festa di Gatsby");
//}


////Snack 7. Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array

//int[] numDispari = new int[6];
//int indexArr = 0;

//for (int i = 0; i < numDispari.Length; i++)
//{
//    Console.Write("Inserisci un numero: ");
//    int inputUtente = Convert.ToInt32(Console.ReadLine());
//    if (inputUtente % 2 != 0)
//    {
//        numDispari[indexArr] = inputUtente;
//        indexArr++;
//    }
//    Console.WriteLine(numDispari[i]);
//}



////Snack 8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

//int[] arrNum = { 10, 20, 30, 40, 50 };

//int somma = 0;

//// v1
//for (int i = 1; i < arrNum.Length; i += 2)
//{
//    somma += arrNum[i];
//}
//Console.WriteLine("La somma dei numeri dispari è: {0}", somma);

//somma = 0;
////v2 
//for (int i = 0; i < arrNum.Length; i++)
//{
//    if(i % 2 != 0)
//    {
//        somma += arrNum[i];
//    }
//}
//Console.WriteLine("La somma dei numeri dispari è: {0}", somma);




////Snack 9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
////Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
////somma degli elementi è minore di 50.

//int[] arrNum = new int[50];

//int somma = 0;

//while (somma < 50)
//{
//    //input utente
//    Console.Write("Inserisci un numero: ");
//    int inputUtente = Convert.ToInt32(Console.ReadLine());

//    somma += inputUtente;
//}



////Snack 10. Fai inserire un numero, che chiameremo N, all’utente.
////Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
////Ogni volta che ne crei uno, stampalo a schermo.


////input utente
//Console.Write("Inserisci un numero: ");
//int N = Convert.ToInt32(Console.ReadLine());

//Random rnd = new Random();

//// cicla la quantità di array da creare
//for (int i = 0; i < N; i++)
//{
//    //crea ad ogni ciclo un array con 10 elementi con valore 0
//    int[] array = new int[10];
//    Console.WriteLine("L'array numero " + (i + 1) + " è: ");

//    // cicliamo ogni elemento dell'array creato
//    for (int j = 0; j < 10; j++)
//    {
//        //generiamo per ogni posizione dell'array un numero random
//        array[j] = rnd.Next(1, 101);
//        Console.Write(array[j] + ", ");
//    }
//    Console.WriteLine();
//}


////Snack 11. Dare la possibilità di inserire due parole.
////          Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. 
////          Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

////input utente1
//Console.Write("Inserisci una parola: ");
//string inputStringa1 = Console.ReadLine();

////input utente2
//Console.Write("Inserisci una parola: ");
//string inputStringa2 = Console.ReadLine();

//string longestWordOrSame = CheckLength(inputStringa1, inputStringa2);
//Console.WriteLine(longestWordOrSame);



//string CheckLength(string inputStringa1, string inputStringa2)
//{
//    if (inputStringa1.Length == inputStringa2.Length)
//    {
//        return inputStringa1 + " - " + inputStringa2;
//    }
//    else if (inputStringa1.Length > inputStringa2.Length)
//    {
//        return inputStringa1;
//    }
//    else
//    {
//        return inputStringa2;
//    }

//}







//Snack 2. Scrivere una funzione per verificare se un numero è pari o dispari.
//         Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.


//input numero utente
Console.Write("Inserisci un numero: ");
int number = Convert.ToInt32(Console.ReadLine());

string CheckEvenOdd(int number)
{
    if (number % 2 == 0)
    {
        return "pari";
    }
    else
    {
        return "dispari";
    }
}

Console.WriteLine("Il numero inserito è " + CheckEvenOdd(number));