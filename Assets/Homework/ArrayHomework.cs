using System;
using System.Collections.Generic;
using UnityEngine;

public class ArrayHomework : MonoBehaviour
{
    [SerializeField] float[] testArray;
    [SerializeField] string[] testStringArray;
    [SerializeField] float mean;
    [SerializeField] long[] fibonacci;
    [SerializeField] long fibonacciCount;

    void Start()
    {
        Reverse(testStringArray);
    }

    void OnValidate()
    {
        fibonacci = GetFibonacci(fibonacciCount);

        if (testArray == null)
            return;
        mean = Mean(testArray);
    }

    void OnDrawGizmos()
    {
        MyTarget[] targetsArray = FindObjectsOfType<MyTarget>();
        List<MyTarget> targetsList = new(targetsArray);

        Transform t = Closest(targetsArray);
        if (t != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, t.position);
        }
    }

    float Mean(float[] numbers)
    {
        float summa = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            summa += numbers[i];
        }
        return summa / numbers.Length;
    }

    Transform Closest(Component[] objects)
    {
        float minDistance = float.MaxValue;
        Transform closest = null;
        Vector3 self = transform.position;

        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i] == null) continue;

            float distance = (self - objects[i].transform.position).magnitude;
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = objects[i].transform;
            }
        }

        return closest;
    }

    void Reverse(string[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int j = array.Length - i - 1;
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    string[] Combine(string[] a, string[] b)
    {
        string[] result = new string[a.Length + b.Length];

        for (int aIndex = 0; aIndex < a.Length; aIndex++)
        {
            result[aIndex] = a[aIndex];
        }

        int bIndex = 0;
        for (int resultIndex = a.Length; resultIndex < result.Length; resultIndex++)
        {
            result[resultIndex] = b[bIndex];
            bIndex++;
        }

        return result;
    }

    int Count(string[] strings, string item)
    {
        int count = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i] == item)
                count++;
        }
        return count;
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
