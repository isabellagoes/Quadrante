double x, y;
string local;

Console.WriteLine("---------------- Quadrante Cartesiano ----------------\n");

Console.WriteLine("O ponto pode se encontrar no plano cartesiano em:\n");

Console.WriteLine("-> um dos quadrantes");
Console.WriteLine("-> sobre um dos eixos");
Console.WriteLine("-> na origem\n");

Console.WriteLine("Informe as coordenadas vertical (y) e horizontal (x):\n");

Console.Write("Coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) local = "na origem";
else if (x == 0) local = "no eixo das ordenadas";
else if (y == 0) local = "no eixo das abscissas";
else if (y > 0)
{
    if (x > 0)
        local = "no quadrante 1";
    else
        local = "no quadrante 2";
}

else
{
    if (x < 0)
        local = "no quadrante 3";
    else
        local = "no quadrante 4";
}

Console.WriteLine($"\nO ponto ({x}, {y}) fica {local}.");