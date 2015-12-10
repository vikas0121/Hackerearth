//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Code
//{
//    class ListingNames
//    {
//        public static void Main(String[] args)
//        {
//            int T = int.Parse(Console.ReadLine());
//            List<string> list = new List<string>();
            //while (T-- > 0)
//            {
//                string name = Console.ReadLine();
//                list.Add(name);
//            }
//            List<string> newList = list.Distinct().ToList();
            
//            foreach (var item in newList)
//            {
//                int count = 0;
//                foreach (var i in list)
//                {
//                    if (i == item)
//                        count += 1;
//                }
//                Console.Write(item);
//                Console.Write(count);
//                Console.WriteLine(" ");
//                Console.WriteLine();
//            }
//        }
//    }
//}
