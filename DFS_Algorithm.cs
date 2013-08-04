//7.* Write a program that finds the largest
//area of equal neighbor elements in a rectangular
//matrix and prints its size. Example:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_EqualNeighbor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 7]; //change dimension to test
            MatrixField[,] MF = new MatrixField[arr.GetLength(0), arr.GetLength(1)];
            int debth = 0;
            Random rnd = new Random();
            rnd.Next(3);

            //init martix with random numbers between 1 nad 3
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    MF[i, j] = new MatrixField(i, j, MF);
                    MF[i, j].value = rnd.Next(3);   // if you whant put here console readline and input digits manualy, or change random range
                    MF[i, j].possX = j;
                    MF[i, j].possY = i;
                    Console.Write(MF[i, j].value + ",  ");
                }
                Console.WriteLine();
            }

            //start search for sequnces
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    debth = debth + MF[i, j].Check(MF[i, j].value);  //here search for sequnces recursively      
                    Console.WriteLine("Curreent Depth for {0},{1} is {2}", i, j, debth);

                    //init elements as not visited and with 0 debth
                    debth = 0;
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        for (int m = 0; m < arr.GetLength(1); m++)
                        {
                            MF[k, m].notVisited = true;
                            MF[k, m].debth = 0;
                        }

                    }
                }
            }

        }
    }
}

class MatrixField
{
    public MatrixField(int possY, int possX, MatrixField[,] field)
    {
        this.possX = possX;
        this.possY = possY;
        this.field = field;
        this.notVisited = true;
        this.debth = 0;
    }
    public bool notVisited;
    public int value;
    public MatrixField[,] field;
    public int possX;
    public int possY;
    public int debth;

    public int Check(int newvalue)
    {
        if (this.possY > 0)  //check above  element is the same
        {

            if ((field[possY - 1, possX].value == newvalue) && field[possY - 1, possX].notVisited)
            {
                this.notVisited = false;
                this.debth = this.debth + field[possY - 1, possX].Check(this.value);
                field[possY - 1, possX].notVisited = false;

            }


        }
        if (this.possY < (field.GetLength(0) - 1)) //check the down member is the same
        {

            if ((field[possY + 1, possX].value == newvalue) && field[possY + 1, possX].notVisited)
            {
                this.notVisited = false;
                this.debth = this.debth + field[possY + 1, possX].Check(this.value);
                field[possY + 1, possX].notVisited = false;

            }


        }
        if (this.possX < (field.GetLength(1) - 1)) //check the right element
        {

            if ((field[possY, possX + 1].value == newvalue) && field[possY, possX + 1].notVisited)
            {
                this.notVisited = false;
                this.debth = this.debth + field[possY, possX + 1].Check(this.value);
                field[possY, possX + 1].notVisited = false;

            }


        }
        if (this.possX > 0) //check the left element
        {

            if ((field[possY, possX - 1].value == newvalue) && field[possY, possX - 1].notVisited)
            {
                this.notVisited = false;
                this.debth = this.debth + field[possY, possX - 1].Check(this.value);
                field[possY, possX - 1].notVisited = false;

            }


        }

        return this.debth + 1;


    }

}
