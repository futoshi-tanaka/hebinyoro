using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerDebugText;

    // Start is called before the first frame update
    void Start()
    {
        // todo ゲーム画面にプレハブおいてないとほかのゲームオブジェクトから参照できない？ださい

        /*
        // プレイヤーの初期位置セット
        var player = Instantiate(Player) as GameObject;
        player.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        */
    }

    // Update is called once per frame
    void Update()
    {
        var player = GameObject.Find("PlayerPrefab");
        var bodyCount = player.GetComponent<PlayerScript>().BodyList.Count;
        if(bodyCount == 10)
        {
            SceneManager.LoadScene("ResultScene");
        }

        // デバッグ文字
        PlayerDebugText = GameObject.Find("DebugText");
        PlayerDebugText.GetComponent<Text>().text = "( " + player.transform.position.x.ToString() + ", " + player.transform.position.y.ToString() + " )";
    }
}
