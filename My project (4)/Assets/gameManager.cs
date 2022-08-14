using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    int score = 0;
    int increment = 1;
    public Text txet1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increase()
    {
        score += increment;
        txet1.text = score.ToString();
    }
    public void Store()
    {
        if (score > 8)
        {
            increment++;
            score -= 8;
            txet1.text = score.ToString();
        }
        else
        {
            print(" You don't have enough energy ! ");
        }
    }
}
