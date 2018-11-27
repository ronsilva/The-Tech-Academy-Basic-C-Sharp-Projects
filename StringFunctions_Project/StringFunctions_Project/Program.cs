using System;
using System.Text;

class Program
    {
        static void Main()
        {
            //Concatenate three strings.
            string fName = "Joe";
            string mName = "Meets";
            string lName = "Black";
            string fullName = fName + " " + mName + " " + lName;
            Console.WriteLine(fullName);
            Console.WriteLine("*********************************");
            //Convert a string to uppercase.
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName);
            //Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder sb = new StringBuilder();

            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("Ron ");
            sb.Append("Silva. ");
            sb.Append("I'm ");
            sb.Append("a ");
            sb.Append("developer ");
            sb.Append("in ");
            sb.Append("training. \n");
            sb.Append("My ");
            sb.Append("rubberduck ");
            sb.Append("is ");
            sb.Append("a ");
            sb.Append("brown ");
            sb.Append("plush ");
            sb.Append("puppy ");
            sb.Append("holding ");
            sb.Append("a ");
            sb.Append("heart. \n");
            sb.Append("I ");
            sb.Append("have ");
            sb.Append("a ");
            sb.Append("hampster ");
            sb.Append("named ");
            sb.Append("\"Daisy\" ");
            sb.Append("& ");
            sb.Append("and ");
            sb.Append("cat ");
            sb.Append("named ");
            sb.Append("\"TinTin L.J.\".");

            Console.WriteLine("*********************************");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
