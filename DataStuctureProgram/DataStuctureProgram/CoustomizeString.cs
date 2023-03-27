using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStuctureProgram
{
    public class CoustomizeString
    {
            public void Customize()
            {
                string line = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.";
                line = line.Replace("<<name>>", "Sayunkta");
                line = line.Replace("<<full name>>", "Sayunkta Mankar");
                line = line.Replace("91-xxxxxxxxxx", "91-9028229984");
                Console.WriteLine(line);

            }
        
    }
}

