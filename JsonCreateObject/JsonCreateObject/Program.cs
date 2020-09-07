using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonCreateObject
{
   public class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();

            //string JSONresult = JsonConvert.SerializeObject(emp);

            //string path = @"c:\json\employee.json";

            //if (File.Exists(path))
            //{
            //    File.Delete(path);
            //    using (var tw = new StreamWriter(path, true))
            //    {
            //        tw.WriteLine(JSONresult.ToString());
            //        tw.Close();
            //    }

            //}

            //else if (!File.Exists(path))
            //{
            //    using (var tw = new StreamWriter(path, true))
            //    {
            //        tw.WriteLine(JSONresult.ToString());
            //        tw.Close();
            //    }

            //}

            Student stu = new Student();
            string JSONresult = JsonConvert.SerializeObject(stu);
            string path = @"c:\json\student.json";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }

            }

            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }


            }



        }
    }
}
