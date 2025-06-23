# 🐍 Python .ini 파일의 개념과 사용 방법
`.ini` 파일은 설정 정보를 저장하는 데 널리 사용되는 **텍스트 기반의 구성 파일**입니다.  
`섹션(Section)`과 `키(Key)=값(Value)` 구조로 되어 있어, 다양한 환경설정 데이터를 **간편하게 저장 및 불러오기**에 적합합니다.

<br>

![img1 daumcdn](https://github.com/user-attachments/assets/8ed00fc6-7073-4a82-b469-2461759235e0)

<br><br>

## 📦 주요 내용

- `.ini` 설정 파일을 사용하여 Key-Value 저장 및 읽기
- 존재하지 않는 섹션(`Section`)이나 키(`Key`)일 경우 자동으로 생성
- 기본값을 설정하고, `.ini` 파일이 없을 경우 새로 생성

<br><br>

### ✅ 1. 설정값 읽기 

```python
import configparser

config = configparser.ConfigParser()
config.read('settings.ini')

db_host = config['Database']['host']
theme = config['AppSettings']['theme']

print(db_host)  # 127.0.0.1
print(theme)    # dark
```

<br><br>

### ✅ 2. 설정값 쓰기 또는 추가

```python
config['NewSection'] = {
    'new_key': 'new_value',
    'another_key': '1234'
}

with open('settings.ini', 'w') as configfile:
    config.write(configfile)
```

<br><br>

### ✅ 3. 예외 처리 및 기본값 사용
```python
try:
    port = config['Database']['port']
except KeyError:
    port = '3306'  # 기본값
```

<br><br>

## 📂 파일 구조

```bash/
├── README.md
└── config_ini_example.py   -> 샘플 코드
```

<br><br><br>
