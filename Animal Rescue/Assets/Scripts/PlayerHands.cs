using UnityEngine;

public class PlayerHands : MonoBehaviour
{
    [SerializeField]
    bool hasBaby = false;

    // Start is called before the first frame update
    void Start()
    {
        ChangeBabyState(hasBaby);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool PickUpBaby()
    {
        if (!hasBaby)
        {
            hasBaby = true;

            ChangeBabyState(true);

            return true;
        }
        
        Debug.Log("Already Holding Baby");
        
        return false;
    }

    public bool ReturnBaby()
    {
        if (hasBaby)
        {
            hasBaby = false;

            ChangeBabyState(false);

            return true;
        }
        
        Debug.Log("No Baby To Return");
        
        return false;
    }

    void ChangeBabyState(bool newActiveState)
    {
        transform.GetChild(0).gameObject.SetActive(newActiveState);
    }
}
