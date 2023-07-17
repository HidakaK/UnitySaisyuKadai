using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Res : MonoBehaviour
{
    //public  static int scorenum;//共有するスコアの数値
    public Text  scoreLabel;
    // Start is called before the first frame update
    void Start()
    {
       
        scoreLabel.text = "スコア" + ScoreSumController.scorenum;
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = "総スコア:" + ScoreSumController.scorenum;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            ScoreSumController.scorenum += 100;//グローバル変数にする
            
        }
    }
}
