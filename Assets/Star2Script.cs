using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2Script : MonoBehaviour
{
    public LogicManager logic;
    public bool star2 = false;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            star2 = true;
            logic.onStars();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        star2 = false;
    }
}
