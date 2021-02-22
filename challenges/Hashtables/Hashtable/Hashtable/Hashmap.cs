using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class Hashmap
    {
        public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

        public Hashmap(int size)
        {
            Map = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public int Hash(string key)
        {
            int hashValue = 0;

            char[] letters = key.ToCharArray();
            for(int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }

            hashValue = (hashValue * 599) % Map.Length;

            return hashValue;
        }

        public void Add(string key, string value)
        {
            int hashkey = Hash(key);
            if(Map[hashkey] == null)
            {
                Map[hashkey] = new LinkedList<KeyValuePair<string, string>>();
            }

            KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);

            Map[hashkey].AddFirst(entry);
        }

        public string Get(string key)
        {
            int hashkey = Hash(key);
            LinkedList<KeyValuePair<string, string>> keyValues = Map[hashkey];
            if (keyValues != null)
            {
                LinkedListNode<KeyValuePair<string, string>> current = keyValues.First;
                while(current != null)
                {
                    if(current.Value.Key == key) { return current.Value.Value; }
                }
            }
            return null;
        }

        public bool Contains(string key)
        {
            int hashkey = Hash(key);
            bool exists = false;
            LinkedList<KeyValuePair<string, string>> keyValues = Map[hashkey];
            if (keyValues != null)
            {
                LinkedListNode<KeyValuePair<string, string>> current = keyValues.First;
                while(current != null)
                {
                    if(current.Value.Key == key) { exists = true; }
                }
            }
            return exists;
        }
    }
}
