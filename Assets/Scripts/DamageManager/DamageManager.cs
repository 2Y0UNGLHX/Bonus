using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    public static DamageManager instance;
    // public TextMeshProUGUI text;
    int damage = 1;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //public void ChangeScore(int coinValue)
    //{
    //    score += coinValue;
    //    Debug.Log(score);
    //    // text.text = score.ToString();
    //}
}
