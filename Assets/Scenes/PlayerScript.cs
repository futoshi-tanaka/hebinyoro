using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float Speed { get; set; }        // 移動スピード
    public Vector3 Angles;                  // 進行方向
    
    public GameObject BodyPrefab;           // 体プレハブの受け皿
    public List<GameObject> BodyList;       // 獲得した体

    // Start is called before the first frame update
    void Start()
    {
        // パラメータ初期化
        Speed = 3.0f;
        Angles = new Vector3(-45, 30, 0);

        BodyList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyInput();
        UpdateMove();
    }

    // キャラクター移動制御
    void UpdateMove()
    {
        var direction = Quaternion.Euler(Angles) * Vector3.forward;
        transform.position += direction * Speed * Time.deltaTime;
        // Z座標補正
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f);

        // Debug.Log(transform.position);
    }

    // キー入力管理
    void KeyInput()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Rotate(0.0f, 0.0f, -1.0f);
            Angles.x -= 1.0f;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            // transform.Rotate(0.0f, 0.0f, 1.0f);
            Angles.x += 1.0f;
        }
    }

    // 当たり判定
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);

        switch(other.gameObject.tag)
        {
            // 敵
            case "Enemy":
            //Destroy(gameObject);
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("ResultScene");    
            break;

            // 体
            case "ItemBody":
            var body = Instantiate(BodyPrefab) as GameObject;
            body.GetComponent<BodyScript>().Parent = GameObject.Find("PlayerPrefab");
            if(BodyList.Count > 0)
            {
                body.GetComponent<BodyScript>().Parent = BodyList[BodyList.Count-1];
            }
            
            BodyList.Add(body);
            break;  
        }
    }
}
