using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungServerOkt.Pages.modul01
{
    public partial class Component1
    {


        protected override void OnInitialized()
        {
            File.ReadAllLines(@"c:\temp\test.txt");
        }
    }
}
