# 📄 C#에서 StreamReader & StreamWriter 사용법

`StreamReader`와 `StreamWriter`는 텍스트 파일을 효율적으로 **읽고 쓰는 데 사용되는 기본 클래스**입니다.  
`using` 문을 활용하여 리소스를 안전하게 해제할 수 있으며, 인코딩과 파일 모드도 설정 가능합니다.

<br><br>

## 🧪 기본 예제: 파일 쓰기 → 읽기

```csharp

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Example\sample.txt";

        // 파일 쓰기 (덮어쓰기)
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, world!");
            writer.WriteLine("This is a second line.");
        }

        // 파일 읽기
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

```

<br><br>

## 🖊️ StreamWriter 주요 옵션

| 생성자 인자                               | 설명                                |
|-------------------------------------------|-------------------------------------|
| `StreamWriter(path)`                      | 기본 인코딩으로 새 파일 생성 (덮어쓰기) |
| `StreamWriter(path, true)`                | 기존 파일 끝에 내용 추가 (Append 모드) |
| `StreamWriter(path, false)`               | 기존 파일 덮어쓰기                  |
| `StreamWriter(path, append, Encoding.UTF8)` | 인코딩 지정 가능                     |

<br><br>

## ⚙️ 주요 메서드 요약

| 클래스         | 메서드        | 설명                     |
|----------------|---------------|--------------------------|
| `StreamWriter` | `Write()`     | 문자열 출력 (줄바꿈 없음)   |
|                | `WriteLine()` | 문자열 출력 + 줄바꿈       |
| `StreamReader` | `ReadLine()`  | 한 줄씩 읽기               |
|                | `ReadToEnd()` | 전체 내용 읽기             |
|                | `Peek()`      | 다음 문자 미리 보기         |

<br><br>

## 💡 실전 팁

- `using` 블록을 사용하면 파일 핸들이 자동으로 닫혀 **메모리 누수 방지**에 유리합니다.
- 파일이 존재하지 않을 경우, `StreamWriter`는 자동으로 새 파일을 **생성**합니다.
- **Append 모드**를 사용하면 기존 내용을 보존하면서 뒤에 내용을 추가할 수 있습니다.

```csharp

using (StreamWriter writer = new StreamWriter("sample.txt", true))
{
    writer.WriteLine("추가된 내용입니다.");
}

```

<br><br>

## ⚠️ 주의사항 ⚠️

- 동시에 StreamReader와 StreamWriter를 같은 파일에서 사용할 경우, 파일 잠금 충돌이 발생할 수 있습니다.
반드시 작업 순서를 나누거나 스트림을 분리해서 사용하세요.
- 인코딩이 다른 파일을 다룰 때는 Encoding.GetEncoding()을 사용해 정확하게 지정해야 합니다.
  
<br><br>

