using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotalScore : MonoBehaviour
{
    public Text AllScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AllScore.text = "�X�R�AAll" + ScoreSumController.scorenum;
    }
}
