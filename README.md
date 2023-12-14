# TREASURE_HUNTER

## 코드 설명
이 코드는 C# 언어로 작성된 콘솔 게임 코드입니다.   
숫자 선택을 통해 진행할 수 있는 간단한 RPG 게임입니다.   

## 게임 방법
이 게임에서 플레이어는 몬스터들을 쓰러뜨리는 용사가 될 수 있습니다.   
검을 강화하여 몬스터들을 공격하고, 보스 몬스터를 쓰러뜨려 보물을 획득하세요!      <br>

1. 플레이어는 내구도 5, 강화 0강짜리 검과 5골드를 가진 채로 게임을 시작합니다.
2. 검 강화와 몬스터 공격 중 하나의 행동을 계속 고를 수 있습니다.
3. 검의 내구도가 다 닳으면 게임 오버입니다.
4. 보스 몬스터의 체력을 다 깎으면 게임 클리어입니다.

#### 검 강화
    (1) 검을 강화하면 1골드가 소모되며 성공할수도 있고 실패할 수도 있습니다.
        - 성공시 내구도가 1증가하고, 1강이 상승합니다.   
        - 실패시 1강 하락합니다.   
    (2) 1강, 3강, 5강, 7강에서 각각 검의 데미지가 1씩 증가합니다.   
        - 반대로 0강, 2강, 4강, 6강으로 강화가 하락하면 데미지가 1씩 감소합니다.
#### 몬스터 공격   
     (1) 몬스터를 공격하면 검의 내구도가 1감소하며 1골드를 얻게 되고 검의 데미지만큼 몬스터의 체력을 깎습니다.   
        - 몬스터의 체력이 다 닳으면 3골드를 얻고 다음 몬스터가 나타납니다. 

## 게임 제작 의도
C# 콘솔 게임을 개발하며 프로그래밍 능력을 향상시키고자 하였고<br>
플레이하기에 간단하면서도 재미와 목적성이 있는 게임을 만들고 싶었습니다.<br>

## 느낀 점
처음부터 혼자서 만들었다면 막막했을 것 같은데 수업시간에 가위바위보나 틱택토같은 게임들을 먼저 만들어보고 난 후여서 다행이었습니다.<br>
하지만 코드를 짜다가 중간중간 테스트를 할 때 예상하지 못한 문제들이 나와 당황스러웠습니다.<br>
코드를 하나하나 다시 보고 어디가 문제인지 알아내는 것은 힘들었지만 찾아내고 나면 이걸 왜 이렇게 짰었지 하는 부분도 많았어서<br>
이번 과제를 계기로 스스로 코드를 짜고 고쳐나가는 방법을 조금 더 알게 된 것 같습니다.

