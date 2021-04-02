using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortyBoy
{
    class FileIO
    {
        // Creating private variables to hold the information
        private string PATH;
        private string FILE_NAME;


        // Constructor
        public FileIO()
        {
            // Initializing the variables
            PATH = "";
            FILE_NAME = "";
        }

        // Getters and Setters
        public string Path
        {
            get => PATH;
            set
            {
                if (value != null && value != "")
                {
                    PATH = value;
                }
            }
        }

        public string File_Name
        {
            get => FILE_NAME;
            set
            {
                if (value != null && value != "")
                {
                    FILE_NAME = value;
                }
            }
        }

    }
}
