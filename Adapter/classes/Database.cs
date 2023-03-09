using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    static class Database
    {
        static string[,] playerOnDB = new String[,]{
                {"Player1","29.8654","100"},
                {"Player2","36.2132","100"},
                {"Player3","32.0012","100"},
            };
        static public string[,] Get() => playerOnDB;
       
    }
}

