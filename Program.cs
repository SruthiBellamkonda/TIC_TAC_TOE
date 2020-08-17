using System;

namespace AssignmentCsharp
{
    class Program
    {
        static int c, d;
        static int player = 1;
        //static int winner;
        static int flag = 0;
        static String[,] arr = { { "0 0", "0 1", "0 2" }, { "1 0", "1 1", "1 2" }, { "2 0", "2 1", "2 2" } };
        static String[,] arr1 = { { "0 0", "0 1", "0 2" }, { "1 0", "1 1", "1 2" }, { "2 0", "2 1", "2 2" } };

        //static char[3][3] arr = { { '1', '2', '3' },{ '4', '5', '6' },{ '7', '8', '9' } };
        static void Main(string[] args)
        {
            //int count2 = 0;
            do

            {
                //c++;
               //Console.Clear();

                Console.WriteLine("Player1:X and Player2:O");

                Console.WriteLine("\n");

                if (player % 2 == 0)

                {

                    Console.WriteLine("Player 2 Chance");

                }

                else

                {

                    Console.WriteLine("Player 1 Chance");

                }

                Console.WriteLine("\n");

                DisplayBoard();
                Console.WriteLine("Enter the row :(as displayed)");

                c = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the column :(as displayed)");
                d = int.Parse(Console.ReadLine());



                

                if (arr[c,d] != " X " && arr[c,d] != " O ")

                {

                    if (player % 2 == 0) 

                    {

                        arr[c,d] = " O ";

                        player++;

                        //count2++;
                        //Console.WriteLine(count2);

                    }

                    else

                    {

                        arr[c,d] = " X ";

                        player++;

                        //count2++;
                        //Console.WriteLine(count2);

                    }

                }

                else 
                {

                    Console.WriteLine("Sorry the  {0} row and {1} column is already marked with {2}", c,d, arr[c,d]);

                    Console.WriteLine("\n");

                    

                }
                //if (count2 >= 9)
                  //  break;
                flag = CheckWinner();
                //Console.WriteLine(flag);

            } while (flag != 1 && flag != -1 );

            Console.Clear();

            DisplayBoard();
            if (flag == 1)
            {

                Console.WriteLine("Player {0} has won", (player % 2) + 1);

            }

            else
            {

                Console.WriteLine("Draw Match");

            }

        }
        public static void DisplayBoard()
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("       |       |       ");
                Console.WriteLine("  {0}  |  {1}  |  {2}  ", arr[i, 0], arr[i, 1], arr[i, 2]);
                if(i!=2)
                Console.WriteLine("_______|_______|_______");
            }


        }
        public static int CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (String.Equals(arr[i, 1],arr[i,0]) && String.Equals(arr[i, 1], arr[i, 2]))//row
                {
                    //Console.WriteLine(arr[i,0]);
                    return 1;
                }
                if (String.Equals(arr[1, i],arr[0,i]) && String.Equals(arr[1, i], arr[2, i]))//column
                {
                    //Console.WriteLine(arr[1, i]);
                    return 1;
                }
                
            }
            if(String.Equals(arr[0,0],arr[1,1]) && String.Equals(arr[0, 0], arr[2,2]))
            {
                return 1;
            }
            if (String.Equals(arr[0, 2],arr[1,1]) && String.Equals(arr[2, 0], arr[1, 1]))
            {
                //Console.WriteLine(arr[1, 1]);
                return 1;
            }
            int count = 0;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (!(String.Equals(arr[i, j], arr1[i, j])))
                        count++;
                }
            }
            if (count == 9)
                return -1;
            return 0;
        }
    }
}
