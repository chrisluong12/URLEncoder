using System;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delims = new char[] { '!', '\"', '#', '$', '%', '&', '<', '>' };
            char[] other = new char[] { '{', '}', '|', '^', '[', ']', '`' };
            char[] query = new char[] { ';', '/', '?', ':', '@', '&', '=', '+', '$', ',' };

            Console.WriteLine("Hi! Welcome to my URL Encoder!");              Console.WriteLine("Enter Project Name: ");             String Project_name = Console.ReadLine();             Console.WriteLine("Enter Activity Name: ");             String Activity_name = Console.ReadLine(); //read in the input
             String url = "https://companyserver.com/content/"; //the start of the url

            encoder(Project_name, ref url, delims, other, query);//sends input through function to check for characters to encode
            url += "/files/"; //appends this to the end of the url string
            encoder(Activity_name, ref url, delims, other, query); // sends the activity name through the encoder to check for characters
            url += "/Report.pdf"; 
            Console.WriteLine(url);

        }

        public static void encoder(String input, ref String url, char[] delims, char[] other, char[] query)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsControl(input[i])) //this should work but not sure if inputting control characters correctly
                {
                    Console.WriteLine("Control Characters are not allowed. Please input a something valid.");
                }
                else if (Char.IsWhiteSpace(input[i]))
                {
                    url += "%20";
                }
                else if (input[i] == delims[0])
                {
                    url += "%21";
                }
                else if (input[i] == delims[1])
                {
                    url += "%22";
                }
                else if (input[i] == delims[2])
                {
                    url += "%23";
                }
                else if (input[i] == delims[3])
                {
                    url += "%24";
                }
                else if (input[i] == delims[4])
                {
                    url += "%25";
                }
                else if (input[i] == delims[5])
                {
                    url += "%26";
                }
                else if (input[i] == delims[6])
                {
                    url += "%3C";
                }
                else if (input[i] == delims[7])
                {
                    url += "%3E";
                }
                else if (input[i] == other[0])
                {
                    url += "%7B";
                }
                else if (input[i] == other[1])
                {
                    url += "%7D";
                }
                else if (input[i] == other[2])
                {
                    url += "%7C";
                }
                else if (input[i] == other[3])
                {
                    url += "%5E";
                }
                else if (input[i] == other[4])
                {
                    url += "%5B";
                }
                else if (input[i] == other[5])
                {
                    url += "%5D";
                }
                else if (input[i] == other[6])
                {
                    url += "%5C";
                }
                else if (input[i] == query[0])
                {
                    url += "%3B";
                }
                else if (input[i] == query[1])
                {
                    url += "%2F";
                }
                else if (input[i] == query[2])
                {
                    url += "%3F";
                }
                else if (input[i] == query[3])
                {
                    url += "%3A";
                }
                else if (input[i] == query[4])
                {
                    url += "%40";
                }
                else if (input[i] == query[5])
                {
                    url += "%26";
                }
                else if (input[i] == query[6])
                {
                    url += "%3D";
                }
                else if (input[i] == query[7])
                {
                    url += "%2B";
                }
                else if (input[i] == query[8])
                {
                    url += "%24";
                }
                else if (input[i] == query[9])
                {
                    url += "%2C";
                }
                else
                {
                    url += input[i];
                }

            }
        }
    }
}
