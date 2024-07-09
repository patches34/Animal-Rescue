using UnityEngine;

[CreateAssetMenu(fileName = "GameDataScriptable Data", menuName = "ScriptableObjects/GameDataScriptable", order = 1)]
public class GameDataScriptable : ScriptableObject
{
    public int BabyCount;

    public GameManager GameManager;

    public HudManager HudManager;

    public Player Player;

    public Color EggLostColor;
    public Color EggReturnedColor;
}