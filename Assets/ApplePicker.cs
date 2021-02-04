using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update

    public List<GameObject> basketList;
    void Start()
    {
        basketList= new List<GameObject>();
            for(int i=0; i<numBaskets; i++)
            {
                GameObject tBasketGO = Instantiate( basketPrefab ) as GameObject;
                Vector3 pos = Vector3.zero;
                pos.y = basketBottomY + ( basketSpacingY * i );
                tBasketGO.transform.position = pos;
                basketList.Add(tBasketGO);
            }
    }
public void AppleDestroyed() {
    // Destroy all falling apples
    GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
    foreach (GameObject tGO in tAppleArray) {
        Destroy(tGO);
    }
    // Destroy one of the Baskets
    // Get the index of the last Basket in basketList
    int basketIndex = basketList.Count-1;

    //Get a reference to that Basket GameObject
    GameObject tBasketGo = basketList[basketIndex];

    //Remove the Basket from the List and destroy the GamebObject
    basketList.RemoveAt(basketIndex);
    Destroy(tBasketGo);

    //Restart the game, which doesn't affect the HighScore.Score
    if (basketList.Count == 0)
    {
        SceneManager.LoadScene("Scenes_");
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
