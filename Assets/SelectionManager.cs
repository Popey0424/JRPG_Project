using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{

    public Material MaterialOutline;
    public Material Materialdefault;
    public GameUI UI;

    private SelectionMode _currentMode;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                print(hit.collider.name);
                CharacterClass character = hit.collider.gameObject.GetComponent<CharacterClass>();
                print(character);
                if (character != null)
                {
                    if (_selectedCharacter != null)
                    {

                        _selectedCharacter.Visual.material = Materialdefault;
                    }
                    _selectedCharacter = character;
                    character.Visual.material = MaterialOutline;
                    UI.SetCharacter(character);
                    
                }
            }
        }
    }

    enum SelectionMode
    {
        Default,
        Attack
    }
    CharacterClass _selectedCharacter;

    public void SetAttackMode()
    {
        if (_selectedCharacter == null)
            return;

        _currentMode = SelectionMode.Attack;
    }
}
