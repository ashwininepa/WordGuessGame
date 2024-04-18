Hello, I am learning C# as add-on. I have worked with Python, R, Shiny, PowerBI, JSON, partly SQL, TeamCity, some parts of GCP.

For this exercise, I am referring to a course from Coursera named "Introduction to Programming With C#: Build A Word Guessing Game" and 
link to the course is https://www.coursera.org/projects/introduction-to-programming-with-c-sharp-build-a-word-guessing-game.

The course takes you through the basics needed for C# and starts with Hello World exercise as in other programming languages. 
I practised those exercises on cloud console and then also wanted to have them stores in my repo for reference. 

I want to keep those exercises in ReadMe (references can be found in commits too) as it will be handy for a beginner like me as 
I am going to edit the Program.cs for the main exercise of this course

1. *Strings and numbers*

```c#
    string sentence1 = "I enjoy learning";

    string sentence2 = "I like coding";

    Console.WriteLine(sentence1);

    Console.WriteLine(sentence2);

    int num1 = 5;

    int num2 = 10;

    int sum = num1 + num2;

    Console.WriteLine(sum);
```


2. *Using variables*

   ```c#
    string[] names = { "John", "Mary", "Bob" };

    Console.WriteLine(names[0]);
   ```


3. if-else condition

```c#
    if(5 > 6)
    {
        Console.WriteLine("Hi");
    }

    else if(6 < 7)
    {
        Console.WriteLine("Hello");
    }
    else
    {
        Console.WriteLine("Hey");
    }
```


4. *Using bool and if-condition (one can also go for if-else)*

```c#
    bool myBoolean = false;
    if(myBoolean){
        Console.WriteLine("It's not true");
    }

    myBoolean = true;
    if(myBoolean){
        Console.WriteLine("It's now true");    
    }
```


5. *A. For-loop*

```c#
    for(int i = 0; i < 5; i++){
        Console.WriteLine("Hello");       
    }
```

5. *B. For-loop*

```c#
    for(int i = 5; i > 0; i--){
        Console.WriteLine("Hi");      
    }
```

5. *C. For-loop*

```c#
    for(int i = 2; i < 6; i++){
        Console.WriteLine("Hey");       
    }
```

5. *D. For-loop*

```c#
    int num = 0;
    for(int i = 0; i < 10; i++){
        num++;
    }
    Console.WriteLine(num);
```

5. *E. For-loop*

```c#
    for(int i = 1; i <= 100; i++){
        Console.WriteLine(i);       
    }
```

6. *Using strings and For-loop together*

```c#
    string[] student_names = new string[3];

    for(int i = 0; i < student_names.Length; i++){
        Console.WriteLine("Enter student name: ");
        student_names[i] = Console.ReadLine();
    }

    for(int j = 0; j < student_names.Length; j++){
        Console.WriteLine(student_names[j]);        
    }
```
