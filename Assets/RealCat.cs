using Unity.VisualScripting;
using UnityEngine;

public class RealCat : MonoBehaviour
{
  
    public float flapstrength;

    public bool catIsAlive = true;

    public LogicManager logic;
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
        if (catIsAlive)
        {
            movement();
        }
    }
    private void movement()
    {
        if (logic.gamemode1 || logic.gamemode2 || logic.gamemode3 || true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                logic.addMoves();
                locationX = objectTransform.position.x;
                locationY = objectTransform.position.y;
                transform.Translate(Vector2.up * flapstrength);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                logic.addMoves();
                locationX = objectTransform.position.x;
                locationY = objectTransform.position.y;
                transform.Translate(Vector2.down * flapstrength);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                logic.addMoves();
                locationX = objectTransform.position.x;
                locationY = objectTransform.position.y;
                transform.Translate(Vector2.right * flapstrength);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                logic.addMoves();
                locationX = objectTransform.position.x;
                locationY = objectTransform.position.y;
                transform.Translate(Vector2.left * flapstrength);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector2(locationX, locationY);
        
    }
}