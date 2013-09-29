using System;
using System.Collections.Generic;
using System.IO;

namespace ThreeDPoints
{
    public class PathStorage
    {
        public static void WritePathPoints(Path pathToAdd)
        {
            string textFileName = @"..\..\TextFiles\CurrentPoints.txt";
            StreamWriter writer = new StreamWriter(textFileName);
            try
            {
                using (writer)
                {
                    foreach (var point in pathToAdd.SetOfPoints)
                    {
                        writer.WriteLine(point.ToString());
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found");
                throw new DirectoryNotFoundException(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found");
                throw new FileNotFoundException(e.Message);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is null");
                throw new ArgumentNullException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("The path is a zero-length string, contains only white space, or contains one or more invalid characters");
                throw new ArgumentException(e.Message);
            }       
        }

        public static void ReadPathPoints()
        {
            string textFileName = @"..\..\TextFiles\CurrentPoints.txt";
            StreamReader reader = new StreamReader(textFileName);
            try
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    int lineNumber = 1;
                    while (line != null)
                    {
                        string[] separated = line.Split(new char[] { '(', ',', ')', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        double one = double.Parse(separated[7]);
                        double two = double.Parse(separated[8]);
                        double three = double.Parse(separated[9]);
                        ThreeDPoint readPoint = new ThreeDPoint(one, two, three);
                        MainTest.currentPath.AddPoint(readPoint);
                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found");
                throw new DirectoryNotFoundException(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found");
                throw new FileNotFoundException(e.Message);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is null");
                throw new ArgumentNullException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("The path is a zero-length string, contains only white space, or contains one or more invalid characters");
                throw new ArgumentException(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("The text you are trying to parse have some invalid numbers");
                throw new FormatException(e.Message);
            }
        }
    }
}
