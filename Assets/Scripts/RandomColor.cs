using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomColor : MonoBehaviour
{
    protected SpriteRenderer sr;
    [SerializeField] protected Color colorCyan;
    [SerializeField] protected Color colorYellow;
    [SerializeField] protected Color colorPink;
    [SerializeField] protected Color colorPurple;
    [SerializeField] protected string currenColor;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        randomColor();
    }

    
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ChangeColor")
        {
            randomColor();
            Destroy(collision.gameObject);
            return;
        }
        if(collision.tag != currenColor)
        {
            RestrartLevel();
        }
    }

    void randomColor()
    {
        int index = Random.Range(0, 4);
        switch(index)
        {
            case 0:
                sr.color = colorCyan;
                currenColor = "Cyan";
                break;
            case 1:
                sr.color = colorYellow;
                currenColor = "Yellow";
                break;
            case 2:
                sr.color = colorPink;
                currenColor = "Pink";
                break;
            case 3:
                sr.color = colorPurple;
                currenColor = "Purple";
                break;
        }
    }

    private void RestrartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
