
int k;
k= Convert.ToInt32(Console.ReadLine()) ;
int o1 = k%7;
int o2 = k%23;
if (o1==0 && o2==0)
{
Console.WriteLine("Число делиться без остатка на 7 и 23.");
} else
{
    Console.WriteLine("Число не делиться без остатка на 7 и 23.");
}


int x;
int y;
x= Convert.ToInt32(Console.ReadLine());
y= Convert.ToInt32(Console.ReadLine());
if (x!=0 && y!=0)
{
    if (x>0 && y>0)
    {
    Console.WriteLine("1 четверть.");
    } else if (x>0 && y<0)
    {
    Console.WriteLine("4 четверть.");
    } else if (x<0 && y>0)
    {
    Console.WriteLine("2 четверть.");
    } else
    {
        Console.WriteLine("3 четверть.");
    }
} else
{
    Console.WriteLine("Число не должно быть равным 0.");
    x= Convert.ToInt32(Console.ReadLine());
    y= Convert.ToInt32(Console.ReadLine());
}


int max=0;
int otr;
otr= Convert.ToInt32(Console.ReadLine());
while (otr>9)
{     
    int ostatok = otr%10;
    if(ostatok>max)
    {
        max=ostatok;
    }    
    otr=otr/10;
    
}
Console.WriteLine($"{max}");

int ost=0;
int N;
N= Convert.ToInt32(Console.ReadLine());
while (N>9)
{    
    ost=0;
    ost = N%10;
    Console.Write($"{ost}, ");
    N=N/10;
    
}
Console.Write($"{N}.");
