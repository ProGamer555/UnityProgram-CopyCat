using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript2 : MonoBehaviour
{
    public LogicManager logic;
    public bool BlueWin = false;

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
        if (collision.gameObject.layer == 6)
        {
            BlueWin = true;
            logic.gameWon();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        BlueWin = false;
    }
}
