
# 🐍 Python 개발 환경 구축 방법 정리(Windows)
이 문서는 Python 프로젝트를 위한 개발 환경을 구축하는 표준적인 방법을 정리한 자료입니다.  
가상환경, 패키지 설치, VSCode 설정, requirements 관리까지 포함됩니다.

<br><br>

## 📦 1. Python 설치

![img1 daumcdn](https://github.com/user-attachments/assets/1b90b847-8ca8-4190-9bf1-cc4e970ce726)

- [공식 다운로드 사이트](https://www.python.org/downloads/)에서 Python 3.12+ 설치
- 설치 시 ✅ 반드시 **"Add Python to PATH"** 체크

<br><br>

⚠️ 특정 Python 버전을 다운로드하고 싶다면 원하는 버전을 찾아 다운로드합니다.

![img1 daumcdn](https://github.com/user-attachments/assets/56161fbb-8af3-4767-a001-9324046e2afa)

<br><br>

⚠️ 사용할 컴퓨터 사양을 확인하여 다운로드합니다.
- 32비트 운영 체제 : Windows x86 executable installer
- 64비트 운영 체제 : Windows x86-64 executable installer

<br>

![img1 daumcdn](https://github.com/user-attachments/assets/81b1b628-7c2e-49ea-af92-fe16e7153913)


<br><br>

⚠️ Python 다운로드 확인하는 방법  
- 단축키 [윈도키 + R ]로 윈도우 실행창을 띄우고 > 'cmd' 를 입력하고 > 확인 버큰을 누르면 명령 프롬프트 창이 실행됩니다. 

<br>

```bash
python --version
pip --version
```

<br><br>

## 🧪 2. 가상환경(Virtual Environment) 생성
가상환경은 프로젝트별 독립적인 라이브러리 공간을 제공합니다.

<br>

```bash
# 1. 프로젝트 디렉토리 이동
cd my_project

# 2. 가상환경 생성
python -m venv venv

# 3. 가상환경 활성화 (Windows)
.\venv\Scripts\activate

```

## 📚 3. 패키지 설치 및 관리

<br>

```bash
# 패키지 설치
pip install opencv-python pandas flask

# 현재 가상환경의 패키지를 파일로 저장
pip freeze > requirements.txt

# requirements.txt 기반으로 환경 재구성
pip install -r requirements.txt
```

- ✔ requirements.txt는 팀원 간 협업, 배포, 서버 환경 재현에 필수

<br><br>

## 📦 4. VS code 다운로드 및 설치  

![img1 daumcdn](https://github.com/user-attachments/assets/e51b4e1f-5460-475c-82bf-e10719abce32)

- [공식 다운로드 사이트](https://code.visualstudio.com/download)에서 설치

<br><br>

✅ 설치가 완료되면 프로그램을 실행합니다.  

![img1 daumcdn](https://github.com/user-attachments/assets/ced223aa-b139-4ceb-b123-7311dd0d4cf1)

<br><br>


