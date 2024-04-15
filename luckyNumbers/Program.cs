using static System.Console;
using static System.Convert;
using static System.Math;

int start, end;
bool test = true;
string str2 = "";
string str1 = ReadLine();
var arr = str1.Split(" ");
start = ToInt32(arr[0]);
end = ToInt32(arr[1]);

for(int i = start; i <= end; i++)
{
    test = true;
    int x = i;
    while (x != 0)
    {
        if(x%10 == 4 || x % 10 == 7)
        {
            x /= 10;
        }
        else
        {
            test = false; 
            break;    
        }
    }
    if(test == true)
    {
        str2 += $"{i} ";
    }
}
if (str2.Equals(""))
{

    WriteLine("-1 ");
}
else
{
    WriteLine(str2);
}
