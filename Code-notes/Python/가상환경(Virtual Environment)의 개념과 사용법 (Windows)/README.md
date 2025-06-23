# 🐍 Python Virtual Environment (`venv`) 사용법 정리
Python 프로젝트별로 독립적인 환경을 구성하고,  
패키지를 분리 관리할 수 있는 `venv` 가상환경 도구에 대한 정리입니다.

<br><br>

## 📌 1. 가상환경(Virtual Environment)이란?

![img1 daumcdn](https://github.com/user-attachments/assets/5c270636-aae0-44b8-b02a-ca913a67150b)


가상환경이란 **Python 프로젝트마다 독립된 공간을 만들어 라이브러리 및 패키지를 분리하여 설치**할 수 있도록 해주는 도구입니다.

- 여러 프로젝트에서 서로 다른 버전의 라이브러리를 사용 가능
- 시스템 전체 Python 환경에 영향을 주지 않음
- 협업 시 동일한 환경을 구성하기 용이

<br><br>

## 📦 2. `venv`란?

- Python 3.3 이상부터 기본으로 제공되는 **가상환경 생성 도구**
- 별도 설치 없이 `python -m venv`로 바로 사용 가능
- 프로젝트별 Python 실행환경을 완전히 분리해줌

<br><br>

## 🛠️ 3. `venv` 설치 및 사용 방법

VSCode > Terminal > New Ternimal 을 선택하여 새 터미널을 띄웁니다.

![img1 daumcdn](https://github.com/user-attachments/assets/adbc007f-4903-45bb-8de9-8cb06ef9a8a9)

* cd 명령을 통해 프로젝트를 작업하고 있는 폴더로 이동합니다.

<br>

### ✅ 가상환경 생성
```bash
python –m venv <가상환경 이름>
cd .\<가상환경 이름>
```

<br>

### ✅ 가상환경 활성화
```bash
<가상환경 이름>/Scripts/activate
```
* 활성화된 가상환경에서는 해당 환경에만 영향을 주며 라이브러리 설치, 업데이트, 제거 등의 작업을 수행할 수 있습니다.

<br>

### ✅ 패키지 설치하기
```bash
pip install <패키지명>
```

<br>

### ✅ 가상환경 내 패키지를 리스트로 확인하고 requirements.txt 파일로 만들기
```bash
# 가상환경에서 사용하고 있는 패키지 리스트 확인
pip freeze

# 파일로 저장
pip freeze > requirements.txt
```

* 패키지 버전 관리
**pip freeze requirements.txt** 명령으로 현재 사용하고 있는 패키지 목록을 파일로 저장하고,  
다른 환경에서 **pip install -r requirements.txt** 명령을 하면 동일한 환경을 구축할 수 있습니다. 

<br>

### ✅ 가상환경 비활성화
```bash
deactivate
```

<br>

### ✅ 가상환경 삭제

python의 가상환경은 폴더로 만들어집니다. 해당하는 폴더를 삭제하면, 가상환경을 삭제할 수 있습니다.

![img1 daumcdn](https://github.com/user-attachments/assets/3c914d3a-c316-4507-9ca5-cbb4f065aec1)


<br><br><br>



