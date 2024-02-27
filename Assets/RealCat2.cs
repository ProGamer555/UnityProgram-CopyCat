using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class RealCat2 : MonoBehaviour
{
    public float flapstrength;
    public LogicManager logic;

    public bool catIsAlive = true;

    public Transform objectTransform;
    private float locationX;
    private float locationY;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((logic.gamemode1) || true && catIsAlive)
        {           
            movement1();
        }
        if ((logic.gamemode2) && catIsAlive)
        {
            movement2();
        }
        if ((logic.gamemode3) && catIsAlive)
        {
            movement3();
        }
    }


    private void movement1()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.up * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.down * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.right * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.left * flapstrength);
        }
    }
    private void movement2()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.up * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.down * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.left * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.right * flapstrength);
        }
    }
    private void movement3()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.down * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.up * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.left * flapstrength);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            locationX = objectTransform.position.x;
            locationY = objectTransform.position.y;
            transform.Translate(Vector2.right * flapstrength);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(locationX, locationY);
    }
}
    
