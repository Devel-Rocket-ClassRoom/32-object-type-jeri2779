using System;

 void PrintData(object data)
{
    string typeName = data.GetType().Name;
    switch (typeName)//타입명으로 분기하여 출력 형식 결정
    {
        case "Int32":
            Console.WriteLine($"정수: {data}");
            break;
        case "Double":
            Console.WriteLine($"실수: {((double)data):F2}");
            break;
        case "String":
            string str = (string)data;
            Console.WriteLine($"문자열: \"{str}\" (길이: {str.Length})");
            break;
        case "Boolean":
            bool boolValue = (bool)data;
            Console.WriteLine($"논리값: {boolValue} → {(boolValue ? "참" : "거짓")}");
            break;
        default:
            Console.WriteLine($"알 수 없는 타입: {typeName} - {data}");
            break;
    }
}

Console.WriteLine("=== 데이터 출력기 ===");
Console.WriteLine();

 void PrintAll(object[] data)
{
    Console.WriteLine("[전체 데이터 출력]");
    foreach (var item in data)
    {
        PrintData(item);
    }
}

 
object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };
PrintAll(data);

//4. 타입별 개수 통계를 출력하세요:
//-정수, 실수, 문자열, 논리값 각각 몇 개인지 출력함
Console.WriteLine();
Console.WriteLine("[타입별 통계]");
int intCount = 0, 
    doubleCount = 0, 
    stringCount = 0, 
    boolCount = 0;

foreach (var item in data)
{
       switch (item.GetType().Name)
    {
        case "Int32"://정수
            intCount++;
            break;
        case "Double"://실수
            doubleCount++;
            break;
        case "String"://문자열
            stringCount++;
            break;
        case "Boolean"://논리값:
            boolCount++;
            break;
    }

 
}
Console.WriteLine($"정수: {intCount}개");
Console.WriteLine($"실수: {doubleCount}개");
Console.WriteLine($"문자열: {stringCount}개");
Console.WriteLine($"논리값: {boolCount}개");
