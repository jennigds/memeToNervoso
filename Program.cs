string fraseEscrita, fraseMEMEtoNervoso;
Console.WriteLine("Ei, o que você pensa sobre mim?");
fraseEscrita = Console.ReadLine()!;

fraseMEMEtoNervoso = $"{fraseEscrita.Remove(10)}... NÃO, PERA.\nTô nervoso";
Console.WriteLine(fraseMEMEtoNervoso);