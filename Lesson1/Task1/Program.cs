int a = 6;
int b = 7;
int c = 10;
int d = 4;
int e = 9;
String g="";
int max = a;
if (b > max)
{
    max = b;g="b";
}
if (c > max)
{
    max = c;g="c";
}
if (d > max)
{
    max = d;g="d";
}
if (e > max)
{
    max = e;g="e";
}

 Console.WriteLine($"самая тяжелая гиря:{g}={max}"); 
