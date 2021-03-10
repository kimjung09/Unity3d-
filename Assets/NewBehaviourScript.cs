using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Start()
    {
        // 간단한 메세지 만들기
        Debug.Log("Hello Unity"); //콘솔창띄우는법

        // 프로그래밍 기초 변수 4가지 
        // 1.변수
        int level = 5;  // 정수형 데이터 단순한 숫자 
        float strength = 15.5f;  // 숫자형 데이터 들어가는 힘의 변수
        string playerName = "나용사";  // 문자열 데이터 플레이어 이름
        bool isFullLevel = false;  // 논리형 데이터 참 혹은 거짓 true & false 자료형 
                                   // 변수의 타입과 이름을 정하는 게 선언 거기에 값을 넣는 것을 초기화 그래서 프로그래밍의 흐름은 선언 -> 초기화 -> 호출 (사용) 으로 흘러간다.

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        // Debug.Log("용사의 레벨은?");
        // Debug.Log(level);
        // Debug.Log("용사의 힘은");
        // Debug.Log(strength);
        // Debug.Log("용사는 만렙인가?");
        // Debug.Log(isFullLevel);

        //2. 그룹형 변수 
        string[] monsters = { "슬라임", "사막뱀", "악어" }; // 변수하나에 여러가지 넣을 수없어 그룹형 변수;

        // 몬스터 레벨에 대한 변수
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        // 리스트 선언하고 초기화
        List<string> items = new List<string>(); //items 라는 Lists 변수 선언
        items.Add("생명물약30");
        items.Add("마나물약10");

        // 안에 들어있는 아이템 삭제하기
        // items.RemoveAt(0);

        //Debug.Log("현재 가지고 있는 아이템");
        //Debug.Log(items[0]);
        //Debug.Log(items[1]);

        //3. 연산자 
        int exp = 1500; // 경험치 변수

        exp = 1500 + 320; // 경험치더하기
        exp = exp - 10; // 빼기 
        level = exp / 300; //레벨당 exp 경험치 300
        strength = level * 3.1f; // 힘을 레벨에 비례해서 3.1만큼 증가

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        // % 몫이 아닌 나머지를 나눈것 남은 경험치 보이기
        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        // 4.문자열에 대한 연산자
        string title = "전설의 ";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + "" + playerName);  // title 과 플레이어 이름 합치기

        // 5.비교 연산자 
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        // 레벨 10일때 튜토리얼 끝내기 
        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        // > (초과) < (미만) >=(이상) <=(이하)

        // 조금 더 어려운 논리 연산자 
        // 모두 참일때만 참 && 하나라도 참일때 ||
        int health = 30; // 생명력
        int mana = 15;  // 마나
        bool isBadCondition = health <= 50 && mana <= 20; // 생명력이 50이하 마나 20이하인지를 비교 &&(AND) 연산자 두값이 true일때만 발동 

        // 삼항 연산자: A:B 중 true일떄 A, false일때 B를 출력해준다.
        string condition = isBadCondition ? "나쁨" : "좋음"; // 용사의 현재상태
        Debug.Log("용사의 상태가 나쁩니까?" + condition); // 값에 따라 true false를 반환해준다.



        /*  or연산자
        // ||(OR) 두값중에서 하나만 true라면 true를 출력해줌. 둘중 하나라도 맞으면 용사의 상태가 나쁘다는 의미가 된다.
        bool isBadCondition = health <= 50 || mana <= 20; // 생명력이 50이하 마나 20이하인지를 비교 &&(AND) 연산자 두값이 true일때만 발동 
        */


        // 6.키워드: 프로그래밍 언어를 구성하는 특별한 단어이다
        //int float = 1; // 변수 이름으로 도 사용할수 없고 값으로 도 불가능 
        //string name = List;

        // 7.조건문: 조건에 만족할씨 로직을 실행하는 제어문
        // true 일떄만 실행
        if (condition == "나쁨") {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용해주세요");  // 플레이어 상태가 나쁠때 나오는 문장
        }
        else // if 가 실행 되지 않을때 
        {
            Debug.Log("현재 플레이어 상태가 좋습니다");
        }
        // 현재상태가 나쁜데 첫번째 아이템이 생명포션일때 생명물약을 먹고 마나포션일때 마나물약을 먹는다
        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다");
        }
        else if (isBadCondition && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("마나포션30을 사용하였습니다");
        }
        // switch,case 문 : 변수의 값에 따라 로직 실행 
        switch (monsters[1]) {
        // case만 따로떄고 같이 묶어서 사용가능
          case "슬라임":
          case "사막뱀":
              Debug.Log("소형몬스터 출현!");
              break;
          case "악마":
              Debug.Log("중형몬스터 출현!");
              break;
          case "골렘":
              Debug.Log("대형몬스터 출현!");
                break;
            // default 모든 case 를 들어가지 못할때 마지막으로 실행되는 코드
            default:
                Debug.Log("??? 몬스터가 출현"); 
                break;
       }

        // 6. 반복문 
         while (health > 0)
        {
            health--;  // 0이 넘어가면 생명력 감소
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다." + health);
            else
                Debug.Log("사망하였습니다");
           
            if (health == 10) // 체력이 10이될때 해독제 사용해서 알아서 빠져나감
            {
                Debug.Log("해독제를 사용합니다");
                break; // 더이상 반복하지않고 빠져나감; 
            }
        }

         // for문: 변수를 연산하면서 로직 반복 실행
         for (int count=0; count<10; count++)  // 두번째 조건으로 몇번을 돌릴지 만들어냄 용사가 체력이 0일때 붕대를 감을때 10번만 감게함.
        {
            health++;
            Debug.Log("현재 붕대를 감고있습니다..." + health);
        }

         // 맵에 있는 몬스터 출력
         // 그룹형변수 길이: .Length(배열) .Count(리스트)
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터 :" + monsters[index]);
        }

        // foreach문 : for의 그룹형변수 탐색 특화 / 직접 그룹핑한 아이템은 한개씩 꺼내서 그룹형변수안에 넣어서 직접 사용
        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monster);
        }
    }
}
    

        // 중괄호를 사용한 초기화
        //Debug.Log("맵에 존재하는 몬스터");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);