using System.Linq;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using Revision;
using System.IO.Pipelines;



class Program
{
    static void Main()
    {



        LinqLearn ll = new LinqLearn();
        var squareResult = ll.SquaresOfOddNumbers([1, 2, 3, 4, 5, 6, 7, 8, 9]);
        System.Console.WriteLine();
        System.Console.WriteLine("Squares of odd are");
        foreach (int i in squareResult)
        {
            System.Console.Write(i+" ");
        }
        var morethan3 = ll.StringsWithMoreThan3Char(["sky", "blue", "sun", "cloud", "hi" ]);
        System.Console.WriteLine();
        System.Console.WriteLine("Strings with more than 3 chars are:");
        foreach (string s in morethan3)
        {
            System.Console.Write(s+", ");
        }
        var student = new GenericRepository<Student>();
        student.AddElement(new Student { Id = 1, Name = "Soumyadeep", CourseName = "Math" });
        student.AddElement(new Student { Id = 2, Name = "John", CourseName = "Science" });
        student.AddElement(new Student { Id = 3, Name = "Lisa", CourseName = "Math" });
        student.AddElement(new Student { Id = 4, Name = "Mira", CourseName = "History" });
        student.AddElement(new Student { Id = 5, Name = "Sam", CourseName = "History" });
        student.AddElement(new Student { Id = 6, Name = "Rahul", CourseName = "Science" });
        student.AddElement(new Student { Id = 7, Name = "Priya", CourseName = "Math" });
        List<(string, string)> studTuple = new List<(string, string)>();
        var allStudents = student.GetAll();
        foreach (var stud in allStudents)
        {
            studTuple.Add((stud.Name, stud.CourseName));
        }
        Dictionaries dict = new Dictionaries();
        var groupByCourse = dict.GroupByKey(studTuple);
        foreach (var kvp in groupByCourse)
        {
            Console.WriteLine($"{kvp.Key} -> [ {string.Join(", ", kvp.Value)} ]");
        }

        StacksLearn st = new StacksLearn();
        st.BasicStackOperations();
        st.ReverseAstring("hello");
        st.CheckBalancedParenthesis("({[]})");
        st.ReverseWordsSentence("Hello World from GPT");
        st.RemoveAdjacentDuplicates("abbaca");
        st.NextGreaterElement([4,5,2,10,8]);

        QueueLearn qu = new QueueLearn();
        qu.BasicQueueOperations();
        // foreach (var x in studTuple)
        // {
        //     System.Console.WriteLine($"{x.Item2}, {x.Item1}");
        // }

        // IntPrinter objInt = new IntPrinter();
        // objInt.dataInt = 10;
        // StringPrinter objString = new StringPrinter();
        // objString.dataStr = "Hello";
        // GeenricsLearn<int> obj1 = new GeenricsLearn<int>();
        // GeenricsLearn<string> obj2 = new GeenricsLearn<string>();
        // GeenricsLearn<List<int>> obj3 = new GeenricsLearn<List<int>>();
        // obj1.dataT = 10;
        // System.Console.WriteLine(obj1.PrintData());

        // obj2.dataT = "string";
        // System.Console.WriteLine(obj2.PrintData());
        // obj3.dataT = new List<int> { 10, 20, 30 };
        // System.Console.WriteLine("Data is:");
        // foreach (var item in obj3.PrintData())
        // {
        //     System.Console.Write(item + " ");
        // }
        // Utilities util = new Utilities();
        // util.Display<int>(100);
        // util.Display<string>("string hello");

        // var userRepo = new UserRepository();
        // userRepo.Add(new User { Id = 1, Name = "Soumyadeep" });
        // userRepo.Add(new User { Id = 2, Name = "John" });
        // var user = userRepo.Get(1);
        // System.Console.WriteLine($"User Found: {user.Name}");

        // var empRepo = new EmployeeRepository();
        // empRepo.Add(new Employee { Id = 1, Name = "Soumyadeep", Department = "IT", Salary = 50000 });
        // empRepo.Add(new Employee { Id = 2, Name = "Sam", Department = "HR", Salary = 100000 });
        // empRepo.Add(new Employee { Id = 3, Name = "Madhu", Department = "Admin", Salary = 500000 });
        // empRepo.Add(new Employee { Id = 4, Name = "John", Department = "HR", Salary = 20000 });

        // var emp = empRepo.GetAllEmployees();
        // System.Console.WriteLine("All Employees are: ");
        // foreach (var e in emp)
        // {
        //     System.Console.WriteLine($"ID -> {e.Id}, Name -> {e.Name}, Department -> {e.Department}, Salary -> {e.Salary}");
        // }
        // var searchEmp = empRepo.SearchEmployee(e => e.Salary > 25000);
        // System.Console.WriteLine("All Employees with Salary > 25000 are:");
        // foreach (var x in searchEmp)
        // {
        //     System.Console.WriteLine($"Name -> {x.Name}, Salary -> {x.Salary}");
        // }
        // var empToRemove = empRepo.SearchEmployee(e => e.Name == "Soumyadeep" && e.Department == "IT").FirstOrDefault();
        // if (empToRemove != null)
        // {
        //     empRepo.RemoveEmployee(empToRemove);
        //     System.Console.WriteLine($"Employee {empToRemove.Name} with ID -> {empToRemove.Id} was successfully removed");
        // }
        // else
        // {
        //     System.Console.WriteLine("No employee found");
        // }
        // System.Console.WriteLine("New List of All employees are: ");
        // var newEmp = empRepo.GetAllEmployees();
        // foreach (var e in newEmp)
        // {
        //     System.Console.WriteLine($"ID -> {e.Id}, Name -> {e.Name}, Department -> {e.Department}, Salary -> {e.Salary}");
        // }
        // var empToUpdate = empRepo.SearchEmployee(e => e.Name == "Sam" && e.Department == "HR").FirstOrDefault();
        // if (empToUpdate != null)
        // {

        //     empToUpdate.Name = "Sam Sundar";
        //     empToUpdate.Salary = 55000;
        //     empRepo.UpdateEmployee(empToUpdate);
        //     System.Console.WriteLine($"Employee {empToUpdate.Name} is updated");
        // }
        // else
        // {
        //     System.Console.WriteLine("Employee not found!");
        // }
        // Console.WriteLine("After Update:");
        // var updatedList = empRepo.GetAllEmployees();
        // foreach (var e in updatedList)
        // {
        //     Console.WriteLine($"ID -> {e.Id}, Name -> {e.Name}, Department -> {e.Department}, Salary -> {e.Salary}");
        // }

        Arrays arrRev = new Arrays();
        var x =arrRev.Generate(5);
        System.Console.WriteLine();
        System.Console.WriteLine("List is ");
        foreach (var y in x)
        {
            System.Console.Write("[ ");
            foreach (int i in y)
            {
                System.Console.Write(i + ", ");
            }
            System.Console.Write(" ]");
        }
        // arrRev.BubbleSort([2, 3, 8, 1, 0, 9, 4, 5]);
            // arrRev.SelectionSort([2, 3, 8, 1, 0, 9, 4, 5]);
            // // arrRev.ReverseArray([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]);
            // // int[] res=arrRev.TwoSumLeetCode([2,5,7,9,11],9);
            // // System.Console.WriteLine();
            // // foreach (int i in res)
            // // {
            // //     System.Console.Write(i+" ");
            // // }
            // arrRev.SecondLargestNumber([7]);
            // var result = arrRev.PairsWithAGivenSum([2, 5, 3, 7, 8, -2], 5);
            // if (result.Count() > 0)
            // {
            //     System.Console.WriteLine("Pairs With Given Sum are:");
            //     foreach (var pair in result)
            //     {
            //         System.Console.WriteLine($"Pair -> {pair.Item1}, {pair.Item2}");
            //     }
            // }
            // else
            //     System.Console.WriteLine("Not found");

            // arrRev.MoveZeroesToEnd([0, 1, 0, 3, 12]);
            // arrRev.OptimizedBubbleSort([5, 4, 3, 7, 3, 0, 8, 9, 10]);
            // arrRev.SelectionSortDescendingOrder([5, 4, 3, 7, 3, 0, 8, 9, 10]);
            // arrRev.SortAndRemoveDuplicates([5, 4, 3, 7, 3, 0, 8, 9, 9, 10]);
            // arrRev.MissingNumber([1, 2, 3, 4, 5, 7]);
            // arrRev.MissingNumberBruteForce([1, 2, 3, 4, 5, 7]);
            // arrRev.PalindromeArray([1, 2, 3, 4, 3, 2, 1]);


            // dict.CharacterCounter("soumyadeep ghosh");
            // dict.FirstNonRepeatingChar("soumyadeep ghosh");
            // dict.GroupAnagrams(["bat", "tab", "tap", "pat", "cat", "act"]);

            // // System.Console.WriteLine(dict.BubbleStringSort("cat"));

            HashSets h = new HashSets();
        // h.RemoveDuplicateCharacters("Soumyadeep Ghosh");
        h.UniqueElementCheck([1,2,3,4,5,6]);

        // StringProblems sp = new StringProblems();
        // sp.ReverseString("hello World");
        // sp.CheckPalindrome("madam");
        // sp.CountVowelsConsonants("Hello World 123!");
        // sp.RemoveDuplicates("Soumyadeep Ghosh");
        // sp.CheckAnagram("madam", "madma");
        // sp.CountOccurences("Soumyadeep Ghosh");
        // sp.SubstringsofString("abc");
    }
}

class Arrays
{

    public void MoveZeroes(int[] nums)
    {
        int posNonZer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[posNonZer] = nums[i];
                posNonZer++;
            }

        }
        for (int i = posNonZer; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }


    public int[] Intersection(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        List<int> res = new List<int>();
        foreach (int i in nums1)
        {
            if (freq.ContainsKey(i))
            {
                freq[i]++;
            }
            else
            {
                freq[i] = 1;
            }
        }
        foreach (int i in nums2)
        {
            if (freq.ContainsKey(i) && freq[i] > 0)
            {
                res.Add(i);
                freq[i]--;
            }
        }

        return res.ToArray();
    }

    public IList<IList<int>> Generate(int numRows)
    {
        List<List<int>> res = new List<List<int>>();
        for (int i = 0; i < numRows; i++)
        {
            List<int> innerRes = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    innerRes.Add(1);
                }
                else if (res != null)
                {
                    innerRes.Add(res.LastOrDefault()[j - 1] + res.LastOrDefault()[j]);
                }
            }
            res.Add(innerRes);

        }
        return res.Select(row => (IList<int>)row).ToList();
    }

    public IList<int> GetRow(int rowIndex)
    {
        List<int> row = new List<int>();
        row.Add(1); // C(k, 0)
        for (int i = 1; i <= rowIndex; i++)
        {
            long prev = row[i - 1];
            long next = prev * (rowIndex - i + 1) / i;
            row.Add((int)next);
        }
        return row.Select(e => e).ToList();
    }

    public int ThirdMax(int[] nums)
    {
        int ThirdMax = int.MinValue;
        return ThirdMax = nums.Distinct().ToArray().Length>2 ? nums.Distinct().OrderByDescending(e => e).Take(3).LastOrDefault():nums.Distinct().OrderByDescending(e=>e).FirstOrDefault();
    }

    public IList<int> FindDisappearedNUmbers(int[] nums)
    {
        List<int> res = new List<int>();
        HashSet<int> numsSet = new HashSet<int>(nums);
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!numsSet.Contains(i))
            {
                res.Add(i);
            }
        }
        return res;
    }



    public void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        System.Console.WriteLine("Sorted array is:");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }

    public void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }

        System.Console.WriteLine("Sorted Array is: ");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }

    public void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
            left++;
            right--;
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Reversed Array is");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }

    public int[] TwoSumLeetCode(int[] arr, int target)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[0];
    }

    public void SecondLargestNumber(int[] arr)

    //Single Pass Logic (Without Sorting):
    // 🔸 Step 1:
    // Initialize two variables:
    // max → to store the largest number so far.
    // secondMax → to store the second largest number so far.
    // ➡️ Set them to the smallest possible integer at the start.
    // 🔸 Step 2:
    // Loop through each element once:
    // ➤ If the current number is greater than max:
    // Update secondMax = max
    // Update max = current number
    // ➤ Else if the current number is between max and secondMax (and not equal to max):
    // Update secondMax = current number
    {
        int secondMax = int.MinValue;
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                secondMax = max;
                max = arr[i];
            }
            else if (arr[i] > secondMax && arr[i] < max)
            {
                secondMax = arr[i];
            }
        }
        if (secondMax == int.MinValue)
        {
            Console.WriteLine("No second largest number found.");
        }
        else
        {
            Console.WriteLine($"Second Largest Number is {secondMax}");
        }
    }

    public List<(int, int)> PairsWithAGivenSum(int[] arr, int sum)
    {
        List<(int, int)> result = new List<(int, int)>();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == sum)
                {
                    result.Add((arr[i], arr[j]));
                }
            }
        }

        return result;
    }

    public void MoveZeroesToEnd(int[] arr)
    {
        int n = arr.Length;
        int pos = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                arr[pos] = arr[i];
                pos++;
            }
        }
        for (int i = pos; i < n; i++)
        {
            arr[i] = 0;
        }
        System.Console.WriteLine("Result is");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }

    public void OptimizedBubbleSort(int[] arr)
    {
        int n = arr.Length;
        // Stopwatch Early if no swaps are done in a full pass
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                System.Console.WriteLine($"stopping after {i + 1} moves");
                break;
            }
        }
        System.Console.WriteLine("Sorted Array is:");
        foreach (int i in arr)
        {
            System.Console.Write(i + " ");
        }
    }

    public void SelectionSortDescendingOrder(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }
            int temp = arr[maxIndex];
            arr[maxIndex] = arr[i];
            arr[i] = temp;
        }
        System.Console.WriteLine("Sorted Array is");
        foreach (int num in arr)
        {
            System.Console.Write(num + " ");
        }
    }

    public void SortAndRemoveDuplicates(int[] arr)
    {
        int n = arr.Length;
        int pos = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        for (int i = 1; i < n; i++)
        {
            if (arr[i] != arr[pos])
            {
                pos++;
                arr[pos] = arr[i];

            }
        }
        System.Console.WriteLine("Sorted Unique Array:");
        for (int i = 0; i <= pos; i++)
        {
            System.Console.Write(arr[i] + " ");
        }
    }

    public void MissingNumber(int[] arr)
    {
        int n = arr.Length;
        int sum = ((n + 2) * (n + 1)) / 2;
        for (int i = 0; i < n; i++)
        {
            sum -= arr[i];
        }
        System.Console.WriteLine($"Missing number is {sum}");
    }

    public void MissingNumberBruteForce(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        //Loop through the array by 1 and check if next element is greater than the current element by 1.
        //If not capture the current element in a variable and add 1 to it to get the result
        int missingNum = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i + 1] - arr[i] != 1)
            {
                missingNum = arr[i] + 1;
                break;
            }
        }
        if (missingNum == 0)
        {
            missingNum = arr[n - 1] + 1;
        }
        System.Console.WriteLine($"Missing Number is {missingNum}");
    }

    public void PalindromeArray(int[] arr)
    {
        bool isPalindrome = true;
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            if (arr[left] != arr[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        if (isPalindrome)
        {
            System.Console.WriteLine("Yes its a Palindrome");
        }
        else
        {
            System.Console.WriteLine("No its not a palindrome");
        }
    }

    public void PairSumExists(int[] arr, int sum)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                if (arr[i] + arr[j] == sum)
                {
                    System.Console.WriteLine("Pair Exists");
                    return;
                }
            }
        }
        System.Console.WriteLine("No pair exist for the given sum");
    }
}



class Dictionaries
{
    public void CharacterCounter(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        Dictionary<char, int> freqCtr = new Dictionary<char, int>();
        foreach (char c in ch)
        {
            if (freqCtr.ContainsKey(c))
            {
                freqCtr[c]++;
            }
            else
            {
                freqCtr[c] = 1;
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Each Occurrence of letters are:");
        foreach (var kvp in freqCtr)
        {
            System.Console.WriteLine($"{kvp.Key} -> {kvp.Value} time(s)");
        }
    }

    public void FirstNonRepeatingChar(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        Dictionary<char, int> freqCtr = new Dictionary<char, int>();
        foreach (char c in ch)
        {
            if (freqCtr.ContainsKey(c))
            {
                freqCtr[c]++;
            }
            else
            {
                freqCtr[c] = 1;
            }
        }

        foreach (char c in ch)
        {
            if (freqCtr[c] == 1)
            {
                System.Console.WriteLine($"First Non Repeating Character is {c} -> {freqCtr[c]} time(S)");
                break;
            }
        }
    }

    public void GroupAnagrams(string[] str)
    {
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
        foreach (string s in str)
        {
            string sorted = BubbleStringSort(s);
            if (myDict.ContainsKey(sorted))
            {
                myDict[sorted].Add(s);
            }
            else
            {
                myDict[sorted] = new List<string> { s };
            }
        }
        System.Console.WriteLine("Grouped Anagrams");
        foreach (var kvp in myDict)
        {
            System.Console.WriteLine($"{kvp.Key} -> {string.Join(", ", kvp.Value)}");
        }
    }

    public string BubbleStringSort(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        int n = ch.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (ch[j] > ch[j + 1])
                {
                    char temp = ch[j];
                    ch[j] = ch[j + 1];
                    ch[j + 1] = temp;
                }
            }
        }
        return string.Join("", ch);
    }

    public void SubArrayWithTargetSum(int[] arr, int tar)
    {
        int n = arr.Length;
        List<int[]> res = new List<int[]>();

        for (int i = 0; i < n - 1; i++)
        {
            int currentSum = 0;
            for (int j = i; j < n; j++)
            {
                currentSum += arr[j];
                if (currentSum == tar)
                {
                    List<int> temp = new List<int>();
                    for (int k = i; k <= j; k++)
                    {
                        temp.Add(arr[k]);
                    }
                    res.Add(temp.ToArray());
                }
            }
        }
    }
    public void IntersectionOfArrays(int[] arr1, int[] arr2)
    {
        HashSet<int> sets = new HashSet<int>(arr1);
        HashSet<int> set2 = new HashSet<int>();
        foreach (int i in arr2)
        {
            if (sets.Contains(i) && !set2.Contains(i))
            {
                set2.Add(i);
            }
        }
        System.Console.WriteLine("Common elements are: ");
        foreach (int i in set2)
        {
            System.Console.Write(i + " ");
        }
    }

    public Dictionary<string, List<string>> GroupByKey(List<(string, string)> stuCourse)
    {
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();

        foreach (var x in stuCourse)
        {
            // List<string> names = new List<string>();
            if (myDict.ContainsKey(x.Item2))
            {
                myDict[x.Item2].Add(x.Item1);
            }
            else
            {
                List<string> names = new List<string>();
                names.Add(x.Item1);
                myDict[x.Item2] = names;
            }
        }
        return myDict;
    }
}

class HashSets
{
    public void RemoveDuplicateCharacters(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        HashSet<char> res = new HashSet<char>();
        StringBuilder sBuilder = new StringBuilder();
        foreach (char c in ch)
        {
            if (!res.Contains(c))
            {
                sBuilder.Append(c);
                res.Add(c);
            }
        }
        System.Console.WriteLine($"New reformed string is {sBuilder}");
    }
    public void UniqueElementCheck(int[] arr)
    {
        bool isUnique = true;
        HashSet<int> set = new HashSet<int>();
        foreach (int i in arr)
        {
            if (!set.Contains(i))
            {
                set.Add(i);
            }
            else
            {
                isUnique = false;
            }
        }
        if (isUnique)
        {
            System.Console.WriteLine("All elements are unique in the array");
        }
        else
        {
            System.Console.WriteLine("Array has some duplicate elements");
        }
    }
}

class StringProblems
{
    public void ReverseString(string str)
    {
        char[] ch = str.ToCharArray();
        int left = 0;
        int right = ch.Length - 1;
        while (left < right)
        {
            char temp = ch[left];
            ch[left] = ch[right];
            ch[right] = temp;
            left++;
            right--;
        }
        System.Console.WriteLine($"Reversed string is {string.Join("", ch)}");
    }

    public void CheckPalindrome(string str)
    {
        bool isPalindrome = true;
        char[] ch = str.ToCharArray();
        int left = 0;
        int right = ch.Length - 1;
        while (left < right)
        {
            if (ch[left] != ch[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }
        if (isPalindrome)
        {
            System.Console.WriteLine($"{str} is a palindrome string");
        }
    }

    public void CountVowelsConsonants(string str)
    {
        int vowelCtr = 0;
        int consCtr = 0;
        char[] ch = str.ToLower().ToCharArray();
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        foreach (char c in ch)
        {
            if (char.IsLetter(c))
            {
                if (vowels.Contains(c))
                {
                    vowelCtr++;
                }
                else
                {
                    consCtr++;
                }
            }
        }

        System.Console.WriteLine($"Number of vowels are {vowelCtr} and consonants are {consCtr}");
    }

    public void RemoveDuplicates(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        // Dictionary<char, int> freqCtr = new Dictionary<char, int>();
        HashSet<char> sets = new HashSet<char>();
        System.Console.WriteLine("String with Unique Characters is");
        foreach (char c in ch)
        {
            if (!sets.Contains(c))
            {
                System.Console.Write(c);
                sets.Add(c);
            }
        }
    }

    public void CheckAnagram(string str1, string str2)
    {
        bool isAnagram = true;
        char[] ch1 = str1.ToCharArray();
        char[] ch2 = str2.ToCharArray();

        Dictionary<char, int> freqCtr = new Dictionary<char, int>();
        if (ch1.Length == ch2.Length)
        {
            foreach (char c in ch1)
            {
                if (freqCtr.ContainsKey(c))
                {
                    freqCtr[c]++;
                }
                else
                {
                    freqCtr[c] = 1;
                }
            }
            foreach (char c in ch2)
            {
                if (freqCtr.ContainsKey(c))
                {
                    freqCtr[c]--;
                }
                else
                {
                    isAnagram = false;
                }
            }
            foreach (var kvp in freqCtr)
            {
                if (kvp.Value != 0)
                {
                    isAnagram = false;
                    break;
                }
            }
        }
        else
            isAnagram = false;
        if (isAnagram)
        {
            System.Console.WriteLine("Strings are anagram");
        }
        else
        {
            System.Console.WriteLine("Not anagram");
        }
    }

    public void CountOccurences(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        Dictionary<char, int> freqCtr = new Dictionary<char, int>();
        foreach (char c in ch)
        {
            if (freqCtr.ContainsKey(c))
            {
                freqCtr[c]++;
            }
            else
            {
                freqCtr[c] = 1;
            }
        }

        System.Console.WriteLine("Occurrences: ");
        foreach (var kvp in freqCtr)
        {
            System.Console.WriteLine($"{kvp.Key} -> {kvp.Value} time(s)");
        }
    }

    public void SubstringsofString(string str)
    {
        char[] ch = str.ToLower().ToCharArray();
        System.Console.WriteLine($"Substrings of the string {str} are as follows: ");
        for (int i = 0; i < ch.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = i; j < ch.Length; j++)
            {
                sb.Append(ch[j]);
                System.Console.WriteLine(sb);
            }
        }
    }
}

class StacksLearn
{
    public void BasicStackOperations()
    {
        Stack<string> stacks = new Stack<string>();
        stacks.Push("Page 1");
        stacks.Push("Page 2");
        stacks.Push("Page 3");
        stacks.Push("Page 4");

        System.Console.WriteLine($"Top of stack -> {stacks.Peek()}");
        System.Console.WriteLine($"Removing from Top -> {stacks.Pop()}");
        System.Console.WriteLine($"New Top -> {stacks.Peek()}");
        System.Console.WriteLine($"New Stack Lenght -> {stacks.Count()}");
    }
    public void ReverseAstring(string str)
    {
        Stack<char> reverse = new Stack<char>(str.ToCharArray());
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            sb.Append(reverse.Pop());
        }
        System.Console.WriteLine($"Reversed string is {sb}");
    }

    public void CheckBalancedParenthesis(string str)
    {
        bool isBalanced = true;
        Dictionary<char, char> bracketPair = new Dictionary<char, char>();
        //str = ({[])}
        bracketPair.Add('(', ')');
        bracketPair.Add('{', '}');
        bracketPair.Add('[', ']');
        char[] ch = str.ToCharArray();
        Stack<char> stChar = new Stack<char>();
        foreach (char c in ch)
        {
            if (bracketPair.ContainsKey(c))
            {
                stChar.Push(c);
            }
            else if (bracketPair.ContainsValue(c))
            {
                if (stChar.Count == 0)
                {
                    isBalanced = false;
                }
                else
                {
                    char lastOpen = stChar.Pop();
                    if (bracketPair[lastOpen] != c)
                    {
                        isBalanced = false;
                        break; // optional: exit early
                    }
                }
            }
        }
        if (stChar.Count != 0)
        {
            if (isBalanced)
            {
                System.Console.WriteLine($"String {str} is a balanced parenthesis");
            }
            else
            {
                System.Console.WriteLine("Unbalanced");
            }
        }
    }

    public void ReverseWordsSentence(string str)
    {
        string[] strArr = str.Split(" ");
        Stack<string> stack = new Stack<string>(strArr);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < strArr.Length; i++)
        {
            sb.Append(stack.Pop());
            sb.Append(" ");
        }
        System.Console.WriteLine("Reversed words in a sentence :");
        System.Console.WriteLine(sb);
    }

    public void RemoveAdjacentDuplicates(string str)
    {
        Stack<char> checkDupe = new Stack<char>();
        char[] ch = str.ToCharArray();
        foreach (char c in ch)
        {
            if (checkDupe.Count > 0 && checkDupe.Peek() == c)
            {
                checkDupe.Pop();
            }
            else
            {
                checkDupe.Push(c);
            }
        }
        System.Console.WriteLine($"Final String is {string.Join("", checkDupe.Reverse().ToArray())}");
    }


    // 📘 Problem Statement:
    // Given an array of integers, for each element, find the next greater element to its right.
    // If no such element exists, return -1.

    // 🔍 Example:
    // Input:  [4, 5, 2, 10, 8]
    // Output: [5,10,10,-1,-1]
    // ➡ For 4 → Next greater is 5
    // ➡ For 5 → Next greater is 10
    // ➡ For 2 → Next greater is 10
    // ➡ For 10 → No greater on right → -1
    // ➡ For 8 → No greater → -1
    public void NextGreaterElement(int[] arr)
    {
        List<int> result = new List<int>();
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            bool found = false;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[i])
                {
                    result.Add(arr[j]);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                result.Add(-1);
            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Output is:");
        foreach (int i in result)
        {
            System.Console.Write(i + " ");
        }
    }

    public void NextGreaterElementUsingStack(int[] arr)
    {
       
        int n = arr.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            Stack<int> nextGreaterElements = new Stack<int>();
            if (nextGreaterElements.Count() > 0 && nextGreaterElements.Peek() <= arr[i])
            {
                nextGreaterElements.Pop();
            }
            else if (nextGreaterElements.Count() == 0)
            {
                nextGreaterElements.Push(-1);
            }
            else if (nextGreaterElements.Count() > 0)
            {
                nextGreaterElements.Push(nextGreaterElements.Peek());
            }
        }

    }
}

class QueueLearn
{
    public void BasicQueueOperations()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Process Page 1");
        queue.Enqueue("Process Page 2");
        queue.Enqueue("Process Page 3");
        queue.Enqueue("Process Page 4");

        System.Console.WriteLine($"The first in the queue is -> {queue.Peek()}");
        System.Console.WriteLine($"Removing the current first in queue is -> {queue.Dequeue()}");
        System.Console.WriteLine($"Next in queue is -> {queue.Peek()}");
        System.Console.WriteLine($"Current Queue Length is {queue.Count()}");
    }
}