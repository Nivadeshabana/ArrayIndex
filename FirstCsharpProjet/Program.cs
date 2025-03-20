// See https://aka.ms/new-console-template for more information
Console.WriteLine("age:");
int age = Int32.Parse(Console.ReadLine());
Console.WriteLine("ageof the person{0}", age);

int[] arr = new int[] { 5, 7, 2,8, 4, 3, 6, 9, 1, 0 };
int[] copyArray = new int[arr.Length];


Array.Copy(arr,copyArray, arr.Length);
for (int i = 0; i < copyArray.Length; i++)
{
    Console.Write("{0}:", arr[i]);
}
for (int i = 0; i < arr.Length; i++)
{
    for(int j = 0; j < arr.Length; j++)
    {
        if (i == arr[j])
        {
            //Console.WriteLine("arr element at {0}:{1}", i, arr[j]);
            copyArray[i] = j;
        }
    }
}
Console.WriteLine("\n copyArray after process");
for (int i = 0;i < copyArray.Length; i++)
{
    Console.Write("{0}:",copyArray[i]);
}
