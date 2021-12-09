using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public GameObject prefabCard;
    public List<GameObject> cardList = new List<GameObject>();
    public List<Sprite> spriteList = new List<Sprite>();
    private CardScript _cardScript;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        float posX = -6;
        float posY = 3;

        GameObject card;

        for(int i = 0; i < 10; i++)
        {
            //Instancia
            card = Instantiate(prefabCard, new Vector3(posX, posY, 0), Quaternion.identity);

            addFront(card);

            card.name = "Card" + i;
            cardList.Add(card);

            posX += 3;
            
            if(i == 4)
            {
                posX = -6;
                posY = -2;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void addFront(GameObject card)
    {
        _cardScript = card.GetComponent<CardScript>();
        randomIndex = Random.Range(0, spriteList.Count);
        _cardScript.front = spriteList[randomIndex];
        spriteList.RemoveAt(randomIndex);
    }
}
