using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxRain : MonoBehaviour
{

    int type;
    float size;

    // Start is called before the first frame update
    void Start()
    {
        // 정해진 범위 내 랜덤하게 box 나타나기
        float x = Random.Range(-2.7f, 2.7f);
        float y = Random.Range(3.0f, 5.0f);
        transform.position = new Vector3(x, y, 0);

        type = Random.Range(1, 6);
        if (type == 1)
        {
            size = 1.6f;
            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
        }
        if (type == 2)
        {
            size = 1.4f;
            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
        }
        if (type == 3)
        {
            size = 1.2f;
            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
        }
        if (type == 4)
        {
            size = 1.0f;
            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
        }
        if (type == 5)
        {
            size = 0.8f;
            GetComponent<SpriteRenderer>().color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
        }
        transform.localScale = new Vector3(size, size, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 화면 밖으로 gameObject 나갈 시 삭제
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "target")
        {
            gameManager.i.gameOver();
        }
    }
}
