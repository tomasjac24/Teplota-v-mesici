using Spectre.Console;
//Výběr měsíce
Zpět:
var mesic = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Vyber měsíc do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber měsíc šipkami)[/]")
        .AddChoices(new[] {
            "Leden", "Únor","Březen","Duben","Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec"
        }));
//Dny v měsíci
string[] dny28 = {"Únor"};
string[] dny30 = {"Duben", "Červen", "Září", "Listopad" };
string[] dny31 = {"Leden", "Březen", "Květen", "Říjen", "Prosinec"};

int dnyVMesici = 0;
if (dny28.Contains(mesic)) dnyVMesici = 28;
if (dny30.Contains(mesic)) dnyVMesici = 30;
if (dny31.Contains(mesic)) dnyVMesici = 31;

var dny = new List<string>();
var stupne = new List<float>();
//Výběr dne
for (int i = 1; i <= dnyVMesici; i++) dny.Add($"{i}.den");
dny.Add("Zpět");
dny.Add("Konec");
bool opakovani = true;
while (opakovani)
{
    Console.Clear();
    var den = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("Vyber den do kterého chceš zadat teplotu.")
            .PageSize(10)
            .MoreChoicesText("[grey](Vyber den šipkami)[/]")
            .AddChoices(dny));
    if(den=="Zpět")
    {
        goto Zpět;
    }
    if (den == "Konec")
    {
        opakovani = false;
        break;
    }
    float stupen = AnsiConsole.Ask<float>("Vypiš teplotu dne:");
    int pozice = dny.IndexOf(den);
    stupne.Add(stupen);
    dny[pozice] = $"{pozice + 1}.den = {stupen}°C";
}