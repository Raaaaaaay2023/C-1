// See https://aka.ms/new-console-template for more information
Console.WriteLine("please type 3 numbers");
string a1 = Console.ReadLine();
string b1 = Console.ReadLine();
string c1 = Console.ReadLine();
int c = Convert.ToInt32(a1);
int d = Convert.ToInt32(b1);
int e = Convert.ToInt32(c1);
int[] nums={c,d,e};
int max=nums.Max();
Console.WriteLine("The max number will be "+ max);
//int result= c*d;
//Console.WriteLine("The numbers you have typed is "+a+" and "+b);
//Console.WriteLine("The result will be "+result);
//finial changes