using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1_InterfaceTask
{
    class Cls_PhoneBook 
    {


        
        // Ceate Dictionary Phone 
        Dictionary<int,string> phoneDectionary=new Dictionary<int,string>();

        // Add New Item to Dictionary
       public string this[int key]
        {
            set
            {
                phoneDectionary[key] = value;
            }
            get
            {
                return phoneDectionary[key];
            }
        }
        // Update Existing Item
        public int this[string _value]
        {
           set
            {
                // Updates Phone Book to modify use to list
                foreach (KeyValuePair<int, string> phone in phoneDectionary.ToList())
                {
                    if (phone.Value == _value)
                        phoneDectionary[phone.Key] = value.ToString();

                }

                // Or for loop to modify

            }
            get
            {
                foreach (KeyValuePair<int,string> phone in phoneDectionary)
                {
                    if (phone.Value == _value)
                        return phone.Key;

                }
                return -1;
            }
        }
        // Print All Phone Book
        public void PrintAllDictionaryItem()
        {
            foreach (KeyValuePair<int, string> item in phoneDectionary)
            {
                Console.WriteLine($"Key:{item.Key}, Value: {item.Value}");
            }
        }

        #region MyRegion

        //// Secondly Add Key and Value to Dictionary
        //public void AddPhoneBook(Tkey _tkey, Tvalue _tvalue)
        //{
        //    phoneDectionary.Add(_tkey, _tvalue);
        //}
        //// Search by Key
        //public void SearchPhonebyKey(Tkey _tkey)
        //{
        //    Console.WriteLine($"Search {_tkey} >> Value is : " + phoneDectionary[_tkey]);
        //}
        //// Search by Value
        //public void SearchPhonebyValue(Tvalue _tvalue)
        //{
        //    for (int i = 0; i < phoneDectionary.Count; i++)
        //    {
        //        Tkey key = phoneDectionary.Keys.ElementAt(i);
        //        Tvalue value = phoneDectionary[key];
        //        // if (value == _tvalue) // error 

        //        Console.WriteLine($"Key: {key}, Value: {value}");
        //    }

        //    // To hold key use ContainsKey or to hold value use ContainsValue or Remove use Remove
        //    //foreach (KeyValuePair<Tkey, Tvalue> item in phoneDectionary)
        //    //{
        //    //    if (phoneDectionary.ContainsValue(_tvalue) == true)
        //    //    {
        //    //        Console.WriteLine($"Search {_tvalue} Key is :{item.Key}");
        //    //        break;
        //    //    }
        //    //}

        //}

        //public void PrintAllDictionaryItem()
        //{
        //    foreach (KeyValuePair<Tkey, Tvalue> item in phoneDectionary)
        //    {
        //        Console.WriteLine($"Key:{item.Key}, Value: {item.Value}");
        //    }
        //}

        #endregion




    }
}
