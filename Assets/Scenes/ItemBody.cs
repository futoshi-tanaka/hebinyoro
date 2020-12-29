using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 当たり判定
    void OnTriggerStay2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            // プレイヤー
            case "Player":
            GetComponent<AudioSource>().Play();
            //Destroy(gameObject);
            break;
            
            default:
            // 生成時に何かしらのオブジェクトと重なっていたら再生成させる(適当すぎる)
            var x = Random.Range(-8.0f, 8.0f);
            var y = Random.Range(-3.0f, 3.0f);
            transform.position = new Vector3(x, y, 0.0f);
            break;
        }
    }
}
