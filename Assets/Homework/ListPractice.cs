using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{
    void Start()
    {
        List<string> myList = new();

        myList.Add("AA");
        myList.Add("BB");
        myList.Add("CC");  // {"AA", "BB", "CC"}

        myList.Insert(0, "XX");   //  {"XX", "AA", "BB", "CC"}
        myList.Insert(2, "YY");   //  {"XX", "AA", "YY", "BB", "CC"}

        bool foundXX = myList.Remove("XX");  // {"AA", "YY", "BB", "CC"}  // true
        bool foundZZ = myList.Remove("ZZ");  // {"AA", "YY", "BB", "CC"}  // false

        myList.RemoveAt(2); // {"AA", "YY", "CC"}

        int index = myList.IndexOf("YY"); // 1
        bool contaisZZ = myList.Contains("ZZ"); // false

        myList.Sort();    // {"AA", "CC", "YY"}   (ABC sorrend)
        myList.Reverse();

    }

    float Mean(List<float> numbers)
    {
        float summa = 0;

        foreach (float current in numbers)
        {
            if (current < 0)
                break;

            summa += current;
        }

        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    float current = numbers[i];
        //    summa += current;
        //}

        return summa / numbers.Count;
    }

    long[] GetFibonacci(long length)
    {
        long[] numbers = new long[length];

        if (length >= 1)
            numbers[0] = 0;

        if (length >= 2)
            numbers[1] = 1;

        for (int i = 2; i < length; i++)
        {
            numbers[i] = numbers[i - 1] + numbers[i - 2];
        }

        return numbers;
    }

}

