using System.Reflection.Metadata;

int Tip3()
{
    return new Random().Next();
}

Console.WriteLine(Tip3());
int slucajniBroj = Tip3 ();
Console.WriteLine(slucajniBroj);



