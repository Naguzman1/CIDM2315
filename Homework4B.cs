namespace Homework4B;
class Program
{  
    public static void Main() 
{
   int N = 5; 
   string shape; 
   Console.Write("Input shape: ");
   shape= Console.ReadLine(); 
   Console.Write($"N is; {N} shape is "+shape+"\n"); 
   side(N,shape); 
}

    static void side(int N,string shape){
    int i,j,k; 
    if(shape=="left"){
   
       for(i=1;i<=N;i++)
       {
    	for(j=1;j<=i;j++)
    	   Console.Write("*");
    	Console.Write("\n"); 
       }
      }
    else if(shape=="right"){
    //if shape is right
     for (i = 1; i <= N; i++)  
         {  
            for (j = 1; j <= N-i; j++)  
            {Console.Write(" ");} 
            for (k = 1; k <= i; k++)  
            {  Console.Write("*");}  
            Console.WriteLine("");  }
        }
    }
}

