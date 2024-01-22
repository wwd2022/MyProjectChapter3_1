using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    [SerializeField] private Image characterSprite;
    [SerializeField] private InputField inputFiold;
    [SerializeField] private GameObject information;
    [SerializeField] private GameObject selectCharacter;

    private CharacterType characterType;
    public void OnClickCharator()
    {
        information.SetActive(false);
        selectCharacter.SetActive(true);
    }

    public void OnClickSelectCharacter(int index)
    {
        characterType = (CharacterType)index;
        var character = GameManager.instance.CharaterList.Find(item => item.CharacterType == characterType);
        
        characterSprite.sprite = character.CharacterSprite;
        characterSprite.SetNativeSize();

        selectCharacter.SetActive(false);
        information.SetActive(true);
    }

    public void OnClickJoin()
    {
        if (!(2 < inputFiold.text.Length && inputFiold.text.Length < 10))
        {
            return;
        }

        GameManager.instance.SetCharacter(characterType, inputFiold.text);

        Destroy(gameObject);
    }
}
