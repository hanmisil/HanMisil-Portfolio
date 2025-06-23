## ⚙️ Project 04. Automation UI Platform – WinForms 기반 공통 자동화 UI 프레임워크

하드웨어 연동 기반 자동화 프로그램을 위한 공통 UI 프레임워크를  
C# WinForms + MVC 구조로 설계 및 개발하였습니다.

<br><br><br>

## 🎯 Overview

본 프로젝트는 회사 내 다양한 자동화 프로그램에서 공통으로 사용할 수 있는  
**BaseForm 기반 UI 프레임워크**를 구축하여 유지보수성을 높이고,  
디자인 일관성과 사용자 경험을 개선하는 것을 목표로 하였습니다.

다양한 센서/기기와 연동하는 자동화 시스템의 특성상,  
**모델 단위의 파라미터 설정, 하드웨어 상태 표시, 로그인 보안, 테마 통일성**이 중요하며  
이를 모두 반영한 구조로 설계되었습니다.

<br><br><br>

## 💡 Key Features

- ✅ **공통 BaseForm 구조 설계**
  - Header / Body / Footer로 정형화된 레이아웃
  - 로그인, 테마, 정보 표시 영역 내장

- ✅ **UserControl 기반 UI 모듈화**
  - 유지보수성과 재사용성을 고려한 화면 분리
  - 각 화면 독립적으로 구성 및 테스트 가능

- ✅ **Flat 디자인 + 동적 테마 시스템**
  - 각 요소에 `Tag`를 부여하여 테마 일괄 변경 가능
  - 밝은/어두운 테마 등 커스터마이징 지원

- ✅ **MVC 구조 적용**
  - 모델-뷰-컨트롤러 분리
  - 데이터 바인딩 및 이벤트 전파로 UI 자동 반영

- ✅ **하드웨어 제어 대응**
  - 자동화 장비의 특성을 반영한 구조
  - 하드웨어 연결/상태 갱신 기능 통합 예정

<br><br><br>

## 🔐 현재 구현된 기능

| 기능 | 설명 |
|------|------|
| 로그인 기능 | 사용자 인증 및 로그인 후 상태 표시 |
| 테마 변경 | 밝은/어두운 모드 전환, 사용자 지정 색상 지원 |
| 모델 관리 | 모델 추가, 이름 변경, 삭제 기능 |
| 파라미터 설정 | 모델별 설정 값 UI에서 관리 가능 (Ex: 좌표값, 타이머 등) |
| 상태 UI | 현재 연결된 하드웨어 상태, 파라미터 값 실시간 반영 (예정) |

<br><br><br>

## 🛠 기술 스택

- **Language**: C#
- **Framework**: .NET Framework 4.7.2
- **UI**: WinForms
- **구조**: MVC 아키텍처
- **디자인**: Flat UI, 테마 색상 자동 적용

<br><br><br>

## 🖼️ UI

📌 로그인 화면

![04  winform UI 1](https://github.com/user-attachments/assets/bac5aae2-18d8-4585-8cd5-24ba422214a2)

📌 시스템 설정 화면

![04  winform UI 2](https://github.com/user-attachments/assets/2cc03a05-8880-4829-a996-b71b3f333528)

📌 하드웨어 관리 및 카메라 연동

![04  winform UI 3](https://github.com/user-attachments/assets/071a0d45-2486-4104-b568-9f809cfd6830)

📌 모델 별 비전 셋팅 화면

![04  winform UI 4](https://github.com/user-attachments/assets/75f5dca4-172e-4861-896e-02f93b364e1a)

<br><br><br>
