
# 🐍 TCP/IP 소켓 통신 (Server/Client) 사용법 정리
이 문서는 Python의 `socket` 모듈을 사용한 TCP/IP 통신 구조와 실무 적용 예제를 다룹니다.  
비전 시스템, 로봇 연동, 자동화 장비 간 통신 등 제어 시스템 개발에 필수적인 기술입니다.

<br><br>

## 📡 1. 소켓 통신이란?

- 소켓(Socket)은 네트워크 상의 두 장치 간 **데이터 송수신 통로**입니다.
- TCP/IP 기반으로, 한쪽이 서버(Server), 다른 한쪽이 클라이언트(Client)로 동작합니다.
- **장비 ↔ 장비**, **카메라 ↔ PC**, **로봇 ↔ 제어 프로그램** 등 다양한 구조에 활용됩니다.

<br><br>

## 🔧 2. 기본 구조

### 🖥️ Server

```python
import socket

HOST = '0.0.0.0'      # 모든 IP에서 접속 허용
PORT = 9999

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, PORT))
server.listen(1)
print(f"[Listening] Port {PORT}...")

conn, addr = server.accept()
print(f"[Connected] {addr}")

while True:
    data = conn.recv(1024).decode()
    if not data:
        break
    print(f"[Received] {data}")
    conn.sendall(f"Echo: {data}".encode())

conn.close()
server.close()
```

<br><br>

### 🖥️ Client

```python
import socket

HOST = '127.0.0.1'    # 서버 IP (원격이면 실제 IP)
PORT = 9999

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
client.connect((HOST, PORT))

client.sendall("Hello Server".encode())
data = client.recv(1024).decode()

print(f"[Server Reply] {data}")
client.close()
```

<br><br>

## ⚙️ 4. 실무 적용 예시

| 분야             | 예시 구성                                         |
|------------------|--------------------------------------------------|
| 🤖 로봇 ↔ 비전     | 로봇이 좌표 요청 → 카메라 연산 → 좌표 전송           |
| 📷 장비 제어      | PC → 소켓으로 명령 전송 → 센서/모션 응답 수신         |
| 🔎 검사 자동화    | 장비 → 검사 요청 → 이미지 처리 후 결과 전송          |
| 🔁 양방향 통신    | 상태 요청, 결과 수신, 오류 코드 응답 등의 반복 통신 구조 |

<br>

> 예를 들어, **Python**으로 작성된 비전 프로그램이 **C#**으로 개발된 제어 프로그램과 **TCP/IP 소켓 통신**을 통해  
> `"작업 시작"`, `"NG"`, `"좌표 전송"`, `"다음 단계로 진행"` 등의 신호를 주고받을 수 있습니다.

<br><br>


## 💡 실전 Tips

- 데이터를 송수신할 때는 **문자열(String)** 또는 **JSON 형식**으로 인코딩/디코딩하는 것이 일반적입니다.
- `recv()` 함수는 **최대 바이트 크기 제한**이 있으므로,
  - **패킷 분할 처리** 또는
  - **데이터 종료 문자열 (Delimiter)** 사용을 권장합니다.
- **다중 클라이언트**를 처리하려면 `select`, `threading`, `asyncio` 등 Python 비동기 프레임워크를 사용할 수 있습니다.
- 네트워크 통신은 **끊김, 예외 등 오류 발생 가능성**이 있으므로,
  - **재접속 로직**
  - **타임아웃 처리**
  - **예외 핸들링 구조**를 반드시 구현해야 합니다.

<br><br>

## 📂 파일 구조

```bash/
├── README.md
├── clientSample.py
└── serverSample.py
```

<br><br>
