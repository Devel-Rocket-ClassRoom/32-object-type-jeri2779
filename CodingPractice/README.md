# 코딩 연습 - object 타입

교안의 예제 코드를 직접 따라 작성하고 실행하는 프로젝트입니다.

> 각 과제의 코드를 `Program.cs`에 작성하세요.
> 이전 과제의 코드가 남아있으면 클래스 이름이 겹쳐서 오류가 발생할 수 있습니다. 이전 과제의 코드를 지우거나 주석 처리한 후 다음 과제를 진행하세요.

---

## 1. object 타입의 기본 개념

`object` 변수에 정수, 실수, 문자열, 
bool 값을 각각 저장하고 
`Console.WriteLine()`으로 출력하세요. 
`object` 타입은 어떤 타입의 값이든 저장할 수 있습니다.

**실행 결과**

```
42
3.14
Hello
True
```

---

## 2. object 타입의 활용

`object[]` 배열을 사용하는 `Stack` 클래스를 구현하세요. `Push(object obj)` 메서드로 값을 추가하고, `Pop()` 메서드로 값을 꺼냅니다. 문자열과 정수를 저장한 후 꺼내어 원래 타입으로 캐스팅하여 출력하세요.

**실행 결과**

```
sausage
3
```

---

## 3. 박싱과 언박싱

### 3-1. 박싱

정수형 변수 `i`에 1234를 저장하고, 
`object` 변수 `o`에 할당하여 
박싱을 수행하세요. 박싱된 값을 출력합니다.

**실행 결과**

```
1234
```

### 3-2. 언박싱

`object` 변수에 1234를 저장하고, 
`(int)`로 명시적 캐스팅하여 정수형 변수로 
언박싱하세요. 언박싱된 값을 출력합니다.

**실행 결과**

```
1234
```

---

## 4. 박싱이 일어나는 상황들

### 4-1. 값 타입을 object에 할당

정수 42를 `object` 변수에 할당하여 박
싱이 발생하는 상황을 만들고 출력하세요.

**실행 결과**

```
42
```

### 4-2. 값 타입을 인터페이스 타입에 할당

`IDisplayable` 인터페이스를 선언하고, 
`Point` 구조체가 이를 구현하도록 하세요. 
`Point` 인스턴스를 
`IDisplayable` 변수에 할당하면 박싱이 발생합니다. 
`GetType().Name`으로 타입 이름을 출력하세요.

**실행 결과**

```
Point
```

---

## 5. 박싱의 특징

정수 3을 `object` 변수에 박싱한 후, 
원본 값을 5로 변경하세요. 
원본과 박싱된 값을 각각 출력하여 
박싱된 값이 원본의 복사본임을 확인합니다.

**실행 결과**

```
원본: 5
박싱된 값: 3
```

---

## 6. 언박싱 시 주의사항

정수 42를 박싱한 후, 
올바른 타입(`int`)으로 언박싱하세요. 
`try-catch`를 사용하여 
잘못된 타입(`long`)으로 언박싱을 시도했을 때 발생하는
예외를 처리하세요. 
올바른 변환 방법(먼저 `int`로 언박싱 후 
`long`으로 변환)도 보여주세요.

**실행 결과**

```
언박싱 성공: 42
잘못된 타입으로 언박싱 시도
올바른 변환: 42
```

---

## 7. 박싱과 성능

### 7-1. 박싱/언박싱 오버헤드 비교

반복문에서 박싱/언박싱을 사용하는 경우와 직접 처리하는 경우를 비교하세요. 
0부터 999까지의 합을 두 가지 방법으로 계산하여 
결과가 동일함을 확인합니다.

**실행 결과**

```
박싱 사용: 499500
직접 처리: 499500
```

### 7-2. 제네릭으로 박싱 피하기

`GenericStack<T>` 클래스를 구현하여 박싱 없이 값 타입을 저장하세요. 정수 42를 저장하고 꺼내어 출력합니다.

**실행 결과**

```
42
```

---

## 8. GetType 메서드와 typeof 연산자

### 8-1. GetType() 메서드

`int`, `string`, 
`char`, `double`, 
`object` 타입의 변수를 각각 생성하고 
`GetType()` 메서드를 호출하여 런타임 타입 정보를 
출력하세요.

**실행 결과**

```
System.Int32
System.String
System.Char
System.Double
System.Object
```

### 8-2. typeof 연산자

`typeof()` 연산자를 사용하여 
`int`, `string`, `double` 
타입의 Type 정보를 컴파일 타임에 가져와 출력하세요.

**실행 결과**

```
System.Int32
System.String
System.Double
```

### 8-3. GetType()과 typeof() 비교

`Point` 클래스에 `X`, `Y` 필드를 정의하고 
인스턴스를 생성하세요. 
`GetType().Name`, 
`typeof(Point).Name`, 
`GetType() == typeof(Point)` 비교, 
필드의 타입 정보를 출력합니다.

**실행 결과**

```
Point
Point
True
Int32
System.Int32
```

---

## 9. ToString 메서드

### 9-1. 기본 동작

`int`, `double`, `bool` 변수를 각각 생성하고
`ToString()` 메서드를 호출하여 문자열 표현을 
출력하세요.

**실행 결과**

```
42
3.14
True
```

### 9-2. ToString() 재정의하기

`Panda` 클래스에 `Name` 필드를 정의하고, 
`ToString()` 메서드를 재정의하여 
이름을 반환하도록 구현하세요. 
`Console.WriteLine()`에 인스턴스를 직접 전달하면 
`ToString()`이 자동으로 호출됨을 확인합니다.

**실행 결과**

```
Petey
Petey
```

### 9-3. 더 상세한 ToString() 구현

`Player` 클래스에 
`Name`, `Level`, 
`Health` 필드를 정의하고, 
`ToString()`을 재정의하여 
`"Player 
{ Name = ..., Level = ..., Health = ... }"` 
형식으로 반환하세요.

**실행 결과**

```
Player { Name = Hero, Level = 10, Health = 100 }
```

---

## 10. object 클래스의 멤버들

`string` 변수 두 개에 같은 값 
`"Hello"`를 저장하고, `Equals()`와 
`ReferenceEquals()`의 차이를 확인하세요. 
`object` 인스턴스 두 개도 생성하여 비교합니다.

**실행 결과**

```
s1.Equals(s2): True
ReferenceEquals(s1, s2): True
ReferenceEquals(s1, s3): True
obj1.Equals(obj2): False
ReferenceEquals(obj1, obj2): False
ReferenceEquals(obj1, obj3): True
```
