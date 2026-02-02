using Unity.VisualScripting;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Transform backGround;
    public float speed;
    public float delay;
    public float resetY = -14.76f;
    public float StartY = -2f;



    // Update is called once per frame
    void Update()
    {
        Vector2 map = Vector2.down * speed;
        transform.Translate(map * Time.deltaTime);
        if (backGround.position.y <= resetY)
        {
            transform.position = new Vector2(transform.position.x, StartY);


        }
    }

}
