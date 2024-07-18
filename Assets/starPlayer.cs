using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class starPlayer : MonoBehaviour
{
    public int starCount = 0;
    public TMP_Text StarText;
    public TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StarText.SetText("Score : " + starCount);
        if (starCount < 3)
        {
            timeText.SetText("Time : " + Mathf.Round(Time.time));

        }
    }

}
