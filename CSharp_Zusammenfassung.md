#### Eingaben (Konsole)

##### Einfache Eingabe über die Konsole:

```
string input = Console.ReadLine();
Console.WriteLine("---");
Console.WriteLine(input);
```

##### Konsolen Abfrage auf andere Datentypen:

Typkonvertierung beachten (ToChar, ToByte, ToBoolean, usw.)

```
Console.Write("Bitte Alter eingeben: "); 
int alter = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("du bist " + alter);
```

---

## Arrays

##### Eindimensionale Arrays

Deklaration:

```
int[] eindimensionalesArray = new int[] { 4, 6, 3, 2, 6, 8, 2 };
```

Auslesen:

```
foreach (int i in eindimensionalesArray)
{
   Console.WriteLine(i);
}
```

##### Mehrdimensionale Arrays

Dekleration:

```
int[,] zweidimensionalesArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
```

Dimensionen bestimmen:

```
int rows = zweidimensionalesArray.GetLength(0); 
int cols = zweidimensionalesArray.GetLength(1);
```

Auslesen:

```
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine(zweidimensionalesArray[i, j]);
    }
}
```

---

## Klassen

##### Grundlegende Implementation

Dekleration

```
class Auto
{
    public string marke;
    public int leistung;

    public double mph()
    {
        return leistung * 1.6;
    }   
}   
```
