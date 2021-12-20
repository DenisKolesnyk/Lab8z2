using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

string f1 = File.ReadAllText("C:\\Text1.txt", Encoding.UTF8);
string f2 = File.ReadAllText("C:\\Text2.txt", Encoding.UTF8);

File.WriteAllText("C:\\h.txt", f1, Encoding.UTF8);

File.WriteAllText("C:\\Text2.txt",
    File.ReadAllText("C:\\h.txt", Encoding.UTF8),
    Encoding.UTF8);
File.WriteAllText("C:\\Text1.txt", f2, Encoding.UTF8);

