using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    [SerializeField]
    RectTransform eggPanel;

    [SerializeField]
    int eggsLeft = 0;

    [SerializeField]
    Image eggPrefab;

    [SerializeField]
    GameDataScriptable gameData;

    List<Image> eggSprites = new List<Image>();

    // Start is called before the first frame update
    void Start()
    {
        gameData.HudManager = this;

        SetupEggs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupEggs()
    {
        for(int i = 0; i < gameData.BabyCount; ++i)
        {
            eggSprites.Add(Instantiate(eggPrefab, eggPanel));

            eggSprites[i].color = gameData.EggLostColor;
        }
    }

    public void UpdateBabyCount(int count)
    {
        if(count > eggSprites.Count)
        {
            Debug.LogError("Found Egg Count Too High");
            return;
        }

        for(int i = 0; i < count; ++i)
        {
            eggSprites[i].color = gameData.EggReturnedColor;
        }
    }
}
