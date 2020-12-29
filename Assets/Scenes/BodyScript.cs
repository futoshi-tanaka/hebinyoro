using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BodyScript : MonoBehaviour
{
    private GameObject Player;
    public GameObject Parent;

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤー情報を紐づけ
        Player = GameObject.Find("PlayerPrefab");
        transform.position = Parent.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Player != null)
        {
            transform.position = Vector3.Lerp(transform.position, Parent.transform.position, 0.1f);
        }
    }

    // 当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);

        switch(other.gameObject.tag)
        {
            // 敵と体が当たってもゲームオーバーにする
            // なんかゲームシーン遷移を一元化したいけど、あとで
            case "Enemy":
            Destroy(gameObject);
            SceneManager.LoadScene("ResultScene");    
            break;
        }
    }
}
