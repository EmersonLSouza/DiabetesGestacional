int glicemia;

Console.WriteLine("----Diabetes Gestacional----\n");

Console.Write("Valor da Glicemia em mg/dL: ");
glicemia = Convert.ToInt32(Console.ReadLine());

if(glicemia > 126)
{   
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Diabetes Mellitus na Gravidez");
}
else
{
    if(glicemia >= 92)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Compatível com Diabetes Gestacional");
    }
    else
    {   
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("(reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
    }
}
    
Console.ResetColor();