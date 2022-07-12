# 2022-1 인하대학교 정보통신종합설계

## 360이미지 및 Depth map으로 구성된 3D 가상 환경에서의 게임을 통한 Interaction 구현

- 360이미지 한 장으로 구현한 Asynchronous AR 환경으로 제작된 Android Game
	- Unity 엔진 기반
	- Open3d와 Cloudcompare 이용
	

------------

### 1. 프로젝트 진행 과정

- 이미지 촬영
	- 가구점 이미지 및 인하대학교 하이테크센터의 강의실 및 휴게실 이미지 3장을 360카메라를 통해 촬영
		- 하이테크센터의 이미지는 Insta360Pro2를 통해 촬영하였음
		
- Depth map 제작
	- 위의 이미지를 Depth map으로 변환
	- Depth map 제작엔 Joint_S3D_Fres모델 활용
		- 해당 논문 참조 : Improving 360 Monocular Depth Estimation via Non-local Dense Prediction Transformer and Joint Supervised and Self-supervised Learning,
											Ilwi Yun, Hyuk-Jae Lee, Chae Eun Rhee,
											https://github.com/yuniw18/Joint_360depth
											
- Mesh 제작
	- Depth map기반으로 Poisson surface reconstruction 기법을 통하여 Mesh 제작
	- 가구점 이미지의 바닥면 평탄화 진행
	
- Unity 빌드
	- 타워디펜스 형식의 3D AR게임 빌드
	
----------
### 2. 프로젝트 실행방법

- 해당 Repository를 git clone

- 다음 링크에서 Resources.zip을 다운받아 Assets/Resource에 압축풀기
	- https://drive.google.com/file/d/1CafZHPfBEZUIJ_cP3i6F46njZmRcA7sn/view?usp=sharing

- Unity에서 불러오기
	- 해당 프로젝트는 Unity 2019.4.34f1에서 제작됨
	
- Scenes폴더에서 GameScene 불러와서 시뮬레이션 가능
	- LALT 입력시 마우스로 시점 전환 가능
	- Space 길게 입력 시 보고 있는 방향에 Object설치 가능
	- P 입력시 Portal에서 Mob생성
	
- Android Apk로 빌드 가능
