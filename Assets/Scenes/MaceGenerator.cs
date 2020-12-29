using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceGenerator : MonoBehaviour
{
    public GameObject MacePrefab;                   // 複製するゲームオブジェクトの受け皿

    public List<GameObject> MacePrefabList;         // 鉄球の管理用リスト

    // Start is called before the first frame update
    void Start()
    {
        // 適当に３個配置してみる
        for(var i = 0; i < 3; i++)
        {
            MacePrefabList.Add(Instantiate(MacePrefab) as GameObject);
        }
        
        MacePrefabList[0].transform.position = new Vector3(4.0f, 1.0f, 0.0f);
        MacePrefabList[1].transform.position = new Vector3(-4.0f, -1.0f, 0.0f);
        MacePrefabList[2].transform.position = new Vector3(0.0f, 5.0f, 0.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
