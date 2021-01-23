using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keyItems;
        TValue[] valueItems;
        Key[] TempKeys = new Key[0];
        Value[] TempsValues = new Value[0];

        public MyDictionary()
        {
            Keys = new Key[0];
            Values = new Value[0];

        }

        public void Add(Key key, Value value)
        {
            TempKeys = Keys;
            TempValues = Value;
            Keys = new Key[Keys.Length + 1];
            Values = new Value[Values.Length + 1];
            for (int i = 0; i < TempKeys.Length; i++)
            {
                Keys[i] = TempKeys[i];
                Values = TempsValues[i];

            }
            Keys[Keys.Length - 1] = key;
            Values[TempsValues.Length - 1] = value;

        }
    }
    public void Read()
        for (int i=0; i< Keys.Length; i++)
        {
        Console.Writeline("Student = " + Keys[i] + ", Number = " + Values[i]);
}
