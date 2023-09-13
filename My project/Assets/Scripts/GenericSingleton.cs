using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;
    
    public static T instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<T>();

                if(_instance == null )
                {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name;
                    _instance = obj.AddComponent<T>();
                }
            }
            return _instance;
        }
    }
    public virtual void Awake()                                        //Awake가 실행 될때
    {
        if (_instance == null)                                    //해당 인스턴스가 존재지 않으면
        {
            _instance = this as T;                                 //인스턴스는 이 클래스 -> class Singleton
            DontDestroyOnLoad(gameObject);                      //유니티에 파괴되지 않는 객체로 등록
        }
        else if (_instance != this)
        {
            Destroy(gameObject);                                //해당 인스턴스가 존재하면 생성하자마자 파괴된다.
        }
    }
}



