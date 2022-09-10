using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //
    [SerializeField] GameObject _stonePrefab;
    //�΂̎��̃C���X�^���X
    GameObject[,] _blocks = new GameObject[8,8];
    StoneController[,] _stones = new StoneController[8, 8];
    // Start is called before the first frame update
    void Start()
    {
        //�����ݒ�
        for(int i =0;i < 8;i++)
        {
            for (int j = 0; j < 8;j++)
            {
                GameObject newobject = Instantiate<GameObject>(_stonePrefab);
                StoneController newController = newobject.GetComponent<StoneController>();
                newobject.transform.localPosition = new Vector3(j, 0, i);
                _blocks[i, j] = newobject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}