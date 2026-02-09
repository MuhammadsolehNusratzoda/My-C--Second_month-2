





// Task 1


// int EvenCount(int n)
// {
//     int cnt = 0;

//     for ( int i = n; i > 0; i /= 10 )
//     {
//         if ( i % 2 == 0 )
//         {
//             cnt++;
//         }
//     }

//     return cnt;

// }

// int OddCount(int n)
// {
//     int cnt = 0;

//     for ( int i = n; i > 0; i/= 10 )
//     {
//         if ( i % 2 != 0 )
//         {
//             cnt++;
//         }
//     }

//     return cnt;

// }

// int DigitCount(int n)
// {
//     int cnt = 0;

//     for ( int i = n; i > 0; i/= 10 )
//     {
//         cnt++;
//     }
//     return cnt;
// }

// int SumDigit(int n)
// {
//     int sum = 0;

//     for (int i = n; i > 0; i/= 10 )
//     {
//         sum += i % 10;
//     }

//     return sum;

// }

// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(EvenCount(n));
// Console.WriteLine(OddCount(n));
// Console.WriteLine(DigitCount(n));
// Console.WriteLine(SumDigit(n));





// Task 2


// int Add (int a, int b)
// {
//     return a + b;
// }

// int Subtract (int a, int b)
// {
//     return a - b;
// }

// int Multiply (int a, int b)
// {
//     return a* b;
// }

// int Division (int a, int b)
// {
//     return a / b;
// }

// int a = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Add(a,b));

// Console.WriteLine(Subtract(a,b));

// Console.WriteLine(Multiply(a,b));

// Console.WriteLine(Division(a,b));






// Task 3


// int MaxDigit (int n)
// {
//     int max = int.MinValue;

//     for( int i = n; i > 0; i /= 10 )
//     {
//         if ( i % 10 > max )
//         {
//             max = i % 10;
//         }
//     }
//     return max;
// }

// int MinDigit (int n)
// {

//     int min = int.MaxValue;
    
//     for(int i = n; i > 0; i /= 10 )
//     {
//         if ( i % 10 < min )
//         {
//             min = i % 10;
//         }
//     }

//     return min;
// }

// int SumOfMinAndMax(int n)
// {
//     return MaxDigit(n) + MinDigit(n);
// }

// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(SumOfMinAndMax(n));










// Task 4


// double Poww(int x, int y)
// {
//     return Math.Pow(x,y);
// }

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Poww(x,y));







// Task 5


// void Swap(ref int a, ref int b)
// {
//     Console.WriteLine(a);

//     Console.WriteLine(b);

//     int c = a;

//     a = b;

//     b = c;

// }


// int a = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(Console.ReadLine());

// Swap(ref a, ref b);

// Console.WriteLine(a);

// Console.WriteLine(b);







// Task 6


// int Divisors(int x)
// {
//     for ( int i = 1; i <= x; i++ )
//     {
//         if ( x % i == 0 )
//         {
//             Console.WriteLine( $"{i} " );
//         }
//     }
//     return 0;
// }

// int x = Convert.ToInt32(Console.ReadLine());

// Divisors(x);









// Task 7 












// Task 8


// int MinNumber(int a, int b, int c, int d)
// {
//     if( a < b && a < c && a < d )
//     {
//         return a;
//     }
//     else if( b < a && b < c && a < d )
//     {
//         return b;
//     }
//     else if( c < a && a < b && a < d )
//     {
//         return c;
//     }
//     else
//     {
//         return d;
//     }
// }


// int a = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(Console.ReadLine());

// int c= Convert.ToInt32(Console.ReadLine());

// int d = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(MinNumber(a,b,c,d));







// Task 9


// int Min(int val1, int val2)
// {
//     if ( val1 < val2 )
//     {
//         Console.Write("Min is = ");
//         return val1;
//     }
//     else
//     {
//         Console.Write("Min is = ");
//         return val2;  
//     }
// }

// int val1 = Convert.ToInt32(Console.ReadLine());

// int val2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Min(val1,val2))








// Task 10


// int Max(int val1, int val2)
// {
//     if ( val1 > val2 )
//     {
//         Console.Write("Max is = ");
//         return val1;
//     }
//     else
//     {
//         Console.Write("Max is = ");
//         return val2;  
//     }
// }

// int val1 = Convert.ToInt32(Console.ReadLine());

// int val2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Max(val1,val2));
