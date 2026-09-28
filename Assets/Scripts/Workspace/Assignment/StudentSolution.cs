using System;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return numbers;

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }

            foreach (int num in numbers)
            {
                Debug.Log(num);
            }

            return numbers; 
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return numbers;

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (int num in numbers)
            {
                Debug.Log(num);
            }

            return numbers; 
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return numbers;

            int n = numbers.Length;
            for (int i = 1; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }

            foreach (int num in numbers)
            {
                Debug.Log(num);
            }

            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return numbers;

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = numbers[maxIndex];
                numbers[maxIndex] = numbers[i];
                numbers[i] = temp;
            }

            foreach (int num in numbers)
            {
                Debug.Log(num);
            }

            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return numbers;

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            foreach (int num in numbers)
            {
                Debug.Log(num);
            }

            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return numbers;

            int n = numbers.Length;
            for (int i = 1; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }

            foreach (int num in numbers)
            {
                Debug.Log(num);
            }

            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) return 0; // ต้อง return ค่า int (ส่ง 0 กลับไปกรณี array ไม่สมบูรณ์)

            
            Array.Sort(numbers);
            Array.Reverse(numbers);

            int max = numbers[0];
            int secondMax = max;

            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < max)
                {
                    secondMax = numbers[i];
                    break;
                }
            }

            return secondMax;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0; 
            
            Array.Sort(numbers);

            int maxStreak = 1;
            int currentStreak = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                
                if (numbers[i] == numbers[i + 1])
                {
                    continue;
                }

                
                if (numbers[i + 1] == numbers[i] + 1)
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1; 
                }

                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                }
            }

            return maxStreak;
        }

        #endregion
    }
}
