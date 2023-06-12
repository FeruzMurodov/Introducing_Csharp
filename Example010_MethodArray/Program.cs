int[] array = { 11, 82, 73, 64, 55, 46, 37, 18, 19 };
int N = array.Length;
int find = 18;
int index=0;
 while(index<N)
 {
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
        }
    index++;
 }