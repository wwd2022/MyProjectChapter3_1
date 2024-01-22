using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    Penguin,
    Knight
}

// Á÷·ÄÈ­
[System.Serializable]
public class Charater
{
    public CharacterType CharacterType;
    public Sprite CharacterSprite;
    public RuntimeAnimatorController AnimatorController;
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<Charater> CharaterList = new List<Charater>();

    public Animator PlayerAnimator;
    public Text PlayerName;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCharacter(CharacterType characterType, string name)
    {
        var character = GameManager.instance.CharaterList.Find(item => item.CharacterType == characterType);

        PlayerAnimator.runtimeAnimatorController = character.AnimatorController;
        PlayerName.text = name;
    }
}
