using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCharacter0;
    [SerializeField]
    GameObject prefabCharacter1;
    [SerializeField]
    GameObject prefabCharacter2;

    GameObject currentCharacter;

    //first frame input support
    bool previousFrameChangeCharacterInput = false; 

    // Start is called before the first frame update
    void Start()
    {
        currentCharacter = Instantiate<GameObject>(
            prefabCharacter0, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("ChangeCharacter") > 0)
        {
            //only change character in first input frame
            if (!previousFrameChangeCharacterInput)
            {
                previousFrameChangeCharacterInput = true;
                //save current position and destroy current character
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);

                int prefabNumber = Random.Range(0, 3);
                if (prefabNumber == 0)
                {
                    currentCharacter = Instantiate<GameObject>(
                    prefabCharacter0, Vector3.zero, Quaternion.identity);
                }
                else if (prefabNumber == 1)
                {
                    currentCharacter = Instantiate<GameObject>(
                    prefabCharacter1, Vector3.zero, Quaternion.identity);
                }
                else
                {
                    currentCharacter = Instantiate<GameObject>(
                    prefabCharacter2, Vector3.zero, Quaternion.identity);
                }
            }

        }
        else
        {
            //no change character input
            previousFrameChangeCharacterInput = false;
        }
    }
}
