//  Program name: Erepting-Volcanoes
//  INPUTS:
//         1) n - diemntion of square  
//         2) m - number of active volcanoes
//         3) x y w - coordinates of the volcanoes and the power of lava
//         1) n - diemntion of square  
// Output:   
//         Maximum power of the lava in the area (which may be the sum of the powers if the lava overlap in some areas)  
// SAMPLE INPUT:
//              8
//              2
//              0 0 5
//              7 7 6
//
//  SAMPLE OUTPUT: 1) The array (just for understnding)
//                 2) Max power of lava in the area

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] area = new int[n, n];
        int[,] pow = new int[n, n];
        
        for (int a0 = 0; a0 < m; a0++)
        {
            string[] tokens_x = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(tokens_x[0]);
            int y = Convert.ToInt32(tokens_x[1]);
            int w = Convert.ToInt32(tokens_x[2]);
           
            for(int i=0; i<n; i++) {
                for(int j=0; j<n; j++) {
                    //TODO
                    int rowDiff = Math.Abs(x- i);
                    int colDiff = Math.Abs(y- j);
                    int max = Math.Max(rowDiff, colDiff);
                    int res = w - max;
                    area[i,j] = res > 0 ? res : 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //TODO
                    pow[i,j] += area[i,j];
                }
            }

 
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(pow[i, j]+ "   ");
            }
            Console.WriteLine();
        }

        int result = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++ )
                if(pow[i,j] > result)
                    result = pow[i,j];



        Console.WriteLine("\nMax power:"+result);
                Console.ReadKey();
    }
}


