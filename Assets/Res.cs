using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Res : MonoBehaviour
{
    //public  static int scorenum;//���L����X�R�A�̐��l
    public Text  scoreLabel;
    // Start is called before the first frame update
    void Start()
    {
       
        scoreLabel.text = "�X�R�A" + ScoreSumController.scorenum;
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = "���X�R�A:" + ScoreSumController.scorenum;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            ScoreSumController.scorenum += 100;//�O���[�o���ϐ��ɂ���
            
        }
    }
}
