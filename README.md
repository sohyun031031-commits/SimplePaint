# SimplePaint

# (C# 코딩) SimplePaint 프로그램

## 개요
- C# 프로그래밍학습
- 1줄소개: 사용자입력데이터처리와현재시간정보구하기를통한간단한페인트프로그램

-사용한플랫폼: 
- C#, .NET Windows Forms, Visual Studio, GitHub

- 사용한컨트롤:
- Label, TextBox, Button, Panel, ColorDialog, ComboBox, PictureBox, MenuStrip, ToolStripMenuItem

- 사용한기술과구현한기능:
- Visual Studio를이용하여UI 디자인
- 그림판넬에서마우스이벤트처리하여그리기기능구현
- ColorDialog를이용하여색상선택기능구현
- ComboBox를이용하여선택된도형그리기기능구현

## 실행화면(과제1)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-1.png)
<img width="746" height="609" alt="스크린샷 2026-04-30 120925" src="https://github.com/user-attachments/assets/79a78068-9078-4706-89d4-1856e5a42032" />


- 구현한내용(위그림참조)
	- 기본 UI 완성


## 실행화면(과제2)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-2.png)
<img width="718" height="596" alt="스크린샷 2026-04-30 120950" src="https://github.com/user-attachments/assets/84cad28a-144a-4fd2-9ea5-f04036bd3d3c" />
<img width="714" height="586" alt="스크린샷 2026-04-30 121018" src="https://github.com/user-attachments/assets/094a2655-6b86-4d52-8177-b6cbdf803333" />


- 구현한내용(위그림참조)
	- 마우스 드래그로 그릴 도형 미리보기 기능
	- 직선, 사각형, 원 그리기 기능 구현
	- 도형의 색상과 선 두께 조절 가능


## 실행화면(과제3)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-3.png)
<img width="1642" height="589" alt="스크린샷 2026-04-30 122310" src="https://github.com/user-attachments/assets/227dfe2c-d228-4e0e-abd8-6ff2411d3968" />
<img width="141" height="302" alt="스크린샷 2026-04-30 122320" src="https://github.com/user-attachments/assets/d79718fe-c6a4-40b7-acb0-ab2e9edb64af" />


- 구현한내용(위그림참조)
	- 그려진 그림을 이미지 파일로 저장하는 기능 구현
	- 파일 저장을 위한 대화 상자인 SaveFileDialog 사용
	- .png, .jpg, .bmp 형식으로 저장 가능


## 실행화면(과제4)
- 코드의 실행 스크린샷과 구현 내용 설명

![실행화면](img/screenshot-4.png)
<img width="956" height="777" alt="스크린샷 2026-04-30 124619" src="https://github.com/user-attachments/assets/43a0886d-38d2-4477-be30-ca37a7857ce4" />
<img width="716" height="586" alt="스크린샷 2026-04-30 124628" src="https://github.com/user-attachments/assets/66c8c008-0e0a-46f7-ab3e-37f8fabd50de" />
<img width="716" height="585" alt="스크린샷 2026-04-30 124644" src="https://github.com/user-attachments/assets/02f1c68c-a0fe-48ae-87e9-ed4ec6f5ab03" />
<img width="713" height="583" alt="스크린샷 2026-04-30 124655" src="https://github.com/user-attachments/assets/04e0dc91-3bb9-4a9c-b42a-151203dc071b" />


- 구현한내용(위그림참조)
	- 외부 이미지 파일을 불러와서 그림판에 표시하는 기능 구현
	- 파일 열기를 위한 대화 상자인 OpenFileDialog 사용
	- .png, .jpg, .bmp 형식의 이미지 파일 열기 가능
	- 외부에서 이미지 파일을 읽어 들여서 캔버스로 사용
	- 이미지 크기에 맞춰 캔버스 크기 조정
	- 이미지가 큰 경우 스크롤바 추가하여 전체 이미지 보기 가능
	- 확대/축소 기능 구현하여 이미지 크기 조절 가능
 	- 이미지의 크기가 클 경우 스크롤바 자동 생성
