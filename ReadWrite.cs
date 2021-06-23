using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjektForms
{
    class ReadWrite
    {
        private string fileNameIn;
        private string fileNameOut;
        private Command[] commands;
        public ReadWrite()
        {
            fileNameIn = "in.txt";
            fileNameOut = "out.txt";
        }
        public void Read()
        {
            using (StreamReader file = new StreamReader(fileNameIn))
            {
                int size = Convert.ToInt32(file.ReadLine());
                commands = new Command[size];
                string fileLine;
                string[] fileLineSplitted;
                string[] ipSplited;
                for (int i = 0; i < size; i++)
                {
                    fileLine = file.ReadLine();
                    fileLineSplitted = fileLine.Split(null);
                    for (int j = 1; j < fileLineSplitted.Length && j < 3; j++)
                    {
                        ipSplited = fileLineSplitted[j].Split('.');
                        byte[] ip = new byte[4];
                        for (int z = 0; z < ipSplited.Length; z++)
                        {
                            ip[z] = Convert.ToByte(ipSplited[z]);
                        }
                        if (j == 1) commands[i] = new Command(fileLineSplitted[0], ip);
                        else commands[i].ip2 = ip;
                    }
                    if (fileLineSplitted.Length == 1)
                    {
                        commands[i] = new Command(fileLineSplitted[0]);
                    }
                    if (fileLineSplitted.Length == 4)
                    {
                        switch (fileLineSplitted[0])
                        {
                            case "DP":
                                char[] array = fileLineSplitted[3].ToCharArray();
                                string value = "";
                                for (int n = 0; n < array.Length - 1; n++)
                                {
                                    value += array[n];
                                }
                                int cost = Convert.ToInt32(value);
                                if (array[array.Length - 1] == 'G') cost = 100 / cost;
                                else if (array[array.Length - 1] == 'M') cost = 100000 / cost;
                                commands[i].cost = cost;
                                break;
                            case "NP2":
                                commands[i].k = Convert.ToInt32(fileLineSplitted[3]);
                                break;
                        }
                    }
                }
            }
        }
        public void Write(List<string> output)
        {
            using (StreamWriter file = new StreamWriter(fileNameOut))
            {
                foreach (string s in output)
                {
                    file.WriteLine(s);
                }
            }
        }
        public Command[] GetCommands()
        {
            return commands;
        }
    }
}
