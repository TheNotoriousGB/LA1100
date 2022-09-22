// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
start:


    Random zufallszahl = new Random();


    int zahl1 = zufallszahl.Next(1, 101);

    Console.WriteLine("Geben sie eine Zahl zwischen 1-100 ein");




    int eingebeneZahl = Convert.ToInt32(Console.ReadLine());

    int question;


    int versuche = 0;

    int allgemeineZahl = 0;

    int komisch = 0;


    do
    {
        switch (allgemeineZahl)
        {
            case int n when (eingebeneZahl < 1):
            case int m when (eingebeneZahl > 100):
                Console.WriteLine(" Ungültige Eingabe : Bitte geben sie eine Zahl von 1-100  ");

           
            goto start;
            

            break;

            case int m when (eingebeneZahl < 101 && eingebeneZahl > 1):
                if (eingebeneZahl > zahl1)
                {
                    Console.WriteLine("Die zahl ist zu gross ");
                    Console.WriteLine("Bitte geben sie erneut eine Zahl ein");
                    eingebeneZahl = Convert.ToInt32(Console.ReadLine());
                    versuche++;

                }
                if (eingebeneZahl < zahl1)
                {
                    Console.WriteLine(" Die Zahl ist zu tief ");
                    Console.WriteLine("Bitte geben sie erneut eine Zahl ein");
                    eingebeneZahl = Convert.ToInt32(Console.ReadLine());
                    versuche++;
                }
                if (eingebeneZahl == zahl1)
                {
                    Console.WriteLine("die Zahl " + eingebeneZahl + " ist die Richtige Zahl ");
                    Console.WriteLine("Glückwunsch ! Du hast nur " + versuche + " gebraucht. ");

                    Console.WriteLine("Willst du weiter spielen [y/n]");





                    question = Convert.ToChar(Console.ReadLine());
                    if (question == 'y')
                    {
                        Console.Clear();
                        goto start;



                    }
                    else if (question == 'n')
                    {
                        Console.WriteLine("Schliessen sie das Fenster ");
                    }

                }


                break;



        }
        
    } while (komisch == 0);
    



