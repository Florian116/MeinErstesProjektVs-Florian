using System;

// So schreibst du einen Kommentar

/*Alle Zeichen die in dieser Kommtar-Variante stehen werden als Kommentar Interpretiert 
*/

namespace Tutorial
{
    class TutorialStart
    {
        /* Mit 'static' werden Methoden bezeichnet die beim Aufruf kein spezifisches Objekt voraussetzen, 
        und 'void' beschreibt eine Methode ohne Rückgabewert. 
        'Main' ist eine Methode von herrausragender Bedeutung. Wenn Laufzeitumgebung der EXE-Datei startet, wird zuerst 'Main' ausgeführt*/

        static void Main()
        {


            //----------------------------------------------Elementare Syntax-------------------------------------------------------------------------------------


            Console.Write("Hello World!");                              //Anweisungen enden immer mit einem Semikolon // Methode erzeugt eine Ausgabe
                                                                        //Konsolen-Cursor am Ende der Zeile 


            Console.
                WriteLine/*Kommentar*/                                  //Anweisungen können in verschiedene Zeilen aufgeteilt werden //
                        ("C# macht spaß");                              //Diese Methode erzeugt eine Ausgabe in der Konsole // Cursor in der nächste Zeile
                                                                        //Kommentare können in mitten einer Anweisung stehen

            Console.WriteLine("..."); Console.WriteLine("...");         // Mehrere Anweisun-
                                                                        //gen können in eine Zeile geschrieben werden


            Console.ReadLine();                                         //Reagiert nur auf 'Enter'

            Console.ReadKey(); ;                                        //Reagiert auf jede Taste //Mehrere Semikolons füren nicht zu einem Fehler

            //----------------------------------------------Datendeklaration-------------------------------------------------------------------------------------

            int value;                                                  //Deklaration durch Datentyp + Bezeichner                       
                                                                        //(Der Bezeichner repräsentiert eine Speicheradresse im Arbeitsspeicher)

            /* Variablenbezeichner
            ->Ein Bezeichner setzt sich aus alphanumerischen Zeichen und dem Unterstrich zusammen.
              Leerzeichen und andere Sonderzeichen wie beispielsweise #, § und $ sind nicht zugelassen.           
            ->Ein Bezeichner muss mit einem Buchstaben oder dem Unterstrich anfangen.
            ->Ein einzelner Unterstrich als Variablenname ist nicht zugelassen.
            ->Der Bezeichner muss eindeutig sein, Er darf nicht gleichlautend mit einem Schlüsselwort, einer Methode
              , einer Klasse oder einem Objektnamen sein.
            */

            value = 50;                                                 //Zuweisung eines gültigen Wertes (Initialisierung)

            double value2 = 1000.11;                                    //Deklaration und Initialisierung können in einer Anweisung erfolgen
            Console.WriteLine(value + value2);                            //Werte werden in der Konsole addiert ausgegeben

            long a = 10, b = 1000000000000000000;                       //Mehrere Variablen gleichen Typs deklarieren und direkt initialisieren



            //----------------------------------------------Variable durch Platzhalter-------------------------------------------------------------------------------------



            Console.WriteLine                                       //
                ("Wert von'a'= {0}\nWert von 'b'= {1}", a, b);


            Console.WriteLine("Ich kaufe {0,3} Eier", a);           //
            Console.WriteLine("Ich kaufe {0,10} Eier", a);          //
            Console.WriteLine("Ich kaufe {0,-10} Eier", a);         /**/

            /*  Vollständige Syntax des Formatausdrucks:
                {N [,M][:Format]}
                Formatangabe    Beschreibung
                C               //Zeigt die Zahl im lokalen Währungsformat an.
                D               //Zeigt die Zahl als dezimalen Integer an.
                E               //Zeigt die Zahl im wissenschaftlichen Format an (Exponentialschreibweise).

                                
                F               //Zeigt die Zahl im Festpunktformat an.
                G               //Eine numerische Zahl wird entweder im Festpunkt- oder im wissenschaftlichen Format angezeigt. Zur Anzeige kommt das »kompakteste« Format.

                                                              
                N               //Zeigt eine numerische Zahl einschließlich Kommaseparatoren an.   
                P               //Zeigt die numerische Zahl als Prozentzahl an. 
                X               //Die Anzeige erfolgt in Hexadezimalnotation.     

                                    */

            Console.WriteLine("value={0:E}", value);                //Ausgabe: 
            Console.WriteLine("value={0:E2}", value);               //Ausgabe: 

            float value3 = 0.2512F;
            Console.WriteLine("value3={0,10:G}", value3);           //Ausgabe: 
            Console.WriteLine("value3={0:P4}", value3);             //Ausgabe: 

            Console.WriteLine($"a={a},b={b}");                      //
                                                                    //



            //----------------------------------------------Formatierung der Ausgabe-------------------------------------------------------------------------------------

            /*  Escape-Zeichen
                werden verwendet wenn Sonderzeichen innerhalb einer Zeichenfolge
                ausgegeben werden sollen.
                
                Escape-Zeichen      Beschreibung
                \'                  
                \''                 
                \\                  
                \a                  
                \b                  
                \f                 
                \n                  
                                   
                \r                 
                \t                 
                \u                  
                \v                  
             */

            Console.WriteLine("Hallo\\nWelt");                         //Ausgabe: 
            Console.WriteLine(@"C#\nmacht\nSpaß");                     //Ausgabe:
                                                                       //



            //---------------------------------------------->>ReadLine<< und >>Read<<-------------------------------------------------------------------------------------

            string input1 = Console.ReadLine();                        //
            Console.WriteLine(input1);                                 //

            int input2 = Console.Read();                               //
            Console.WriteLine(input2);                                 //
            Console.ReadLine();                                        //
            Console.ReadLine();





        }

    }
}