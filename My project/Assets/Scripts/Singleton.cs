using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance {  get; private set;  }    // 싱글톤 호출 Static < 전역으로 메모리에 올려줌

    private void Awake()                                        // Awake가 실행 될때
    {
        if(Instance == null)                                    //해당 인스턴스가 존재지 않으면
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);                      
        }                                   
        else
        {
            Destroy(gameObject);
        }
    }

    public int playerScore = 0;

    public void InscreaseScore(int amount)
    {
        playerScore += amount;
    }

}
