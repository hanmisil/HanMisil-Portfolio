# 📊 ZedGraph 설치 및 사용법

**ZedGraph**는 C# WinForms에서 2D 차트를 그릴 수 있는 강력하고 가벼운 오픈소스 그래프 라이브러리입니다.

<br><br>


## 📦 설치 방법

###  1. NuGet 패키지 설치 방법

NuGet을 통해 간단히 설치할 수 있습니다.

```bash
Install-Package ZedGraph
```

<br>

✅ '프로젝트 > NuGet 패키지 관리' 선택합니다. 

![img1 daumcdn](https://github.com/user-attachments/assets/b6287a09-0857-410e-8800-e9f1b0dc00a4)

<br>

✅ '찾아보기 탭 > ZedGragh 검색하여  > ZedGragh 클릭 > 설치' 클릭하여 설치합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/23c427dc-2cae-444f-bf53-fce6ac41d036)

<br>

✅ 설치가 성공적으로 완료되었을 경우 
- '솔루션 탐색기 > 참조 > ZedGragh' 추가
- '도구 상자 > ZedGragh Library > ZedGraghControl' 추가
- ⚠️ 만약 도구상자에 ZedGragh Library가 추가되지 않을 경우 Visual Studio프로그램을 재실행합니다.
  
![img1 daumcdn](https://github.com/user-attachments/assets/b2166394-3c95-401c-93a0-73b8663b04d1)

<br>

✅ 도구 상자에서 ZedGraghControl을 드래그하여 WinForm에 가져다가 사용할 수 있습니다. 

![img1 daumcdn](https://github.com/user-attachments/assets/9239e92f-d958-4a7c-b721-25d26994abf8)

<br>

###  2. 참조 직접 추가

아래의 첨부파일을 원하는 위치 혹은 프로젝트 실행 위치에 다운로드 합니다.

✅ '참조 > 오른쪽 마우스 클릭 > 참조 추가' 클릭 합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/e12c7ad6-d8e6-47ee-9ab8-e6822c84fab9)

<br>

✅ '찾아보기'를 눌러 다운로드 받았던 'ZedGragh.dll'을 찾아 추가해줍니다.

![img1 daumcdn](https://github.com/user-attachments/assets/e25b392f-cf81-4bdf-92e5-c578fa970b3e)

<br>

✅ '도구 상자' 클릭 > 오른쪽 마우스 클릭 > 항목 선택' 를 눌러 항목을 추가합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/c050f685-e6e0-4217-9e32-e7dd25731b0d)
![img1 daumcdn](https://github.com/user-attachments/assets/d21ad3b1-60a7-4416-b146-7507fbd26b41)

<br>

✅ dll 항목을 찾아 추가합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/796e9de6-605c-48c9-b690-7f5b5ef22f17)

<br>

✅ 도구 상자의 항목을 추가하면 도구 상자에 'ZedGraghControl' 항목이 추가되었습니다. 이 도구를 선택하고 원하는 WinForm에 배치하여 사용합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/402a511a-8a03-455a-a901-d7bfb64dad21)

<br><br>

## 🖊️ StreamWriter 주요 옵션

| 생성자 인자                               | 설명                                 |
|-------------------------------------------|--------------------------------------|
| `StreamWriter(path)`                      | 기본 인코딩으로 새 파일 생성 (덮어쓰기) |
| `StreamWriter(path, true)`                | 기존 파일 끝에 내용 추가 (Append 모드) |
| `StreamWriter(path, false)`               | 기존 파일 덮어쓰기                   |
| `StreamWriter(path, append, Encoding.UTF8)` | 인코딩 지정 가능                      |

<br><br>

## 🧪 기본 사용 예제 (WinForms)

```csharp
using ZedGraph;

private void Form1_Load(object sender, EventArgs e)
{
    GraphPane pane = zedGraphControl1.GraphPane;
    pane.Title.Text = "예제 선 그래프";
    pane.XAxis.Title.Text = "X 축";
    pane.YAxis.Title.Text = "Y 축";

    PointPairList list = new PointPairList();
    for (int i = 0; i < 10; i++)
    {
        list.Add(i, Math.Sin(i));
    }

    LineItem myCurve = pane.AddCurve("Sine Wave", list, Color.Blue, SymbolType.Circle);

    zedGraphControl1.AxisChange();
    zedGraphControl1.Invalidate();
}
```

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
using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine("추가된 내용");
}
```

<br><br>

## ⚠️주의사항 ⚠️

- .NET Core에서는 공식 지원이 없으며, .NET Framework 프로젝트에서만 정상적으로 작동합니다.












