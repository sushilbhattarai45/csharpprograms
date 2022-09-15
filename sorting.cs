
using System;

public class HelloWorld
{
  public static void Main (string[]args)
  {
    int[] arr = new int[5];
      Console.WriteLine ("enter data for array");
    for (int i = 0; i < 5; i++)
      {
	arr[i] = Convert.ToInt32 (Console.ReadLine ());
      }
      int temp=0;
    
for (int i=0;i<5;i++)
{
    for (int j=i+1;j<5;j++)
    {
       if(arr[i]>arr[j])
       {        temp=arr[i];
        arr[i]=arr[j];
        arr[j]=temp;
       }
    }

}
  for (int i = 0; i < 5; i++)
      {
Console.WriteLine(arr[i]);      }
  }
}
