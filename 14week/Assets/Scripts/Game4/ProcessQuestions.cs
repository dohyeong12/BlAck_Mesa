using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProcessQuestions : MonoBehaviour

{

    string question;
    bool answer;

    
    public Text text;
    public Text GameClear;
    public Text GameOver;
    public Text ResultText;
    public Text ScoreText;



    public static int Score = 0;


    private void Start()
    {


        Score = 500;
        ScoreText.text = "Score : " + Score;
        ProcessQuestion();


    }
    public void ProcessQuestion()
    {

        int randomIndex = Random.Range(0, 39);
        switch (randomIndex)
        {
            case 0:
                question = "유니티는 2005년에 만들어졌다";
                answer = true;

                break;
            case 1:
                question = "원숭이에게도 지문이 있다";
                answer = true;
                break;
            case 2:
                question = "기린의 목뼈는 모두 7개이다. 그러면 사람은 그보다 작은 5개이다.";
                answer = false;
                break;
            case 3:
                question = "달팽이도 이빨이 있다";
                answer = true;
                break;
            case 4:
                question = "벼룩은 암컷과 수컷 가운데 수컷의 몸집이 더 크다";
                answer = false;
                break;
            case 5:
                question = "밀물과 썰물 현상은 하루 2번씩 일어난다";
                answer = true;
                break;
            case 6:
                question = "고대 원시인들의 가장 큰 적은 공룡이었다";
                answer = false;
                break;
            case 7:
                question = "비행기의 출발시간이란 비행기의 탑승문이 완전히 닫힌 순간을 말한다";
                answer = false;
                break;
            case 8:
                question = "남극에도 우편번호가 있다";
                answer = false;
                break;
            case 9:
                question = "인간의 뇌 세포는 재생이 안 되는 신체세포이다";
                answer = true;
                break;
            case 10:
                question = "사람의 땀은 산성이다 ";
                answer = true;
                break;
            case 11:
                question = "여왕개미의 수명은 10년 이상이다";
                answer = true;
                break;
            case 12:
                question = "금붕어는 뒤로 헤엄칠 수 있다";
                answer = false;
                break;
            case 13:
                question = "손톱은 뼈가 아닌 피부가 변해서 된 것이다";
                answer = true;
                break;
            case 14:
                question = "우리나라 최초의 국가는 조선이다";
                answer = true;
                break;
            case 15:
                question = "8만 대장경의 경판 수는 8만개를 넘는다";
                answer = true;
                break;
            case 16:
                question = "파란 전등 밑에서 빨강 종이를 보면 보라색으로 보인다";
                answer = false;
                break;
            case 17:
                question = "얼룩말의 줄무늬는 하얀색이다";
                answer = true;
                break;
            case 18:
                question = "은행잎은 활엽수이다";
                answer = false;
                break;
            case 19:
                question = "바나나의 씨는 없다";
                answer = true;
                break;
            case 20:
                question = "하마는 육식동물이다";
                answer = false;
                break;
            case 21:
                question = "사슴은 쓸개가 없다";
                answer = true;
                break;
            case 22:
                question = "날개를 가진 새 중에 가장 빠른 새는 독수리다";
                answer = false;
                break;
            case 23:
                question = "문어의 다리는 문어의 머리에서 나온다";
                answer = true;
                break;
            case 24:
                question = "북극곰은 겨울잠을 자는 동물이다";
                answer = false;
                break;
            case 25:
                question = "우리나라 최초의 라면값은 10원이었다";
                answer = true;
                break;
            case 26:
                question = "딸기는 장미과에 속한다";
                answer = true;
                break;
            case 27:
                question = "토끼는 걸어 다닐 수 있다";
                answer = false;
                break;
            case 28:
                question = "세상 모든 게들은 옆으로 걷는다";
                answer = false;
                break;
            case 29:
                question = "대머리도 비듬이 생긴다";
                answer = true;
                break;
            case 30:
                question = "뱀은 뒤로 갈수 있다";
                answer = false;
                break;
            case 31:
                question = "가장 강한 독을 가진 개구리 한마리의 독으로 사람 2000명 이상을 죽일 수 있다";
                answer = true;
                break;
            case 32:
                question = "개미도 높은 곳에서 떨어지면 죽는다";
                answer = false;
                break;
            case 33:
                question = "세계에서 제일 처음으로 텔레비전 방송을 시작한 나라는 영국이다";
                answer = true;
                break;
            case 34:
                question = "세계적으로 가장 많이 발생하는 병은 말라리아다";
                answer = false;
                break;
            case 35:
                question = "새는 뒤로도 날 수 있다";
                answer = true;
                break;
            case 36:
                question = "달걀은 어린 닭이 낳은 것일수록 그 크기가 크다";
                answer = false;
                break;
            case 37:
                question = "사람의 세포는 개미의 세포보다 크다";
                answer = false;
                break;
            case 38:
                question = "위가 없어도 사람은 살 수 있다";
                answer = true;
                break;
            case 39:
                question = "개의 발에도 땀이 난다";
                answer = false;
                break;

        }

        text.text = question;

    }
    public void trueOnClickOBtn()
    {
        if (answer)
        {
            ResultText.text = "정답";
            Score += 200;
            ScoreText.text = "Score : " + Score;

        }
        else
        {
            ResultText.text = "오답";
            Score -= 500;
            ScoreText.text = "Score : " + Score;
        }

        ProcessQuestion();
    }
    public void falseOnClickXBtn()
    {
        if (answer)
        {
            ResultText.text = "오답";

            Score -= 500;
            ScoreText.text = "Score : " + Score;

        }
        else
        {
            ResultText.text = "정답";

            Score += 200;
            ScoreText.text = "Score : " + Score;

        }
        ProcessQuestion();
    }
    public void Update()
    {
        
            if (Score >= 1500)
            {
                HPLC.instance.PlayGame = 1;
                HPLC.instance.WinGame = 1;
                SceneManager.LoadScene("INgame");
                GameClear.text = "GameClear";
            
    
            
        }
            else if (Score < 0)
            {   
                HPLC.instance.PlayGame = 1;
                HPLC.instance.LoseGame = 1;
                SceneManager.LoadScene("INgame");
                GameOver.text = "GameOver";
            
            
            }
        
    }
}

