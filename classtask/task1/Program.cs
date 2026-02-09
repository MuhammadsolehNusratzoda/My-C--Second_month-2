

// Task 1


// void PrintFromNumberToOne(int number)
// {
//     for ( int i = number; i > 0; i--)
//     {
//         Console.Write(i + " ");
//     }
// }

// int n = Convert.ToInt32(Console.ReadLine());
// PrintFromNumberToOne(n);





// Task 2


// int Sum(int a, int b, int c, int d)
// {
//     return a + b + c + d;
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Sum(a, b, c, d));



// Task 3


// int Reverse (int n)
// {
//     int rev = 0;

//     while (n > 0)
//     {
//         rev = rev * 10 + n % 10;
//         n /= 10;
//     }
//     return rev;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Reverse(n));





// Task 4


// int PrintStars(int n)
// {
//     for ( int i = 1; i <= n; i++ )
//     {
//         Console.Write("*");
//     }
//     return 0;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// PrintStars(n);



// Task 5


// int PrintSquare(int size)
// {
//     for ( int i = 1; i <= size; i++ )
//     {
//         for ( int j = 1; j <= size; j++ )
//         {
//             Console.Write("*");
//         }

//         Console.WriteLine();
//     }
//     return 0;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// PrintSquare(n);





// Task 6


// int PrintStars(int n)
// {
//     for ( int i = 0; i < n; i++ )
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
//     return 0;
// }

// int PrintRectangle(int width, int height)
// {
//     for ( int i = 0; i < height; i++ )
//     {
//         PrintStars(width);
//     }
//     return 0;
// }

// int w = Convert.ToInt32(Console.ReadLine());  

// int h = Convert.ToInt32(Console.ReadLine());   

// PrintRectangle(w, h);




// Task 7


// int PrintStars(int n)
// {
//     for ( int i = 0; i < n; i++ )
//     {
//         Console.Write( "*" );
//     }
//     Console.WriteLine();
//     return 0;
// }

// int PrintTriangle(int size)
// {
//     for ( int i = 1; i <= size; i++ )
//     {
//         PrintStars(i);
//     }
//     return 0;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// PrintTriangle(n);



// Task 8


// int PrintStars(int n)
// {
//     for ( int i = 0; i < n; i++ )
//     {
//         Console.Write( "*" );
//     }
//     Console.WriteLine();
//     return 0;
// }

// int PrintSpaces(int number)
// {
//     for ( int i = 0; i < number; i++ )
//     {
//         Console.Write( " " );
//     }
//     return 0;
// }

// int PrintTriangle(int size)
// {
//     for ( int i = 1; i <= size; i++ )
//     {
//         PrintSpaces(size - i);
//         PrintStars(i);
//     }
//     return 0;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// PrintTriangle(n);









// Task 9


// int PrintStars(int n)
// {
//     for ( int i = 0; i < n; i++ )
//     {
//         Console.Write( "*" );
//     }
//     Console.WriteLine();
//     return 0;
// }

// int PrintSpaces(int number)
// {
//     for ( int i = 0; i < number; i++ )
//     {
//         Console.Write( " " );
//     }
//     return 0;
// }

// int Tree(int height)
// {
//     for ( int i = 1; i <= height; i++ )
//     {
//         PrintSpaces(height - i);
//         PrintStars(i);
//     }
//     return 0;
// }

// int n = Convert.ToInt32(Console.ReadLine());

// Tree(n);