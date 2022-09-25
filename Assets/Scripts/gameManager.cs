using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // text를 만지기 위해 

public class gameManager : MonoBehaviour
{
    public GameObject boxRain;
    public GameObject gameOverText;
    public GameObject target;

    public Text timeText;
    float alive = 0.0f;

    public static gameManager i;

    public Animator anime;

    void Awake()
    {
        i = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeBoxRain", 0.0f, 0.3f);
    }

    void makeBoxRain()
    {
        Instantiate(boxRain); // 박스 복사
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timeText.text = alive.ToString("N2");
    }

    public void gameOver()
    {
        anime.SetBool("isDie", true);
        gameOverText.SetActive(true);
        Invoke("dead", 0.5f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(target);
    }
}
