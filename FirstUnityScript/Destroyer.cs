using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplotion;

    Timer explodeTimer;

    void Start()
    {
        explodeTimer = gameObject.AddComponent<Timer>();
        explodeTimer.Duration = 1;
        explodeTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (explodeTimer.Finished)
        {
            explodeTimer.Run();
            GameObject personaje = GameObject.FindWithTag("C4BuscadoresPrefab");
            if (personaje != null)
            {
                Instantiate<GameObject>(prefabExplotion,
                    personaje.transform.position,
                    Quaternion.identity);
                Destroy(personaje);
            }
        }


        
        
    }
}
