using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = {0,12,1,6, 5, 4, 30};

            Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.ReadLine();
        }


        //sorting function
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++) // array boyunca dolaşıyoruz
            {
                int key = array[i];   // current elementimiz (key) array'in bütün elemanlarına gelecek sırayla
                int pre = i - 1;      //pre eleman da ondan bir önceki (karşılaştırma yapılacak olan) eleman
                
                while (pre>= 0 && key < array[pre]) //pre 0 olmadıkça ve key, bir önceki elemandan küçük olduğu sürece
                {
                    array[pre + 1] = array[pre]; //preden bir sonraki elemanla yer değiştiriyor
                    pre = pre - 1;              //pre bir önceki eleman oluyor
                }
                array[pre + 1] = key;  //yeni key sıradaki eleman
            }
        }

    }
}
