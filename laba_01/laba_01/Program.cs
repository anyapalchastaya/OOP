using System.Text;

Console.ForegroundColor = ConsoleColor.DarkCyan;
// 1a
int age = 10;
Console.WriteLine("Age: " + age);

bool flag = true;
Console.WriteLine("Flag:" + flag);

byte Age = 62;
Console.WriteLine("Age:" + Age); 

sbyte level = 23;
Console.WriteLine(level);

short value = -1109;
Console.WriteLine(value);

long range = -7091821871L;
Console.WriteLine(range);

ushort Value = 42019;
Console.WriteLine(Value);

uint totalScore = 1151092;
Console.WriteLine(totalScore);

ulong Range = 17091821871L;
Console.WriteLine(Range);

float number = 43.27F;
Console.WriteLine(number);

double VAlue = -11092.53D;
Console.WriteLine(VAlue);

char ch1 = '\u0042';
char ch2 = 'x';
Console.WriteLine(ch1);
Console.WriteLine(ch2);

decimal bankBalance = 53005.25M;
Console.WriteLine(bankBalance);

//1b_1
int ageint = 5;
float agefloat = ageint;
Console.WriteLine("agefloat=" + agefloat);

int num = 7;
float numF = 2.5F;
float result = num + numF;
Console.WriteLine("result=" + result);

//1b_2
double doub = 4.5;
float dfloa = (float) doub;
Console.WriteLine("dfloa=" + dfloa);

int heightint = 6;
byte heightbyte = (byte)heightint;
Console.WriteLine("hrightbyte=" + heightbyte);

double doubweight = 25.5;
bool boolweight = Convert.ToBoolean(doubweight);
Console.WriteLine("boolweight=" + boolweight);

int year = 10;
float quater = 2.5F;
int result1 = (int)(year + quater);
Console.WriteLine("result1=" + result1);

double dNumber = 23.15;
Console.WriteLine("dNumber " + dNumber.GetType());
string strNumber = System.Convert.ToString(dNumber);
Console.WriteLine("dNumber after Converttostring " + strNumber.GetType());

//1c
int ab = 1;
object ba = ab; //упаковка
int ca =(int) ba; //распаковка
Console.WriteLine("ca=" + ca);

//1d
Console.WriteLine("Enter ur name");
var name0 = Console.ReadLine();
Console.WriteLine("i'm " + name0.GetType());

//1e
int? notInt = null; // system. nullable ( структура)
Console.WriteLine("Task1e\n notInt" + notInt);

//1f
var taskF = 345; //-> int;
Console.WriteLine("task 1F \n taskF = " + taskF);

//2
string name = "Anya";
string midname = "Palchastaya";
string copyname = "Anya";
Console.Write("task 2a name == midname =  ");
Console.WriteLine(name == midname);
Console.Write(" task 2a name == copyname =  ");
Console.WriteLine(name == copyname);
Console.WriteLine("Compare:" + String.Compare(name, midname));
Console.WriteLine("Equals:" + String.Equals(name, midname));
Console.WriteLine("Contains:" + name.Contains(midname));
Console.WriteLine("Compare:" + String.Compare(name, copyname));
Console.WriteLine("Equals:" + String.Equals(name, copyname));
Console.WriteLine("Contains:" + name.Contains(copyname));
Console.WriteLine("== " + name == copyname);
Console.WriteLine("== " + name == midname);
string letter1 = "a";
string letter2 = "b";
Console.WriteLine(letter1 + letter2); //   конкантинация/сцепление
Console.WriteLine(String.Concat(letter1,letter2)); //   конкантинация 
string copymidname = String.Copy(midname); //  копируем строку 
Console.WriteLine("Подстрока: name  = " +name + "Anya [2] = " + name.Substring(2,1)); //выделение подстроки
string deal = "How are you doing Anya?";
string[] subs = deal.Split(" "); // разделение строк
foreach (var sub in subs)
{
    Console.WriteLine($" Разеделение строки deal = {deal} Разделение: {sub}") ; //интерполирование 

}
string str1 = "Hellooooooo";
Console.WriteLine("str1 = " + str1);
Console.WriteLine("Insert " + str1.Insert(1, " eee "));
Console.WriteLine("Remove " + str1.Remove(1, 5));

// 2c 
Console.WriteLine("2c\n");
string empty = string.Empty;
string nullStr = null;
if (string.IsNullOrWhiteSpace(empty))
{
    Console.WriteLine("i am Empty ");
}
if (string.IsNullOrEmpty(nullStr))
{
    Console.WriteLine("I am Null ");
}



// 2d 
Console.WriteLine("2d\n");
StringBuilder sb = new StringBuilder("hi dear R2D2", 50); // Предоставляет возможность менять строку.
//name[0] = "h"; стринг нельзя изменять


Console.WriteLine("Sb = " + sb);
sb.Remove(0, 7);
Console.WriteLine("Sb After rm " + sb);
sb.Insert(5, " & C3PO"); //вставить в 5 позицию
Console.WriteLine("Sb After insert " + sb);
sb.Append(": Star Wars"); //добавить в конец 
Console.WriteLine("Sb After Append " + sb);
Console.WriteLine("task 3");
Console.WriteLine();
int[] nums = { 1, 3, 5, 7, 9 };
string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
Console.WriteLine("3b string arr: " + string.Join(",", weekDays2));
Console.WriteLine("Lenght of massive: " + weekDays2.Length);
weekDays2[1] = "anuesday";
Console.WriteLine("3b string arr: " + string.Join(",", weekDays2));

int[][] jaggedArr = new int[3][]; // ступенчатый массив
jaggedArr[0] = new int[2];
jaggedArr[1] = new int[3];
jaggedArr[2] = new int[4];

for (int i = 0; i < jaggedArr.Length; i++)
{
    
    for (int j = 0; j < jaggedArr[i].Length; j++)
    {
        if (i == 0 && j == 0)
        {
            Console.WriteLine("Enter number");

            jaggedArr[0][0] = Convert.ToInt32(Console.ReadLine()); // тк с консоли все идет стрингом 

            Console.WriteLine("Your arr\\/");
            Console.Write(jaggedArr[0][0] + " ");
        }
        else
        {
            jaggedArr[i][j] = i + j;
            Console.Write(jaggedArr[i][j] + " ");
        }
    }
    Console.WriteLine();
}

// 4 
Console.WriteLine("Task 4");
(int, string, char, string, ulong) person = (25, "Anya", 'A', "Palchastaya", System.UInt64.MaxValue);
Console.WriteLine($"our tuple: {person}" );
Console.WriteLine($"our tuple: {person.Item1},{person.Item3},{person.Item4} ");
(var age2, _,_,_,_) = person; //распаковкамв переменные
(var height2, var phrase, _) = (3,"bye",9.0);
(int, string, char, string, ulong) person2 = (5, "Anya", 'A', "Palchastaya", System.UInt64.MaxValue);
Console.WriteLine($"age2 = {age2},height2 = {height2}");
Console.WriteLine($"phrase = {phrase}");
Console.WriteLine($"Compare tuple: {person==person2}");

//  5
Console.WriteLine("Task 5");
//local function
(int, int, int, char) Tupler(int[] num, string str)
{
    int max_num = -2147483648;
    int min_num = 2147483647;
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {

        max_num = Math.Max(max_num, num[i]);
        min_num = Math.Min(min_num, num[i]);
        sum += num[i];
    }
    (int, int, int, char) tup = (max_num, min_num, sum, str[0]);
    return tup;
}
int[] arr_5 = { -1, 0, 1, 2, 3, 4, 7 };
string car = "Porsche";
Console.WriteLine($"task 5\n Parametrs [-1, 0, 1, 2, 3, 4, 7] and {car} fun return :{Tupler(arr_5, car)}");
//6
void check_fun()
{
    double a = double.MaxValue;

    int b;

    try
    {
        b = checked((int)a);
    }
    catch (OverflowException e)
    {
        Console.WriteLine("checked: double -> int " + e.Message);  // output: Arithmetic operation resulted in an overflow.
    }
}
void uncheck_fun()
{
    double a = double.MaxValue;
    int b = unchecked((int)a);
    Console.WriteLine("unchecked: double-> int " + b);  // output: -2147483648
}
check_fun();
uncheck_fun();






























//dynamic dyn = 1;
//object obj = 1;
//Console.WriteLine(dyn.GetType());
//Console.WriteLine(obj.GetType());

