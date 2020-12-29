using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceScript : MonoBehaviour
{
    public Vector3 Scale;
    public float Scale_Bias_X = 1.0f;
    public float Scale_Bias_Y = 1.0f;

    static float MIN_X_SCALE = 1.0f;
    static float MAX_X_SCALE = 1.5f;
    static float MIN_Y_SCALE = 1.0f;
    static float MAX_Y_SCALE = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Scale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // 鉄球を大きくしたり小さくしたり
        if(Scale.x > MAX_X_SCALE)
        {
            Scale_Bias_X = -1.0f;
        }
        else if(Scale.x < MIN_X_SCALE)
        {
            Scale_Bias_X = 1.0f;
        }
        var add_scale_x = Time.deltaTime * Scale_Bias_X;

        if(Scale.y > MAX_Y_SCALE)
        {
            Scale_Bias_Y = -1.0f;
        }
        else if(Scale.y < MIN_Y_SCALE)
        {
            Scale_Bias_Y = 1.0f;
        }
        var add_scale_y = Time.deltaTime * Scale_Bias_Y;

        Scale.x += add_scale_x;
        Scale.y += add_scale_y;
        transform.localScale = Scale;
        
        // なんとなく回す
        transform.Rotate(0.0f, 0.0f, 0.1f);
    }
}
