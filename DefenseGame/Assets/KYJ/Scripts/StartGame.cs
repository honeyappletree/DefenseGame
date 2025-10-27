using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour, IPointerDownHandler
{
    private bool goGame = false;
    private int escapeCount = 0; //안드로이드에서 이전 버튼을 누른 횟수
    
    public void OnPointerDown(PointerEventData eventData)
    {
        if(goGame == false) //goGame 변수의 상태가 false일 때 GoGame 함수를 실행
        {
            GoGame();
        }
    }

    public void GoGame() //시작하기 버튼을 눌렀을 때
    {
        goGame = true;
        SceneManager.LoadScene("Loading");
        goGame = false;
        Debug.Log(goGame);
    }

    void TouchAndroidMenu()
    {
        if (Application.platform != RuntimePlatform.Android)
        {
            return; //플랫폼이 안드로이드가 아닐 때 함수를 종료함.
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escapeCount++;

            if(escapeCount == 2)
            {
                Debug.Log("종료되었습니다.");
                Application.Quit();
                escapeCount = 0;
                Debug.Log(escapeCount);
            }
        }
    }

    void Update()
    {
        TouchAndroidMenu();
    }
}
