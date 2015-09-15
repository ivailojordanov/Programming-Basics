using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static int position1;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split();
            char[] rooms = new char[n];
            FillRooms(input, rooms);
            position1 = n / 2;

            while (command[0] != "END")
            {
                if (command[0] == "RIGHT")
                {
                    if (position1 + int.Parse(command[1].ToString()) + 1 > rooms.Length - 1)
                    {
                        int position2 = rooms.Length - 1;
                        if (position1 != position2)
                        {
                            position1 = rooms.Length - 1;
                            SwitchLights(rooms, position1);
                        }
                    }
                    else
                    {
                        position1 = position1 + int.Parse(command[1].ToString()) + 1;
                        SwitchLights(rooms, position1);
                    }
                }
                else if (command[0] == "LEFT")
                {
                    if (position1 - int.Parse(command[1].ToString()) - 1 < 0)
                    {
                        int position2 = 0;
                        if (position1 != position2)
                        {
                            position1 = 0;
                            SwitchLights(rooms, position1);
                        }
                    }
                    else
                    {
                        position1 = position1 - int.Parse(command[1].ToString()) - 1;
                        SwitchLights(rooms, position1);
                    }
                }
                else
                {
                    position1 = position1 - int.Parse(command[1].ToString()) - 1;
                    SwitchLights(rooms, position1);
                }
                command = Console.ReadLine().Split();
            }
            int count = 0;
            foreach (var item in rooms)
	        {
                if(item == 'D') count++;
	        }
            Console.WriteLine(count * (int)'D');

        }

        private static void FillRooms(string input, char[] rooms)
        {
            int counter = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = input[counter % input.Length];
                counter++;
            }
        }

        private static void SwitchLights(char[] rooms, int position1)
        {
            if (rooms[position1] == 'L')
            {
                rooms[position1] = 'D';
            }
            else
            {
                rooms[position1] = 'L';
            }
        }
    }
}
