using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    // Awake is called before start
    void Awake()
    {
        ScreenUtils.Initialize();
    }

}
