using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public LogicManager logic;
    public bool RedWin = false;

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
        if (collision.gameObject.layer == 3)
        {
            RedWin = true;
            logic.gameWon();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
            RedWin = false;
    }
}
