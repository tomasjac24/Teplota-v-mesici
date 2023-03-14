using Spectre.Console;
//Výběr měsíce
var mesic = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Vyber měsíc do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber měsíc šipkami)[/]")
        .AddChoices(new[] {
            "Leden", "Únor","Březen","Duben","Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec"
        }));
//Dny v měsíci
string[] dny28 = {"1.den","2.den","3.den","4.den","5.den","6.den","7.den","8.den","9.den","10.den","11.den","12.den","13.den","14.den",
            "15.den","16.den","17.den","18.den","19.den","20.den","21.den","22.den","23.den","24.den","25.den","26.den","27.den","28.den",};
string[] dny30 = {"1.den","2.den","3.den","4.den","5.den","6.den","7.den","8.den","9.den","10.den","11.den","12.den","13.den","14.den",
            "15.den","16.den","17.den","18.den","19.den","20.den","21.den","22.den","23.den","24.den","25.den","26.den","27.den","28.den",
            "29.den","30.den"};
string[] dny31 = {"1.den","2.den","3.den","4.den","5.den","6.den","7.den","8.den","9.den","10.den","11.den","12.den","13.den","14.den",
            "15.den","16.den","17.den","18.den","19.den","20.den","21.den","22.den","23.den","24.den","25.den","26.den","27.den","28.den",
            "29.den","30.den","31.den"};

switch (mesic)
{
    case "Leden":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );

        break;

    case "Únor":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny28
        );
        break;
    
    case "Březen":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );
        break;

    case "Duben":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny30
        );
        break;

    case "Květen":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );
        break;

    case "Červen":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny30
        );
        break;

    case "Červenec":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );
        break;

    case "Srpen":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );
        break;

    case "Září":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny30
        );
        break;

    case "Říjen":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );
        break;

    case "Listopad":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny30
        );
        break;

    case "Prosinec":
    new SelectionPrompt<string>()
        .Title("Vyber den do kterého chceš zadat teplotu.")
        .PageSize(10)
        .MoreChoicesText("[grey](Vyber den šipkami)[/]")
        .AddChoices(
            dny31
        );
        break;


}