using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton Instance {  get; private set;  }    // �̱��� ȣ�� Static < �������� �޸𸮿� �÷���

    private void Awake()                                        // Awake�� ���� �ɶ�
    {
        if(Instance == null)                                    //�ش� �ν��Ͻ��� ������ ������
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