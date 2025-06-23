# 🌐 C# TCP/IP 소켓 통신 예제

C#에서는 `System.Net.Sockets` 네임스페이스를 사용해 TCP 통신을 구현할 수 있습니다.  
아래는 간단한 서버/클라이언트 통신 예제이며, WinForms 또는 Console에서 테스트 가능합니다.

<br><br>

## 🖥️ Server 코드

```csharp
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class TcpServer
{
    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("서버 시작됨... 클라이언트 연결 대기 중");

        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("클라이언트 연결됨");

        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytes = stream.Read(buffer, 0, buffer.Length);
        string data = Encoding.UTF8.GetString(buffer, 0, bytes);
        Console.WriteLine($"수신된 메시지: {data}");

        // 응답 보내기
        string response = "서버 응답: Hello Client!";
        byte[] responseData = Encoding.UTF8.GetBytes(response);
        stream.Write(responseData, 0, responseData.Length);

        stream.Close();
        client.Close();
        server.Stop();
    }
}
```

<br><br>

## 🖥️ Client 코드

```csharp
using System;
using System.Net.Sockets;
using System.Text;

class TcpClientProgram
{
    static void Main()
    {
        TcpClient client = new TcpClient("127.0.0.1", 5000);
        NetworkStream stream = client.GetStream();

        string message = "클라이언트에서 보낸 메시지";
        byte[] data = Encoding.UTF8.GetBytes(message);
        stream.Write(data, 0, data.Length);

        byte[] buffer = new byte[1024];
        int bytes = stream.Read(buffer, 0, buffer.Length);
        string response = Encoding.UTF8.GetString(buffer, 0, bytes);
        Console.WriteLine($"서버 응답: {response}");

        stream.Close();
        client.Close();
    }
}
```

<br><br>

## 🤖 실무 적용 예시

| 분야           | 구성 예시                                                             |
|----------------|------------------------------------------------------------------------|
| 로봇 ↔ 비전    | 로봇이 좌표 요청 → 카메라 연산 → 좌표 전송                             |
| 장비 제어      | PC → 소켓으로 명령 전송 → 센서/모션 응답 수신                           |
| 검사 자동화    | 장비 → 검사 요청 → 이미지 처리 후 결과 전송                            |
| 양방향 통신    | 상태 요청, 결과 수신, 오류 코드 응답 등 반복                           |

<br><br>

## 💡 실전 Tips

- 문자열 또는 **JSON 포맷**으로 송수신 데이터를 처리하는 것이 일반적입니다.
- `recv()`는 **바이트 크기 제한**이 있으므로, **패킷 구분자**나 **데이터 끝 구분자** 사용을 권장합니다.
- 다중 클라이언트 지원을 위해 `Thread`, `async/await`, 또는 `SocketAsyncEventArgs`를 활용할 수 있습니다.
- `try-catch` 구문으로 예외 처리 및 연결 유지 로직을 반드시 구현하세요.

<br><br>

## ⚠️ 주의사항 ⚠️

- 데이터 수신 시 **버퍼 크기**와 **메시지 종료 조건**을 명확히 설정해야 합니다.
- 연결이 끊기는 상황에 대비해 **재연결 로직**을 고려하세요.
- **방화벽**, 포트 충돌 등의 이유로 서버가 외부에서 접근 불가할 수 있으니 환경 설정을 점검해야 합니다.


<br><br><br><br>
