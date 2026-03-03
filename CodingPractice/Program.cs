using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
Console.WriteLine("## 1. object 타입의 기본 개념");
object obj1 = 42;
object obj2 = 3.14;
object obj3 = "Hello";
object obj4 = true;
Console.WriteLine(obj1);
Console.WriteLine(obj2);
Console.WriteLine(obj3);
Console.WriteLine(obj4);

Console.WriteLine();

Console.WriteLine("## 2. object 타입의 활용");
Stack stack = new Stack();

// 문자열 저장
stack.Push("sausage");
string s = (string)stack.Pop();
Console.WriteLine(s);

// 정수 저장
stack.Push(3);
int three = (int)stack.Pop();
Console.WriteLine(three);


Console.WriteLine();

Console.WriteLine("### 3-1. 박싱");

int num = 1234;
object o = num;
Console.WriteLine(o);

Console.WriteLine();

Console.WriteLine("### 3-2. 언박싱");

object o1 = 1234;
int i1 = (int)o1;
Console.WriteLine(i1);

Console.WriteLine();
Console.WriteLine("### 4-1. 값 타입을 object에 할당");
int i2 = 42;
object boxed = i2;
Console.WriteLine(boxed);

Console.WriteLine();
Console.WriteLine("### 4-2. 값 타입을 인터페이스 타입에 할당");
Point p = new Point { X = 10, Y = 20 };
IDisplayable d = p;
Console.WriteLine(d.GetType().Name);

Console.WriteLine();
Console.WriteLine("## 5. 박싱의 특징");

int i3 = 3;
object o3 = i3;
o3 = 5;
Console.WriteLine($"원본:{o3}"); // 5
Console.WriteLine($"박싱된 값: {i3}"); // 3

Console.WriteLine();
Console.WriteLine("## 6. 언박싱 시 주의사항");

object boxing = 42;
int i4 = (int)boxing;
Console.WriteLine($"언박싱 성공: {i4}");

try
{
    long l = (long)boxing; // 잘못된 타입으로 언박싱 시도
}
catch(InvalidCastException)
{
    Console.WriteLine("잘못된 타입으로 언박싱 시도");
}
int temp = (int)boxing; 
long crt = temp;
Console.WriteLine($"올바른 변환:{crt}");

Console.WriteLine();
Console.WriteLine("### 7-1. 박싱/언박싱 오버헤드 비교");
int sum = 0;
int sum0 = 0;
for (int i = 0; i < 1000; i++)
{
    object box = i; // 박싱
    sum = sum + (int)box; // 언박싱
}
Console.WriteLine($"박싱 사용: {sum}");
for (int j = 0; j < 1000; j++)
{
    sum0 = sum0 + j; // 박싱 없이 직접 연산
}
Console.WriteLine($"직접 처리: {sum0}");

Console.WriteLine();
Console.WriteLine("### 7-2. 제네릭으로 박싱 피하기");
GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(42);       // 박싱 없음
int value = intStack.Pop();  // 언박싱 없음
Console.WriteLine(value);

Console.WriteLine();
Console.WriteLine("### 8-1. GetType() 메서드");

int nums = 1234;
string s1 = "안녕하세요";
char c1 = 'A';
double d1 = 3.14;
object object1 = new object();

Console.WriteLine(nums.GetType());
Console.WriteLine(s1.GetType());
Console.WriteLine(c1.GetType());
Console.WriteLine(d1.GetType());
Console.WriteLine(object1.GetType());

Console.WriteLine();
Console.WriteLine("### 8-2. typeof 연산자");

Console.WriteLine(typeof(int));
Console.WriteLine(typeof(string));
Console.WriteLine(typeof(double));

Console.WriteLine();
Console.WriteLine("### 8-3. GetType()과 typeof() 비교");
Point0 point0 = new Point0 { x = 10, y = 20};

Console.WriteLine(point0.GetType().Name);
Console.WriteLine(typeof(Point0).Name);
Console.WriteLine(point0.GetType() == typeof(Point0));
Console.WriteLine(point0.x.GetType().Name);
Console.WriteLine(point0.y.GetType().Name);

Console.WriteLine();
Console.WriteLine("### 9-1. 기본 동작");


int i9 = 42;
double d9 = 3.14;
bool flag = true;

Console.WriteLine(i9.ToString());
Console.WriteLine(d9.ToString());
Console.WriteLine(flag.ToString());

Console.WriteLine();
Console.WriteLine("### 9-2. ToString() 재정의하기");
Panda p1 = new Panda { Name = "Petey" };
Console.WriteLine(p1);
Console.WriteLine(p1.ToString());

Console.WriteLine();
Console.WriteLine("### 9-3. 더 상세한 ToString() 구현");
Player player = new Player { Name = "Hero", Level = 10, Health = 100 };
Console.WriteLine(player);


Console.WriteLine();
Console.WriteLine("## 10. object 클래스의 멤버들");

string str1 = "Hello";
string str2 = "Hello";
string str3 = str1;

Console.WriteLine(str1.Equals(str2));
Console.WriteLine(ReferenceEquals(str1,str2));
Console.WriteLine(ReferenceEquals(str1,str3));
Console.WriteLine();

object objA = new object();
object objB = new object();
object objC = objA;
Console.WriteLine(objA.Equals(objB));
Console.WriteLine(ReferenceEquals(objA, objB));
Console.WriteLine(ReferenceEquals(objA, objC));


