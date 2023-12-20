int a = 7;
int b = 10;
int c = 6;
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
