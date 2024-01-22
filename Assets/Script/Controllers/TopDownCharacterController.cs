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
    // �� ��������Ʈ ������ ������ ���� �ۼ��� �� �ִ�.
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
