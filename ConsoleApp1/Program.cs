// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")

//Matrix Questions

int[,,,] my4DArray = new int[2, 3, 5, 4]
{
    {

        {

     { 1,2,3,4},
     { 1, 2, 3, 4},
     { 1, 2, 3, 4},
     { 1, 2, 3, 4},
     { 1, 2, 3, 5}

        },

        {
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3 ,4},
        { 1, 2, 3, 5}


         },

        {
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 5}
        },
    },



     {
        {
            { 1, 2, 3, 4},
            { 1, 2, 3, 4},
            { 1, 2, 3, 4},
            { 1, 2, 3, 4},
            { 1, 2, 3, 5}
        },
        {

        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 5}

        },

        {
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 4},
        { 1, 2, 3, 5}
    },
        },
};


//Matrix

int[,,] Matrix3D =
{
    {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 },


    }
};


Question 1
Console.Write("Output: ");
int[] arr = new int[20];

for (int index = 0; index < arr.Length; index++)
{
    arr[index] = index * 5;
    Console.Write(arr[index] + " ");
}

Question 2

bool arraysEqual = true;

Console.Write("Enter lenght of first array: ");
int length = int.Parse(Console.ReadLine());

int[] arrA = new int[length];

for (int i = 0; i < arrA.Length; i++)
{
    Console.Write("Enter element {0}: ", i);
    arrA[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nEnter lenght of second array: ");

if (length != int.Parse(Console.ReadLine()))

    Console.WriteLine("\nArrays have different lengths.");
else
{
    int[] arrB = new int[length];

    for (int i = 0; i < arrB.Length; i++)
    {
        Console.Write("Enter element {0}: ", i);
        arrB[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i] != arrB[i])
        {
            Console.WriteLine("\nArrays are different.");
            arraysEqual = false;
            break;
        }
    }

    if (arraysEqual) Console.WriteLine("\nArrays are the same.");
}

//      Question 3

bool arrayEqual = true;
char[] array1 = new char[5] { 'a', 'b', 'c', 'd', 'e' };
char[] array2 = new char[5] { 'a', 'b', 'c', 'd', 'e' };

if (array1.Length > array2.Length) Console.WriteLine("Second array is lexicographicaly first.");
else if (array1.Length < array2.Length) Console.WriteLine("First array is lexicographicaly first.");
else
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < array2[i])
        {
            Console.WriteLine("First array is lexicographicaly first.");
            arrayEqual = false;
            break;
        }
        if (array1[i] > array2[i])
        {
            Console.WriteLine("Second array is lexicographicaly first.");
            arrayEqual = false;
            break;
        }
    }

    if (arrayEqual) Console.WriteLine("Arrays are lexicographicaly equal.");
}


//Question 4


int count = 1, tempCount = 1, number = 0;

Console.Write("Enter array length: ");
int lengthofArray = int.Parse(Console.ReadLine());
int[] ArrSequence = new int[lengthofArray];

for (int i = 0; i < ArrSequence.Length; i++)
{
    Console.Write("Enter {0} element: ", i);
    ArrSequence[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < ArrSequence.Length - 1; i++)
{
    if (ArrSequence[i] == ArrSequence[i + 1]) tempCount++;
    else tempCount = 1;

    if (tempCount > count)
    {
        count = tempCount;
        number = ArrSequence[i];
    }
}

for (int i = 0; i < count; i++) Console.Write("{0}, ", number);


//Question 7

int sum = 0;

Console.Write("Enter N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Enter K (K < N): ");


int k = int.Parse(Console.ReadLine());
while (k > N)
{
    Console.Write("Enter K(K < N): ");
    k = int.Parse(Console.ReadLine());
}

int[] arr = new int[N];

for (int i = 0; i < N; i++)
{
    Console.Write("Enter {0} element: ", i);
    arr[i] = int.Parse(Console.ReadLine());
}

Array.Sort(arr, (a, b) => b.CompareTo(a));

for (int i = 0; i < k; i++) sum += arr[i];

Console.WriteLine("\nBiggest sum is {0}", sum);


// Question 11


int summation = 0, start = 0, end = 0;
bool sumFound = false;

Console.Write("Enter S: ");
int s = Int32.Parse(Console.ReadLine());

Console.Write("Enter array length: ");
int length_Array = int.Parse(Console.ReadLine());

int[] ArraysofSum = new int[length_Array];

for (int i = 0; i < length_Array; i++)
{
    Console.Write("Enter {0} element: ", i);
    ArraysofSum[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < length_Array - 1; i++)
{
    summation = ArraysofSum[i];

    for (int j = i + 1; j < length_Array; j++)
    {
        summation += arr[j];
        if (summation == s)
        {
            start = i;
            end = j;
            sumFound = true;
            break;
        }
    }

    if (sumFound) break;
}

if (sumFound) for (int i = start; i <= end; i++) Console.Write("{0},", ArraysofSum[i]);
else Console.WriteLine("No sum found.");


//Question 13


int row = 0, col = 0, sumz = -1000;

Console.Write("Enter N (N>3): ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter M (M>3): ");
int m = int.Parse(Console.ReadLine());

while ((n <= 3) && (m <= 3))
{
    Console.Write("Enter N (N>3): ");
    n = int.Parse(Console.ReadLine());
    Console.Write("Enter M (M>3): ");
    m = int.Parse(Console.ReadLine());
}


int[,] arrz = new int[n, m];

for (int i = 0; i < n; i++)
    for (int j = 0; j < m; j++)
    {
        Console.Write("Arr [{0}][{1}] = ", i, j);
        arrz[i, j] = int.Parse(Console.ReadLine());
    }

for (int tempRow = 0; tempRow < arrz.GetLength(0) - 1; tempRow++)
    for (int tempCol = 0; tempCol < arrz.GetLength(1) - 1; tempCol++)
    {
        int tempSum = arrz[row, col] + arrz[row, col + 1] + arrz[row, col + 2] +
            arrz[row + 1, col] + arrz[row + 1, col + 1] + arrz[row + 1, col + 2] +
            arrz[row + 2, col] + arrz[row + 2, col + 1] + arrz[row + 2, col + 2];

        if (tempSum > sumz)
        {
            row = tempRow;
            col = tempCol;
            sumz = tempSum;
        }
    }

Console.WriteLine("Result");
Console.WriteLine("{0} {1} {2}", arrz[row, col], arrz[row, col + 1], arrz[row, col + 2]);
Console.WriteLine("{0} {1} {2}", arrz[row + 1, col], arrz[row + 1, col + 1], arrz[row + 1, col + 2]);
Console.WriteLine("{0} {1} {2}", arrz[row + 2, col], arrz[row + 2, col + 2], arrz[row + 2, col + 2]);
Console.WriteLine("The maximum sum is {0}.", sum);


//Question 19

int num, i, ctr, stno, enno;

Console.Write("\n\n");
Console.Write("Find the prime numbers within a range of numbers:\n");
Console.Write("---------------------------------------------------");
Console.Write("\n\n");

Console.Write("Input starting number of range: ");
stno = Convert.ToInt32(Console.ReadLine());
Console.Write("Input ending number of range : ");
enno = Convert.ToInt32(Console.ReadLine());
Console.Write("The prime numbers between {0} and {1} are : \n", stno, enno);

for (num = stno; num <= enno; num++)
{
    ctr = 0;

    for (i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            ctr++;
            break;
        }
    }

    if (ctr == 0 && num != 1)
        Console.Write("{0} ", num);
}
Console.Write("\n");
