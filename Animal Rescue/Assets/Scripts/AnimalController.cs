using UnityEngine;

public enum AnimalType
{
    Baby,
    Nest
}

public class AnimalController : MonoBehaviour
{
    [SerializeField]
    GameDataScriptable gameData;

    [SerializeField]
    AnimalType type;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHands player = collision.transform.GetComponentInChildren<PlayerHands>();

        if (player != null)
        {
            switch (type)
            {
                case AnimalType.Baby:
                    if (player.PickUpBaby())
                    {
                        gameObject.SetActive(false);
                    }                    
                    break;

                case AnimalType.Nest:
                    if (player.ReturnBaby())
                    {
                        gameData.GameManager.ReturnBaby();
                    }
                    break;
            }

        }
    }
}
