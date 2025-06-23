## 📌 Project 03. 비전 카메라와 로봇 간 통신 연동 API 개발

비전 카메라에서 인식한 위치 데이터를 바탕으로 로봇의 정밀 제어를 수행하고,  
서로 다른 통신 언어를 자동 변환하는 **양방향 API 시스템**을 구축하였습니다.

<br><br><br>

## 🧭 Overview

비전 카메라를 로봇의 팔에 부착하여 다양한 모션을 취하고,  
카메라로부터 받은 좌표 정보를 기반으로 로봇이 원하는 위치에 정밀하게 이동하도록 하는  
**양방향 통신 기반 제어 API**를 개발하였습니다.

- 비전 카메라의 위치 정보 → 로봇의 캘리브레이션된 좌표로 변환  
- 로봇의 상태값 수신 및 조건에 따라 자동 동작/정지 판단  
- 서로 다른 언어 (로봇 언어 ↔ 카메라 언어) 간 통신 포맷 변환 자동화  
- Python 기반 API 개발 + C#으로도 연동 가능한 구조로 테스트 완료

<br><br><br>

## 💡 Key Features

- **로봇 ↔ 비전 카메라 양방향 통신 API** 개발 (REST 기반: POST/GET)
- **Socket 통신**으로 상태값 주고받기 + 조건 기반 Pass/Fail 판단 및 응답 처리
- **캘리브레이션**을 활용하여 비전 좌표와 로봇 좌표 간 정밀 위치 매핑
- 로봇 제공 API에 연동하여 커맨드 전달 및 동작 트리거 수행
- 다양한 언어/환경에서 재활용 가능한 **Python 모듈화 구조** 설계

<br><br><br>

## 🛠 Skill Set

- **Language**: Python (중심), C# (검증용)
- **Protocols**: HTTP (REST), Socket
- **기술 요소**: 로봇 API 연동, 비전 좌표 처리, 실시간 상태 확인, 커맨드 매핑

<br><br><br>

## 📄 Development Outcomes

- 기존 수동 연동 작업을 자동화하여 **통신 오류 및 작업 실패율 감소**
- Python 기반으로 다양한 시스템에 적용 가능하도록 **라이브러리화**
- 실제 장비 기반 테스트 완료 → 고객 요청에 따라 다양한 모션 적용 가능
- 로봇 언어와 카메라 언어 간 통신 변환을 자동화하여 **엔지니어 의존도 감소**

<br><br><br>

## ✅ Summary of Results

| 항목              | 결과 |
|-------------------|------|
| 연동 대상         | 비전 카메라, 로봇, 모션 제어기 |
| 핵심 기능         | REST API 통신, 상태 기반 동작, 좌표 캘리브레이션 |
| 주요 성과         | 자동화된 모션 트리거, 오류 감소, 언어 변환 시스템 구축 |

<br><br><br>

## 🖼️ Program

📌 카메라(Sensopart Config) 프로그램 비전 설정

![02  sensopart config sample](https://github.com/user-attachments/assets/302f4177-4c01-4126-b49a-df5663233403)

<br>

📌 카메라(Sensopart Config) 프로그램 비전 설정

![02  sensopart config image](https://github.com/user-attachments/assets/b9147173-c747-40f1-bd72-a5016fab50ea)

<br>

📌 로봇 펜턴드 테스트 화면

![02  robot pendant](https://github.com/user-attachments/assets/6453c4df-3315-4018-be9b-c6a008c5bc49)

