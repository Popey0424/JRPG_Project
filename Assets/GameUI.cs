using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{

    public Image ImagePortrait;
    public TMPro.TextMeshProUGUI TextLife;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCharacter(CharacterClass character)
    {
        ImagePortrait.sprite = character.SpritePortrait;
        TextLife.text = character.Life.ToString();
    }
}
