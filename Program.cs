// See https://aka.ms/new-console-template for more information
//#1
string sentence1 = "I enjoy learning";
string sentence2 = "I like coding";
Console.WriteLine(sentence1);
Console.WriteLine(sentence2);

int num1 = 5;
int num2 = 10;
int sum = num1 + num2;
Console.WriteLine(sum);

//#2
string[] names = { "John", "Mary", "Bob" };
Console.WriteLine(names[0]);

//#3
if(5 > 6){
    Console.WriteLine("Hi");
}
else if(6 < 7){
    Console.WriteLine("Hello");
}
else{
    Console.WriteLine("Hey");
}

//#4
bool myBoolean = false;

if(myBoolean){
    Console.WriteLine("It's not true");
}

myBoolean = true;

if(myBoolean){
    Console.WriteLine("It's now true");
}

//#5
for(int i = 0; i < 5; i++){
    Console.WriteLine("Hello");
}

//#6
for(int i = 5; i > 0; i--){
    Console.WriteLine("Hi");
}

//#7
for(int i = 2; i < 6; i++){
    Console.WriteLine("Hey");
}

//#8
int num = 0;
for(int i = 0; i < 10; i++){
    num++;
}
Console.WriteLine(num);

//#9
for(int i = 1; i <= 100; i++){
    Console.WriteLine(i);
}

//#10
string[] student_names = new string[3];
for(int i = 0; i < student_names.Length; i++){
    Console.WriteLine("Enter student name: ");
    student_names[i] = Console.ReadLine();
}

for(int j = 0; j < student_names.Length; j++){
    Console.WriteLine(student_names[j]);
}