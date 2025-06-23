## 🏆 Fintech AI Hackathon – LSTM 기반 소비 예측 및 카드 추천 모델 (2등 수상)

과거의 소비 데이터를 기반으로 미래 소비를 예측하고,  
사용자의 상황에 맞는 카드를 추천하는 **AI 기반 소비 분석 모델**을 구현하였습니다.

<br><br><br>

## 🔗 Related Links

- 🧠 GitHub Source Code: https://github.com/hanmisil/Fintech_AI_Hackathon
  
<br><br><br>

## 🎯 Overview

기존의 카드 추천 시스템은 단순히 지난달 소비 패턴만 분석하는 방식이 많아,  
다음 달 소비를 예측하거나 외부 요인을 반영한 분석이 어렵다는 한계가 있었습니다.

본 프로젝트는 **과거 소비 패턴과 외부 데이터(계절성, GDP 등)**를 함께 분석하여  
**다음 달 소비를 예측**하고, 그에 적합한 **카드 추천 알고리즘**을 제시하는 것이 목표였습니다.

또한, OpenCV OCR을 활용하여 실물 카드 인식 기능을 통해 **비전 기반 자동화 UX**를 실험적으로 구현하였습니다.

<br><br><br>

## 💡 Key Features

- **LSTM 모델 기반 시계열 소비 예측**
- 회귀분석을 통한 변수 영향도 분석 및 검증
- PyTesseract + OpenCV를 활용한 카드 번호 자동 인식
- 예측 결과 기반 추천 카드 분류 (의사결정트리 기반)
- Google Colab 기반 학습환경 구성

<br><br><br>

## 🛠 Tech Stack

- **AI 분석**: Python 3.6, Pandas, TensorFlow, Statsmodels
- **OCR & Vision**: OpenCV 4.x, PyTesseract
- **환경**: Google Colab
- **기타**: scikit-learn, Matplotlib, GitHub

<br>

✅ **OCR 기반 데이터 추출 로직 → Vision 검사 프로세스에 응용 가능**  
✅ **LSTM을 활용한 수요 예측 → 부품 소모량 예측, 생산 계획 등에 활용 가능**  
✅ **실시간 데이터 처리 경험 → 모션 제어/센서 통합 시스템에서 분석 적용 가능**  

<br><br><br>

## 🏁 Results

| 항목             | 내용 |
|------------------|------|
| 예측 모델       | LSTM (Keras) + 회귀분석 (Statsmodels) |
| 인식 기술       | OCR (OpenCV + PyTesseract) |
| 주요 성과       | 2등 수상 / 미래 지출 예측 정확도 향상 / 카드 추천 알고리즘 구현 |
| 실무 활용성     | OCR 비전 시스템, 소비/물류 수요 예측, 데이터 기반 의사결정에 응용 가능 |

<br><br><br>
