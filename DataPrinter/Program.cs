using System;

// README.md를 읽고 코드를 작성하세요.
/*
 * # 데이터 출력기

다양한 타입의 데이터를 `object[]` 배열에 저장하고, 각 데이터의 타입에 따라 다른 형식으로 출력하는 프로그램을 작성하세요.

**요구사항:**

1. `PrintData(object data)` 메서드를 구현하세요:
   - `GetType().Name`으로 타입명을 확인함
   - 타입에 따라 다른 형식으로 출력함:
     - `Int32`: `정수: {값}`
     - `Double`: `실수: {값:F2}`
     - `String`: `문자열: "{값}" (길이: {길이})`
     - `Boolean`: `논리값: {값} → {참이면 '참', 거짓이면 '거짓'}`
     - 기타: `알 수 없는 타입: {타입명} - {값}`

2. `PrintAll(object[] data)` 메서드를 구현하세요:
   - 배열의 모든 요소에 대해 `PrintData`를 호출함

3. 테스트 데이터로 실행하세요:
   - `object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };`

4. 타입별 개수 통계를 출력하세요:
   - 정수, 실수, 문자열, 논리값 각각 몇 개인지 출력함

## 예상 실행 결과

```
=== 데이터 출력기 ===

[전체 데이터 출력]
정수: 42
실수: 3.14
문자열: "Hello" (길이: 5)
논리값: True → 참
정수: 100
문자열: "World" (길이: 5)
논리값: False → 거짓
실수: 2.72

[타입별 통계]
정수: 2개
실수: 2개
문자열: 2개
논리값: 2개
 */

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
