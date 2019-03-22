using System;
using System.IO;

namespace Documentmerger2
{
    class Program
    {static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2<input_file_1> <input_file_2> ... <input_file_n> <output_file>  ");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }
            else
            {

                var output = args[args.Length - 1];
                StreamWriter writer = null;
                int count = 0;
                try
                {
                     writer = new StreamWriter(output);

                    String line = null;

                    while (count < (args.Length - 1))
                    {


                        using (StreamReader reader = new StreamReader(args[count]))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                writer.WriteLine(line);
                            }
                        }

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    writer.Close();
                }

            }

        }
    }
}
