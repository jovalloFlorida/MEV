using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite back;
    public Sprite front;
    private bool esFrontal;
    private SpriteRenderer _spriteRenderer;
    

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Has clicado la carta " + gameObject.name);
        _spriteRenderer.sprite = (esFrontal) ? back : front;
        esFrontal = !esFrontal;
    }
}
