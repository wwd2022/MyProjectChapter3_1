using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public delegate void OnMoveDel(Vector2 direction);
    public OnMoveDel OnMoveEvent;

    //public delegate void OnLookDel(Vector2 direction);
    //public OnLookDel OnLookEvent;
    // 위 델리게이트 선언을 다음과 같이 작성할 수 있다.
    public Action<Vector2> OnLookEvent;

    // Start is called before the first frame update
    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
