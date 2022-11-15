using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RestoreController : MonoBehaviour
{
    // 记录物体最开始的三维坐标
    Vector3 originalPosition;
    [Tooltip("需要复位的物体")]
    public GameObject gObject;

    void Awake()
    {
        originalPosition = gObject.transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region 复位
    public void Restore()
    {
        gObject.transform.position = originalPosition;
    }
    #endregion
}
