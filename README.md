# BlAck_Mesa
 캡스톤 2학년 1학기

14주 후는 육성 시뮬레이션으로 

모종의 이유로 빚을 지게 된 주인공이 빚을 갚기 위해 노력하는 이야기이다

플레이어는 행동으로 주인공의 능력치에 변화를 줄 수 있으며

능력치에 따라 엔딩도 변하게 된다

## 프로젝트 개요    
98일 이라는 한정된 시간에서 체력과 돈이라는 제한적인 재화를 효율적으로 사용하여 

돈을 목표에 맞추거나 혹은 스탯을 플레이어가 원하는 방향으로 만들어 내어 다양한 엔딩을 보는 것이 목표인 게임이다.

체력과 포만감, 건강 소모되는 여러가지 행동을 통해 최대체력,지능,돈을 올릴 수 있으며 

소모되는 체력, 건강, 포만감은 돈을 사용하여 회복할 수 있다.

만약 '질병'에 걸리게 되면 소모되는 체력의 양이 증가하는데 질병은 날짜가 지나갈때 랜덤으로 부여된다.

행동은 OX퀴즈,점프게임,청기백기,물건받기 총 4가지 미니게임을 통해 표현하였다.

실력이 뛰어나지 않은 4명의 팀원의 실력향상을 위해 여러개의 미니게임을 만들며 

각자 하나의 게임을 완성하게 하였고 게임을 완성시키며 실력을 향상시키는걸 목표로 하였다.

## 팀소개

- 사진

팀장 : 이도건 / 팀원 : 권내규, 배준우, 송도현, 신세웅

이도건(dg041124@gmail.com) : 총괄, 메인시스템 개발, 계획 발표, 기획

권내규(azaz77884689@gmail.com) : 러쉬게임 개발, 기획

배준우(edwin2514381@naver.com) : 물건받기게임 개발, 최종발표, 기획

송도현(ghuijeong67@gmail.com) : 청기백기 개발, 리드미, 기획및 밸런싱

신세웅(sw427531@gmail.com) : OX게임 개발, 중간발표, 기획

(https://github.com/IlIlIlllIIllI/BlAck_Mesa)

## 사용기술

개발에 사용한 기술 - 유니티(C#) 
개발에 소요된 물품 및 준비물 - Honeti, Pixel UI, SimplePixelUI, TextMesh Pro, nGarden, DungGeunMo

## 프로젝트 진행 과정(월별 진행상황)

### 3월

팀 결정

메인 시스템 기획 구상 및 결정


### 4월

기획 수정

미니게임 기획

메인 시스템 개발 시작


### 5월

미니게임 개발, 중간 점검

캐릭터 디자인 시작


### 6월

미니게임 완성 

미니게임 통합 및 메인 시스템 완성


## 프로젝트 상세 소개

- 레이아웃 세부 설명
- 데이터베이스 / 데이터플로우 / 시스템 구조
- 세부 수행 과정
  
  체력 : 30 / 30, 학력 : 0, 돈 : 20, 포만감 : 60  / 100, 건강 : 80, 질병 : X

위의 스탯으로 게임을 시작한다. 98일 동안 게임을 진행할 수 있으며 '잠'을 통해 하루가 지나간다.

행동을 통해 스탯이 올라가고 체력이 소모되며 체력이 0이 되면 '잠'외의 행동이 불가능하고 '잠'을 하게 되면 최대체력만큼 체력이 회복된다.

체력을 사용하는 행동에는 온동,공부,일 3가지가 존재한다.

'운동'을 하면 체력 10, 건강3, 포만감3 만큼 소모되고 최대체력이 1만큼 올라간다. /-> 증가 되는 최대체력을 적게 설정하여 하루에 할 수 있는 '행동'이 많아지는 것이 희귀한 이벤트로 만들었다.

'공부'를 하면 체력 10, 건강3, 포만감3 만큼 소모되고 지능이 3만큼 올라간다. /->  지능을 통해 얻을 수 있는 돈의 양이 많아진다. '공부'를 한번 하게 되면 얻을 수 있는 돈의 양이 3% 늘어나게 많들었다.

'일'를 하면 체력 10, 건강3, 포만감3 만큼 소모되고 돈이 증가한다. '일'을 하면 미니게임이 나오고 클리어 여부와 지능에 따라 획득가능한 돈의 양이 많아지는데 클리어 하면 10원, 실패하면 5원의 기본금이 주어지고 기본금에 지능%만큼 추가로 얻게 되는데 기본금 10에 지능 30이면 13원을 얻게 되는 것이다. 소수점이면 반올림한다.

'운동', '공부', '일'을 통해 건강이 낮아지고 낮아진  '병원'이나 '식당'에서 회복할 수 있다.



'병원'에는 '진료', '치료', '수술' 3가지중 하나를 선택하여 건강을 회복할 수 있다.

'진료' : 30원이 소모되며 건강을 5 올려준다. / '치료' : 100원이 소모되며 질병을 치료하고 건강을 15회복한다. / '수술' : 400원이 소모되며 질병을 치료하고 건강을 55회복 시킨다. /-> 병원에서 건강을 회복할려면 식당에 비해 많은 돈을 필요로 하게 된다. 그러나 포만감의 구애받지 않고 건강을 회복할 수 있으며 질병을 빠르게 없앨 수 있는 유일한 수단이다.


'식당'은 음식을 먹어 건강을 회복하고 포만감을 올릴 수 있다. 여러가지 메뉴가 있으며 각자 소모되는 돈과 올라가는 건강,포만감이 다르며 포만감이 100이 되면 음식을 먹지 못한다.음식은 일반음식과 건강이 소모되는 대신에 포만감이 대폭 증가하는 음식 두 종류가 있다.

국밥 : 5원소모되며 건강이 2 증가하고 포만감이 25증가한다. / 된장찌개 : 45원 소모되며 건강이 15 증가하고 포만감이 20증가한다. / 벽제갈비 : 130되며 건강이 25 증가하고 포만감이 50증가한다. / 햄버거 : 5원 소모되며 건강이 3 줄어들고 포만감이 30 증가한다. / 치킨 : 15원 소모되며 건강이 5줄어들고 포만감이 50증가한다.


미니게임은 러쉬게임,OX게임,물건받기,청기백기가 있다. 러쉬 게임은 오른쪽으로 이동하는 주인공을 점프하며 건물에 부딪히지 않고 오래 살아남는 게임이고, OX게임은 등장하는 질문에 O,X 중 알맞은 정답을 선택하는 게임이다. 물건받기는 하늘에서 떨어지는 다양한 물건을 땅에 에서 최대한 많이 잡으면서 폭탄은 피해야하며, 청기백기는 올라가는 깃발의 색에 맞는 방향키를 누르는 게임이다.

## 사용자 수행 흐름도
![캡톤](https://user-images.githubusercontent.com/108465094/178197685-bc7aad9a-b521-4593-98f0-f6c47ea386a8.png)


## 프로젝트 추진 결과

- 결과 분석, 유지 보수
각자 미니게임을 하나씩 만들어 통합하였지만 미니게임의 수가 적어 지루하기에 쉬워지는 문제가 있다. 때문에 다양한 미니게임을 추가해야할 것이고 그에 맞춰 밸런스역시 계속해서 수정해야할 필요가 있다.

## 결과 및 발표 자료

- [깃허브 저장소 주소](https://github.com/IlIlIlllIIllI/BlAck_Mesa)
   
- 프로젝트 소개 영상 / 팀 소개 영상

- 계획 발표 자료  [산학분반1팀_블랙 메사.pptx](https://github.com/IlIlIlllIIllI/BlAck_Mesa/files/9081203/1._.pptx)
   
- 중간 발표 자료 [--PPT___3.pptx](https://github.com/IlIlIlllIIllI/BlAck_Mesa/files/9080081/--PPT___3.pptx) 
 
- 최종 발표 자료 [14주후_최종발표_BlackMesa.zip](https://github.com/IlIlIlllIIllI/BlAck_Mesa/files/9108726/14._._BlackMesa.zip) 
