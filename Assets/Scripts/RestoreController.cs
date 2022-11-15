using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RestoreController : MonoBehaviour
{
    // ��¼�����ʼ����ά����
    Vector3 originalPosition;
    [Tooltip("��Ҫ��λ������")]
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

    #region ��λ
    public void Restore()
    {
        gObject.transform.position = originalPosition;
    }
    #endregion
}
