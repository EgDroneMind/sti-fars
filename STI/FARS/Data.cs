using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FARS
{
    internal class Data
    {
        public static void inputAccInfo(string studentNo, string lName, string fName, string mName, string program)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outFile = new StreamWriter(Path.Combine(path, "FARS\\data\\accounts\\" + studentNo + ".txt")))
            {
                outFile.WriteLine("Name: " + fName + " " + mName + " " + lName);
                outFile.WriteLine("Student No. " + studentNo);
                outFile.WriteLine("Program: " + program);
                outFile.WriteLine(fName);
                outFile.WriteLine(0);
            }
        }
        public static bool checkAccount(string studentNo)
        {
            bool final = true;
            List<string> verify = new List<string>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(Path.Combine(path, "FARS\\data\\info.txt")))
            {
                string[] inputFiles = File.ReadAllLines(Path.Combine(path, "FARS\\data\\info.txt"));
                for (int i = 0; i + 1 < inputFiles.Length; i += 2)
                {
                    verify.Add(inputFiles[i]);
                }
                foreach (string entry in verify)
                {
                    if (entry.Equals(studentNo))
                    {
                        final = false;
                        break;
                    }
                }
            }
            return final;
        }
        public static void encodeRequest(string facility, int type, string notes) 
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] contents = File.ReadAllLines(Path.Combine(path, "FARS\\data\\accounts\\" + frmLogin.StudentID + ".txt"));
            int requestNo = Convert.ToInt32(contents[4]);
            requestNo++;
            contents[4] = requestNo.ToString();
            using (StreamWriter outFile = new StreamWriter(Path.Combine(path, "FARS\\data\\accounts\\" + frmLogin.StudentID + ".txt")))
            {
                foreach (string content in contents) 
                {
                    outFile.WriteLine(content);
                }
            }
            using (StreamWriter outFile = new StreamWriter(Path.Combine(path, "FARS\\data\\accounts\\" + frmLogin.StudentID + "_request.txt"), true))
            {
                outFile.WriteLine("REQUEST ");
                outFile.WriteLine(facility);
                outFile.WriteLine(type);
                outFile.WriteLine(notes);
                outFile.WriteLine(requestNo);
            }
        }
    }
}
