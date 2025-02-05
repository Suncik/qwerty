using System;

class Program{
    static void Main(){


        //  1-MASALA


        // int x=0, s=0;
        // while(x<1000){
        //     x++;
        //     s+=x;

        // }
        // System.Console.WriteLine(s);


        // //2-MASALA
        // int[] array=new int[5];
        // System.Console.WriteLine("massiv elementlarini kiriting: ");
        // for(int i=0; i<5; i++){
        //     array[i]=int.Parse(Console.ReadLine());

        // }
        // int  mx=0, mn=0;
        // for(int i=0; i<5; i++){
        //     if(i==0){
        //         mn=mx=array[i];
        //     }  else if(array[i]>mx){
        //         mx=array[i];
        //     }
        //      if(array[i]<mn){
        //         mn=array[i];
        //     }
        
        // }
        //     System.Console.WriteLine($"mn={mn}  mx={mx}");



        // 3-MASALA
        int k=1;
        System.Console.WriteLine("X SONINI KIRITING:");
        int x=int.Parse(Console.ReadLine());
        for(int i=1; i<=x; i++){
            k*=i;
        }
        System.Console.WriteLine($"{x}!={k}");





    }
}