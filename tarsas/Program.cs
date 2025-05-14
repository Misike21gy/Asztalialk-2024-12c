Console.WriteLine("MMMMMMVMMMMMMMMVMMMMMMMMEMMMMMMMMMMMMMMMMMMMEMMMMMMMMMMMMMMMMMMMMEMMMMMMMMMMMMMMMMVMMMMMMVMMMMMMEMMMMMMMMMMVMMMMMMMMMMMMMMMMMMMVMMMMMMMMMMMVMMMMMMMMEMMMMMMMMMMMVMMMMMMEMMMMMMMMMMEMMMMMMMMMMMEMMMMMMMMMM");
string palya = "MMMMMMVMMMMMMMMVMMMMMMMMEMMMMMMMMMMMMMMMMMMMEMMMMMMMMMMMMMMMMMMMMEMMMMMMMMMMMMMMMMVMMMMMMVMMMMMMEMMMMMMMMMMVMMMMMMMMMMMMMMMMMMMVMMMMMMMMMMMVMMMMMMMMEMMMMMMMMMMMVMMMMMMEMMMMMMMMMMEMMMMMMMMMMMEMMMMMMMMMM";
Console.WriteLine(palya);

//Teszteset 1. (Csak M V E)

int i, j;
int ok = 0;

for (i = 0; i < palya.Length; i++)
{
    if(palya[i] =='E' || palya[i]=='M' || palya[i] == 'V')
    {
        ok++;   
    }
}

if (ok == palya.Length)
{
    Console.WriteLine("Minden ok!");
}
else
{
    Console.WriteLine("Nem jó 😢 !");
}

int lepes = -1;
int dobas;
Console.WriteLine("Dobj!");
dobas=Convert.ToInt32(Console.ReadLine());
lepes += dobas;

while (lepes < palya.Length)
{
    Console.WriteLine("{0} {1}" , lepes, palya);

    if (palya[lepes] == 'E')
    {
        lepes += dobas;
        Console.WriteLine("Új pozíció: {0}", lepes);
    }

    if (palya[lepes] == 'V')
    {
        lepes -= dobas;
        Console.WriteLine("Új pozíció: {0}", lepes);
    }

    if (palya[lepes] == 'M')
    {
        lepes -= dobas;
        Console.WriteLine("Új pozíció: {0}", lepes);
    }

    Console.WriteLine("Dobj!");
    dobas = Convert.ToInt32(Console.ReadLine());
    lepes += dobas;
}



