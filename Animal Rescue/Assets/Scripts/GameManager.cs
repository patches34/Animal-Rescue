using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int savedBabies = 0;

    [SerializeField]
    GameDataScriptable gameData;

    // Start is called before the first frame update
    void Start()
    {
        gameData.GameManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnBaby()
    {
        ++savedBabies;

        if (savedBabies > gameData.BabyCount)
        {
            Debug.LogError("Found Too Many Babies");
        }
        else
        {
            gameData.HudManager.UpdateBabyCount(savedBabies);
        }
    }
}
